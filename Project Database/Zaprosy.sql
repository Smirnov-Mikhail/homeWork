-- ЗАПРОСЫ
-- 1) Запрос, выдающий выполненные заказы, в которых было более двух мясных пирогов.
SELECT
idOrder
FROM
dbo.partOfOrder
WHERE	numberPie > 2 and idPie = 1 and
		idOrder = (SELECT idOrder FROM dbo.orderPie WHERE
		orderStatus = 'выполнен' and orderPie.idOrder = partOfOrder.idOrder)

-- 2) Все пироги, в состав которых входит ингредиент “тмин”.
SELECT
name
FROM pie
WHERE idPie = (SELECT idPie FROM partOfPie WHERE idIngr = 4)

-- 3) Для каждого вида пирогов выведит его название и суммарный доход от этих пирогов в выполненных заказах.
SELECT
	name, 
	(SELECT COALESCE(sum(numberPie) * price
	, 0) FROM partOfOrder WHERE dbo.partOfOrder.idPie = pie.idPie) as profit
FROM
pie

-- ПРЕДСТАВЛЕНИЕ
-- Сколько пирогов заказал каждый из клиентов.
CREATE VIEW countPiesClient AS
SELECT 
name as nameClient, surname as surnameClient,
	(SELECT 
	sum(numberPie)
	FROM partOfOrder
	WHERE partOfOrder.idOrder = 
	(SELECT idOrder FROM orderPie WHERE client.idClient = orderPie.idClient 
										and partOfOrder.idOrder = idOrder
										and orderPie.orderStatus = 'выполнен')) as countPies
FROM
client

-- Представление, которое выводит клиентов, в чьих заказах никогда не было пирогов меньше,
-- чем средний размер заказа по всем клиентам.
CREATE VIEW importantClient AS
SELECT 
nameClient, surnameClient, countPies
FROM
countPiesClient
WHERE countPies >= (SELECT avg(countPies) FROM countPiesClient)
