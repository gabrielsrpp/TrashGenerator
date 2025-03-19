namespace TrashGenerator
{
    partial class Form1
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
            txtTrashCode = new TextBox();
            numCaracteres = new NumericUpDown();
            btnGerar = new Button();
            btnCopiar = new Button();
            chkLetras = new CheckBox();
            chkNumeros = new CheckBox();
            chkSimbolos = new CheckBox();
            lblAviso = new Label();
            btnSelecionarArquivo = new Button();
            txtCaminhoArquivo = new TextBox();
            btnProtect = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numCaracteres).BeginInit();
            SuspendLayout();
            // 
            // txtTrashCode
            // 
            txtTrashCode.Location = new Point(123, 67);
            txtTrashCode.Multiline = true;
            txtTrashCode.Name = "txtTrashCode";
            txtTrashCode.Size = new Size(534, 91);
            txtTrashCode.TabIndex = 0;
            txtTrashCode.Text = "txtTrashCode";
            txtTrashCode.TextChanged += txtTrashCode_TextChanged;
            // 
            // numCaracteres
            // 
            numCaracteres.Location = new Point(327, 164);
            numCaracteres.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numCaracteres.Name = "numCaracteres";
            numCaracteres.Size = new Size(120, 23);
            numCaracteres.TabIndex = 1;
            numCaracteres.ValueChanged += numCaracteres_ValueChanged;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(251, 206);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(75, 23);
            btnGerar.TabIndex = 2;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(413, 206);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(75, 23);
            btnCopiar.TabIndex = 3;
            btnCopiar.Text = "Copiar";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // chkLetras
            // 
            chkLetras.AutoSize = true;
            chkLetras.Location = new Point(332, 260);
            chkLetras.Name = "chkLetras";
            chkLetras.Size = new Size(57, 19);
            chkLetras.TabIndex = 5;
            chkLetras.Text = "Letras";
            chkLetras.UseVisualStyleBackColor = true;
            chkLetras.CheckedChanged += chkLetras_CheckedChanged;
            // 
            // chkNumeros
            // 
            chkNumeros.AutoSize = true;
            chkNumeros.BackColor = SystemColors.Control;
            chkNumeros.BackgroundImageLayout = ImageLayout.None;
            chkNumeros.Location = new Point(332, 210);
            chkNumeros.Name = "chkNumeros";
            chkNumeros.Size = new Size(75, 19);
            chkNumeros.TabIndex = 6;
            chkNumeros.Text = "Numeros";
            chkNumeros.UseVisualStyleBackColor = false;
            chkNumeros.CheckedChanged += chkNumeros_CheckedChanged;
            // 
            // chkSimbolos
            // 
            chkSimbolos.AutoSize = true;
            chkSimbolos.Location = new Point(332, 235);
            chkSimbolos.Name = "chkSimbolos";
            chkSimbolos.Size = new Size(75, 19);
            chkSimbolos.TabIndex = 7;
            chkSimbolos.Text = "Simbolos";
            chkSimbolos.UseVisualStyleBackColor = true;
            chkSimbolos.CheckedChanged += chkSimbolos_CheckedChanged;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Location = new Point(251, 419);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(49, 15);
            lblAviso.TabIndex = 8;
            lblAviso.Text = "lblAviso";
            lblAviso.Click += lblAviso_Click;
            // 
            // btnSelecionarArquivo
            // 
            btnSelecionarArquivo.Location = new Point(188, 359);
            btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            btnSelecionarArquivo.Size = new Size(80, 23);
            btnSelecionarArquivo.TabIndex = 9;
            btnSelecionarArquivo.Text = "Selecionar";
            btnSelecionarArquivo.UseVisualStyleBackColor = true;
            btnSelecionarArquivo.Click += btnSelecionarArquivo_Click;
            // 
            // txtCaminhoArquivo
            // 
            txtCaminhoArquivo.Location = new Point(282, 359);
            txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            txtCaminhoArquivo.Size = new Size(196, 23);
            txtCaminhoArquivo.TabIndex = 10;
            txtCaminhoArquivo.TextChanged += txtCaminhoArquivo_TextChanged;
            // 
            // btnProtect
            // 
            btnProtect.Location = new Point(495, 359);
            btnProtect.Name = "btnProtect";
            btnProtect.Size = new Size(75, 23);
            btnProtect.TabIndex = 11;
            btnProtect.Text = "Proteger";
            btnProtect.UseVisualStyleBackColor = true;
            btnProtect.Click += btnProtect_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(350, 330);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(74, 23);
            textBox1.TabIndex = 12;
            textBox1.Text = "JunkCode";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnProtect);
            Controls.Add(txtCaminhoArquivo);
            Controls.Add(btnSelecionarArquivo);
            Controls.Add(lblAviso);
            Controls.Add(chkSimbolos);
            Controls.Add(chkNumeros);
            Controls.Add(chkLetras);
            Controls.Add(btnCopiar);
            Controls.Add(btnGerar);
            Controls.Add(numCaracteres);
            Controls.Add(txtTrashCode);
            Name = "Form1";
            Text = "TrashTool";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numCaracteres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTrashCode;
        private NumericUpDown numCaracteres;
        private Button btnGerar;
        private Button btnCopiar;
        private CheckBox chkLetras;
        private CheckBox chkNumeros;
        private CheckBox chkSimbolos;
        private Label lblAviso;
        private Button btnSelecionarArquivo;
        private TextBox txtCaminhoArquivo;
        private Button btnProtect;
        private TextBox textBox1;
    }
}
