using Microsoft.Data.SqlClient;

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
            SqlConnection connection = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand command = new SqlCommand("select * from department2", connection);
            connection.Open();
            List<Department> departments = [];

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                departments.Add(new Department()
                {
                    Number = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Capacity = reader.GetInt32(2),
                });
            }
            connection.Close();

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
            SqlConnection connection = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");

            string deptName = DepartmentNameTxt.Text;

            int deptCapacity = Convert.ToInt32(DepartmentCapacityTxt.Text);
            SqlCommand command = new SqlCommand($"insert into department2 (name, capacity) values ('{deptName}', {deptCapacity})", connection);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();

            DepartmentNameTxt.Clear();
            DepartmentCapacityTxt.Clear();
        }
        private void UpdateDepartmentBtn_Click(object sender, EventArgs e)
        {
            string name = UpdateDepartmentNameTxt.Text.ToLower();
            int capacity = Convert.ToInt32(UpdateDepartmentCapacityTxt.Text);

            SqlConnection connection = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand command = new SqlCommand($"update department2 set capacity = @n1 where name = @n2", connection);

            SqlParameter p1 = new SqlParameter("n1", capacity);
            SqlParameter p2 = new SqlParameter("n2", name);

            command.Parameters.Add(p1);
            command.Parameters.Add(p2);

            connection.Open();
            object result = command.ExecuteNonQuery();
            connection.Close();
            UpdateDepartmentNameTxt.Clear();
            UpdateDepartmentCapacityTxt.Clear();
        }

        private void DeleteDepartmentBtn_Click(object sender, EventArgs e)
        {
            string name = DeleteDepartmentNameTxt.Text.ToLower();


            SqlConnection connection = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
            SqlCommand command = new SqlCommand($"delete from department2 where name = @n1", connection);

            SqlParameter p1 = new SqlParameter("n1", name);

            command.Parameters.Add(p1);

            connection.Open();
            object result = command.ExecuteNonQuery();
            connection.Close();
            DeleteDepartmentNameTxt.Clear();
 
        }
    }
}
