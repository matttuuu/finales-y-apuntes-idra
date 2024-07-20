----Practica de JOIN-----

create table Especialidades(
	nombre_especialidad varchar(50),
	id int identity (1,1) primary key

)






create table registered_Users(
	id int not null identity (1,1) primary key,
	username varchar(60) not null,
	email varchar(120),
	logged_on timestamp,
	active bit
)





select * from registered_Users

insert into registered_Users (username,email,active)
values
('mattt_444','matthew@idra.yahoo.com',1)



alter table registered_Users
add foreign key 








insert into Especialidades (nombre_especialidad) --Para insertar
values
('Forense'),('Criminalistica'),('Cientifica')
	
select * from Especialidades







--Parte join--

select * from Customers;
select * from dbo.Orders;


--El join sirve para combinar registros de una o mas tablas 
--4 tipos principales de join

--join: devuelve los registros que estan en las dos tablas relacionadas por el criterio de combinacion

select * from Customers c
join orders o
on c.CustomerID = o.CustomerID;


--left outer join: devuelve los registros que estan en la tabla izquierda del join, y de la derecha solo aquellos
--registros que esten dentro del criterio de combinacion (trae todo lo compatible de la izquierda, y si la derecha 
--no los tiene, trae NULL)

select * from Customers c
left join Orders o --left join y left outer join son lo mismo
on c.CustomerID = o.CustomerID

--right outer join: lo mismo que left join, pero para los campos de la tabla de la derecha
select * from customers c
right join Orders o
on c.CustomerID = o.CustomerID

--full join/full outer join: devuelve todos los campos de ambas tablas, incluso los que sean null
select * from customers c
full join orders o
on c.CustomerID = o.CustomerID





-----Practica




select c.CustomerID, count (c.CustomerID) from Customers c
group by c.CustomerID -- !!! Cada vez que tenga los operandos sum(), count(), avg() - tiene que haber un group by!



--Mostrar un listado con los productos mas vendidos por vendedor
select e.FirstName,e.LastName from Employees e
join dbo.[Sales Totals by Amount] s on e.EmployeeID = s.OrderID --???



--cual es el nombre del cliente que mas ha gastado en envio de ordenes
select c.CustomerID, c.ContactName, o.Freight as valor
from dbo.Customers c
join dbo.Orders o on c.CustomerID = o.CustomerID
order by valor desc






