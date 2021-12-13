using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsVariant14
{
    public partial class FormBase : Form
    {

        private string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "dataVar14.txt");
        public FormBase()
        {
            InitializeComponent();
        }

        private void LoadFile()
        {
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                dataGridView1.Rows.Clear();
                while (!streamReader.EndOfStream)
                {
                    string[] values = streamReader.ReadLine().Split('‼');
                    dataGridView1.Rows.Add(values);
                }
                streamReader.Close();
            }
        }

        private void FormBase_Load(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Value?. - https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-
                string firsName = row.Cells["FirsName"].Value?.ToString();
                string name = row.Cells["NameColumn"].Value?.ToString();
                string lastName = row.Cells["LastName"].Value?.ToString();
                string shortFIO = $"{firsName}.{name?[0]}.{lastName?[0]}";
                string model = row.Cells["Model"].Value?.ToString();
                string num = row.Cells["Num"].Value?.ToString();
                string color = row.Cells["Color"].Value?.ToString();
                string result = string.Join("‼", new string[] { firsName, name, lastName, shortFIO, model, num, color });
                
                // Если строка не пустая то записываем её в файл
                if(result.Length > 8)
                    streamWriter.WriteLine(result);
            }
            streamWriter.Close();
            LoadFile();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                // Группируем по модели, потом сортируем по количеству элементов в каждой группе и выводим группу с максимальным значением элементов
                string popularModel = dataGridView1.Rows.Cast<DataGridViewRow>().GroupBy(r => r.Cells["Model"]?.Value).OrderBy(g => g.Count()).Last().First().Cells["Model"].Value.ToString();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Если срока относиться к популярной модели то показываем её
                    if (row.Cells["Model"].Value?.ToString() == popularModel)
                        row.Visible = true;
                    else // Иначе если строка не новая то скрываем её
                    if(!row.IsNewRow)
                        row.Visible = false;
                }
            }
        }

        private void buttonInitialState_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                    row.Visible = true;
            }

            dataGridView1.ClearSelection();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Если цвет машины белый то показываем
                if (row.Cells["Color"].Value?.ToString().ToUpper() == "БЕЛЫЙ")
                    row.Visible = true;
                else // Иначе если строка не новая то скрываем её
                if (!row.IsNewRow)
                    row.Visible = false;
            }
            // Сортируем по модели 
            dataGridView1.Sort(dataGridView1.Columns["Model"], ListSortDirection.Ascending);
        }
    }
}
