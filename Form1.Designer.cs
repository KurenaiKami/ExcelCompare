namespace ExcelCompare
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_open_1 = new System.Windows.Forms.Button();
            this.btn_open_2 = new System.Windows.Forms.Button();
            this.compare_path_1 = new System.Windows.Forms.TextBox();
            this.compare_path_2 = new System.Windows.Forms.TextBox();
            this.btn_compare = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Sheet1 = new System.Windows.Forms.Label();
            this.Sheet2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_open_1
            // 
            this.btn_open_1.Location = new System.Drawing.Point(410, 12);
            this.btn_open_1.Name = "btn_open_1";
            this.btn_open_1.Size = new System.Drawing.Size(39, 23);
            this.btn_open_1.TabIndex = 0;
            this.btn_open_1.Text = "...";
            this.btn_open_1.UseVisualStyleBackColor = true;
            this.btn_open_1.Click += new System.EventHandler(this.btn_open_1_Click);
            // 
            // btn_open_2
            // 
            this.btn_open_2.Location = new System.Drawing.Point(410, 41);
            this.btn_open_2.Name = "btn_open_2";
            this.btn_open_2.Size = new System.Drawing.Size(39, 23);
            this.btn_open_2.TabIndex = 1;
            this.btn_open_2.Text = "...";
            this.btn_open_2.UseVisualStyleBackColor = true;
            this.btn_open_2.Click += new System.EventHandler(this.btn_open_2_Click);
            // 
            // compare_path_1
            // 
            this.compare_path_1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compare_path_1.Location = new System.Drawing.Point(77, 14);
            this.compare_path_1.Name = "compare_path_1";
            this.compare_path_1.Size = new System.Drawing.Size(310, 24);
            this.compare_path_1.TabIndex = 2;
            // 
            // compare_path_2
            // 
            this.compare_path_2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compare_path_2.Location = new System.Drawing.Point(77, 41);
            this.compare_path_2.Name = "compare_path_2";
            this.compare_path_2.Size = new System.Drawing.Size(310, 24);
            this.compare_path_2.TabIndex = 3;
            // 
            // btn_compare
            // 
            this.btn_compare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_compare.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compare.Location = new System.Drawing.Point(757, 12);
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.Size = new System.Drawing.Size(75, 50);
            this.btn_compare.TabIndex = 4;
            this.btn_compare.Text = "Compare";
            this.btn_compare.UseVisualStyleBackColor = true;
            this.btn_compare.Click += new System.EventHandler(this.btn_compare_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Sheet2);
            this.panel1.Controls.Add(this.Sheet1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 471);
            this.panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(466, 432);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(483, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(466, 432);
            this.dataGridView2.TabIndex = 1;
            // 
            // Sheet1
            // 
            this.Sheet1.AutoSize = true;
            this.Sheet1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sheet1.Location = new System.Drawing.Point(4, 18);
            this.Sheet1.Name = "Sheet1";
            this.Sheet1.Size = new System.Drawing.Size(45, 17);
            this.Sheet1.TabIndex = 2;
            this.Sheet1.Text = "Sheet1";
            // 
            // Sheet2
            // 
            this.Sheet2.AutoSize = true;
            this.Sheet2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sheet2.Location = new System.Drawing.Point(481, 18);
            this.Sheet2.Name = "Sheet2";
            this.Sheet2.Size = new System.Drawing.Size(47, 17);
            this.Sheet2.TabIndex = 3;
            this.Sheet2.Text = "Sheet2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_compare);
            this.Controls.Add(this.compare_path_2);
            this.Controls.Add(this.compare_path_1);
            this.Controls.Add(this.btn_open_2);
            this.Controls.Add(this.btn_open_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open_1;
        private System.Windows.Forms.Button btn_open_2;
        private System.Windows.Forms.TextBox compare_path_1;
        private System.Windows.Forms.TextBox compare_path_2;
        private System.Windows.Forms.Button btn_compare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Sheet2;
        private System.Windows.Forms.Label Sheet1;
    }
}

