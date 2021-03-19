
namespace ABC_Company
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.total_count = new System.Windows.Forms.Label();
            this.aBC_CompanyDataSet = new ABC_Company.ABC_CompanyDataSet();
            this.aBCCompanyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outputBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updt = new System.Windows.Forms.Button();
            this.InsertRec = new System.Windows.Forms.Button();
            this.depid = new System.Windows.Forms.TextBox();
            this.district = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.empID = new System.Windows.Forms.TextBox();
            this.ShowDet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SalDet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.getDistrict = new System.Windows.Forms.TextBox();
            this.getDEmp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.end_date = new System.Windows.Forms.TextBox();
            this.start_date = new System.Windows.Forms.TextBox();
            this.getAttendance = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aBC_CompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCCompanyDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Employees present:";
            // 
            // total_count
            // 
            this.total_count.AutoSize = true;
            this.total_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_count.Location = new System.Drawing.Point(260, 22);
            this.total_count.Name = "total_count";
            this.total_count.Size = new System.Drawing.Size(0, 20);
            this.total_count.TabIndex = 1;
            // 
            // aBC_CompanyDataSet
            // 
            this.aBC_CompanyDataSet.DataSetName = "ABC_CompanyDataSet";
            this.aBC_CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aBCCompanyDataSetBindingSource
            // 
            this.aBCCompanyDataSetBindingSource.DataSource = this.aBC_CompanyDataSet;
            this.aBCCompanyDataSetBindingSource.Position = 0;
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.FormattingEnabled = true;
            this.outputBox.ItemHeight = 20;
            this.outputBox.Location = new System.Drawing.Point(725, 123);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(292, 324);
            this.outputBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updt);
            this.groupBox1.Controls.Add(this.InsertRec);
            this.groupBox1.Controls.Add(this.depid);
            this.groupBox1.Controls.Add(this.district);
            this.groupBox1.Controls.Add(this.Phone);
            this.groupBox1.Controls.Add(this.Lname);
            this.groupBox1.Controls.Add(this.Fname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 264);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert Employee";
            // 
            // updt
            // 
            this.updt.Location = new System.Drawing.Point(163, 205);
            this.updt.Name = "updt";
            this.updt.Size = new System.Drawing.Size(104, 43);
            this.updt.TabIndex = 16;
            this.updt.Text = "Update";
            this.updt.UseVisualStyleBackColor = true;
            this.updt.Click += new System.EventHandler(this.updt_Click);
            // 
            // InsertRec
            // 
            this.InsertRec.Location = new System.Drawing.Point(37, 205);
            this.InsertRec.Name = "InsertRec";
            this.InsertRec.Size = new System.Drawing.Size(104, 43);
            this.InsertRec.TabIndex = 15;
            this.InsertRec.Text = "Insert";
            this.InsertRec.UseVisualStyleBackColor = true;
            this.InsertRec.Click += new System.EventHandler(this.InsertRec_Click);
            // 
            // depid
            // 
            this.depid.Location = new System.Drawing.Point(147, 160);
            this.depid.Name = "depid";
            this.depid.Size = new System.Drawing.Size(152, 23);
            this.depid.TabIndex = 14;
            // 
            // district
            // 
            this.district.Location = new System.Drawing.Point(147, 124);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(152, 23);
            this.district.TabIndex = 13;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(147, 90);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(152, 23);
            this.Phone.TabIndex = 12;
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(147, 55);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(152, 23);
            this.Lname.TabIndex = 11;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(147, 21);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(152, 23);
            this.Fname.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Department Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "District:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone no:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Employee ID:";
            // 
            // empID
            // 
            this.empID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empID.Location = new System.Drawing.Point(147, 43);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(152, 23);
            this.empID.TabIndex = 17;
            // 
            // ShowDet
            // 
            this.ShowDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDet.Location = new System.Drawing.Point(37, 88);
            this.ShowDet.Name = "ShowDet";
            this.ShowDet.Size = new System.Drawing.Size(104, 43);
            this.ShowDet.TabIndex = 18;
            this.ShowDet.Text = "Show Details";
            this.ShowDet.UseVisualStyleBackColor = true;
            this.ShowDet.Click += new System.EventHandler(this.ShowDet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SalDet);
            this.groupBox2.Controls.Add(this.empID);
            this.groupBox2.Controls.Add(this.ShowDet);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 153);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get Details of Employee";
            // 
            // SalDet
            // 
            this.SalDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalDet.Location = new System.Drawing.Point(163, 88);
            this.SalDet.Name = "SalDet";
            this.SalDet.Size = new System.Drawing.Size(104, 43);
            this.SalDet.TabIndex = 19;
            this.SalDet.Text = "Salary Details";
            this.SalDet.UseVisualStyleBackColor = true;
            this.SalDet.Click += new System.EventHandler(this.SalDet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.getDistrict);
            this.groupBox3.Controls.Add(this.getDEmp);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(375, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 153);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Get Employees based on City(ASC)";
            // 
            // getDistrict
            // 
            this.getDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDistrict.Location = new System.Drawing.Point(147, 43);
            this.getDistrict.Name = "getDistrict";
            this.getDistrict.Size = new System.Drawing.Size(152, 23);
            this.getDistrict.TabIndex = 17;
            // 
            // getDEmp
            // 
            this.getDEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDEmp.Location = new System.Drawing.Point(18, 88);
            this.getDEmp.Name = "getDEmp";
            this.getDEmp.Size = new System.Drawing.Size(130, 43);
            this.getDEmp.TabIndex = 18;
            this.getDEmp.Text = "Get Employees";
            this.getDEmp.UseVisualStyleBackColor = true;
            this.getDEmp.Click += new System.EventHandler(this.getDEmp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "City/District:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.end_date);
            this.groupBox4.Controls.Add(this.start_date);
            this.groupBox4.Controls.Add(this.getAttendance);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(375, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 264);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Get attendance using Stored PROC";
            // 
            // end_date
            // 
            this.end_date.Location = new System.Drawing.Point(147, 144);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(152, 23);
            this.end_date.TabIndex = 20;
            // 
            // start_date
            // 
            this.start_date.Location = new System.Drawing.Point(147, 110);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(152, 23);
            this.start_date.TabIndex = 19;
            // 
            // getAttendance
            // 
            this.getAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAttendance.Location = new System.Drawing.Point(18, 204);
            this.getAttendance.Name = "getAttendance";
            this.getAttendance.Size = new System.Drawing.Size(130, 43);
            this.getAttendance.TabIndex = 18;
            this.getAttendance.Text = " Attendance";
            this.getAttendance.UseVisualStyleBackColor = true;
            this.getAttendance.Click += new System.EventHandler(this.getAttendance_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "End Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Start Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "(YYYY-MM-DD)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 552);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.total_count);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aBC_CompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCCompanyDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total_count;
        private System.Windows.Forms.BindingSource aBCCompanyDataSetBindingSource;
        private ABC_CompanyDataSet aBC_CompanyDataSet;
        private System.Windows.Forms.ListBox outputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InsertRec;
        private System.Windows.Forms.TextBox depid;
        private System.Windows.Forms.TextBox district;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox empID;
        private System.Windows.Forms.Button ShowDet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox getDistrict;
        private System.Windows.Forms.Button getDEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SalDet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button getAttendance;
        private System.Windows.Forms.TextBox end_date;
        private System.Windows.Forms.TextBox start_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
    }
}

