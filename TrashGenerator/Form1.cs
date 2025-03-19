using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TrashGenerator
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Purple800,
                Primary.Purple800,
                Primary.Purple800,
                Accent.Purple700,
                TextShade.BLACK
            );

            
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAviso.Text = "Recomenda-se um limite para proteção do código!";
            numCaracteres.Maximum = int.MaxValue;

            
            AplicarEstiloControles();
        }

        private void AplicarEstiloControles()
        {
            
            AplicarEstiloMaterial(txtTrashCode);
            AplicarEstiloMaterial(txtCaminhoArquivo);
            AplicarEstiloMaterial(numCaracteres);
            AplicarEstiloMaterial(btnGerar);
            AplicarEstiloMaterial(btnCopiar);
            AplicarEstiloMaterial(btnSelecionarArquivo);
            AplicarEstiloMaterial(btnProtect);

            
            AplicarEstiloCheckBox(chkLetras);
            AplicarEstiloCheckBox(chkNumeros);
            AplicarEstiloCheckBox(chkSimbolos);
        }

        private void AplicarEstiloMaterial(Control controle)
        {
            
            if (controle is MaterialTextBox)
            {
                var materialTextBox = (MaterialTextBox)controle;
                materialTextBox.BorderStyle = BorderStyle.None;
                materialTextBox.BackColor = MaterialSkinManager.Instance.BackgroundColor;
                materialTextBox.ForeColor = MaterialSkinManager.Instance.TextHighEmphasisColor;
            }
            else if (controle is MaterialButton)
            {
                var materialButton = (MaterialButton)controle;
                materialButton.BackColor = MaterialSkinManager.Instance.ColorScheme.AccentColor;
                materialButton.ForeColor = MaterialSkinManager.Instance.TextHighEmphasisColor;
                materialButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            }
            else if (controle is MaterialLabel)
            {
                var materialLabel = (MaterialLabel)controle;
                materialLabel.BackColor = MaterialSkinManager.Instance.BackgroundColor;
                materialLabel.ForeColor = MaterialSkinManager.Instance.TextHighEmphasisColor;
            }
        }

        private void AplicarEstiloCheckBox(CheckBox checkBox)
        {
            
            checkBox.BackColor = MaterialSkinManager.Instance.BackgroundColor;
            checkBox.ForeColor = MaterialSkinManager.Instance.TextHighEmphasisColor;
            checkBox.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            
            int tamanho = (int)numCaracteres.Value;

            
            string caracteres = "";

            if (chkLetras.Checked) caracteres += "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            if (chkNumeros.Checked) caracteres += "0123456789";
            if (chkSimbolos.Checked) caracteres += "!@#$%^&*()_+-=[]{}|;:,.<>?/";

            
            if (string.IsNullOrEmpty(caracteres))
            {
                MessageBox.Show("Selecione pelo menos um tipo de caractere!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < tamanho; i++)
            {
                int index = random.Next(caracteres.Length);
                sb.Append(caracteres[index]);
            }

            
            txtTrashCode.Text = sb.ToString();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtTrashCode.Text))
            {
                Clipboard.SetText(txtTrashCode.Text);
                MessageBox.Show("Código copiado para a área de transferência!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nada para copiar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos C# (*.cs)|*.cs|Todos os arquivos (*.*)|*.*";
            openFileDialog.Title = "Selecione um arquivo para proteger";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                txtCaminhoArquivo.Text = openFileDialog.FileName;
            }
        }

        private void btnProtect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCaminhoArquivo.Text))
            {
                MessageBox.Show("Selecione um arquivo primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string caminhoArquivo = txtCaminhoArquivo.Text;

            try
            {
                
                string conteudoAtual = File.ReadAllText(caminhoArquivo);

                
                string junkCode = GerarJunkCode();

                
                string novoConteudo = conteudoAtual + Environment.NewLine + junkCode;

                
                File.WriteAllText(caminhoArquivo, novoConteudo);

                MessageBox.Show("Arquivo protegido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao proteger o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GerarJunkCode()
        {
            
            StringBuilder junkCode = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                string tipo = random.Next(0, 2) == 0 ? "private" : "public";
                string nomeVar = $"junkVar_{random.Next(1000, 9999)}";
                long valor = random.Next(1000, 9999);

                junkCode.AppendLine($"{tipo} long {nomeVar} = {valor}; // [JUNK]");
            }

            return junkCode.ToString();
        }

        
        private void txtTrashCode_TextChanged(object sender, EventArgs e) { }
        private void numCaracteres_ValueChanged(object sender, EventArgs e) { }
        private void grpCaracteres_Enter(object sender, EventArgs e) { }
        private void chkLetras_CheckedChanged(object sender, EventArgs e) { }
        private void chkNumeros_CheckedChanged(object sender, EventArgs e) { }
        private void chkSimbolos_CheckedChanged(object sender, EventArgs e) { }
        private void lblAviso_Click(object sender, EventArgs e) { }
        private void txtCaminhoArquivo_TextChanged(object sender, EventArgs e) { }
    }
}