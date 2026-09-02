namespace prySP01
{
    partial class frmInicio1
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
            this.lblBienvenidoAlSistema = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenidoAlSistema
            // 
            this.lblBienvenidoAlSistema.AutoSize = true;
            this.lblBienvenidoAlSistema.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBienvenidoAlSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblBienvenidoAlSistema.Location = new System.Drawing.Point(155, 54);
            this.lblBienvenidoAlSistema.Name = "lblBienvenidoAlSistema";
            this.lblBienvenidoAlSistema.Size = new System.Drawing.Size(354, 39);
            this.lblBienvenidoAlSistema.TabIndex = 0;
            this.lblBienvenidoAlSistema.Text = "Bienvenido al Sistema";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(284, 132);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 34);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmInicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 268);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblBienvenidoAlSistema);
            this.Name = "frmInicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenidoAlSistema;
        private System.Windows.Forms.Button btnAceptar;
    }
}