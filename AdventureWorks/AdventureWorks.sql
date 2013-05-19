USE AdventureWorks
GO
--����������ROW_NUMBER(),RANK(),DENSE_RANK()
SELECT ProductId, SalesCount,
ROW_NUMBER() OVER(ORDER BY SalesCount desc) rownum,
RANK() OVER(ORDER BY SalesCount desc) rank,
DENSE_RANK() OVER(ORDER BY SalesCount desc) dense_rank
FROM 
(
select ProductID,COUNT(*) as SalesCount from Sales.SalesOrderDetail
group by ProductID
) as q
order by SalesCount desc

--OVER�����
SELECT SalesOrderID,OrderDate,
ROW_NUMBER() OVER(PARTITION BY Year(OrderDate),Month(OrderDate) ORDER BY OrderDate) rownum
FROM SALES.SalesOrderHeader
WHERE SalesPersonID=280
ORDER BY OrderDate

--����������NTILE()
select ProductID,SalesCount,
NTILE(100) OVER(ORDER BY SalesCount) as Percenttitle from
(
	select ProductID,COUNT(*) as SalesCount from Sales.SalesOrderDetail
	group by ProductID
) as q
order by SalesCount;

--OVER��ۺϺ���
SELECT ProductID,Product,SubCat,SalesCount,
NTILE(100) OVER(ORDER BY SalesCount) as Percenttile,
CAST(CAST(SalesCount AS NUMERIC(9,2))/
SUM(SalesCount) OVER(Partition By SubCat)*100 AS NUMERIC(9,2)) as PercOfSubcat
 FROM
(
SELECT P.ProductID,P.Name AS Product,PSC.Name AS SubCat,COUNT(*) as SalesCount 
FROM Sales.SalesOrderDetail AS SOD 
JOIN Production.Product AS P ON SOD.ProductID=P.ProductID
JOIN Production.ProductSubcategory PSC ON P.ProductSubcategoryID=PSC.ProductSubcategoryID
GROUP BY PSC.Name,P.Name,P.ProductID
) AS Q
ORDER BY SubCat DESC