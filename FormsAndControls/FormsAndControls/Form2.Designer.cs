namespace FormsAndControls
{
    partial class Form2
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
            this.btnOK = new System.Windows.Forms.Button();
            this.tbGetal = new System.Windows.Forms.TextBox();
            this.lbGetal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(62, 65);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 46);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbGetal
            // 
            this.tbGetal.Location = new System.Drawing.Point(62, 32);
            this.tbGetal.Name = "tbGetal";
            this.tbGetal.Size = new System.Drawing.Size(125, 27);
            this.tbGetal.TabIndex = 1;
            // 
            // lbGetal
            // 
            this.lbGetal.AutoSize = true;
            this.lbGetal.Location = new System.Drawing.Point(68, 9);
            this.lbGetal.Name = "lbGetal";
            this.lbGetal.Size = new System.Drawing.Size(112, 20);
            this.lbGetal.TabIndex = 2;
            this.lbGetal.Text = "Voer je getal in:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 123);
            this.Controls.Add(this.lbGetal);
            this.Controls.Add(this.tbGetal);
            this.Controls.Add(this.btnOK);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbGetal;
        private System.Windows.Forms.Label lbGetal;
    }
}