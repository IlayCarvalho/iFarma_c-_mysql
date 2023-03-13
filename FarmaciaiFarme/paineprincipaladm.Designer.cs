
namespace FarmaciaiFarme
{
    partial class adm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adm));
            this.btn_adcusuario = new System.Windows.Forms.Button();
            this.btn_listarusuarios = new System.Windows.Forms.Button();
            this.btn_pagfarmaceutico = new System.Windows.Forms.Button();
            this.btn_sairgerente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_adcusuario
            // 
            this.btn_adcusuario.BackColor = System.Drawing.Color.MintCream;
            this.btn_adcusuario.Location = new System.Drawing.Point(-1, 177);
            this.btn_adcusuario.Name = "btn_adcusuario";
            this.btn_adcusuario.Size = new System.Drawing.Size(207, 49);
            this.btn_adcusuario.TabIndex = 0;
            this.btn_adcusuario.Text = "Adicionar usúario";
            this.btn_adcusuario.UseVisualStyleBackColor = false;
            // 
            // btn_listarusuarios
            // 
            this.btn_listarusuarios.Location = new System.Drawing.Point(-1, 222);
            this.btn_listarusuarios.Name = "btn_listarusuarios";
            this.btn_listarusuarios.Size = new System.Drawing.Size(206, 51);
            this.btn_listarusuarios.TabIndex = 1;
            this.btn_listarusuarios.Text = "Listar usúarios";
            this.btn_listarusuarios.UseVisualStyleBackColor = true;
            // 
            // btn_pagfarmaceutico
            // 
            this.btn_pagfarmaceutico.Location = new System.Drawing.Point(-1, 270);
            this.btn_pagfarmaceutico.Name = "btn_pagfarmaceutico";
            this.btn_pagfarmaceutico.Size = new System.Drawing.Size(207, 44);
            this.btn_pagfarmaceutico.TabIndex = 2;
            this.btn_pagfarmaceutico.Text = "Pagina do Farmaceutico";
            this.btn_pagfarmaceutico.UseVisualStyleBackColor = true;
            // 
            // btn_sairgerente
            // 
            this.btn_sairgerente.Location = new System.Drawing.Point(-1, 313);
            this.btn_sairgerente.Name = "btn_sairgerente";
            this.btn_sairgerente.Size = new System.Drawing.Size(207, 44);
            this.btn_sairgerente.TabIndex = 3;
            this.btn_sairgerente.Text = "Sair";
            this.btn_sairgerente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adicionar Usúarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Função do usúario";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador"});
            this.comboBox1.Location = new System.Drawing.Point(233, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 425);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sairgerente);
            this.Controls.Add(this.btn_pagfarmaceutico);
            this.Controls.Add(this.btn_listarusuarios);
            this.Controls.Add(this.btn_adcusuario);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adm";
            this.Text = "Gerente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adcusuario;
        private System.Windows.Forms.Button btn_listarusuarios;
        private System.Windows.Forms.Button btn_pagfarmaceutico;
        private System.Windows.Forms.Button btn_sairgerente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}