-- Yeni bir db oluştur

create database CarRentalDB;

-- kullanılacak db'ye geçiş yap
use CarRentalDB;


Create Table Brands (
   Id INT PRIMARY KEY IDENTITY(1,1),
   Name VARCHAR(50) NOT NULL
);


Create Table Models (
   Id INT PRIMARY KEY IDENTITY(1,1),
   Name VARCHAR(50) NOT NULL,
   BrandId INT FOREIGN KEY REFERENCES Brands(Id)
);

Create Table Transmissions (
   Id INT PRIMARY KEY IDENTITY(1,1),
   Name VARCHAR(50) NOT NULL
);

Create Table Fuels (
   Id INT PRIMARY KEY IDENTITY(1,1),
   Name VARCHAR(50) NOT NULL
);

Create Table Colors (
   Id INT PRIMARY KEY IDENTITY(1,1),
   Name VARCHAR(50) NOT NULL
);


Create Table ModelTransmissions (
   Id INT PRIMARY KEY IDENTITY(1,1),
   ModelId INT FOREIGN KEY REFERENCES Models(Id),
   TransmissionId INT FOREIGN KEY REFERENCES Transmissions(Id),
);

Create Table ModelFuels (
   Id INT PRIMARY KEY IDENTITY(1,1),
   ModelId INT FOREIGN KEY REFERENCES Models(Id),
   FuelId INT FOREIGN KEY REFERENCES Fuels(Id),
);


Create Table Cars (
   Id INT PRIMARY KEY IDENTITY(1,1),
   Plate VARCHAR(50) NOT NULL,
   Kilometer INT NOT NULL,
   ModelYear INT Not NULL,
   ColorId INT FOREIGN KEY REFERENCES Colors(Id),
   ModelId INT FOREIGN KEY REFERENCES Models(Id),
);


-- Brands Tablosu

Insert Into Brands (Name) Values ('Toyota'),('Honda'),('BMW'),('Mercedes'),('Ford'),('Audi'),('Hyundai'),('Nissan'),
('Peugeot'),('Volswagen');


INSERT INTO Models (Name, BrandId) VALUES 
('Corolla', 1), ('Civic', 2), ('320i', 3), ('C200', 4), ('Focus', 5),
('A4', 6), ('i30', 7), ('Qashqai', 8), ('208', 9), ('Golf', 10);


INSERT INTO Transmissions (Name) VALUES ('Manual'), ('Automatic'), ('CVT'), ('Semi-Automatic'), 
('Dual-Clutch'), ('Tiptronic'), ('Electric'), ('Hybrid'), ('7-Speed'), ('8-Speed');

INSERT INTO Fuels (Name) VALUES ('Gasoline'), ('Diesel'), ('Electric'), ('Hybrid'), ('LPG'), 
('Hydrogen'), ('Ethanol'), ('CNG'), ('Bio-Diesel'), ('Methanol');

INSERT INTO Colors (Name) VALUES ('Red'), ('Blue'), ('Black'), ('White'), ('Grey'), 
('Silver'), ('Green'), ('Yellow'), ('Orange'), ('Purple');


INSERT INTO ModelTransmissions (ModelId, TransmissionId) VALUES 
(1,1), (2,2), (3,3), (4,4), (5,5), (6,6), (7,7), (8,8), (9,9), (10,10);

INSERT INTO ModelFuels (ModelId, FuelId) VALUES 
(1,1), (2,2), (3,3), (4,4), (5,5), (6,6), (7,7), (8,8), (9,9), (10,10);

INSERT INTO Cars (Plate, Kilometer, ModelYear, ColorId, ModelId) VALUES 
('34ABC123', 50000, 2020, 1, 1),
('06DEF456', 60000, 2019, 2, 2),
('35GHI789', 70000, 2021, 3, 3),
('16JKL012', 80000, 2018, 4, 4),
('07MNO345', 90000, 2022, 5, 5),
('44PQR678', 40000, 2023, 6, 6),
('22STU901', 55000, 2020, 7, 7),
('09VWX234', 30000, 2019, 8, 8),
('01YZA567', 20000, 2021, 9, 9),
('45BCD890', 10000, 2022, 10, 10);





-- Select (Veri çekme)

Select * From Cars;  -- Tüm arabaları getir

Select Name From Brands; -- Sadece marka isimlerini getir

--Where 

Select * from Cars Where ModelYear>2020; -- 2020 sonrası üretilen arabaları getir

-- OrderBy artan veya azalan sırada sıralamak için kullnılır.

Select * From Cars Order By Kilometer ASC; -- Ascending kilometeresi düşük arabaları en önce getir
Select * From Cars Order By Kilometer DESC; -- Descending En yeni arabaları listele


-- GROUP BY
--İstatistiksel verileri elde etmek için

--COUNT,SUM,AVG,MIN,MAX gibi fonksiyonları kullanır.

Select ModelYear,Count(*) as "Araba sayısı" From Cars Group By ModelYear; -- Model yılına göre araba sayısı getir

--DISTINCT - Benzersiz Değerleri getirme
SElect Distinct ModelYear From Cars;


Select Count(*) From Cars; -- Toplam araba sayısı
Select SUM(Kilometer) From Cars; -- Arabaların toplam kilometresi
Select AVG(Kilometer) From Cars; -- Arabaların ortalama kilometresi


--JOIN ilişkili tablolardaki verileri birleştirmek için
--INNER JOIN => iki tabloda eşleşen verileri döndürür.
--LEFT JOIN,RIGHT JOIN,FULL JOIN => ödev konusu 

Select c.Plate,m.Name,b.Name From Cars as c
Inner join Models as m ON c.ModelId=m.Id
Inner join Brands as b On m.BrandId=b.Id;


-- Arabaları markası,modeli,rengi ve yakıt türü ile birlikte listele

Select c.Plate,b.Name,m.Name,cl.Name,f.Name from Cars as c
Inner join Models as m on c.ModelId = m.Id
Inner join Brands as b on m.BrandId=b.Id
Inner join Colors as cl on c.ColorId=cl.Id
Inner join ModelFuels as mf on m.Id=mf.ModelId
Inner join Fuels as f on mf.FuelId=f.Id


--Model bazında en yüksek kilometreye sahip arabaları bul

Select m.Name, Max(c.Kilometer) as MaxKilometer from Cars as c
Inner join Models as m on c.ModelId = m.Id
Group By m.Name


--Subquery

Select * from Cars Where ModelYear = (Select Max(ModelYear) From Cars); -- en yeni arabalrı getir


--HAVING group by ile oluşurulan gruplar üzerinde filtreleme yapar

--where yalnızca satırlara uygulanırken, Having gruplara uygulanır

--En az 1 modeli olan markaları getir
 Select b.Name,Count(m.Id) as "Model Sayısı" From Brands  as b
 Inner Join Models as m On b.Id=m.BrandId
 Group By b.Name
 HAving Count(m.Id)>=1;


 -- Farklı vites türlerini destekleyen modelleri ve kaç farklı vites tipi desteklediklerini göster
 -- en az 1 farklı vites türü olanları getir

 Select m.Name,count(Distinct mt.TransmissionId) as VitesSayısı  from Models as m
 Inner Join ModelTransmissions as mt On m.Id = mt.ModelId
 Group By m.Name
 Having count(Distinct mt.TransmissionId)>=1

 --Model Yılı 2018 ve sonrası olan modellerde, en az 1 araba bulunanları getir

 Select m.Name,Count(c.Id) as ArabaSayısı from Cars as c 
 Inner join Models as m On c.ModelId=m.Id
 Where c.ModelYear>=2018
 Group By m.Name
 Having Count(c.Id)>=1;
