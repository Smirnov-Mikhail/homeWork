-- �������
-- 1) ������, �������� ����������� ������, � ������� ���� ����� ���� ������ �������.
SELECT
idOrder
FROM
dbo.partOfOrder
WHERE	numberPie > 2 and idPie = 1 and
		idOrder = (SELECT idOrder FROM dbo.orderPie WHERE
		orderStatus = '��������' and orderPie.idOrder = partOfOrder.idOrder)

-- 2) ��� ������, � ������ ������� ������ ���������� �����.
SELECT
name
FROM pie
WHERE idPie = (SELECT idPie FROM partOfPie WHERE idIngr = 4)

-- 3) ��� ������� ���� ������� ������� ��� �������� � ��������� ����� �� ���� ������� � ����������� �������.
SELECT
	name, 
	(SELECT COALESCE(sum(numberPie) * price
	, 0) FROM partOfOrder WHERE dbo.partOfOrder.idPie = pie.idPie) as profit
FROM
pie

-- �������������
-- ������� ������� ������� ������ �� ��������.
CREATE VIEW countPiesClient AS
SELECT 
name as nameClient, surname as surnameClient,
	(SELECT 
	sum(numberPie)
	FROM partOfOrder
	WHERE partOfOrder.idOrder = 
	(SELECT idOrder FROM orderPie WHERE client.idClient = orderPie.idClient 
										and partOfOrder.idOrder = idOrder
										and orderPie.orderStatus = '��������')) as countPies
FROM
client

-- �������������, ������� ������� ��������, � ���� ������� ������� �� ���� ������� ������,
-- ��� ������� ������ ������ �� ���� ��������.
CREATE VIEW importantClient AS
SELECT 
nameClient, surnameClient, countPies
FROM
countPiesClient
WHERE countPies >= (SELECT avg(countPies) FROM countPiesClient)
