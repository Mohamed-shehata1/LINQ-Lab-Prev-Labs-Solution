using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            SqlCommand command = new SqlCommand("select * from department2", connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            List<Department> departments = [];
            foreach (DataRow row in table.Rows)
            {
                Department temp = new Department()
                {
                    Number = Convert.ToInt32(row[0]),
                    Name = Convert.ToString(row[1]),
                    Capacity = Convert.ToInt32(row[2]),
                };
                departments.Add(temp);
            }

            listDepartments.Items.Clear();
            foreach (Department department in departments)
            {
                listDepartments.Items.Add(department);
            }
        }

        private void ClearDepartmentsBtn_Click(object sender, EventArgs e)
        {
            listDepartments.Items.Clear();
        }

        private void AddDepartmentBtn_Click(object sender, EventArgs e)
        {
            string name = DepartmentNameTxt.Text;
            int capacity = Convert.ToInt32(DepartmentCapacityTxt.Text);

            SqlConnection connection = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            SqlCommand command = new SqlCommand("select * from department2", connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = sqlCommandBuilder.GetInsertCommand();
            adapter.Fill(table);

            DataRow newRow = table.NewRow();
            newRow["name"] = name;
            newRow["capacity"] = capacity;

            table.Rows.Add(newRow);
            adapter.Update(table);

            DepartmentNameTxt.Clear();
            DepartmentCapacityTxt.Clear();
        }
        private void UpdateDepartmentBtn_Click(object sender, EventArgs e)
        {
            string name = UpdateDepartmentNameTxt.Text.ToLower();
            int capacity = Convert.ToInt32(UpdateDepartmentCapacityTxt.Text);
            SqlConnection connection = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            SqlCommand command = new SqlCommand("select * from department2", connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand();

            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                if (row["name"].ToString() == name)
                {
                    row["capacity"] = capacity;
                }
            }
            adapter.Update(table);

            UpdateDepartmentNameTxt.Clear();
            UpdateDepartmentCapacityTxt.Clear();
        }

        private void DeleteDepartmentBtn_Click(object sender, EventArgs e)
        {
            string name = DeleteDepartmentNameTxt.Text.ToLower();

            SqlConnection connection = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            SqlCommand command = new SqlCommand("select * from department2", connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.DeleteCommand = sqlCommandBuilder.GetDeleteCommand();

            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                if (row["name"].ToString() == name)
                {
                    row.Delete();
                }
            }
            adapter.Update(table);
            DeleteDepartmentNameTxt.Clear();
        }
    }
}
