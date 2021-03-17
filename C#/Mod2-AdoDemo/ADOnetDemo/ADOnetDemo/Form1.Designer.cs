
namespace ADOnetDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetByDataReader = new System.Windows.Forms.Button();
            this.DataAdapter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExecScalar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.InsertQuery = new System.Windows.Forms.Button();
            this.Ename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Esal = new System.Windows.Forms.TextBox();
            this.InsertWParam = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.custOrderdet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.orderId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetByDataReader
            // 
            this.GetByDataReader.Location = new System.Drawing.Point(22, 141);
            this.GetByDataReader.Name = "GetByDataReader";
            this.GetByDataReader.Size = new System.Drawing.Size(121, 66);
            this.GetByDataReader.TabIndex = 0;
            this.GetByDataReader.Text = "DataReader";
            this.GetByDataReader.UseVisualStyleBackColor = true;
            this.GetByDataReader.Click += new System.EventHandler(this.GetByDataReader_Click);
            // 
            // DataAdapter
            // 
            this.DataAdapter.Location = new System.Drawing.Point(22, 50);
            this.DataAdapter.Name = "DataAdapter";
            this.DataAdapter.Size = new System.Drawing.Size(121, 61);
            this.DataAdapter.TabIndex = 1;
            this.DataAdapter.Text = "DataAdapter";
            this.DataAdapter.UseVisualStyleBackColor = true;
            this.DataAdapter.Click += new System.EventHandler(this.DataAdapter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataAdapter);
            this.groupBox1.Controls.Add(this.GetByDataReader);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 242);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multi Access";
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.FormattingEnabled = true;
            this.outputBox.ItemHeight = 20;
            this.outputBox.Location = new System.Drawing.Point(613, 33);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(360, 404);
            this.outputBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ExecScalar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Single Value Access";
            // 
            // ExecScalar
            // 
            this.ExecScalar.Location = new System.Drawing.Point(21, 50);
            this.ExecScalar.Name = "ExecScalar";
            this.ExecScalar.Size = new System.Drawing.Size(121, 61);
            this.ExecScalar.TabIndex = 1;
            this.ExecScalar.Text = "ExecuteScalar";
            this.ExecScalar.UseVisualStyleBackColor = true;
            this.ExecScalar.Click += new System.EventHandler(this.ExecScalar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.InsertWParam);
            this.groupBox3.Controls.Add(this.label);
            this.groupBox3.Controls.Add(this.Esal);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Ename);
            this.groupBox3.Controls.Add(this.InsertQuery);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(256, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 226);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Execute Non-Query";
            // 
            // InsertQuery
            // 
            this.InsertQuery.Location = new System.Drawing.Point(25, 136);
            this.InsertQuery.Name = "InsertQuery";
            this.InsertQuery.Size = new System.Drawing.Size(103, 67);
            this.InsertQuery.TabIndex = 1;
            this.InsertQuery.Text = "Insert without param";
            this.InsertQuery.UseVisualStyleBackColor = true;
            this.InsertQuery.Click += new System.EventHandler(this.InsertQuery_Click);
            // 
            // Ename
            // 
            this.Ename.Location = new System.Drawing.Point(162, 46);
            this.Ename.Name = "Ename";
            this.Ename.Size = new System.Drawing.Size(123, 23);
            this.Ename.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Name: ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 83);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(139, 17);
            this.label.TabIndex = 5;
            this.label.Text = "Employee Salary :";
            // 
            // Esal
            // 
            this.Esal.Location = new System.Drawing.Point(162, 83);
            this.Esal.Name = "Esal";
            this.Esal.Size = new System.Drawing.Size(123, 23);
            this.Esal.TabIndex = 4;
            // 
            // InsertWParam
            // 
            this.InsertWParam.Location = new System.Drawing.Point(162, 136);
            this.InsertWParam.Name = "InsertWParam";
            this.InsertWParam.Size = new System.Drawing.Size(103, 67);
            this.InsertWParam.TabIndex = 6;
            this.InsertWParam.Text = "Insert with param";
            this.InsertWParam.UseVisualStyleBackColor = true;
            this.InsertWParam.Click += new System.EventHandler(this.InsertWParam_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.custOrderdet);
            this.groupBox4.Controls.Add(this.orderId);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(256, 283);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 154);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stored Procedures";
            // 
            // custOrderdet
            // 
            this.custOrderdet.Location = new System.Drawing.Point(73, 94);
            this.custOrderdet.Name = "custOrderdet";
            this.custOrderdet.Size = new System.Drawing.Size(152, 38);
            this.custOrderdet.TabIndex = 1;
            this.custOrderdet.Text = "CustOrderDetails";
            this.custOrderdet.UseVisualStyleBackColor = true;
            this.custOrderdet.Click += new System.EventHandler(this.custOrderdet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Order Id:";
            // 
            // orderId
            // 
            this.orderId.Location = new System.Drawing.Point(144, 53);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(123, 23);
            this.orderId.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 476);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetByDataReader;
        private System.Windows.Forms.Button DataAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox outputBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ExecScalar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox Esal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ename;
        private System.Windows.Forms.Button InsertQuery;
        private System.Windows.Forms.Button InsertWParam;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button custOrderdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderId;
    }
}

