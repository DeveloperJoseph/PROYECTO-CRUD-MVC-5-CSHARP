---- PROCEDURE CUSTOMERS  - LISTAR ----
create proc sp_ListCustomers
as
begin
select CustomerID, CompanyName
from Customers
end;
go

---- PROCEDURE CUSTOMERS  - LISTAR PEDIDO----
CREATE proc ListaPedidosCustomer
@CustomerID nchar(5)
as
begin
select OrderID, CustomerID,OrderDate,RequiredDate,
ShippedDate, ShipVia, Freight,ShipName,ShipAddress,
ShipCity,ShipPostalCode,ShipCountry
from Orders 
where CustomerID=@CustomerID;
END
go


---- PROCEDURE EMPLOYEES  - LISTAR ----
create proc sp_ListEmpleados
as
begin
select EmployeeID,FirstName
from Employees;
end
go


---- PROCEDURE EMPLOYEES  - LISTAR PEDIDOS----

create proc ListaPedidosEmployee
@EmployeeID int
as
begin
select OrderID,EmployeeID,OrderDate,RequiredDate,
ShippedDate, ShipVia, Freight,ShipName,ShipAddress,
ShipCity,ShipPostalCode,ShipCountry
from Orders 
where EmployeeID=@EmployeeID;
END
go


exec sp_ListCustomers
go

exec sp_ListEmpleados
go

