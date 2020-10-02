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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label precioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTP1));
            this.btnVolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesoMaximo = new System.Windows.Forms.TextBox();
            this.lblQuesos = new System.Windows.Forms.Label();
            this.btnGreedy = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cQuesoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuesoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.cQuesoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cQuesoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnPD = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cQuesoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cQuesoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cQuesoBindingNavigator)).BeginInit();
            this.cQuesoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(15, 138);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(54, 17);
            codigoLabel.TabIndex = 0;
            codigoLabel.Text = "codigo:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Location = new System.Drawing.Point(15, 245);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(43, 17);
            pesoLabel.TabIndex = 2;
            pesoLabel.Text = "peso:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(15, 194);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(51, 17);
            precioLabel.TabIndex = 4;
            precioLabel.Text = "precio:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1155, 387);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.TabStop = false;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btn_Volver_Click);
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
            // txtPesoMaximo
            // 
            this.txtPesoMaximo.Location = new System.Drawing.Point(805, 101);
            this.txtPesoMaximo.Name = "txtPesoMaximo";
            this.txtPesoMaximo.Size = new System.Drawing.Size(100, 22);
            this.txtPesoMaximo.TabIndex = 8;
            // 
            // lblQuesos
            // 
            this.lblQuesos.AutoSize = true;
            this.lblQuesos.Location = new System.Drawing.Point(975, 62);
            this.lblQuesos.Name = "lblQuesos";
            this.lblQuesos.Size = new System.Drawing.Size(121, 17);
            this.lblQuesos.TabIndex = 11;
            this.lblQuesos.Text = "Lista de QUESOS";
            // 
            // btnGreedy
            // 
            this.btnGreedy.Location = new System.Drawing.Point(805, 198);
            this.btnGreedy.Name = "btnGreedy";
            this.btnGreedy.Size = new System.Drawing.Size(102, 36);
            this.btnGreedy.TabIndex = 12;
            this.btnGreedy.Text = "Greedy";
            this.btnGreedy.UseVisualStyleBackColor = true;
            this.btnGreedy.Click += new System.EventHandler(this.btnGreedy_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 23);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.cQuesoDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(codigoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.codigoTextBox);
            this.splitContainer1.Panel2.Controls.Add(pesoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.pesoTextBox);
            this.splitContainer1.Panel2.Controls.Add(precioLabel);
            this.splitContainer1.Panel2.Controls.Add(this.precioTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(757, 387);
            this.splitContainer1.SplitterDistance = 484;
            this.splitContainer1.TabIndex = 13;
            // 
            // cQuesoDataGridView
            // 
            this.cQuesoDataGridView.AutoGenerateColumns = false;
            this.cQuesoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cQuesoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.cQuesoDataGridView.DataSource = this.cQuesoBindingSource;
            this.cQuesoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cQuesoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.cQuesoDataGridView.Name = "cQuesoDataGridView";
            this.cQuesoDataGridView.RowHeadersWidth = 51;
            this.cQuesoDataGridView.RowTemplate.Height = 24;
            this.cQuesoDataGridView.Size = new System.Drawing.Size(484, 387);
            this.cQuesoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn2.HeaderText = "precio";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "peso";
            this.dataGridViewTextBoxColumn3.HeaderText = "peso";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // cQuesoBindingSource
            // 
            this.cQuesoBindingSource.DataSource = typeof(Labo2_TP1.cQueso);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cQuesoBindingSource, "codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(75, 135);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(175, 22);
            this.codigoTextBox.TabIndex = 1;
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cQuesoBindingSource, "peso", true));
            this.pesoTextBox.Location = new System.Drawing.Point(75, 245);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(175, 22);
            this.pesoTextBox.TabIndex = 3;
            this.pesoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.pesoTextBox_Validating);
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cQuesoBindingSource, "precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(75, 191);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(175, 22);
            this.precioTextBox.TabIndex = 5;
            this.precioTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.precioTextBox_Validating);
            // 
            // cQuesoBindingNavigator
            // 
            this.cQuesoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cQuesoBindingNavigator.BindingSource = this.cQuesoBindingSource;
            this.cQuesoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cQuesoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cQuesoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cQuesoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cQuesoBindingNavigatorSaveItem});
            this.cQuesoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cQuesoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cQuesoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cQuesoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cQuesoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cQuesoBindingNavigator.Name = "cQuesoBindingNavigator";
            this.cQuesoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cQuesoBindingNavigator.Size = new System.Drawing.Size(1259, 27);
            this.cQuesoBindingNavigator.TabIndex = 14;
            this.cQuesoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // cQuesoBindingNavigatorSaveItem
            // 
            this.cQuesoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cQuesoBindingNavigatorSaveItem.Enabled = false;
            this.cQuesoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cQuesoBindingNavigatorSaveItem.Image")));
            this.cQuesoBindingNavigatorSaveItem.Name = "cQuesoBindingNavigatorSaveItem";
            this.cQuesoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.cQuesoBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // btnPD
            // 
            this.btnPD.Location = new System.Drawing.Point(790, 289);
            this.btnPD.Name = "btnPD";
            this.btnPD.Size = new System.Drawing.Size(127, 49);
            this.btnPD.TabIndex = 15;
            this.btnPD.Text = "Programacion Dinamica";
            this.btnPD.UseVisualStyleBackColor = true;
            this.btnPD.Click += new System.EventHandler(this.btnPD_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(997, 320);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(117, 17);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "PRECIO TOTAL: ";
            // 
            // FormTP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 429);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnPD);
            this.Controls.Add(this.cQuesoBindingNavigator);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnGreedy);
            this.Controls.Add(this.lblQuesos);
            this.Controls.Add(this.txtPesoMaximo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVolver);
            this.Name = "FormTP1";
            this.Text = "TP1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cQuesoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cQuesoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cQuesoBindingNavigator)).EndInit();
            this.cQuesoBindingNavigator.ResumeLayout(false);
            this.cQuesoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesoMaximo;
        private System.Windows.Forms.Label lblQuesos;
        private System.Windows.Forms.Button btnGreedy;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView cQuesoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource cQuesoBindingSource;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.BindingNavigator cQuesoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cQuesoBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnPD;
        private System.Windows.Forms.Label lblPrecio;
    }
}