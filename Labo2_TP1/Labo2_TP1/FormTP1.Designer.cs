namespace Labo2_TP1
{
    partial class FormTP1
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.dGQuesos = new System.Windows.Forms.DataGridView();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtPesoMaximo = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblQuesos = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGQuesos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1110, 315);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.TabStop = false;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // dGQuesos
            // 
            this.dGQuesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGQuesos.Location = new System.Drawing.Point(39, 42);
            this.dGQuesos.Name = "dGQuesos";
            this.dGQuesos.RowHeadersWidth = 51;
            this.dGQuesos.RowTemplate.Height = 24;
            this.dGQuesos.Size = new System.Drawing.Size(475, 308);
            this.dGQuesos.TabIndex = 1;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(554, 179);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(554, 240);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(40, 17);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(802, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "PESO MAXIMO";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(630, 179);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(630, 240);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 22);
            this.txtPeso.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(557, 315);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtPesoMaximo
            // 
            this.txtPesoMaximo.Location = new System.Drawing.Point(805, 101);
            this.txtPesoMaximo.Name = "txtPesoMaximo";
            this.txtPesoMaximo.Size = new System.Drawing.Size(100, 22);
            this.txtPesoMaximo.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(672, 314);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(439, 373);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblQuesos
            // 
            this.lblQuesos.AutoSize = true;
            this.lblQuesos.Location = new System.Drawing.Point(978, 62);
            this.lblQuesos.Name = "lblQuesos";
            this.lblQuesos.Size = new System.Drawing.Size(121, 17);
            this.lblQuesos.TabIndex = 11;
            this.lblQuesos.Text = "Lista de QUESOS";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(829, 158);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // FormTP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 429);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblQuesos);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtPesoMaximo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.dGQuesos);
            this.Controls.Add(this.btnVolver);
            this.Name = "FormTP1";
            this.Text = "TP1";
            ((System.ComponentModel.ISupportInitialize)(this.dGQuesos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dGQuesos;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtPesoMaximo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblQuesos;
        private System.Windows.Forms.Button btnEnter;
    }
}