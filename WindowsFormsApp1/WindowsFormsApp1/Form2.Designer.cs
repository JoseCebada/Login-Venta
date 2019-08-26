namespace WindowsFormsApp1
{
    partial class Form2
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
            this.lbCursos = new System.Windows.Forms.Label();
            this.lbPago = new System.Windows.Forms.Label();
            this.checkC = new System.Windows.Forms.CheckBox();
            this.checkBasic = new System.Windows.Forms.CheckBox();
            this.radioTarjeta = new System.Windows.Forms.RadioButton();
            this.radioPaypal = new System.Windows.Forms.RadioButton();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCursos
            // 
            this.lbCursos.AutoSize = true;
            this.lbCursos.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCursos.Location = new System.Drawing.Point(28, 68);
            this.lbCursos.Name = "lbCursos";
            this.lbCursos.Size = new System.Drawing.Size(233, 36);
            this.lbCursos.TabIndex = 0;
            this.lbCursos.Text = "Cursos de venta";
            this.lbCursos.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbPago
            // 
            this.lbPago.AutoSize = true;
            this.lbPago.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPago.Location = new System.Drawing.Point(311, 68);
            this.lbPago.Name = "lbPago";
            this.lbPago.Size = new System.Drawing.Size(235, 36);
            this.lbPago.TabIndex = 1;
            this.lbPago.Text = "Formas de pago";
            // 
            // checkC
            // 
            this.checkC.AutoSize = true;
            this.checkC.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkC.Location = new System.Drawing.Point(34, 163);
            this.checkC.Name = "checkC";
            this.checkC.Size = new System.Drawing.Size(125, 32);
            this.checkC.TabIndex = 2;
            this.checkC.Text = "Visual C#";
            this.checkC.UseVisualStyleBackColor = true;
            // 
            // checkBasic
            // 
            this.checkBasic.AutoSize = true;
            this.checkBasic.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBasic.Location = new System.Drawing.Point(34, 236);
            this.checkBasic.Name = "checkBasic";
            this.checkBasic.Size = new System.Drawing.Size(150, 32);
            this.checkBasic.TabIndex = 3;
            this.checkBasic.Text = "Visual Basic";
            this.checkBasic.UseVisualStyleBackColor = true;
            // 
            // radioTarjeta
            // 
            this.radioTarjeta.AutoSize = true;
            this.radioTarjeta.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTarjeta.Location = new System.Drawing.Point(308, 163);
            this.radioTarjeta.Name = "radioTarjeta";
            this.radioTarjeta.Size = new System.Drawing.Size(208, 32);
            this.radioTarjeta.TabIndex = 6;
            this.radioTarjeta.TabStop = true;
            this.radioTarjeta.Text = "Tarjeta de crédito";
            this.radioTarjeta.UseVisualStyleBackColor = true;
            // 
            // radioPaypal
            // 
            this.radioPaypal.AutoSize = true;
            this.radioPaypal.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPaypal.Location = new System.Drawing.Point(308, 236);
            this.radioPaypal.Name = "radioPaypal";
            this.radioPaypal.Size = new System.Drawing.Size(97, 32);
            this.radioPaypal.TabIndex = 7;
            this.radioPaypal.TabStop = true;
            this.radioPaypal.Text = "Paypal";
            this.radioPaypal.UseVisualStyleBackColor = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(172, 371);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.BtnComprar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(365, 371);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(92, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 472);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.radioPaypal);
            this.Controls.Add(this.radioTarjeta);
            this.Controls.Add(this.checkBasic);
            this.Controls.Add(this.checkC);
            this.Controls.Add(this.lbPago);
            this.Controls.Add(this.lbCursos);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCursos;
        private System.Windows.Forms.Label lbPago;
        private System.Windows.Forms.CheckBox checkC;
        private System.Windows.Forms.CheckBox checkBasic;
        private System.Windows.Forms.RadioButton radioTarjeta;
        private System.Windows.Forms.RadioButton radioPaypal;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCerrar;
    }
}