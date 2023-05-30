using System.Data.SqlClient;

namespace KURSOVA_RSK_BD
{
    public partial class Form1 : Form
    {
        string connectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder["Data Source"] = $@".\{dataSourceText.Text}";
            connectionStringBuilder["Initial Catalog"] = $"{dataBaseText.Text}";
            connectionStringBuilder["Integrated Security"] = true;
            connectionStringBuilder["MultipleActiveResultSets"] = true;
            using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();
                    connectionString = connectionStringBuilder.ConnectionString;
                    EnterDataForm enterDataForm = new EnterDataForm(connectionString);
                    enterDataForm.Show();
                    this.Visible = false;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}