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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.allSalesAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allSalesAppDataSet = new AllSalesApp.AllSalesAppDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.HacerPedidobtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CrearFacturabtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTot = new System.Windows.Forms.Label();
            this.labelNumeros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesAppDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 33);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 39);
            this.comboBox1.TabIndex = 4;
            // 
            // HacerPedidobtn
            // 
            this.HacerPedidobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HacerPedidobtn.Location = new System.Drawing.Point(433, 578);
            this.HacerPedidobtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HacerPedidobtn.Name = "HacerPedidobtn";
            this.HacerPedidobtn.Size = new System.Drawing.Size(236, 39);
            this.HacerPedidobtn.TabIndex = 6;
            this.HacerPedidobtn.Text = "Generar Lista";
            this.HacerPedidobtn.UseVisualStyleBackColor = true;
            this.HacerPedidobtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(40, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(629, 388);
            this.dataGridView1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(701, 123);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(696, 388);
            this.dataGridView2.TabIndex = 9;
            // 
            // CrearFacturabtn
            // 
            this.CrearFacturabtn.Enabled = false;
            this.CrearFacturabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearFacturabtn.Location = new System.Drawing.Point(1093, 578);
            this.CrearFacturabtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CrearFacturabtn.Name = "CrearFacturabtn";
            this.CrearFacturabtn.Size = new System.Drawing.Size(236, 39);
            this.CrearFacturabtn.TabIndex = 10;
            this.CrearFacturabtn.Text = "Crear Factura";
            this.CrearFacturabtn.UseVisualStyleBackColor = true;
            this.CrearFacturabtn.Visible = false;
            this.CrearFacturabtn.Click += new System.EventHandler(this.CrearFacturabtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.label2.Location = new System.Drawing.Point(80, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Catálogo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.label3.Location = new System.Drawing.Point(785, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Factura";
            this.label3.Visible = false;
            // 
            // labelTot
            // 
            this.labelTot.AutoSize = true;
            this.labelTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.labelTot.Location = new System.Drawing.Point(917, 513);
            this.labelTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTot.Name = "labelTot";
            this.labelTot.Size = new System.Drawing.Size(79, 32);
            this.labelTot.TabIndex = 13;
            this.labelTot.Text = "Total";
            this.labelTot.Visible = false;
            // 
            // labelNumeros
            // 
            this.labelNumeros.AutoSize = true;
            this.labelNumeros.Enabled = false;
            this.labelNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.labelNumeros.Location = new System.Drawing.Point(1209, 513);
            this.labelNumeros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumeros.Name = "labelNumeros";
            this.labelNumeros.Size = new System.Drawing.Size(115, 32);
            this.labelNumeros.TabIndex = 14;
            this.labelNumeros.Text = "Numero";
            this.labelNumeros.Visible = false;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1412, 647);
            this.Controls.Add(this.labelNumeros);
            this.Controls.Add(this.labelTot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CrearFacturabtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HacerPedidobtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allSalesAppDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button HacerPedidobtn;
        private System.Windows.Forms.BindingSource allSalesAppDataSetBindingSource;
        private AllSalesAppDataSet allSalesAppDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button CrearFacturabtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTot;
        private System.Windows.Forms.Label labelNumeros;
    }
}