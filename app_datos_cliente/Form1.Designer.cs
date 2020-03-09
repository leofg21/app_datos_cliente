namespace app_datos_cliente
{
    partial class Form1
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
            this.dgvPaises = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCiudades = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarPais = new System.Windows.Forms.Button();
            this.btnEditarPais = new System.Windows.Forms.Button();
            this.btnEliminarPais = new System.Windows.Forms.Button();
            this.btnEliminarCiudad = new System.Windows.Forms.Button();
            this.btnEditarCiudad = new System.Windows.Forms.Button();
            this.btnGuardarCiudad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.txtIdCiudad = new System.Windows.Forms.TextBox();
            this.btnCancelarPais = new System.Windows.Forms.Button();
            this.btnCancelarCiudad = new System.Windows.Forms.Button();
            this.txtBuscarPais = new System.Windows.Forms.TextBox();
            this.txtBuscarCiudad = new System.Windows.Forms.TextBox();
            this.btnBuscarPais = new System.Windows.Forms.Button();
            this.btnRecargarPais = new System.Windows.Forms.Button();
            this.btnRecargarCiudad = new System.Windows.Forms.Button();
            this.btnBuscarCiudad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaises
            // 
            this.dgvPaises.AllowUserToAddRows = false;
            this.dgvPaises.AllowUserToDeleteRows = false;
            this.dgvPaises.AllowUserToResizeRows = false;
            this.dgvPaises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaises.Location = new System.Drawing.Point(6, 153);
            this.dgvPaises.Name = "dgvPaises";
            this.dgvPaises.ReadOnly = true;
            this.dgvPaises.RowHeadersVisible = false;
            this.dgvPaises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaises.Size = new System.Drawing.Size(389, 278);
            this.dgvPaises.TabIndex = 0;
            this.dgvPaises.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaises_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecargarPais);
            this.groupBox1.Controls.Add(this.btnBuscarPais);
            this.groupBox1.Controls.Add(this.txtBuscarPais);
            this.groupBox1.Controls.Add(this.btnCancelarPais);
            this.groupBox1.Controls.Add(this.btnEliminarPais);
            this.groupBox1.Controls.Add(this.btnEditarPais);
            this.groupBox1.Controls.Add(this.btnGuardarPais);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPais);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.dgvPaises);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 437);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paises";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRecargarCiudad);
            this.groupBox2.Controls.Add(this.btnBuscarCiudad);
            this.groupBox2.Controls.Add(this.txtBuscarCiudad);
            this.groupBox2.Controls.Add(this.btnCancelarCiudad);
            this.groupBox2.Controls.Add(this.txtIdCiudad);
            this.groupBox2.Controls.Add(this.btnEliminarCiudad);
            this.groupBox2.Controls.Add(this.btnEditarCiudad);
            this.groupBox2.Controls.Add(this.btnGuardarCiudad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCiudad);
            this.groupBox2.Controls.Add(this.txtCodigoPais);
            this.groupBox2.Controls.Add(this.dgvCiudades);
            this.groupBox2.Location = new System.Drawing.Point(419, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 437);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ciudades";
            // 
            // dgvCiudades
            // 
            this.dgvCiudades.AllowUserToAddRows = false;
            this.dgvCiudades.AllowUserToDeleteRows = false;
            this.dgvCiudades.AllowUserToResizeRows = false;
            this.dgvCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudades.Location = new System.Drawing.Point(6, 153);
            this.dgvCiudades.Name = "dgvCiudades";
            this.dgvCiudades.ReadOnly = true;
            this.dgvCiudades.RowHeadersVisible = false;
            this.dgvCiudades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCiudades.Size = new System.Drawing.Size(389, 278);
            this.dgvCiudades.TabIndex = 0;
            this.dgvCiudades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCiudades_CellClick);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(38, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(115, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(159, 45);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(116, 20);
            this.txtPais.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "País";
            // 
            // btnGuardarPais
            // 
            this.btnGuardarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPais.Location = new System.Drawing.Point(38, 71);
            this.btnGuardarPais.Name = "btnGuardarPais";
            this.btnGuardarPais.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPais.TabIndex = 5;
            this.btnGuardarPais.Text = "GUARDAR";
            this.btnGuardarPais.UseVisualStyleBackColor = true;
            this.btnGuardarPais.Click += new System.EventHandler(this.btnGuardarPais_Click);
            // 
            // btnEditarPais
            // 
            this.btnEditarPais.Enabled = false;
            this.btnEditarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPais.Location = new System.Drawing.Point(119, 71);
            this.btnEditarPais.Name = "btnEditarPais";
            this.btnEditarPais.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPais.TabIndex = 6;
            this.btnEditarPais.Text = "EDITAR";
            this.btnEditarPais.UseVisualStyleBackColor = true;
            this.btnEditarPais.Click += new System.EventHandler(this.btnEditarPais_Click);
            // 
            // btnEliminarPais
            // 
            this.btnEliminarPais.Enabled = false;
            this.btnEliminarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPais.Location = new System.Drawing.Point(200, 71);
            this.btnEliminarPais.Name = "btnEliminarPais";
            this.btnEliminarPais.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPais.TabIndex = 7;
            this.btnEliminarPais.Text = "ELIMINAR";
            this.btnEliminarPais.UseVisualStyleBackColor = true;
            this.btnEliminarPais.Click += new System.EventHandler(this.btnEliminarPais_Click);
            // 
            // btnEliminarCiudad
            // 
            this.btnEliminarCiudad.Enabled = false;
            this.btnEliminarCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCiudad.Location = new System.Drawing.Point(217, 71);
            this.btnEliminarCiudad.Name = "btnEliminarCiudad";
            this.btnEliminarCiudad.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCiudad.TabIndex = 14;
            this.btnEliminarCiudad.Text = "ELIMINAR";
            this.btnEliminarCiudad.UseVisualStyleBackColor = true;
            this.btnEliminarCiudad.Click += new System.EventHandler(this.btnEliminarCiudad_Click);
            // 
            // btnEditarCiudad
            // 
            this.btnEditarCiudad.Enabled = false;
            this.btnEditarCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCiudad.Location = new System.Drawing.Point(136, 71);
            this.btnEditarCiudad.Name = "btnEditarCiudad";
            this.btnEditarCiudad.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCiudad.TabIndex = 13;
            this.btnEditarCiudad.Text = "EDITAR";
            this.btnEditarCiudad.UseVisualStyleBackColor = true;
            this.btnEditarCiudad.Click += new System.EventHandler(this.btnEditarCiudad_Click);
            // 
            // btnGuardarCiudad
            // 
            this.btnGuardarCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCiudad.Location = new System.Drawing.Point(55, 71);
            this.btnGuardarCiudad.Name = "btnGuardarCiudad";
            this.btnGuardarCiudad.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCiudad.TabIndex = 12;
            this.btnGuardarCiudad.Text = "GUARDAR";
            this.btnGuardarCiudad.UseVisualStyleBackColor = true;
            this.btnGuardarCiudad.Click += new System.EventHandler(this.btnGuardarCiudad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Código País";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(176, 45);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(116, 20);
            this.txtCiudad.TabIndex = 9;
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.Location = new System.Drawing.Point(55, 45);
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Size = new System.Drawing.Size(115, 20);
            this.txtCodigoPais.TabIndex = 8;
            // 
            // txtIdCiudad
            // 
            this.txtIdCiudad.Enabled = false;
            this.txtIdCiudad.Location = new System.Drawing.Point(18, 45);
            this.txtIdCiudad.Name = "txtIdCiudad";
            this.txtIdCiudad.Size = new System.Drawing.Size(31, 20);
            this.txtIdCiudad.TabIndex = 15;
            this.txtIdCiudad.Visible = false;
            // 
            // btnCancelarPais
            // 
            this.btnCancelarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPais.Location = new System.Drawing.Point(281, 45);
            this.btnCancelarPais.Name = "btnCancelarPais";
            this.btnCancelarPais.Size = new System.Drawing.Size(85, 49);
            this.btnCancelarPais.TabIndex = 8;
            this.btnCancelarPais.Text = "CANCELAR";
            this.btnCancelarPais.UseVisualStyleBackColor = true;
            this.btnCancelarPais.Click += new System.EventHandler(this.btnCancelarPais_Click);
            // 
            // btnCancelarCiudad
            // 
            this.btnCancelarCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCiudad.Location = new System.Drawing.Point(298, 45);
            this.btnCancelarCiudad.Name = "btnCancelarCiudad";
            this.btnCancelarCiudad.Size = new System.Drawing.Size(85, 49);
            this.btnCancelarCiudad.TabIndex = 16;
            this.btnCancelarCiudad.Text = "CANCELAR";
            this.btnCancelarCiudad.UseVisualStyleBackColor = true;
            this.btnCancelarCiudad.Click += new System.EventHandler(this.btnCancelarCiudad_Click);
            // 
            // txtBuscarPais
            // 
            this.txtBuscarPais.Location = new System.Drawing.Point(38, 127);
            this.txtBuscarPais.Name = "txtBuscarPais";
            this.txtBuscarPais.Size = new System.Drawing.Size(156, 20);
            this.txtBuscarPais.TabIndex = 9;
            // 
            // txtBuscarCiudad
            // 
            this.txtBuscarCiudad.Location = new System.Drawing.Point(55, 127);
            this.txtBuscarCiudad.Name = "txtBuscarCiudad";
            this.txtBuscarCiudad.Size = new System.Drawing.Size(115, 20);
            this.txtBuscarCiudad.TabIndex = 17;
            // 
            // btnBuscarPais
            // 
            this.btnBuscarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPais.Location = new System.Drawing.Point(200, 124);
            this.btnBuscarPais.Name = "btnBuscarPais";
            this.btnBuscarPais.Size = new System.Drawing.Size(53, 23);
            this.btnBuscarPais.TabIndex = 10;
            this.btnBuscarPais.Text = "Buscar";
            this.btnBuscarPais.UseVisualStyleBackColor = true;
            this.btnBuscarPais.Click += new System.EventHandler(this.btnBuscarPais_Click);
            // 
            // btnRecargarPais
            // 
            this.btnRecargarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargarPais.Location = new System.Drawing.Point(259, 124);
            this.btnRecargarPais.Name = "btnRecargarPais";
            this.btnRecargarPais.Size = new System.Drawing.Size(68, 23);
            this.btnRecargarPais.TabIndex = 11;
            this.btnRecargarPais.Text = "Recargar";
            this.btnRecargarPais.UseVisualStyleBackColor = true;
            this.btnRecargarPais.Click += new System.EventHandler(this.btnRecargarPais_Click);
            // 
            // btnRecargarCiudad
            // 
            this.btnRecargarCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargarCiudad.Location = new System.Drawing.Point(235, 125);
            this.btnRecargarCiudad.Name = "btnRecargarCiudad";
            this.btnRecargarCiudad.Size = new System.Drawing.Size(68, 23);
            this.btnRecargarCiudad.TabIndex = 19;
            this.btnRecargarCiudad.Text = "Recargar";
            this.btnRecargarCiudad.UseVisualStyleBackColor = true;
            this.btnRecargarCiudad.Click += new System.EventHandler(this.btnRecargarCiudad_Click);
            // 
            // btnBuscarCiudad
            // 
            this.btnBuscarCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCiudad.Location = new System.Drawing.Point(176, 125);
            this.btnBuscarCiudad.Name = "btnBuscarCiudad";
            this.btnBuscarCiudad.Size = new System.Drawing.Size(53, 23);
            this.btnBuscarCiudad.TabIndex = 18;
            this.btnBuscarCiudad.Text = "Buscar";
            this.btnBuscarCiudad.UseVisualStyleBackColor = true;
            this.btnBuscarCiudad.Click += new System.EventHandler(this.btnBuscarCiudad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaises;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCiudades;
        private System.Windows.Forms.Button btnEliminarPais;
        private System.Windows.Forms.Button btnEditarPais;
        private System.Windows.Forms.Button btnGuardarPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnEliminarCiudad;
        private System.Windows.Forms.Button btnEditarCiudad;
        private System.Windows.Forms.Button btnGuardarCiudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtCodigoPais;
        private System.Windows.Forms.TextBox txtIdCiudad;
        private System.Windows.Forms.Button btnCancelarPais;
        private System.Windows.Forms.Button btnCancelarCiudad;
        private System.Windows.Forms.Button btnRecargarPais;
        private System.Windows.Forms.Button btnBuscarPais;
        private System.Windows.Forms.TextBox txtBuscarPais;
        private System.Windows.Forms.Button btnRecargarCiudad;
        private System.Windows.Forms.Button btnBuscarCiudad;
        private System.Windows.Forms.TextBox txtBuscarCiudad;
    }
}

