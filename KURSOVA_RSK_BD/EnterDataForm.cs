using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSOVA_RSK_BD
{
    public partial class EnterDataForm : Form
    {
        List<List<string>> modules = new List<List<string>>() {
            new List<string>() {"Т1", "С1", "Т2", "Т4", "Т5", "Т3", "Ф2", "Ф1", "С3"},
            new List<string>() {"Ф3", "Ф4"},
            new List<string>() {"С2"},
            new List<string>() {"Р1"}
        };
        string connectionString;
        decimal tz;
        decimal tp;
        decimal lcp;
        decimal vcp;
        decimal tvz;
        public EnterDataForm(string connectionString, decimal tz, decimal tp, decimal lcp, decimal vcp, decimal tvz, List<List<string>> modules)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.tz = tz;
            this.tp = tp;
            this.lcp = lcp;
            this.vcp = vcp;
            this.tvz = tvz;
            this.modules = modules;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < dataGridView1.ColumnCount)
            {
                for (int i = dataGridView1.ColumnCount - 1; i >= numericUpDown1.Value; i--)
                {
                    dataGridView1.Columns.RemoveAt(i);
                }
            }
            else
            {
                for (int i = dataGridView1.ColumnCount; i < numericUpDown1.Value; i++)
                {
                    dataGridView1.Columns.Add($"Д{i + 1}", $"Д{i + 1}");
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value < dataGridView1.RowCount)
            {
                for (int i = dataGridView1.RowCount - 1; i >= numericUpDown2.Value; i--)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
            else
            {
                for (int i = dataGridView1.RowCount; i < numericUpDown2.Value; i++)
                {
                    dataGridView1.Rows.Add();
                }
            }
        }

        private void EnterDataForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                dataGridView1.Columns.Add($"Д{i + 1}", $"Д{i + 1}");
            }

            for (int i = 0; i < numericUpDown2.Value; i++)
            {
                dataGridView1.Rows.Add();
            }

            dataGridView2.Columns.Add("АС", "АС");
            dataGridView2.Rows.Add();
            for (int i = 1; i <= GVMUpDown.Value; i++)
            {
                dataGridView2.Columns.Add($"ГВМ{i}", $"ГВМ{i}");
                dataGridView2.Rows.Add();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Transaction = sqlTransaction;
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"Delete TIME_MATRIX";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = @"DELETE PATHS_MATRIX";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = @"DELETE DETAILS";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.CommandText = @"INSERT INTO DETAILS VALUES(@ID, @DO1, @DO2, @DO3, @DO4, @DO5, @DO6
                , @DO7, @DO8)";
                sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar, 10);
                sqlCommand.Parameters.Add("@DO1", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@DO2", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@DO3", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@DO4", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@DO5", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@DO6", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@DO7", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@DO8", SqlDbType.NVarChar, 20);
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    sqlCommand.Parameters["@ID"].Value = $"Д{i + 1}";
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        sqlCommand.Parameters[$"@DO{j + 1}"].Value = dataGridView1[i, j] == null || dataGridView1[i, j].Value == null || dataGridView1[i, j].Value == "" ? DBNull.Value : dataGridView1[i, j].Value;
                    }
                    sqlCommand.ExecuteNonQuery();
                }


                sqlCommand.CommandText = @"INSERT INTO PATHS_MATRIX VALUES(@ID, @DY1, @DY2, @DY3, @DY4, @DY5, @DY6, @DY7, @DY8, @ID_DETAILS)";
                sqlCommand.Parameters.Add("@DY1", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@DY2", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@DY3", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@DY4", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@DY5", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@DY6", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@DY7", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@DY8", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@ID_DETAILS", SqlDbType.NVarChar, 20);

                int amountOfDY = 0;

                List<string> unreformed = new List<string>();
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    sqlCommand.Parameters["@ID"].Value = $"Д{i + 1}";
                    sqlCommand.Parameters["@ID_DETAILS"].Value = $"Д{i + 1}";
                    StringBuilder stringBuilder = new StringBuilder();
                    int local = 0;
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {

                        for (int x = 0; x < modules.Count; x++)
                        {
                            if (modules[x].Contains(dataGridView1[i, j].Value))
                            {
                                stringBuilder.Append($"М{x + 1}, ");
                                break;
                            }
                        }
                        string result = stringBuilder.ToString();
                        if (result.Length > 3)
                            result = result.Remove(result.Length - 2);
                        List<string> splited = result.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
                        for (int x = 0; x < splited.Count - 1; x++)
                        {
                            if (splited[x] == splited[x + 1])
                            {
                                splited.RemoveAt(x + 1);
                                x--;
                            }
                        }
                        local = splited.Count;
                        for (int x = 0; x < splited.Count; x++)
                        {
                            sqlCommand.Parameters[$"@DY{x + 1}"].Value = splited[x];
                        }
                        for (int x = splited.Count; x < 8; x++)
                        {
                            sqlCommand.Parameters[$"@DY{x + 1}"].Value = DBNull.Value;
                        }
                    }
                    amountOfDY += local;
                    unreformed.Add(stringBuilder.ToString());
                    sqlCommand.ExecuteNonQuery();
                }

                List<string> collection = new List<string>();
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        if (!(dataGridView1[i, j].Value is null))
                            collection.Add(dataGridView1[i, j].Value.ToString());
                    }
                }
                collection = collection.Distinct().ToList();

                List<List<string>> answers = new List<List<string>>();

                foreach (var x in collection)
                {
                    answers.Add(new List<string>());
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        int amount = 0;
                        string answ;
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            if (!(dataGridView1[j, i].Value is null) && dataGridView1[j, i].Value.ToString().Equals(x))
                            {
                                amount += 1;
                            }
                        }
                        answers[answers.Count - 1].Add($"{x}: {i + 1}-{amount}");
                    }
                }

                List<string> fullAmounts = new List<string>();

                foreach (var x in answers)
                {
                    List<int> amounts = new List<int>();
                    string[] splited = new string[0];
                    string letter = "";
                    int prevAmount = 0;
                    int pos = 0;
                    foreach (var y in x)
                    {
                        splited = y.Split(": ", StringSplitOptions.RemoveEmptyEntries)[1].Split("-", StringSplitOptions.RemoveEmptyEntries);
                        letter = y.Split(": ", StringSplitOptions.RemoveEmptyEntries)[0];

                        amounts.Add(int.Parse(splited[1]));
                        if (prevAmount < amounts[amounts.Count - 1])
                        {
                            prevAmount = amounts[amounts.Count - 1];
                            pos = int.Parse(splited[0]);
                        }
                    }
                    int max = amounts.Max();
                    fullAmounts.Add($"{letter}-{amounts.Sum()}-{max}-{pos}");
                    for (int i = 0; i < x.Count; i++)
                    {
                        if (int.Parse(x[i].Split(": ", StringSplitOptions.RemoveEmptyEntries)[1].Split("-", StringSplitOptions.RemoveEmptyEntries)[1]) != max)
                        {
                            x.RemoveAt(i);
                            i--;
                        }
                    }
                }

                for (int i = 0; i < fullAmounts.Count - 1; i++)
                {
                    if (int.Parse(fullAmounts[i].Split("-")[1]) < int.Parse(fullAmounts[i + 1].Split("-")[1]))
                    {
                        (fullAmounts[i], fullAmounts[i + 1]) = (fullAmounts[i + 1], fullAmounts[i]);
                    }
                    else if (int.Parse(fullAmounts[i].Split("-")[1]) == int.Parse(fullAmounts[i + 1].Split("-")[1]))
                    {
                        if (int.Parse(fullAmounts[i].Split("-")[2]) < int.Parse(fullAmounts[i + 1].Split("-")[2]))
                        {
                            (fullAmounts[i], fullAmounts[i + 1]) = (fullAmounts[i + 1], fullAmounts[i]);
                        }
                        else if (int.Parse(fullAmounts[i].Split("-")[2]) == int.Parse(fullAmounts[i + 1].Split("-")[2]))
                        {
                            if (int.Parse(fullAmounts[i].Split("-")[3]) > int.Parse(fullAmounts[i + 1].Split("-")[3]))
                            {
                                (fullAmounts[i], fullAmounts[i + 1]) = (fullAmounts[i + 1], fullAmounts[i]);
                            }
                        }
                    }
                }

                sqlCommand.CommandText = @"Delete SIMPLE_MATRIX_OPERATIONS";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = @"INSERT INTO SIMPLE_MATRIX_OPERATIONS VALUES(@ID, @POS1, @POS2, @POS3, @POS4, @POS5, @POS6, @POS7, @POS8, @AMOUNT_OF_USE, @COMPLEXITY)";
                sqlCommand.Parameters.Add("@POS1", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@POS2", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@POS3", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@POS4", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@POS5", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@POS6", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@POS7", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@POS8", SqlDbType.NVarChar, 20);
                sqlCommand.Parameters.Add("@AMOUNT_OF_USE", SqlDbType.Int);
                sqlCommand.Parameters.Add("@COMPLEXITY", SqlDbType.Decimal);
                sqlCommand.Parameters["@COMPLEXITY"].Precision = 18;
                sqlCommand.Parameters["@COMPLEXITY"].Scale = 2;




                decimal complexity = 1.0m;
                decimal step = complexity / (collection.Count - 1);
                List<decimal> complexities = new List<decimal>();
                for (int i = 0; i < fullAmounts.Count; i++)
                {
                    sqlCommand.Parameters["@ID"].Value = $"{fullAmounts[i].Split("-")[0]}";
                    for (int q = 0; q < 8; q++)
                    {
                        sqlCommand.Parameters[$"@POS{q + 1}"].Value = DBNull.Value;
                    }
                    foreach (var x in answers)
                    {
                        foreach (var y in x)
                        {
                            if (y.Contains(fullAmounts[i].Split("-")[0]))
                            {
                                sqlCommand.Parameters[$"@POS{int.Parse(fullAmounts[i].Split("-")[3])}"].Value = fullAmounts[i].Split("-")[2];
                                sqlCommand.Parameters["@AMOUNT_OF_USE"].Value = int.Parse(fullAmounts[i].Split("-")[1]);
                            }
                        }
                    }
                    sqlCommand.Parameters["@COMPLEXITY"].Value = complexity;
                    complexities.Add(complexity);
                    complexity -= step;
                    if (complexity < 0.1M)
                    {
                        complexity = 0.1m;
                    }
                    sqlCommand.ExecuteNonQuery();
                }

                decimal tOb = decimal.Parse(tObText.Text);

                decimal tMax;

                decimal sum = 0;
                for (int i = 0; i < fullAmounts.Count; i++)
                {
                    sum += complexities[i] * decimal.Parse(fullAmounts[i].Split("-")[1]);
                }

                tMax = amountOfDY * tOb * 60 / sum;

                List<string> detailTimes = new List<string>();
                for (int i = 0; i < fullAmounts.Count; i++)
                {
                    detailTimes.Add($"{fullAmounts[i].Split("-")[0]}-{tMax * complexities[i]}");
                }

                List<List<decimal>> sums = new List<List<decimal>>();
                for (int i = 0; i < unreformed.Count; i++)
                {
                    string[] mas = unreformed[i].Split(", ", StringSplitOptions.RemoveEmptyEntries);
                    if (mas.Length > 0)
                    {
                        string prev = mas[0];
                        decimal sum2 = 0;
                        sums.Add(new List<decimal>());
                        for (int j = 0; j < mas.Length; j++)
                        {
                            for (int x = 0; x < detailTimes.Count; x++)
                            {
                                if (dataGridView1[i, j].Value != null && detailTimes[x].Contains(dataGridView1[i, j].Value.ToString()))
                                {
                                    if (mas[j] != prev)
                                    {
                                        sums[sums.Count - 1].Add(sum2);
                                        prev = mas[j];
                                        sum2 = 0;
                                    }
                                    sum2 += decimal.Parse(detailTimes[x].Split("-")[1]);
                                }
                            }
                        }
                        sums[sums.Count - 1].Add(sum2);
                    }
                }



                sqlCommand.CommandText = @"INSERT INTO TIME_MATRIX VALUES(@ID, @DY11, @DY21, @DY31, @DY41, @DY51, @DY61, @DY71, @DY81, @ID_DETAILS)";
                sqlCommand.Parameters.Add("@DY11", SqlDbType.Decimal);
                sqlCommand.Parameters.Add("@DY21", SqlDbType.Decimal);
                sqlCommand.Parameters.Add("@DY31", SqlDbType.Decimal);
                sqlCommand.Parameters.Add("@DY41", SqlDbType.Decimal);
                sqlCommand.Parameters.Add("@DY51", SqlDbType.Decimal);
                sqlCommand.Parameters.Add("@DY61", SqlDbType.Decimal);
                sqlCommand.Parameters.Add("@DY71", SqlDbType.Decimal);
                sqlCommand.Parameters.Add("@DY81", SqlDbType.Decimal);

                for (int i = 0; i < sums.Count; i++)
                {
                    sqlCommand.Parameters["@ID"].Value = $"Д{i + 1}";
                    sqlCommand.Parameters["@ID_DETAILS"].Value = $"Д{i + 1}";
                    for (int j = 0; j < sums[i].Count; j++)
                    {
                        sqlCommand.Parameters[$"@DY{j + 1}1"].Value = sums[i][j];
                    }
                    for (int j = sums[i].Count; j < 8; j++)
                    {
                        sqlCommand.Parameters[$"@DY{j + 1}1"].Value = DBNull.Value;
                    }
                    sqlCommand.ExecuteNonQuery();
                }
                for (int i = sums.Count; i < 14; i++)
                {
                    sqlCommand.Parameters["@ID"].Value = $"Д{i + 1}";
                    sqlCommand.Parameters["@ID_DETAILS"].Value = $"Д{i + 1}";
                    for (int j = 0; j < 8; j++)
                    {
                        sqlCommand.Parameters[$"@DY{j + 1}1"].Value = DBNull.Value;
                    }
                    sqlCommand.ExecuteNonQuery();
                }

                decimal tcp = lcp / vcp;
                sqlCommand.CommandText = "Delete TIME_OF_SERVING";
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = "Insert into TIME_OF_SERVING (Enter, ExitD, Value) values (@Enter, @ExitD, @Value)";
                sqlCommand.Parameters.Add("@Enter", SqlDbType.VarChar, 20);
                sqlCommand.Parameters.Add("@ExitD", SqlDbType.VarChar, 20);
                sqlCommand.Parameters.Add("@Value", SqlDbType.Decimal);

                for(int i = 1; i < dataGridView2.ColumnCount; i++)
                {
                    if (dataGridView2[i, 0].Value is not null)
                    {
                        sqlCommand.Parameters["@Enter"].Value = "АС";
                        sqlCommand.Parameters["@ExitD"].Value = $"ГВМ{i}";
                        sqlCommand.Parameters["@Value"].Value = decimal.Parse(dataGridView2[i, 0].Value.ToString()) * tcp + tvz + tvz + tz;
                        sqlCommand.ExecuteNonQuery();
                    }
                }

                for (int i = 1; i < dataGridView2.RowCount; i++)
                {
                    if (dataGridView2[0, i].Value is not null)
                    {
                        sqlCommand.Parameters["@Enter"].Value = $"ГВМ{i}";
                        sqlCommand.Parameters["@ExitD"].Value = "АС";
                        sqlCommand.Parameters["@Value"].Value = decimal.Parse(dataGridView2[0, i].Value.ToString()) * tcp + tvz + tvz + tp;
                        sqlCommand.ExecuteNonQuery();
                    }
                }

                for(int i = 1; i < dataGridView2.RowCount; i++)
                {
                    for(int j = 1; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2[j, i].Value is not null && i != j)
                        {
                            sqlCommand.Parameters["@Enter"].Value = $"ГВМ{i}";
                            sqlCommand.Parameters["@ExitD"].Value = $"ГВМ{j}";
                            sqlCommand.Parameters["@Value"].Value = decimal.Parse(dataGridView2[j, i].Value.ToString()) * tcp + tvz + tvz + tp + tz;
                            sqlCommand.ExecuteNonQuery();
                        }
                    }
                }

                sqlTransaction.Commit();
                MessageBox.Show("Inserted!");
                MessageBox.Show($"Кількість ДУ = {amountOfDY}");
                MessageBox.Show($"t max = {tMax}");
            }
            catch (Exception ex)
            {
                sqlTransaction.Rollback();
                MessageBox.Show(ex.Message);
            }
        }

        private void GVMUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(GVMUpDown.Value < dataGridView2.ColumnCount)
            {
                for(int i = dataGridView2.ColumnCount - 1; i >= GVMUpDown.Value; i--)
                {
                    dataGridView2.Columns.RemoveAt(i);
                    dataGridView2.Rows.RemoveAt(i);
                }
            }
            else
            {
                for(int i = dataGridView2.ColumnCount; i <= GVMUpDown.Value; i++)
                {
                    dataGridView2.Columns.Add($"ГВМ{i}", $"ГВМ{i}");
                    dataGridView2.Rows.Add();
                }
            }
        }
    }
}
