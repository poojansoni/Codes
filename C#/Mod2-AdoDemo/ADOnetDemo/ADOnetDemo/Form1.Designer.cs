
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
            this.SuspendLayout();
            // 
            // GetByDataReader
            // 
            this.GetByDataReader.Location = new System.Drawing.Point(367, 80);
            this.GetByDataReader.Name = "GetByDataReader";
            this.GetByDataReader.Size = new System.Drawing.Size(199, 71);
            this.GetByDataReader.TabIndex = 0;
            this.GetByDataReader.Text = "DataReader";
            this.GetByDataReader.UseVisualStyleBackColor = true;
            this.GetByDataReader.Click += new System.EventHandler(this.GetByDataReader_Click);
            // 
            // DataAdapter
            // 
            this.DataAdapter.Location = new System.Drawing.Point(69, 80);
            this.DataAdapter.Name = "DataAdapter";
            this.DataAdapter.Size = new System.Drawing.Size(199, 71);
            this.DataAdapter.TabIndex = 1;
            this.DataAdapter.Text = "DataAdapter";
            this.DataAdapter.UseVisualStyleBackColor = true;
            this.DataAdapter.Click += new System.EventHandler(this.DataAdapter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 228);
            this.Controls.Add(this.DataAdapter);
            this.Controls.Add(this.GetByDataReader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetByDataReader;
        private System.Windows.Forms.Button DataAdapter;
    }
}

