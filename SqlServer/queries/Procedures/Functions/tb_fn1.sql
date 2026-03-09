--get accounts of a custoer
create function GetCustomers(@customerId int)
returns table
as
return select * from Accounts where CustomerId=@customerId
select * from GetCustomers(3)
select AccountId,AccountNumber from GetCustomers(2)