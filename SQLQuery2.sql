-- Select 
-- ANSII
select ContactName Adi,CompanyName Sirketadi,City sehir from Customers

select * from Customers where City ='Berlin'

-- case insensitive buyuk kuçuk harf duyarsız
select * from Products where CategoryID =1 or CategoryID=3

select * from Products where CategoryID =1 and UnitPrice>=10

select * from Products where CategoryID =1 order by UnitPrice desc  --ascending --  descending

select count (*) from Products -- satır sayısını verir

select count (*) from Products where CategoryID=2 -- categoriıd si 2 olan kaç tane satır var



--hangi kategoride kac farklı urunumuz var
select CategoryID, count (*) from Products group by CategoryID

--10 dan az olan kategorileri sırala unitprice 20 den  buyuk olanda 
select CategoryID, count (*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID = Categories.CategoryID

--DTA Data Tranformation object

select * from Products p left join [Order Details] od -- solda olup sağda olmayanları da getir
on p.ProductID = od.ProductID
inner join orders o
on o.OrderID = od.OrderID

select * from Customers c right join orders o -- sağda olup solda olmayanalrı da getir
on c.CustomerID =o.CustomerID
where o.CustomerID is null 














