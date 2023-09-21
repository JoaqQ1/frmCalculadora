namespace TrabajoIngegrador
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOperar = new Button();
            btnCerrar = new Button();
            btnLimpiar = new Button();
            textBox1 = new TextBox();
            lblPrimerOperando = new Label();
            lblSegundoOperando = new Label();
            textBox2 = new TextBox();
            lblOperar = new Label();
            lblResultado = new Label();
            radioButtonBinario = new RadioButton();
            radioButtonDecimal = new RadioButton();
            GrpBoxSistema = new GroupBox();
            comboBoxOperadores = new ComboBox();
            lblResult = new Label();
            GrpBoxSistema.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(12, 464);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(238, 43);
            btnOperar.TabIndex = 0;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(528, 464);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(219, 43);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(256, 464);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(266, 43);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 417);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "1,2,3...";
            textBox1.Size = new Size(238, 43);
            textBox1.TabIndex = 5;
            // 
            // lblPrimerOperando
            // 
            lblPrimerOperando.AutoSize = true;
            lblPrimerOperando.FlatStyle = FlatStyle.Popup;
            lblPrimerOperando.Font = new Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperando.Location = new Point(38, 376);
            lblPrimerOperando.Name = "lblPrimerOperando";
            lblPrimerOperando.Size = new Size(176, 31);
            lblPrimerOperando.TabIndex = 6;
            lblPrimerOperando.Text = "Primer operador:";
            // 
            // lblSegundoOperando
            // 
            lblSegundoOperando.AutoSize = true;
            lblSegundoOperando.FlatStyle = FlatStyle.Popup;
            lblSegundoOperando.Font = new Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperando.Location = new Point(545, 376);
            lblSegundoOperando.Name = "lblSegundoOperando";
            lblSegundoOperando.Size = new Size(199, 31);
            lblSegundoOperando.TabIndex = 8;
            lblSegundoOperando.Text = "Segundo operador:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(528, 417);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "1,2,3...";
            textBox2.Size = new Size(216, 43);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // lblOperar
            // 
            lblOperar.AutoSize = true;
            lblOperar.FlatStyle = FlatStyle.Popup;
            lblOperar.Font = new Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperar.Location = new Point(321, 376);
            lblOperar.Name = "lblOperar";
            lblOperar.Size = new Size(120, 31);
            lblOperar.TabIndex = 9;
            lblOperar.Text = "Operacion:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.FlatStyle = FlatStyle.Popup;
            lblResultado.Font = new Font("Arial Narrow", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.ForeColor = SystemColors.ActiveCaptionText;
            lblResultado.Location = new Point(38, 63);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(175, 46);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Resultado:";
            // 
            // radioButtonBinario
            // 
            radioButtonBinario.AutoSize = true;
            radioButtonBinario.Location = new Point(16, 42);
            radioButtonBinario.Name = "radioButtonBinario";
            radioButtonBinario.Size = new Size(74, 25);
            radioButtonBinario.TabIndex = 11;
            radioButtonBinario.TabStop = true;
            radioButtonBinario.Text = "Binario";
            radioButtonBinario.UseVisualStyleBackColor = true;
            // 
            // radioButtonDecimal
            // 
            radioButtonDecimal.AutoSize = true;
            radioButtonDecimal.Location = new Point(149, 42);
            radioButtonDecimal.Name = "radioButtonDecimal";
            radioButtonDecimal.Size = new Size(81, 25);
            radioButtonDecimal.TabIndex = 12;
            radioButtonDecimal.TabStop = true;
            radioButtonDecimal.Text = "Decimal";
            radioButtonDecimal.UseVisualStyleBackColor = true;
            radioButtonDecimal.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // GrpBoxSistema
            // 
            GrpBoxSistema.Controls.Add(radioButtonBinario);
            GrpBoxSistema.Controls.Add(radioButtonDecimal);
            GrpBoxSistema.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GrpBoxSistema.Location = new Point(256, 261);
            GrpBoxSistema.Name = "GrpBoxSistema";
            GrpBoxSistema.Size = new Size(245, 88);
            GrpBoxSistema.TabIndex = 13;
            GrpBoxSistema.TabStop = false;
            GrpBoxSistema.Text = "Representar resultado en:";
            // 
            // comboBoxOperadores
            // 
            comboBoxOperadores.BackColor = SystemColors.InactiveBorder;
            comboBoxOperadores.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOperadores.Font = new Font("Segoe UI Light", 19F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxOperadores.ForeColor = Color.Red;
            comboBoxOperadores.FormattingEnabled = true;
            comboBoxOperadores.Items.AddRange(new object[] {"+", "-", "/", "*" });
            comboBoxOperadores.Location = new Point(292, 417);
            comboBoxOperadores.Name = "comboBoxOperadores";
            comboBoxOperadores.Size = new Size(194, 43);
            comboBoxOperadores.TabIndex = 14;
            comboBoxOperadores.SelectedIndexChanged += comboBoxOperadores_SelectedIndexChanged;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.FlatStyle = FlatStyle.Popup;
            lblResult.Font = new Font("Arial Narrow", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.ForeColor = SystemColors.ActiveCaptionText;
            lblResult.Location = new Point(219, 63);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 46);
            lblResult.TabIndex = 15;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(6F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 519);
            Controls.Add(lblResult);
            Controls.Add(comboBoxOperadores);
            Controls.Add(GrpBoxSistema);
            Controls.Add(lblResultado);
            Controls.Add(lblOperar);
            Controls.Add(lblSegundoOperando);
            Controls.Add(textBox2);
            Controls.Add(lblPrimerOperando);
            Controls.Add(textBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCerrar);
            Controls.Add(btnOperar);
            Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumno: Joaquin Quiroga";
            FormClosing += FormView_FormClosing;
            Load += FormView_Load;
            GrpBoxSistema.ResumeLayout(false);
            GrpBoxSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperar;
        private Button btnCerrar;
        private Button btnLimpiar;
        private TextBox textBox1;
        private Label lblPrimerOperando;
        private Label lblSegundoOperando;
        private TextBox textBox2;
        private Label lblOperar;
        private Label lblResultado;
        private RadioButton radioButtonBinario;
        private RadioButton radioButtonDecimal;
        private GroupBox GrpBoxSistema;
        private ComboBox comboBoxOperadores;
        private Label lblResult;
    }
}