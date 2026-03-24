using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
namespace HandsOnAdo_Demo1
{
    internal class Demo3
    {
        //invoking stored procedure using ado.net
        public static void AddEmployee(string name,string dept,int salary)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=bankDb;Integrated Security=True;Trust Server Certificate=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("AddEmployee", connection);
                    //set Procedur
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    //pass parameter values to store procedure
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Dept", dept);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void GetEmployeesByDept(string dept)
        {
            try
            {
                using(SqlConnection connection=new SqlConnection("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=bankDb;Integrated Security=True;Trust Server Certificate=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("GetEmployeeByDept", connection);
                    //set Procedur
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    //pass parameter values to store procedure
                    command.Parameters.AddWithValue("@deptname", dept);
                    SqlDataReader reader=command.ExecuteReader();
                   
                    while (reader.Read())
                    {
                        Console.WriteLine($"Id:{reader["EmployeeId"]} Name:{reader["Name"]} " +
                            $"Dept:{reader["Department"]} Salary:{reader[3]}");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void Main()
        {
            try
            {
                AddEmployee("Karan", "Hr", 50000);
                GetEmployeesByDept("Hr");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
