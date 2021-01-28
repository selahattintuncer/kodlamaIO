--Select
Select ContactName Adi, CompanyName Sirketadi, City Sehir from Customers -- Cont

Select * from Customers where City = 'London'


Select * from Products where categoryId=1 or CategoryID=3

Select * from Products where categoryId=1 and UnitPrice>10  -- categoryId 1 olanları ve Unitprice 10 dan büyük olanları getir

select * from Products order by ProductName  -- ürünleri ProductName göre sıralayarak getir

select * from Products order by ProductName, UnitPrice   -- ürünleri ProductName ve sonra  UnitPrice göre sıralayarak getir

select * from Products order by UnitPrice asc -- asc artan şeklinde sırala demek

select * from Products order by UnitPrice desc -- desc düşen şeklinde sırala demek

select count(*) from Products -- kaç satır var sayısını verir

select count(*) from Products where CategoryID=2 -- CategoryID 2 olanların kaç satır var sayısını verir


--hangi katagoride kaç farklı ürünümüz var =
select categoryID, count(*) from products group by categoryID

--ürün sayısı 10 dan az olan kategorileri listele =
select categoryID, count(*) from products group by categoryID having count(*)<10

--birim fiyatı 20 den fazla olup ürün sayısı 10 dan az olan kategorileri listele =
select categoryID, count(*) from products where unitprice>20
group by categoryID having count(*)<10

--tabloları birleştirerek veri getirme (inner join)=
select products.ProductID, products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID= Categories.CategoryID
where products.UnitPrice>10  -- unitprice 10 dan büyük olanları getirir



--DTO Data Transformation object
 -- tablo adında boşluk olduğu için köşeli parantez içinde yazılıyor
 select * from products p inner join [Order Details] od 
 on p.ProductID= od.ProductID
 
 select * from products p left join [Order Details] od 
 on p.ProductID= od.ProductID

 select * from customers c inner join Orders o 
 on c.customerID= o.customerID 

 select * from customers c left join Orders o 
 on c.customerID= o.customerID 

 select * from customers c left join Orders o 
 on c.customerID= o.customerID
 where o.CustomerID is null -- null demek olmayan data demek, PK (primery key) ya uygulanır

