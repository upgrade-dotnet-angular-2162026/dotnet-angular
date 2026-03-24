using Microsoft.Data.SqlClient;
namespace HandsOnAdo_Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                string dept = "Admin";
                //initiate connction
                SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=bankDb;Integrated Security=True;Trust Server Certificate=True"); //pass connectionstring
                //open connection
                connection.Open();
                SqlCommand command=new SqlCommand($"Select * from Employees where Department='{dept}'",connection);//passing query
                //store records in datareader object
                SqlDataReader reader=command.ExecuteReader(); //executing the query
                while (reader.Read())
                {
                    Console.WriteLine($"Id:{reader["EmployeeId"]} Name:{reader["Name"]} " +
                        $"Dept:{reader["Department"]} Salary:{reader[3]}");
                }
			}
            catch (SqlException ex) //handle sql excetions
            {

                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) //handle system excpetions
			{

				Console.WriteLine(ex.Message);
			}
        }
    }
}
