-- �������
-- �����
CREATE TABLE pie (
idPie int PRIMARY KEY,
name char(20) NOT NULL,
price money NOT NULL
);

INSERT INTO pie (idPie, name, price)
VALUES (1, '� �����', $10), (2, '� �������� � �����', $8), (3, '� ��������', $5), 
(4, '� �������', $20),(5, '� ���������', $10), (6, '������ � �������', $50);

-- ������ ������
CREATE TABLE partOfPie (
idPartOfPie int PRIMARY KEY,
idPie int FOREIGN KEY REFERENCES pie(idPie),
idIngr int FOREIGN KEY REFERENCES storage(idIngr) NOT NULL,
massI float NOT NULL
);

INSERT INTO partOfPie (idPartOfPie, idPie, idIngr, massI)
VALUES 
(1, 1, 5, 0.8), (2, 1, 6, 0.2), (3, 1, 7, 0.2), (4, 1, 1, 0.6), (5, 1, 3, 0.2),
(6, 2, 5, 0.8), (7, 2, 6, 0.2), (8, 2, 7, 0.2), (9, 2, 10, 0.6), (10, 2, 11, 0.2), 
(11, 3, 5, 0.8), (12, 3, 6, 0.2), (13, 3, 7, 0.2), (14, 3, 12, 0.6), (15, 3, 3, 0.2), 
(16, 4, 5, 0.8), (17, 4, 6, 0.2), (18, 4, 7, 0.2), (19, 4, 8, 0.6), (20, 4, 9, 0.2), 
(21, 5, 5, 0.8), (22, 4, 6, 0.2), (23, 4, 7, 0.2), (24, 4, 2, 0.6), (25, 4, 3, 0.2), 
(26, 6, 5, 0.8), (27, 6, 6, 0.2), (28, 6, 7, 0.2), (29, 6, 4, 0.6), (30, 6, 13, 0.2);

-- ������
CREATE TABLE client(
idClient int PRIMARY KEY,
name char(20) NOT NULL,
surname char(20) NOT NULL,
spentMoney money default NULL,
discount float NOT NULL
);

INSERT INTO client(idClient, name, surname, discount)
VALUES (1, 'ϸ��', '�������', 1), (2, '������', '�������', 1), (3, '�����', '�������', 1);

-- ������
CREATE TABLE orderPie (
idOrder int PRIMARY KEY,
orderTime datetime NOT NULL,
idClient int FOREIGN KEY REFERENCES client(idClient) NOT NULL,
orderStatus char(12) NOT NULL CHECK (orderStatus IN ('������', '� ���������', '��������', '��������'))
);

INSERT INTO orderPie (idOrder, orderTime, idClient, orderStatus)
VALUES (1, '2007-05-08 12:35:29', 1, '��������'), 
(2, '2008-05-08 12:35:29', 1, '��������'),
(3, '2009-05-08 12:35:29', 3, '��������'),
(4, '2010-05-08 12:35:29', 2, '��������'),
(5, '2010-05-08 12:35:29', 1, '��������'),
(6, '2011-05-08 12:35:29', 2, '������'),
(7, '2012-05-08 12:35:29', 3, '������'),
(8, '2013-05-08 12:35:29', 3, '������');

-- ������ ������
CREATE TABLE partOfOrder (
idPartOfPie int PRIMARY KEY,
idOrder int FOREIGN KEY REFERENCES orderPie(idOrder),
idPie int NOT NULL,
numberPie int NOT NULL
);

INSERT INTO partOfOrder (idPartOfPie, idOrder, idPie, numberPie)
VALUES (1, 1, 1, 3), (2, 2, 1, 2), (3, 3, 1, 5), (4, 4, 6, 3), (5, 5, 3, 2), (6, 6, 6, 4), (7, 7, 4, 4),
(8, 7, 5, 2), (9, 8, 1, 2);

-- �����
CREATE TABLE storage (
idIngr int PRIMARY KEY,
ingredient char(20) NOT NULL,
mass float NOT NULL
);

INSERT INTO storage (idIngr, ingredient, mass)
VALUES (1, '����', 10), (2, '��������', 10), (3, '���', 10), (4, '����', 1), (5, '����', 100), (6, '����', 100),
(7, '�����', 100), (8, '��������', 1), (9, '������', 1), (10, '�������', 0), (11, '���', 0), (12, '�������', 0)
, (13, '�����', 0);

-- ����������
CREATE TABLE providers (
idProv int PRIMARY KEY,
name char(20) NOT NULL,
address char(30) NOT NULL,
telephonNumber char(10) NOT NULL,
idIngr int FOREIGN KEY REFERENCES storage(idIngr),
massIngr float,
priceIngr money
);