using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;
namespace HandsOnAdo_Demo1
{
    internal class Demo4
    {
        static void Main()
        {
            //Dataset
            //Dataset is a collection of DataTable
            //Each DataTable can hold 1 result set data
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=bankDb;Integrated Security=True;Trust Server Certificate=True"))
            {
                connection.Open();
                //Initiate Dataset
                DataSet ds=new DataSet();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Employees", connection);
                //stored result set data in dataset
                 sqlDataAdapter.Fill(ds,"Employee");
                connection.Close();
                foreach(DataRow row in ds.Tables["Employee"].Rows)
                {
                    Console.WriteLine($"Id:{row["EmployeeId"]} Name:{row["Name"]}");
                }
                Console.WriteLine();
                //read 2nd row
                DataRow r = ds.Tables["Employee"].Rows[4];
                Console.WriteLine($"Id:{r["EmployeeId"]} Name:{r["Name"]}");
                Console.WriteLine();
                //holding 2nd table in dataset
                 sqlDataAdapter = new SqlDataAdapter("Select * from Customers", connection);
                
                sqlDataAdapter.Fill(ds, "Customer");
                DataRow row1 = ds.Tables["Customer"].Rows[2];
                Console.WriteLine($"Id:{row1["CustomerId"]} Name:{row1["FirstName"]}");


            }
        }
    }
}
