using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSOVA_RSK_BD
{
    public partial class EnterModulesAndTime : Form
    {
        string connectionString;
        public EnterModulesAndTime(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            List<List<string>> modules = new List<List<string>>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                modules.Add(new List<string>());
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1[j, i].Value is not null)
                    {
                        modules[i].Add(dataGridView1[j, i].Value.ToString());
                    }
                    else
                    {
                        break;
                    }
                }
            }
            EnterDataForm enterDataForm = new EnterDataForm(connectionString, decimal.Parse(tzTextBox.Text), decimal.Parse(tpTextBox.Text)
                , decimal.Parse(lcpTextBox.Text), decimal.Parse(VcpTextBox.Text), decimal.Parse(tvzTextBox.Text), modules);
            enterDataForm.Show();
            Close();
        }

        private void EnterModulesAndTime_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < amountOfDetailsUpDown.Value; i++)
            {
                dataGridView1.Columns.Add($"{i + 1}", $"{i + 1}");
            }

            for (int i = 0; i < amountOfModulesUpDown.Value; i++)
            {
                dataGridView1.Rows.Add();
            }
        }

        private void amountOfModulesUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (amountOfModulesUpDown.Value < dataGridView1.Rows.Count)
            {
                for (int i = dataGridView1.Rows.Count - 1; i >= amountOfModulesUpDown.Value; i--)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
            else
            {
                for (int i = dataGridView1.RowCount; i < amountOfModulesUpDown.Value; i++)
                {
                    dataGridView1.Rows.Add();
                }
            }
        }

        private void amountOfDetailsUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (amountOfDetailsUpDown.Value < dataGridView1.Rows.Count)
            {
                for (int i = dataGridView1.Columns.Count - 1; i >= amountOfDetailsUpDown.Value; i--)
                {
                    dataGridView1.Columns.RemoveAt(i);
                }
            }
            else
            {
                for (int i = dataGridView1.ColumnCount; i < amountOfDetailsUpDown.Value; i++)
                {
                    dataGridView1.Columns.Add($"{i + 1}", $"{i + 1}");
                }
            }
        }
    }
}
