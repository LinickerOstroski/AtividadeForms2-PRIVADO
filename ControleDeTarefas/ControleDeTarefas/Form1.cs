using System.Data;
using System.Windows.Forms;

namespace ControleDeTarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tarefa = txtTarefa.Text;
            string dataLimite = txtData.Text;

            DataTable dt = new DataTable();

            dt.Columns.Add("Tarefa", typeof(string));
            dt.Columns.Add("Data Limite", typeof(string));

            DataRow novaLinha = dt.NewRow();
            novaLinha["Tarefa"] = tarefa;
            novaLinha["Data Limite"] = dataLimite;

            dt.Rows.Add(novaLinha);
            dgTarefas.DataSource = dt;
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            if (dgTarefas.SelectedRows.Count > 0)
            {
                DataRowView linhaSelecionada = dgTarefas.SelectedRows[0].DataBoundItem as DataRowView;

                if (linhaSelecionada != null)
                {
                    DataRow linhaDataRow = linhaSelecionada.Row;
                    DataTable dt = dgTarefas.DataSource as DataTable;

                    if (dt != null)
                    {
                        dt.Rows.Remove(linhaDataRow);
                        dgTarefas.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Escolha uma linha!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}