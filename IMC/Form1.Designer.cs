namespace IMC
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_estatura = new System.Windows.Forms.TextBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.lbl_sancadas = new System.Windows.Forms.Label();
            this.txt_sancadas = new System.Windows.Forms.TextBox();
            this.btn_messagebox_calculos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pasos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(21, 73);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(201, 26);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Ingresa tu Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(26, 117);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(379, 34);
            this.txt_nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa tu Estatura: ";
            // 
            // txt_estatura
            // 
            this.txt_estatura.Location = new System.Drawing.Point(26, 213);
            this.txt_estatura.Name = "txt_estatura";
            this.txt_estatura.Size = new System.Drawing.Size(379, 34);
            this.txt_estatura.TabIndex = 3;
            this.txt_estatura.TextChanged += new System.EventHandler(this.txt_estatura_TextChanged);
            this.txt_estatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_estatura_KeyPress);
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(21, 272);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(174, 26);
            this.lbl_peso.TabIndex = 4;
            this.lbl_peso.Text = "Ingresa tu Peso: ";
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(26, 326);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(379, 34);
            this.txt_peso.TabIndex = 5;
            this.txt_peso.TextChanged += new System.EventHandler(this.txt_peso_TextChanged);
            this.txt_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_peso_KeyPress);
            // 
            // lbl_sancadas
            // 
            this.lbl_sancadas.AutoSize = true;
            this.lbl_sancadas.Location = new System.Drawing.Point(23, 380);
            this.lbl_sancadas.Name = "lbl_sancadas";
            this.lbl_sancadas.Size = new System.Drawing.Size(290, 26);
            this.lbl_sancadas.TabIndex = 6;
            this.lbl_sancadas.Text = "Ingresa tu Sancada en (cm): ";
            // 
            // txt_sancadas
            // 
            this.txt_sancadas.Location = new System.Drawing.Point(26, 427);
            this.txt_sancadas.Name = "txt_sancadas";
            this.txt_sancadas.Size = new System.Drawing.Size(379, 34);
            this.txt_sancadas.TabIndex = 7;
            this.txt_sancadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sancadas_KeyPress);
            // 
            // btn_messagebox_calculos
            // 
            this.btn_messagebox_calculos.BackColor = System.Drawing.Color.Plum;
            this.btn_messagebox_calculos.ForeColor = System.Drawing.Color.Black;
            this.btn_messagebox_calculos.Location = new System.Drawing.Point(123, 614);
            this.btn_messagebox_calculos.Name = "btn_messagebox_calculos";
            this.btn_messagebox_calculos.Size = new System.Drawing.Size(184, 61);
            this.btn_messagebox_calculos.TabIndex = 8;
            this.btn_messagebox_calculos.Text = "Información";
            this.btn_messagebox_calculos.UseVisualStyleBackColor = false;
            this.btn_messagebox_calculos.Click += new System.EventHandler(this.btn_messagebox_calculos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingresa tu Pasos:";
            // 
            // txt_pasos
            // 
            this.txt_pasos.Location = new System.Drawing.Point(26, 534);
            this.txt_pasos.Name = "txt_pasos";
            this.txt_pasos.Size = new System.Drawing.Size(379, 34);
            this.txt_pasos.TabIndex = 10;
            this.txt_pasos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pasos_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(77, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "CALCULAR EL IMC";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(443, 704);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pasos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_messagebox_calculos);
            this.Controls.Add(this.txt_sancadas);
            this.Controls.Add(this.lbl_sancadas);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.txt_estatura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_estatura;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label lbl_sancadas;
        private System.Windows.Forms.TextBox txt_sancadas;
        private System.Windows.Forms.Button btn_messagebox_calculos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pasos;
        private System.Windows.Forms.Label label3;
    }
}

