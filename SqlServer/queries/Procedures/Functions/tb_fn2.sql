create function GetCustomerAccountDetails(@customreId int)
returns table
as
return Select c.firstname,a.accountId,a.accountNumber from Customers c join Accounts a
on c.CustomerId=a.CustomerId where c.CustomerId=@customreId
select * from GetCustomerAccountDetails(1)