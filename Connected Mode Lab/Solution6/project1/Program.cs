
using Microsoft.Data.SqlClient;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // select

            //SqlConnection connection = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
            //SqlCommand command = new SqlCommand("select * from department2", connection);
            //connection.Open();

            //List<Department> departments = [];

            //SqlDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    //Console.WriteLine($"{reader[0]} - {reader[1]} - {reader[2]}");
            //    departments.Add(new Department()
            //    {
            //        Number = reader.GetInt32(0),
            //        Name = reader.GetString(1),
            //        Capacity = reader.GetInt32(2),
            //    });
            //}
            //connection.Close();

            //foreach (Department department in departments)
            //{
            //    Console.WriteLine(department);
            //}

            /***************************************************************/

            // insert

            //SqlConnection connection = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");

            //string deptName = "python";
            //int deptCapacity = 30;
            //SqlCommand command = new SqlCommand($"insert into department2 (name, capacity) values ('{deptName}', {deptCapacity})", connection);

            //connection.Open();
            //int result = command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine(result);

            /***************************************************************/

            // update

            //SqlConnection connection = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");

            //int deptCapacity = 40;
            //int deptId = 1;
            //SqlCommand command = new SqlCommand($"update department2 set capacity = @n1 where id = @n2", connection);

            //SqlParameter p1 = new SqlParameter("n1", deptCapacity);
            //SqlParameter p2 = new SqlParameter("n2", deptId);

            //command.Parameters.Add(p1);
            //command.Parameters.Add(p2);


            //connection.Open();
            //object result = command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine(result);

            /***************************************************************/

            // delete

            //SqlConnection connection = new SqlConnection("Data Source=MOHAMED\\SQLEXPRESS;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");

            //int deptNumber = 1;
            //SqlCommand command = new SqlCommand($"delete from department2 where id = @n1", connection);

            //SqlParameter p1 = new SqlParameter("n1", deptNumber);
            //command.Parameters.Add(p1);

            //connection.Open();
            //object result = command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine(result);
        }
    }
}
