CREATE TRIGGER checkDiscount ON client
FOR UPDATE AS
BEGIN
	DECLARE @table table(price int);
	INSERT INTO @table(price)
	(SELECT
			numberPie * 
			COALESCE((SELECT price FROM pie WHERE pie.idPie = partOfOrder.idPie), 0)
		FROM
		partOfOrder
		WHERE (SELECT idClient FROM inserted) =
		(SELECT idClient FROM orderPie WHERE
						orderPie.idOrder = partOfOrder.idOrder and orderPie.orderStatus = 'выполнен'))

	UPDATE client
	SET spentMoney = (SELECT sum(price) FROM @table)
		

	UPDATE client
	SET discount = 0.9
	WHERE spentMoney > $100

	UPDATE client
	SET discount = 1.0
	WHERE spentMoney < $100
END

/*SELECT 
			COALESCE((SELECT price FROM pie WHERE pie.idPie = min(partOfOrder.idPie1)) * sum(numberPie1), 0) +
			COALESCE((SELECT price FROM pie WHERE pie.idPie = min(partOfOrder.idPie2)) * sum(numberPie2), 0) +
			COALESCE((SELECT price FROM pie WHERE pie.idPie = min(partOfOrder.idPie3)) * sum(numberPie3), 0) +
			COALESCE((SELECT price FROM pie WHERE pie.idPie = min(partOfOrder.idPie4)) * sum(numberPie4), 0) +
			COALESCE((SELECT price FROM pie WHERE pie.idPie = min(partOfOrder.idPie5)) * sum(numberPie5), 0) +
			COALESCE((SELECT price FROM pie WHERE pie.idPie = min(partOfOrder.idPie6)) * sum(numberPie6), 0)	
		FROM
		partOfOrder
		WHERE (SELECT idClient FROM inserted) = 
		(SELECT min(idClient) FROM orderPie WHERE orderPie.idOrder = partOfOrder.idOrder and orderPie.orderStatus = 'выполнен')) */