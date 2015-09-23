-- Таблица, показывающая сколько и каких пирогов нам нужно сделать.
CREATE VIEW countPiesNeedDone AS
SELECT 
	idPie as idPie, name as name,
	(SELECT 
		sum(numberPie)
	FROM partOfOrder
	WHERE partOfOrder.idPie = pie.idPie and
	partOfOrder.idOrder =
	(SELECT idOrder FROM dbo.orderPie 
	WHERE dbo.orderPie.idOrder = dbo.partOfOrder.idOrder and dbo.orderPie.orderStatus = 'принят')) as countPies
FROM
pie

-- Таблица, показывающая сколько и каких ингредиентов нам нужно.
CREATE VIEW countIngredients AS
SELECT
	idIngr as idIngredient,
	(
		(SELECT sum(countPies) FROM countPiesNeedDone 
		WHERE idPie IN (SELECT idPie FROM partOfPie WHERE partOfPie.idIngr = storage.idIngr))
		* (SELECT min(massI) FROM partOfPie WHERE partOfPie.idIngr = storage.idIngr)
	) as massIngredient
FROM
storage

-- Функция, считающая остатки продуктов и определяющая,
-- какое количество продуктов надо заказать, чтобы выполнить все заказы.
ALTER FUNCTION checkStorage()
RETURNS @productsList TABLE (idIngr int, ingredient text, mass float) AS
BEGIN
	-- Таблица, полученная объединением таблицы с нужными нам ингредиентами
	-- для приготовления пирогов и таблицы с имеющимися ингредиентами.
	DECLARE @joinStorageAndIngr table(idIngr int, ingredient char(20), mass float, idIngredient int, massIngredient float);
	INSERT INTO @joinStorageAndIngr(idIngr, ingredient, mass, idIngredient, massIngredient)
	SELECT idIngr, ingredient, mass, idIngredient, massIngredient
	FROM storage
	INNER JOIN
	countIngredients on storage.idIngr = countIngredients.idIngredient
	
	INSERT INTO @productsList (idIngr, ingredient , mass)
	SELECT	
	idIngr, ingredient, -(mass - massIngredient)	
	FROM @joinStorageAndIngr
	WHERE (mass - massIngredient) < 0
RETURN
END

-- Вызов функции.
SELECT * FROM checkStorage ()