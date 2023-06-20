namespace InterfacePlataforma
{
    partial class Form_init
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_iniciar = new System.Windows.Forms.Button();
            this.rb_masc = new System.Windows.Forms.RadioButton();
            this.rb_fem = new System.Windows.Forms.RadioButton();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.txbx_fullname = new System.Windows.Forms.TextBox();
            this.lb_sexo = new System.Windows.Forms.Label();
            this.txbx_idade = new System.Windows.Forms.TextBox();
            this.txbx_peso = new System.Windows.Forms.TextBox();
            this.txbx_numbtest = new System.Windows.Forms.TextBox();
            this.bt_visualizar = new System.Windows.Forms.Button();
            this.lb_idade = new System.Windows.Forms.Label();
            this.lb_peso = new System.Windows.Forms.Label();
            this.lb_numtest = new System.Windows.Forms.Label();
            this.lb_typetest = new System.Windows.Forms.Label();
            this.cb_testType = new System.Windows.Forms.ComboBox();
            this.lb_test = new System.Windows.Forms.Label();
            this.cb_grupo = new System.Windows.Forms.ComboBox();
            this.lb_grupo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_iniciar
            // 
            this.bt_iniciar.BackColor = System.Drawing.Color.LawnGreen;
            this.bt_iniciar.Location = new System.Drawing.Point(352, 45);
            this.bt_iniciar.Name = "bt_iniciar";
            this.bt_iniciar.Size = new System.Drawing.Size(161, 89);
            this.bt_iniciar.TabIndex = 6;
            this.bt_iniciar.Text = "Start";
            this.bt_iniciar.UseVisualStyleBackColor = false;
            this.bt_iniciar.Click += new System.EventHandler(this.Bt_iniciar_Click);
            // 
            // rb_masc
            // 
            this.rb_masc.AutoSize = true;
            this.rb_masc.Checked = true;
            this.rb_masc.Location = new System.Drawing.Point(22, 180);
            this.rb_masc.Name = "rb_masc";
            this.rb_masc.Size = new System.Drawing.Size(34, 17);
            this.rb_masc.TabIndex = 2;
            this.rb_masc.TabStop = true;
            this.rb_masc.Text = "M";
            this.rb_masc.UseVisualStyleBackColor = true;
            // 
            // rb_fem
            // 
            this.rb_fem.AutoSize = true;
            this.rb_fem.Location = new System.Drawing.Point(70, 180);
            this.rb_fem.Name = "rb_fem";
            this.rb_fem.Size = new System.Drawing.Size(31, 17);
            this.rb_fem.TabIndex = 3;
            this.rb_fem.Text = "F";
            this.rb_fem.UseVisualStyleBackColor = true;
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.Location = new System.Drawing.Point(19, 86);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(80, 20);
            this.lb_fullname.TabIndex = 3;
            this.lb_fullname.Text = "Full Name";
            // 
            // txbx_fullname
            // 
            this.txbx_fullname.Location = new System.Drawing.Point(22, 114);
            this.txbx_fullname.Name = "txbx_fullname";
            this.txbx_fullname.Size = new System.Drawing.Size(264, 20);
            this.txbx_fullname.TabIndex = 1;
            this.txbx_fullname.Text = "Heron Pereira";
            // 
            // lb_sexo
            // 
            this.lb_sexo.AutoSize = true;
            this.lb_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sexo.Location = new System.Drawing.Point(19, 153);
            this.lb_sexo.Name = "lb_sexo";
            this.lb_sexo.Size = new System.Drawing.Size(36, 20);
            this.lb_sexo.TabIndex = 5;
            this.lb_sexo.Text = "Sex";
            // 
            // txbx_idade
            // 
            this.txbx_idade.Location = new System.Drawing.Point(139, 224);
            this.txbx_idade.Name = "txbx_idade";
            this.txbx_idade.Size = new System.Drawing.Size(147, 20);
            this.txbx_idade.TabIndex = 4;
            this.txbx_idade.Text = "31";
            // 
            // txbx_peso
            // 
            this.txbx_peso.Location = new System.Drawing.Point(139, 262);
            this.txbx_peso.Name = "txbx_peso";
            this.txbx_peso.Size = new System.Drawing.Size(147, 20);
            this.txbx_peso.TabIndex = 5;
            this.txbx_peso.Text = "100";
            // 
            // txbx_numbtest
            // 
            this.txbx_numbtest.Location = new System.Drawing.Point(47, 46);
            this.txbx_numbtest.Name = "txbx_numbtest";
            this.txbx_numbtest.Size = new System.Drawing.Size(61, 20);
            this.txbx_numbtest.TabIndex = 0;
            this.txbx_numbtest.Text = "1";
            // 
            // bt_visualizar
            // 
            this.bt_visualizar.Location = new System.Drawing.Point(352, 208);
            this.bt_visualizar.Name = "bt_visualizar";
            this.bt_visualizar.Size = new System.Drawing.Size(161, 50);
            this.bt_visualizar.TabIndex = 7;
            this.bt_visualizar.Text = "Visualize";
            this.bt_visualizar.UseVisualStyleBackColor = true;
            this.bt_visualizar.Click += new System.EventHandler(this.Bt_visualizar_Click);
            // 
            // lb_idade
            // 
            this.lb_idade.AutoSize = true;
            this.lb_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idade.Location = new System.Drawing.Point(19, 222);
            this.lb_idade.Name = "lb_idade";
            this.lb_idade.Size = new System.Drawing.Size(94, 20);
            this.lb_idade.TabIndex = 11;
            this.lb_idade.Text = "Age (Years)";
            // 
            // lb_peso
            // 
            this.lb_peso.AutoSize = true;
            this.lb_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_peso.Location = new System.Drawing.Point(18, 260);
            this.lb_peso.Name = "lb_peso";
            this.lb_peso.Size = new System.Drawing.Size(90, 20);
            this.lb_peso.TabIndex = 12;
            this.lb_peso.Text = "Weight (kg)";
            // 
            // lb_numtest
            // 
            this.lb_numtest.AutoSize = true;
            this.lb_numtest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numtest.Location = new System.Drawing.Point(18, 47);
            this.lb_numtest.Name = "lb_numtest";
            this.lb_numtest.Size = new System.Drawing.Size(23, 17);
            this.lb_numtest.TabIndex = 13;
            this.lb_numtest.Text = "Nº";
            // 
            // lb_typetest
            // 
            this.lb_typetest.AutoSize = true;
            this.lb_typetest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_typetest.Location = new System.Drawing.Point(119, 45);
            this.lb_typetest.Name = "lb_typetest";
            this.lb_typetest.Size = new System.Drawing.Size(40, 17);
            this.lb_typetest.TabIndex = 16;
            this.lb_typetest.Text = "Type";
            // 
            // cb_testType
            // 
            this.cb_testType.FormattingEnabled = true;
            this.cb_testType.Items.AddRange(new object[] {
            "Static",
            "Dinamic"});
            this.cb_testType.Location = new System.Drawing.Point(165, 45);
            this.cb_testType.Name = "cb_testType";
            this.cb_testType.Size = new System.Drawing.Size(121, 21);
            this.cb_testType.TabIndex = 18;
            this.cb_testType.Text = "Static";
            // 
            // lb_test
            // 
            this.lb_test.AutoSize = true;
            this.lb_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_test.Location = new System.Drawing.Point(18, 13);
            this.lb_test.Name = "lb_test";
            this.lb_test.Size = new System.Drawing.Size(40, 20);
            this.lb_test.TabIndex = 19;
            this.lb_test.Text = "Test";
            // 
            // cb_grupo
            // 
            this.cb_grupo.FormattingEnabled = true;
            this.cb_grupo.Items.AddRange(new object[] {
            "Control",
            "Diabetes",
            "Neuropathy"});
            this.cb_grupo.Location = new System.Drawing.Point(139, 180);
            this.cb_grupo.Name = "cb_grupo";
            this.cb_grupo.Size = new System.Drawing.Size(147, 21);
            this.cb_grupo.TabIndex = 22;
            this.cb_grupo.Text = "Control";
            // 
            // lb_grupo
            // 
            this.lb_grupo.AutoSize = true;
            this.lb_grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_grupo.Location = new System.Drawing.Point(136, 156);
            this.lb_grupo.Name = "lb_grupo";
            this.lb_grupo.Size = new System.Drawing.Size(48, 17);
            this.lb_grupo.TabIndex = 21;
            this.lb_grupo.Text = "Group";
            // 
            // Form_init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 325);
            this.Controls.Add(this.cb_grupo);
            this.Controls.Add(this.lb_grupo);
            this.Controls.Add(this.lb_test);
            this.Controls.Add(this.cb_testType);
            this.Controls.Add(this.lb_typetest);
            this.Controls.Add(this.lb_numtest);
            this.Controls.Add(this.lb_peso);
            this.Controls.Add(this.lb_idade);
            this.Controls.Add(this.bt_visualizar);
            this.Controls.Add(this.txbx_numbtest);
            this.Controls.Add(this.txbx_peso);
            this.Controls.Add(this.txbx_idade);
            this.Controls.Add(this.lb_sexo);
            this.Controls.Add(this.txbx_fullname);
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.rb_fem);
            this.Controls.Add(this.rb_masc);
            this.Controls.Add(this.bt_iniciar);
            this.Name = "Form_init";
            this.Text = "Baropodometry Platform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_iniciar;
        private System.Windows.Forms.RadioButton rb_masc;
        private System.Windows.Forms.RadioButton rb_fem;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.TextBox txbx_fullname;
        private System.Windows.Forms.Label lb_sexo;
        private System.Windows.Forms.TextBox txbx_idade;
        private System.Windows.Forms.TextBox txbx_peso;
        private System.Windows.Forms.TextBox txbx_numbtest;
        private System.Windows.Forms.Button bt_visualizar;
        private System.Windows.Forms.Label lb_idade;
        private System.Windows.Forms.Label lb_peso;
        private System.Windows.Forms.Label lb_numtest;
        private System.Windows.Forms.Label lb_typetest;
        private System.Windows.Forms.ComboBox cb_testType;
        private System.Windows.Forms.Label lb_test;
        private System.Windows.Forms.ComboBox cb_grupo;
        private System.Windows.Forms.Label lb_grupo;
    }
}

