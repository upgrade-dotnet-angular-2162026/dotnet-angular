create procedure GetEmployeeByDept
(@deptname varchar(20))
as
begin
select * from Employees where 
Department=@deptname
end
exec GetEmployeeByDept 'HR'
create procedure GetEmployeeDetails @deptName 
varchar(30),@MinSalary int
as
begin
Select * from Employees where 
Department=@deptName and Salray>=@MinSalary
end
exec GetEmployeeDetails 'Hr',20000
create procedure AddEmployee
@Name varchar(20),
@Dept varchar(30),
@Salary int
as
begin
insert into Employees(Name,Department,Salray) 
values(@Name,@Dept,@Salary)
end
exec AddEmployee 'Sachin','Loans',56000
exec AddEmployee 'John','Finance',40000