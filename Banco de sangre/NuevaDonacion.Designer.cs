namespace Banco_de_sangre
{
    partial class NuevaDonacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaDonacion));
            this.btnaAgregar = new System.Windows.Forms.Button();
            this.txtbDuracion = new System.Windows.Forms.TextBox();
            this.txtbAlbum = new System.Windows.Forms.TextBox();
            this.txtbArtista = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnaAgregar
            // 
            this.btnaAgregar.Location = new System.Drawing.Point(167, 249);
            this.btnaAgregar.Name = "btnaAgregar";
            this.btnaAgregar.Size = new System.Drawing.Size(146, 41);
            this.btnaAgregar.TabIndex = 11;
            this.btnaAgregar.Text = "Agregar";
            this.btnaAgregar.UseVisualStyleBackColor = true;
            // 
            // txtbDuracion
            // 
            this.txtbDuracion.Location = new System.Drawing.Point(213, 192);
            this.txtbDuracion.Name = "txtbDuracion";
            this.txtbDuracion.Size = new System.Drawing.Size(191, 20);
            this.txtbDuracion.TabIndex = 7;
            // 
            // txtbAlbum
            // 
            this.txtbAlbum.Location = new System.Drawing.Point(213, 143);
            this.txtbAlbum.Name = "txtbAlbum";
            this.txtbAlbum.Size = new System.Drawing.Size(191, 20);
            this.txtbAlbum.TabIndex = 8;
            // 
            // txtbArtista
            // 
            this.txtbArtista.Location = new System.Drawing.Point(213, 86);
            this.txtbArtista.Name = "txtbArtista";
            this.txtbArtista.Size = new System.Drawing.Size(191, 20);
            this.txtbArtista.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de sangre";
            // 
            // txtbTitulo
            // 
            this.txtbTitulo.Location = new System.Drawing.Point(213, 35);
            this.txtbTitulo.Name = "txtbTitulo";
            this.txtbTitulo.Size = new System.Drawing.Size(191, 20);
            this.txtbTitulo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mililitros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // NuevaDonacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 336);
            this.Controls.Add(this.btnaAgregar);
            this.Controls.Add(this.txtbDuracion);
            this.Controls.Add(this.txtbAlbum);
            this.Controls.Add(this.txtbArtista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevaDonacion";
            this.Text = "NuevaDonacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaAgregar;
        private System.Windows.Forms.TextBox txtbDuracion;
        private System.Windows.Forms.TextBox txtbAlbum;
        private System.Windows.Forms.TextBox txtbArtista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}