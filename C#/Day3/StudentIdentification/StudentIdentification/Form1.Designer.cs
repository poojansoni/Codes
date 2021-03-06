
namespace StudentIdentification
{
    partial class s_name
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.s_id = new System.Windows.Forms.TextBox();
            this.s_n = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Student Identification";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Student Id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(209, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Student Name:";
            // 
            // s_id
            // 
            this.s_id.Location = new System.Drawing.Point(440, 141);
            this.s_id.Name = "s_id";
            this.s_id.Size = new System.Drawing.Size(140, 22);
            this.s_id.TabIndex = 3;
            // 
            // s_n
            // 
            this.s_n.Location = new System.Drawing.Point(440, 221);
            this.s_n.Name = "s_n";
            this.s_n.Size = new System.Drawing.Size(140, 22);
            this.s_n.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(323, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get Name";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // s_name
            // 
            this.ClientSize = new System.Drawing.Size(818, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.s_n);
            this.Controls.Add(this.s_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "s_name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox s_id;
        private System.Windows.Forms.TextBox s_n;
        private System.Windows.Forms.Button button1;
    }
}

