--Select
--ANSII
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'London'
-- * tüm kolonlar demek
--case insesitive
sElEcT * from Products where categoryId =1 or categoryId=3
sElEcT * from Products where categoryId =1 and UnitPrice>=10

select * from Products order by CategoryID,ProductName
select * from Products where CategoryID=1 order by UnitPrice desc   --asc ascending-    desc descendin+

select count(*) from Products
select count(*) Adet from Products where CategoryID=2

select categoryID,count(*) from Products group by CategoryID 
select categoryID,count(*) from Products group by CategoryID having count (*)<10
select categoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count (*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Products.CategoryID 
from Products inner join Categories -- iki tabloda eşleşenleri getirir
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation object

select * from Products p inner join [Order Details] od --solda olup sağda olmayanları da getir
on p.ProductID = od.ProductID
inner join Orders o on o.OrderID = od.OrderID

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID 
where o.CustomerID is null --satış yapmayan kişiler



