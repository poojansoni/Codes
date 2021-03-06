
namespace helloWorld
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
            this.billno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qnt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.amnt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marlett", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poojan shop";
            // 
            // billno
            // 
            this.billno.Location = new System.Drawing.Point(439, 94);
            this.billno.Name = "billno";
            this.billno.Size = new System.Drawing.Size(116, 22);
            this.billno.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bill Number:";
            // 
            // prod
            // 
            this.prod.Location = new System.Drawing.Point(439, 159);
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(116, 22);
            this.prod.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Details:";
            // 
            // qnt
            // 
            this.qnt.Location = new System.Drawing.Point(439, 219);
            this.qnt.Name = "qnt";
            this.qnt.Size = new System.Drawing.Size(116, 22);
            this.qnt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(324, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Generate Bill";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // amnt
            // 
            this.amnt.Location = new System.Drawing.Point(439, 283);
            this.amnt.Name = "amnt";
            this.amnt.Size = new System.Drawing.Size(116, 22);
            this.amnt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Amount:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amnt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.billno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox billno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox amnt;
        private System.Windows.Forms.Label label5;
    }
}

