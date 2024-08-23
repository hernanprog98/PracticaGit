namespace ABMEpec.Presentacion
{
    partial class FrmContrato
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
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgvContratos = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.lblCliente);
            this.grpFiltros.Controls.Add(this.txtCliente);
            this.grpFiltros.Controls.Add(this.dgvContratos);
            this.grpFiltros.Controls.Add(this.btnConsultar);
            this.grpFiltros.Location = new System.Drawing.Point(23, 23);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(2);
            this.grpFiltros.Size = new System.Drawing.Size(554, 281);
            this.grpFiltros.TabIndex = 12;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(17, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(113, 13);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente / Razón Social";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(137, 26);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(252, 20);
            this.txtCliente.TabIndex = 8;
            // 
            // dgvContratos
            // 
            this.dgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratos.Location = new System.Drawing.Point(20, 64);
            this.dgvContratos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvContratos.Name = "dgvContratos";
            this.dgvContratos.RowHeadersWidth = 51;
            this.dgvContratos.RowTemplate.Height = 24;
            this.dgvContratos.Size = new System.Drawing.Size(520, 201);
            this.dgvContratos.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(464, 24);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(488, 321);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(43, 321);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // FrmContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contratos EPEC";
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgvContratos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblCliente;
    }
}