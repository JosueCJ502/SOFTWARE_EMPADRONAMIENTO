namespace EMPADRONAMIENTO
{
    partial class frmConsultar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.btnConId = new System.Windows.Forms.Button();
            this.btnConNombre = new System.Windows.Forms.Button();
            this.btnConMunicipio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnConCorreo = new System.Windows.Forms.Button();
            this.btnConPais = new System.Windows.Forms.Button();
            this.btnConApellido = new System.Windows.Forms.Button();
            this.btnConCUI = new System.Windows.Forms.Button();
            this.btnConDepartamento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 57);
            this.panel1.TabIndex = 2;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(3, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(109, 50);
            this.btnRegresar.TabIndex = 35;
            this.btnRegresar.Text = "<< &Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Edwardian Script ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(291, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-3, 588);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 57);
            this.panel2.TabIndex = 37;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(328, 91);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(148, 40);
            this.btnMostrar.TabIndex = 38;
            this.btnMostrar.Text = "&Mostrar Registros";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(13, 332);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Size = new System.Drawing.Size(775, 246);
            this.dgvRegistros.TabIndex = 39;
            // 
            // btnConId
            // 
            this.btnConId.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConId.Location = new System.Drawing.Point(22, 214);
            this.btnConId.Name = "btnConId";
            this.btnConId.Size = new System.Drawing.Size(136, 40);
            this.btnConId.TabIndex = 40;
            this.btnConId.Text = "Consulta Por &Id";
            this.btnConId.UseVisualStyleBackColor = true;
            this.btnConId.Click += new System.EventHandler(this.btnConId_Click);
            // 
            // btnConNombre
            // 
            this.btnConNombre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConNombre.Location = new System.Drawing.Point(179, 214);
            this.btnConNombre.Name = "btnConNombre";
            this.btnConNombre.Size = new System.Drawing.Size(172, 40);
            this.btnConNombre.TabIndex = 41;
            this.btnConNombre.Text = "Consulta Por &Nombre";
            this.btnConNombre.UseVisualStyleBackColor = true;
            this.btnConNombre.Click += new System.EventHandler(this.btnConNombre_Click);
            // 
            // btnConMunicipio
            // 
            this.btnConMunicipio.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConMunicipio.Location = new System.Drawing.Point(381, 214);
            this.btnConMunicipio.Name = "btnConMunicipio";
            this.btnConMunicipio.Size = new System.Drawing.Size(187, 40);
            this.btnConMunicipio.TabIndex = 42;
            this.btnConMunicipio.Text = "Consulta Por Mu&nicipio";
            this.btnConMunicipio.UseVisualStyleBackColor = true;
            this.btnConMunicipio.Click += new System.EventHandler(this.btnConMunicipio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Presiona para Ver el Listado de Empadronados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Ingrese su Dato y Elige un Boton";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(305, 169);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(200, 26);
            this.txtConsulta.TabIndex = 45;
            // 
            // btnConCorreo
            // 
            this.btnConCorreo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConCorreo.Location = new System.Drawing.Point(593, 214);
            this.btnConCorreo.Name = "btnConCorreo";
            this.btnConCorreo.Size = new System.Drawing.Size(187, 40);
            this.btnConCorreo.TabIndex = 46;
            this.btnConCorreo.Text = "Consulta Por Co&rreo";
            this.btnConCorreo.UseVisualStyleBackColor = true;
            this.btnConCorreo.Click += new System.EventHandler(this.btnConCorreo_Click);
            // 
            // btnConPais
            // 
            this.btnConPais.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConPais.Location = new System.Drawing.Point(594, 269);
            this.btnConPais.Name = "btnConPais";
            this.btnConPais.Size = new System.Drawing.Size(187, 40);
            this.btnConPais.TabIndex = 50;
            this.btnConPais.Text = "Consulta Por &Pais";
            this.btnConPais.UseVisualStyleBackColor = true;
            this.btnConPais.Click += new System.EventHandler(this.btnConPais_Click);
            // 
            // btnConApellido
            // 
            this.btnConApellido.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConApellido.Location = new System.Drawing.Point(180, 269);
            this.btnConApellido.Name = "btnConApellido";
            this.btnConApellido.Size = new System.Drawing.Size(171, 40);
            this.btnConApellido.TabIndex = 48;
            this.btnConApellido.Text = "Consulta Por &Apellido";
            this.btnConApellido.UseVisualStyleBackColor = true;
            this.btnConApellido.Click += new System.EventHandler(this.btnConApellido_Click);
            // 
            // btnConCUI
            // 
            this.btnConCUI.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConCUI.Location = new System.Drawing.Point(13, 269);
            this.btnConCUI.Name = "btnConCUI";
            this.btnConCUI.Size = new System.Drawing.Size(155, 40);
            this.btnConCUI.TabIndex = 47;
            this.btnConCUI.Text = "Consulta Por &CUI";
            this.btnConCUI.UseVisualStyleBackColor = true;
            this.btnConCUI.Click += new System.EventHandler(this.btnConCUI_Click);
            // 
            // btnConDepartamento
            // 
            this.btnConDepartamento.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConDepartamento.Location = new System.Drawing.Point(365, 268);
            this.btnConDepartamento.Name = "btnConDepartamento";
            this.btnConDepartamento.Size = new System.Drawing.Size(218, 40);
            this.btnConDepartamento.TabIndex = 51;
            this.btnConDepartamento.Text = "Consulta Por &Departamento";
            this.btnConDepartamento.UseVisualStyleBackColor = true;
            this.btnConDepartamento.Click += new System.EventHandler(this.btnConDepartamento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palace Script MT", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(608, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Edgar Josué Coc Juc";
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.btnConDepartamento);
            this.Controls.Add(this.btnConPais);
            this.Controls.Add(this.btnConApellido);
            this.Controls.Add(this.btnConCUI);
            this.Controls.Add(this.btnConCorreo);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConMunicipio);
            this.Controls.Add(this.btnConNombre);
            this.Controls.Add(this.btnConId);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR";
            this.Load += new System.EventHandler(this.frmConsultar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnConId;
        private System.Windows.Forms.Button btnConNombre;
        private System.Windows.Forms.Button btnConMunicipio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnConCorreo;
        private System.Windows.Forms.Button btnConPais;
        private System.Windows.Forms.Button btnConApellido;
        private System.Windows.Forms.Button btnConCUI;
        private System.Windows.Forms.Button btnConDepartamento;
        private System.Windows.Forms.Label label3;
    }
}