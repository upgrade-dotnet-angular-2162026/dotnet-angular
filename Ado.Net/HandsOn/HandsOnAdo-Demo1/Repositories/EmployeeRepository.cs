using HandsOnAdo_Demo1.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
namespace HandsOnAdo_Demo1.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        private SqlConnection? connection = null;
        string connectionString = "Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=bankDb;Integrated Security=True;Trust Server Certificate=True";
        public EmployeeRepository()
        {
            connection = new SqlConnection(connectionString);
        }
        private SqlCommand? command = null;
        private string? qry = null;
        public void AddEmployee(EmployeeDataModel employeeDataModel)
        {
            try
            {
                qry = $"Insert into Employees values('{employeeDataModel.Name}'," +
                    $"'{employeeDataModel.Department}',{employeeDataModel.Salary})";
                command = new SqlCommand(qry, connection);
                connection?.Open();
                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection?.Close();
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            try
            {
                qry = $"Delete from Employees where EmployeeId={employeeId}";
                command = new SqlCommand(qry, connection);
                connection?.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection?.Close();
            }
        }

        public EmployeeDataModel? GetEmployee(int employeeId)
        {
            try
            {
                qry = "Select * from Employees where EmployeeId=" + employeeId;
                command = new SqlCommand(qry, connection);
                connection?.Open();
                SqlDataReader reader = command.ExecuteReader();
                EmployeeDataModel? employeeDataModel = null;
                if (reader.HasRows) //HasRows checks the reader having records are not
                {
                    reader.Read();
                    //convert reader data to EmployeeDataModel
                    employeeDataModel = new EmployeeDataModel()
                    {
                        EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
                        Name = reader["Name"].ToString(),
                        Department = reader["Department"].ToString(),
                        Salary = (int)reader["Salary"]
                    };
                }
                return employeeDataModel;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection?.Close();
            }

        }

        public List<EmployeeDataModel> GetEmployees()
        {
            try
            {
                qry = "Select * from Employees";
                command = new SqlCommand(qry, connection);
                connection?.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<EmployeeDataModel> employees = new List<EmployeeDataModel>();
                while (reader.Read())
                {
                    //Adding employees to List
                    employees.Add(
                        new EmployeeDataModel()
                        {
                            EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
                            Name = reader["Name"].ToString(),
                            Department = reader["Department"].ToString(),
                            Salary = (int)reader["Salary"]
                        }
                        );
                }
                return employees;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection?.Close();
            }

        }

        public void UpdateEmployee(int employeeId, string dept, int salary)
        {
            try
            {
                qry = $"Update Employees set Department='{dept}',Salary={salary} where EmployeeId={employeeId}";
                command = new SqlCommand(qry, connection);
                connection?.Open();
                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection?.Close();
            }
        }
    }
    class Test_Employee
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Employee Managment App!!");
                EmployeeRepository employeeRepository = new EmployeeRepository();
                do
                {
                    Console.WriteLine("1.AddEmployee");
                    Console.WriteLine("2.DeleteEmployee");
                    Console.WriteLine("3.UpdateEmployee");
                    Console.WriteLine("4.GetEmployee");
                    Console.WriteLine("5.GetAllEmployees");
                    Console.WriteLine("6.Exit App");
                    Console.WriteLine("Enter Choice");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            {
                                //Add Employee
                                EmployeeDataModel model = new EmployeeDataModel();
                                Console.WriteLine("Enter Name");
                                model.Name = Console.ReadLine();
                                Console.WriteLine("Enter Dept");
                                model.Department = Console.ReadLine();
                                Console.WriteLine("Enter Salary");
                                model.Salary = int.Parse(Console.ReadLine());
                                employeeRepository.AddEmployee(model);
                            }
                            break;
                        case 2:
                            {
                                //Depete Employee
                                Console.WriteLine("Enter EmployeeId");
                                int employeeId = int.Parse(Console.ReadLine());
                                employeeRepository.DeleteEmployee(employeeId);
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Enter EmployeeId");
                                int employeeId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Dept");
                                string department = Console.ReadLine();
                                Console.WriteLine("Enter Salary");
                                int salary = int.Parse(Console.ReadLine());
                                employeeRepository.UpdateEmployee(employeeId, department, salary);


                            }
                            break;
                        case 4:
                            {
                                //Get Employee
                                Console.WriteLine("Enter EmployeeId");
                                int employeeId = int.Parse(Console.ReadLine());
                                EmployeeDataModel? model = employeeRepository.GetEmployee(employeeId);
                                if (model != null)
                                {
                                    Console.WriteLine($"Id:{model.EmployeeId} Name:{model.Name} Dept:{model.Department} Salary:{model.Salary}");
                                }
                                else
                                    Console.WriteLine("Employee Id Invalid");
                            }
                            break;
                        case 5:
                            {
                                List<EmployeeDataModel> employees = employeeRepository.GetEmployees();
                                foreach (var model in employees)
                                {
                                    Console.WriteLine($"Id:{model.EmployeeId} Name:{model.Name} Dept:{model.Department} Salary:{model.Salary}");
                                }
                            }
                            break;
                        case 6:
                            {
                                //closing app
                                Environment.Exit(0);
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Invalid Choice");
                            }
                            break;
                    }

                } while (true);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
