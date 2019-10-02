namespace AllSalesApp.Views
{
    partial class BorrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrarCliente));
            this.SearchCliente = new System.Windows.Forms.Button();
            this.IDClientecombox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Borrarbtn = new System.Windows.Forms.Button();
            this.Direcciontxt = new System.Windows.Forms.TextBox();
            this.Provincialbl = new System.Windows.Forms.Label();
            this.Correotxt = new System.Windows.Forms.TextBox();
            this.Telefonotxt = new System.Windows.Forms.TextBox();
            this.Cedulatxt = new System.Windows.Forms.TextBox();
            this.NombreClientetxt = new System.Windows.Forms.TextBox();
            this.Direccionlbl = new System.Windows.Forms.Label();
            this.CorreoClientelbl = new System.Windows.Forms.Label();
            this.TelefonoClientelbl = new System.Windows.Forms.Label();
            this.CedulaClientelbl = new System.Windows.Forms.Label();
            this.Nombrelbl = new System.Windows.Forms.Label();
            this.Provinciatxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchCliente
            // 
            this.SearchCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchCliente.BackgroundImage")));
            this.SearchCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchCliente.Location = new System.Drawing.Point(493, 20);
            this.SearchCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchCliente.Name = "SearchCliente";
            this.SearchCliente.Size = new System.Drawing.Size(114, 89);
            this.SearchCliente.TabIndex = 59;
            this.SearchCliente.UseVisualStyleBackColor = true;
            this.SearchCliente.Click += new System.EventHandler(this.SearchCliente_Click);
            // 
            // IDClientecombox
            // 
            this.IDClientecombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDClientecombox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDClientecombox.FormattingEnabled = true;
            this.IDClientecombox.Location = new System.Drawing.Point(188, 46);
            this.IDClientecombox.Name = "IDClientecombox";
            this.IDClientecombox.Size = new System.Drawing.Size(258, 32);
            this.IDClientecombox.TabIndex = 58;
            this.IDClientecombox.SelectedIndexChanged += new System.EventHandler(this.IDClientecombox_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Nombre cliente:";
            // 
            // Borrarbtn
            // 
            this.Borrarbtn.BackColor = System.Drawing.Color.Red;
            this.Borrarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrarbtn.Location = new System.Drawing.Point(421, 281);
            this.Borrarbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Borrarbtn.Name = "Borrarbtn";
            this.Borrarbtn.Size = new System.Drawing.Size(274, 41);
            this.Borrarbtn.TabIndex = 56;
            this.Borrarbtn.Text = "Borrar cliente";
            this.Borrarbtn.UseVisualStyleBackColor = false;
            this.Borrarbtn.Click += new System.EventHandler(this.Borrarbtn_Click);
            // 
            // Direcciontxt
            // 
            this.Direcciontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direcciontxt.Location = new System.Drawing.Point(823, 206);
            this.Direcciontxt.Name = "Direcciontxt";
            this.Direcciontxt.ReadOnly = true;
            this.Direcciontxt.Size = new System.Drawing.Size(168, 29);
            this.Direcciontxt.TabIndex = 55;
            // 
            // Provincialbl
            // 
            this.Provincialbl.AutoSize = true;
            this.Provincialbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Provincialbl.Location = new System.Drawing.Point(712, 157);
            this.Provincialbl.Name = "Provincialbl";
            this.Provincialbl.Size = new System.Drawing.Size(108, 26);
            this.Provincialbl.TabIndex = 54;
            this.Provincialbl.Text = "Provincia:";
            // 
            // Correotxt
            // 
            this.Correotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correotxt.Location = new System.Drawing.Point(512, 204);
            this.Correotxt.Name = "Correotxt";
            this.Correotxt.ReadOnly = true;
            this.Correotxt.Size = new System.Drawing.Size(152, 29);
            this.Correotxt.TabIndex = 52;
            // 
            // Telefonotxt
            // 
            this.Telefonotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefonotxt.Location = new System.Drawing.Point(512, 157);
            this.Telefonotxt.Name = "Telefonotxt";
            this.Telefonotxt.ReadOnly = true;
            this.Telefonotxt.Size = new System.Drawing.Size(152, 29);
            this.Telefonotxt.TabIndex = 51;
            // 
            // Cedulatxt
            // 
            this.Cedulatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cedulatxt.Location = new System.Drawing.Point(222, 205);
            this.Cedulatxt.Name = "Cedulatxt";
            this.Cedulatxt.ReadOnly = true;
            this.Cedulatxt.Size = new System.Drawing.Size(152, 29);
            this.Cedulatxt.TabIndex = 50;
            // 
            // NombreClientetxt
            // 
            this.NombreClientetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreClientetxt.Location = new System.Drawing.Point(222, 159);
            this.NombreClientetxt.Name = "NombreClientetxt";
            this.NombreClientetxt.ReadOnly = true;
            this.NombreClientetxt.Size = new System.Drawing.Size(152, 29);
            this.NombreClientetxt.TabIndex = 49;
            // 
            // Direccionlbl
            // 
            this.Direccionlbl.AutoSize = true;
            this.Direccionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccionlbl.Location = new System.Drawing.Point(712, 206);
            this.Direccionlbl.Name = "Direccionlbl";
            this.Direccionlbl.Size = new System.Drawing.Size(108, 25);
            this.Direccionlbl.TabIndex = 48;
            this.Direccionlbl.Text = "Dirección:";
            // 
            // CorreoClientelbl
            // 
            this.CorreoClientelbl.AutoSize = true;
            this.CorreoClientelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoClientelbl.Location = new System.Drawing.Point(416, 207);
            this.CorreoClientelbl.Name = "CorreoClientelbl";
            this.CorreoClientelbl.Size = new System.Drawing.Size(83, 25);
            this.CorreoClientelbl.TabIndex = 47;
            this.CorreoClientelbl.Text = "Correo:";
            // 
            // TelefonoClientelbl
            // 
            this.TelefonoClientelbl.AutoSize = true;
            this.TelefonoClientelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoClientelbl.Location = new System.Drawing.Point(400, 157);
            this.TelefonoClientelbl.Name = "TelefonoClientelbl";
            this.TelefonoClientelbl.Size = new System.Drawing.Size(102, 25);
            this.TelefonoClientelbl.TabIndex = 46;
            this.TelefonoClientelbl.Text = "Teléfono:";
            // 
            // CedulaClientelbl
            // 
            this.CedulaClientelbl.AutoSize = true;
            this.CedulaClientelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaClientelbl.Location = new System.Drawing.Point(130, 206);
            this.CedulaClientelbl.Name = "CedulaClientelbl";
            this.CedulaClientelbl.Size = new System.Drawing.Size(86, 25);
            this.CedulaClientelbl.TabIndex = 45;
            this.CedulaClientelbl.Text = "Cedula:";
            // 
            // Nombrelbl
            // 
            this.Nombrelbl.AutoSize = true;
            this.Nombrelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrelbl.Location = new System.Drawing.Point(54, 159);
            this.Nombrelbl.Name = "Nombrelbl";
            this.Nombrelbl.Size = new System.Drawing.Size(162, 25);
            this.Nombrelbl.TabIndex = 44;
            this.Nombrelbl.Text = "Nombre cliente:";
            // 
            // Provinciatxt
            // 
            this.Provinciatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Provinciatxt.Location = new System.Drawing.Point(823, 162);
            this.Provinciatxt.Name = "Provinciatxt";
            this.Provinciatxt.ReadOnly = true;
            this.Provinciatxt.Size = new System.Drawing.Size(168, 29);
            this.Provinciatxt.TabIndex = 60;
            // 
            // BorrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 526);
            this.Controls.Add(this.Provinciatxt);
            this.Controls.Add(this.SearchCliente);
            this.Controls.Add(this.IDClientecombox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Borrarbtn);
            this.Controls.Add(this.Direcciontxt);
            this.Controls.Add(this.Provincialbl);
            this.Controls.Add(this.Correotxt);
            this.Controls.Add(this.Telefonotxt);
            this.Controls.Add(this.Cedulatxt);
            this.Controls.Add(this.NombreClientetxt);
            this.Controls.Add(this.Direccionlbl);
            this.Controls.Add(this.CorreoClientelbl);
            this.Controls.Add(this.TelefonoClientelbl);
            this.Controls.Add(this.CedulaClientelbl);
            this.Controls.Add(this.Nombrelbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BorrarCliente";
            this.Text = "Borrar cliente";
            this.Load += new System.EventHandler(this.BorrarCliente_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchCliente;
        private System.Windows.Forms.ComboBox IDClientecombox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Borrarbtn;
        private System.Windows.Forms.TextBox Direcciontxt;
        private System.Windows.Forms.Label Provincialbl;
        private System.Windows.Forms.TextBox Correotxt;
        private System.Windows.Forms.TextBox Telefonotxt;
        private System.Windows.Forms.TextBox Cedulatxt;
        private System.Windows.Forms.TextBox NombreClientetxt;
        private System.Windows.Forms.Label Direccionlbl;
        private System.Windows.Forms.Label CorreoClientelbl;
        private System.Windows.Forms.Label TelefonoClientelbl;
        private System.Windows.Forms.Label CedulaClientelbl;
        private System.Windows.Forms.Label Nombrelbl;
        private System.Windows.Forms.TextBox Provinciatxt;
    }
}