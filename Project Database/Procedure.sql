ALTER PROCEDURE calculateOrders (
@canOrderDone INT OUTPUT
) AS
BEGIN
	-- Сколько и каких пирогов в каждом заказе.
	CREATE TABLE #countPiesNeedDone
	(idOrder int, idPie int, numberPie int)
	INSERT INTO #countPiesNeedDone (idOrder, idPie, numberPie)
	SELECT 
	idOrder as IdOrder, idPie, numberPie
	FROM
	partOfOrder
	WHERE EXISTS(SELECT orderStatus FROM orderPie 
				WHERE orderStatus = 'принят' and orderPie.idOrder = partOfOrder.idOrder)
			
	-- Сколько и каких ингредиентов в каждом заказе.
	CREATE TABLE #countIngredientsForOrder (idOrder int, idIngr int, massI float)
	INSERT INTO #countIngredientsForOrder (idOrder, idIngr, massI)
	SELECT 
	idOrder, idIngr, sum(numberPie * massI)
	FROM
	#countPiesNeedDone, partOfPie
	WHERE #countPiesNeedDone.idPie = partOfPie.idPie
	GROUP BY idOrder, idIngr

	-- Дублируем склад.
	CREATE TABLE #tempStorage (idIngr int, ingredient char(20), mass float);
	INSERT INTO #tempStorage (idIngr, ingredient, mass)
	SELECT
	idIngr, ingredient, mass
	FROM
	storage

	-- Идём по заказам и вычитаем из склада количество ингредиентов, которое нужно для заказа.
	DECLARE @i INT = (SELECT MIN(idOrder) FROM #countIngredientsForOrder);
	DECLARE @result INT = 0;
	WHILE @i <= (SELECT MAX(idOrder) FROM #countIngredientsForOrder)
	BEGIN
		UPDATE #tempStorage
		SET mass -= 
		COALESCE((SELECT massI FROM #countIngredientsForOrder 
						WHERE #countIngredientsForOrder.idIngr =  #tempStorage.idIngr and idOrder = @i), 0)

		if (not EXISTS(SELECT idOrder FROM #countIngredientsForOrder WHERE idOrder = @i))
		begin
			SET @i = @i + 1
			continue
		end
		else if ((SELECT min(mass) FROM #tempStorage) < 0)
		begin
			UPDATE #tempStorage
			SET mass +=
			COALESCE((SELECT massI FROM #countIngredientsForOrder 
							WHERE #countIngredientsForOrder.idIngr =  #tempStorage.idIngr and idOrder = @i), 0)
		end
		else
			SET @result = @result + 1;
		SET @i = @i + 1
	END

	SET @canOrderDone = @result
END

DECLARE @count INT
EXEC calculateOrders @count OUTPUT
SELECT @count