using Microsoft.Data.SqlClient;
using System.Data;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // disconnected mode

            SqlConnection connection = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            SqlCommand command = new SqlCommand("select * from department2", connection);

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = sqlCommandBuilder.GetInsertCommand();
            adapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand();
            adapter.DeleteCommand = sqlCommandBuilder.GetDeleteCommand();

            // select

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

            foreach (Department department in departments)
            {
                Console.WriteLine(department);
            }

            // insert

            //adapter.Fill(table);
            //DataRow newRow = table.NewRow();
            //newRow[0] = 109;
            //newRow[1] = "react native";
            //newRow[2] = 33;

            //table.Rows.Add(newRow);

            //adapter.Update(table);

            // update

            //adapter.Fill(table);
            //table.Rows[0][2] = 55;
            //adapter.Update(table);

            //delete
            //adapter.Fill(table);
            //table.Rows[0].Delete();
            //adapter.Update(table);
        }
    }
}
