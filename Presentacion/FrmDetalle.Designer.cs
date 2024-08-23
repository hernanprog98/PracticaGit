namespace ABMEpec.Presentacion
{
    partial class FrmDetalle
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.rbtTrifasico = new System.Windows.Forms.RadioButton();
            this.rbtMonofasico = new System.Windows.Forms.RadioButton();
            this.cboTarifa = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtContrato = new System.Windows.Forms.TextBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblContrato = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.dtpFechaInicio);
            this.grpDatos.Controls.Add(this.rbtTrifasico);
            this.grpDatos.Controls.Add(this.rbtMonofasico);
            this.grpDatos.Controls.Add(this.cboTarifa);
            this.grpDatos.Controls.Add(this.txtCliente);
            this.grpDatos.Controls.Add(this.txtContrato);
            this.grpDatos.Controls.Add(this.lblFechaInicio);
            this.grpDatos.Controls.Add(this.lblServicio);
            this.grpDatos.Controls.Add(this.lblTarifa);
            this.grpDatos.Controls.Add(this.lblCliente);
            this.grpDatos.Controls.Add(this.lblContrato);
            this.grpDatos.Location = new System.Drawing.Point(9, 10);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(2);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(2);
            this.grpDatos.Size = new System.Drawing.Size(350, 270);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(148, 233);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaInicio.TabIndex = 6;
            this.dtpFechaInicio.Value = new System.DateTime(2024, 6, 22, 0, 0, 0, 0);
            // 
            // rbtTrifasico
            // 
            this.rbtTrifasico.AutoSize = true;
            this.rbtTrifasico.Location = new System.Drawing.Point(251, 184);
            this.rbtTrifasico.Name = "rbtTrifasico";
            this.rbtTrifasico.Size = new System.Drawing.Size(91, 17);
            this.rbtTrifasico.TabIndex = 4;
            this.rbtTrifasico.TabStop = true;
            this.rbtTrifasico.Text = "\"T\" - Trifásico";
            this.rbtTrifasico.UseVisualStyleBackColor = true;
            // 
            // rbtMonofasico
            // 
            this.rbtMonofasico.AutoSize = true;
            this.rbtMonofasico.Location = new System.Drawing.Point(148, 184);
            this.rbtMonofasico.Name = "rbtMonofasico";
            this.rbtMonofasico.Size = new System.Drawing.Size(108, 17);
            this.rbtMonofasico.TabIndex = 3;
            this.rbtMonofasico.TabStop = true;
            this.rbtMonofasico.Text = "\"M\" - Monofásico";
            this.rbtMonofasico.UseVisualStyleBackColor = true;
            // 
            // cboTarifa
            // 
            this.cboTarifa.FormattingEnabled = true;
            this.cboTarifa.Location = new System.Drawing.Point(148, 131);
            this.cboTarifa.Name = "cboTarifa";
            this.cboTarifa.Size = new System.Drawing.Size(186, 21);
            this.cboTarifa.TabIndex = 2;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(148, 81);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(186, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // txtContrato
            // 
            this.txtContrato.Location = new System.Drawing.Point(148, 32);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(57, 20);
            this.txtContrato.TabIndex = 1;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(57, 237);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(65, 13);
            this.lblFechaInicio.TabIndex = 15;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(51, 186);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(69, 13);
            this.lblServicio.TabIndex = 13;
            this.lblServicio.Text = "Tipo Servicio";
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(85, 135);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(34, 13);
            this.lblTarifa.TabIndex = 11;
            this.lblTarifa.Text = "Tarifa";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(13, 84);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(113, 13);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.Text = "Cliente / Razón Social";
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(35, 32);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(87, 13);
            this.lblContrato.TabIndex = 7;
            this.lblContrato.Text = "Número Contrato";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(83, 302);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(81, 31);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(206, 302);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 31);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 350);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpDatos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Contrato EPEC";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.RadioButton rbtTrifasico;
        private System.Windows.Forms.RadioButton rbtMonofasico;
        private System.Windows.Forms.ComboBox cboTarifa;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtContrato;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}