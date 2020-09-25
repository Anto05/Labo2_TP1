namespace Labo2_TP1
{
    partial class FormPrincipal
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
            this.btnTP1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTP1
            // 
            this.btnTP1.Location = new System.Drawing.Point(103, 199);
            this.btnTP1.Name = "btnTP1";
            this.btnTP1.Size = new System.Drawing.Size(198, 96);
            this.btnTP1.TabIndex = 0;
            this.btnTP1.Text = "TP1";
            this.btnTP1.UseVisualStyleBackColor = true;
            this.btnTP1.Click += new System.EventHandler(this.btnTP1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 516);
            this.Controls.Add(this.btnTP1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTP1;
    }
}

