using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelCompare
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> data1;
        private Dictionary<string, List<string>> data2;

        private Dictionary<string, Dictionary<int ,int > > posData1;
        private Dictionary<string, Dictionary<int, int> > posData2;
        public Form1()
        {
            data1 = new Dictionary<string, List<string> >();
            data2 = new Dictionary<string, List<string> >();
            posData1 = new Dictionary<string,Dictionary<int,int>>();
            posData2 = new Dictionary<string,Dictionary<int,int>>();
            InitializeComponent();
        }

        private void btn_open_1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "打开excel文件";
            openFileDialog.Filter = "excel03文件(*.xls)|*.xls|excel07文件(*.xlsx)|*.xlsx";
            openFileDialog.InitialDirectory = @"C:\Users\Administrator\Desktop";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.compare_path_1.Text = openFileDialog.FileName;

                //根据路径打开一个Excel文件并将数据填充到DataSet中
                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + this.compare_path_1.Text + ";Extended Properties ='Excel 8.0;HDR=NO;IMEX=1'";//HDR=YES 有两个值:YES/NO,表示第一行是否字段名,默认是YES,第一行是字段名
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                string strExcel = "";
                OleDbDataAdapter myCommand = null;
                DataSet ds = null;
                strExcel = "select  * from   [sheet1$]";
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                ds = new DataSet();
                myCommand.Fill(ds, "table1");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;

            }
        }

        private void btn_open_2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "打开excel文件";
            openFileDialog.Filter = "excel03文件(*.xls)|*.xls|excel07文件(*.xlsx)|*.xlsx";
            openFileDialog.InitialDirectory = @"C:\Users\Administrator\Desktop";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.compare_path_2.Text = openFileDialog.FileName;

                //根据路径打开一个Excel文件并将数据填充到DataSet中
                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + this.compare_path_2.Text + ";Extended Properties ='Excel 8.0;HDR=NO;IMEX=1'";//HDR=YES 有两个值:YES/NO,表示第一行是否字段名,默认是YES,第一行是字段名
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                string strExcel = "";
                OleDbDataAdapter myCommand = null;
                DataSet ds = null;
                strExcel = "select  * from   [sheet1$]";
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                ds = new DataSet();
                myCommand.Fill(ds, "table1");
                dataGridView2.DataSource = ds.Tables[0].DefaultView;

            }
        }
        private void btn_compare_Click(object sender, EventArgs e)
        {
            data1.Clear();
            data2.Clear();
            posData1.Clear();
            posData2.Clear();

            int row = dataGridView1.Rows.Count - 1;
            int cell = dataGridView1.Rows[1].Cells.Count;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cell; j++)
                {
                    string key = dataGridView1.Rows[0].Cells[j].Value.ToString();
                    string value = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    if (i == 0)
                    {
                        data1.Add(key, new List<string>());
                        posData1.Add(key, new Dictionary<int, int>());
                    }
                    data1[key].Add(value);
                    posData1[key].Add( i,j );
                }
            }

            row = dataGridView2.Rows.Count - 1;
            cell = dataGridView2.Rows[1].Cells.Count;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < cell; j++)
                {
                    string key = dataGridView2.Rows[0].Cells[j].Value.ToString();
                    string value = dataGridView2.Rows[i].Cells[j].Value.ToString();
                    if (i == 0)
                    {
                        data2.Add(key, new List<string>());
                        posData2.Add(key,new Dictionary<int,int>());
                    }
                    data2[key].Add(value);
                    posData2[key].Add(i, j);
                }
            }


            //compare
            foreach(KeyValuePair<string,List<string>> item in data1)
            {
                foreach(KeyValuePair<string,List<string>> item2 in data2)
                {
                    
                    if(item.Key == item2.Key)
                    {
                        var result = item.Value.Except(item2.Value);
                    }
                }
            }


        }

    }
}
