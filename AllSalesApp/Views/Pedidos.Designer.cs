using System;

namespace AllSalesApp.Views
{
    partial class Pedidos
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
            this.Buscarbtn = new System.Windows.Forms.Button();
            this.allSalesAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allSalesAppDataSet = new AllSalesApp.AllSalesAppDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.HacerPedidobtn = new System.Windows.Forms.Button();
            this.PedidosListView = new System.Windows.Forms.ListView();
            this.NombreHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecioHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesAppDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Buscarbtn
            // 
            this.Buscarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbtn.Location = new System.Drawing.Point(508, 35);
            this.Buscarbtn.Name = "Buscarbtn";
            this.Buscarbtn.Size = new System.Drawing.Size(95, 39);
            this.Buscarbtn.TabIndex = 2;
            this.Buscarbtn.Text = "Buscar";
            this.Buscarbtn.UseVisualStyleBackColor = true;
            this.Buscarbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // allSalesAppDataSetBindingSource
            // 
            this.allSalesAppDataSetBindingSource.DataSource = this.allSalesAppDataSet;
            this.allSalesAppDataSetBindingSource.Position = 0;
            // 
            // allSalesAppDataSet
            // 
            this.allSalesAppDataSet.DataSetName = "AllSalesAppDataSet";
            this.allSalesAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 39);
            this.comboBox1.TabIndex = 4;
            // 
            // Cancelar
            // 
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(232, 371);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(95, 39);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Buscar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // HacerPedidobtn
            // 
            this.HacerPedidobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HacerPedidobtn.Location = new System.Drawing.Point(452, 371);
            this.HacerPedidobtn.Name = "HacerPedidobtn";
            this.HacerPedidobtn.Size = new System.Drawing.Size(236, 39);
            this.HacerPedidobtn.TabIndex = 6;
            this.HacerPedidobtn.Text = "Hacer Pedido";
            this.HacerPedidobtn.UseVisualStyleBackColor = true;
            this.HacerPedidobtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // PedidosListView
            // 
            this.PedidosListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NombreHeader1,
            this.PrecioHeader1});
            this.PedidosListView.HideSelection = false;
            this.PedidosListView.Location = new System.Drawing.Point(12, 85);
            this.PedidosListView.Name = "PedidosListView";
            this.PedidosListView.Size = new System.Drawing.Size(173, 180);
            this.PedidosListView.TabIndex = 7;
            this.PedidosListView.UseCompatibleStateImageBehavior = false;
            this.PedidosListView.View = System.Windows.Forms.View.Details;
            this.PedidosListView.SelectedIndexChanged += new System.EventHandler(this.PedidosListView_SelectedIndexChanged);
            // 
            // NombreHeader1
            // 
            this.NombreHeader1.Text = "Nombre Producto";
            this.NombreHeader1.Width = 250;
            // 
            // PrecioHeader1
            // 
            this.PrecioHeader1.Text = "Precio";
            this.PrecioHeader1.Width = 83;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(486, 180);
            this.dataGridView1.TabIndex = 8;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PedidosListView);
            this.Controls.Add(this.HacerPedidobtn);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Buscarbtn);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.allSalesAppDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscarbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button HacerPedidobtn;
        private System.Windows.Forms.BindingSource allSalesAppDataSetBindingSource;
        private AllSalesAppDataSet allSalesAppDataSet;
        private System.Windows.Forms.ListView PedidosListView;
        private System.Windows.Forms.ColumnHeader NombreHeader1;
        private System.Windows.Forms.ColumnHeader PrecioHeader1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}