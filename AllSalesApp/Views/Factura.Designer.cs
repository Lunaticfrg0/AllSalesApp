namespace AllSalesApp.Views
{
    partial class Factura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.allSalesAppDataSet = new AllSalesApp.AllSalesAppDataSet();
            this.allSalesApplbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Msg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesApplbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AllowUserToResizeRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFacturas.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacturas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturas.Location = new System.Drawing.Point(24, 225);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvFacturas.RowTemplate.Height = 24;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(1373, 390);
            this.dgvFacturas.TabIndex = 9;
            this.dgvFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFacturas_CellClick);
            this.dgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellContentClick);
            this.dgvFacturas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFacturas_CellDoubleClick_1);
            this.dgvFacturas.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFacturas_CellMouseLeave);
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.MinimumWidth = 10;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cliente";
            // 
            // cboBuscar
            // 
            this.cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Location = new System.Drawing.Point(145, 128);
            this.cboBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(269, 39);
            this.cboBuscar.TabIndex = 16;
            // 
            // allSalesAppDataSet
            // 
            this.allSalesAppDataSet.DataSetName = "AllSalesAppDataSet";
            this.allSalesAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allSalesApplbindingSource
            // 
            this.allSalesApplbindingSource.DataSource = this.allSalesAppDataSet;
            this.allSalesApplbindingSource.Position = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(492, 128);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 38);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.Location = new System.Drawing.Point(571, 225);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(0, 17);
            this.Msg.TabIndex = 18;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 647);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Factura";
            this.Text = "Factura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Factura_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesApplbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBuscar;
        private AllSalesAppDataSet allSalesAppDataSet;
        private System.Windows.Forms.BindingSource allSalesApplbindingSource;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label Msg;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}