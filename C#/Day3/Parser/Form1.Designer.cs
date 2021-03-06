
namespace Parser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.str = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.intr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dobr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.flot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter any Value:";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(406, 60);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(100, 22);
            this.value.TabIndex = 2;
            // 
            // str
            // 
            this.str.Location = new System.Drawing.Point(342, 163);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(237, 22);
            this.str.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "String:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // intr
            // 
            this.intr.Location = new System.Drawing.Point(342, 208);
            this.intr.Name = "intr";
            this.intr.Size = new System.Drawing.Size(237, 22);
            this.intr.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Integer:";
            // 
            // dobr
            // 
            this.dobr.Location = new System.Drawing.Point(342, 255);
            this.dobr.Name = "dobr";
            this.dobr.Size = new System.Drawing.Size(237, 22);
            this.dobr.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Double:";
            // 
            // flot
            // 
            this.flot.Location = new System.Drawing.Point(342, 300);
            this.flot.Name = "flot";
            this.flot.Size = new System.Drawing.Size(237, 22);
            this.flot.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Float:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dobr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.intr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.str);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.TextBox str;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox intr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dobr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox flot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

