
namespace TrabajoPractico3NumII
{
    partial class txtBoxUs
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblMostrar = new System.Windows.Forms.Label();
            this.ButtEntrar = new System.Windows.Forms.Button();
            this.ButtCerrar = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxContra = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblNuevoUs = new System.Windows.Forms.Label();
            this.linkLblNewUs = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LblMostrar
            // 
            this.LblMostrar.AutoSize = true;
            this.LblMostrar.BackColor = System.Drawing.Color.Transparent;
            this.LblMostrar.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblMostrar.Location = new System.Drawing.Point(108, 39);
            this.LblMostrar.Name = "LblMostrar";
            this.LblMostrar.Size = new System.Drawing.Size(149, 45);
            this.LblMostrar.TabIndex = 0;
            this.LblMostrar.Text = "Bienvenido";
            // 
            // ButtEntrar
            // 
            this.ButtEntrar.Location = new System.Drawing.Point(89, 190);
            this.ButtEntrar.Name = "ButtEntrar";
            this.ButtEntrar.Size = new System.Drawing.Size(75, 23);
            this.ButtEntrar.TabIndex = 1;
            this.ButtEntrar.Text = "Entrar";
            this.ButtEntrar.UseVisualStyleBackColor = true;
            this.ButtEntrar.Click += new System.EventHandler(this.ButtEntrar_Click);
            // 
            // ButtCerrar
            // 
            this.ButtCerrar.Location = new System.Drawing.Point(192, 190);
            this.ButtCerrar.Name = "ButtCerrar";
            this.ButtCerrar.Size = new System.Drawing.Size(75, 23);
            this.ButtCerrar.TabIndex = 3;
            this.ButtCerrar.Text = "Cerrar";
            this.ButtCerrar.UseVisualStyleBackColor = true;
            this.ButtCerrar.Click += new System.EventHandler(this.ButtCerrar_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(157, 98);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario.TabIndex = 4;
            // 
            // txtBoxContra
            // 
            this.txtBoxContra.Location = new System.Drawing.Point(157, 146);
            this.txtBoxContra.Name = "txtBoxContra";
            this.txtBoxContra.Size = new System.Drawing.Size(100, 20);
            this.txtBoxContra.TabIndex = 5;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(89, 98);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.BackColor = System.Drawing.Color.Transparent;
            this.lblContra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContra.Location = new System.Drawing.Point(89, 146);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(61, 13);
            this.lblContra.TabIndex = 7;
            this.lblContra.Text = "Contraseña";
            // 
            // lblNuevoUs
            // 
            this.lblNuevoUs.AutoSize = true;
            this.lblNuevoUs.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevoUs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNuevoUs.Location = new System.Drawing.Point(499, 89);
            this.lblNuevoUs.Name = "lblNuevoUs";
            this.lblNuevoUs.Size = new System.Drawing.Size(148, 13);
            this.lblNuevoUs.TabIndex = 8;
            this.lblNuevoUs.Text = "Nuevo Usuario? Crea uno en:";
            // 
            // linkLblNewUs
            // 
            this.linkLblNewUs.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLblNewUs.AutoSize = true;
            this.linkLblNewUs.DisabledLinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.linkLblNewUs.LinkColor = System.Drawing.Color.Black;
            this.linkLblNewUs.Location = new System.Drawing.Point(502, 121);
            this.linkLblNewUs.Name = "linkLblNewUs";
            this.linkLblNewUs.Size = new System.Drawing.Size(153, 13);
            this.linkLblNewUs.TabIndex = 9;
            this.linkLblNewUs.TabStop = true;
            this.linkLblNewUs.Text = "www.createnewusuario.com.ar";
            // 
            // txtBoxUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrabajoPractico3NumII.Properties.Resources.f608x342_1003882_1033605_0;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLblNewUs);
            this.Controls.Add(this.lblNuevoUs);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtBoxContra);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.ButtCerrar);
            this.Controls.Add(this.ButtEntrar);
            this.Controls.Add(this.LblMostrar);
            this.Name = "txtBoxUs";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMostrar;
        private System.Windows.Forms.Button ButtEntrar;
        private System.Windows.Forms.Button ButtCerrar;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox txtBoxContra;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblNuevoUs;
        private System.Windows.Forms.LinkLabel linkLblNewUs;
    }
}

