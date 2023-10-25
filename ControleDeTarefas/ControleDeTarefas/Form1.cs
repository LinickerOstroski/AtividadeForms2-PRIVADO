using System.Data;
using System.Windows.Forms;

namespace ControleDeTarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            carregarDados();
        }

        private void salvarDados()
        {
            using (StreamWriter sw = new StreamWriter("dados.txt"))
            {
                foreach (DataGridViewRow row in dgTarefas.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string linha = "";
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            linha += cell.Value.ToString() + ";";
                        }
                        sw.WriteLine(linha.TrimEnd(';'));
                    }
                }
            }
        }

        private void carregarDados()
        {
            if (File.Exists("dados.txt"))
            {
                using (StreamReader sr = new StreamReader("dados.txt"))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        string[] valores = linha.Split(';');

                        if (valores.Length == dgTarefas.ColumnCount)
                            dgTarefas.Rows.Add(valores);
                        else
                        {
                            MessageBox.Show("O número de colunas no arquivo não corresponde ao DataGridView.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("O arquivo especificado não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tarefa = txtTarefa.Text;
            string dataLimite = txtData.Text;

            dgTarefas.Rows.Add(new object[]{ tarefa, dataLimite});
            salvarDados();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();

            resultado = MessageBox.Show("Quer mesmo resolver?", "Confirmação", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                dgTarefas.Rows.RemoveAt(dgTarefas.CurrentRow.Index);
            }
            
            salvarDados();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}