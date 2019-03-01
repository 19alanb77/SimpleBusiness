CREATE DATABASE projekt;

--USUWANIE WSZYSTKICH CONSTRAINTOW JEDNOCZESNIE 
DECLARE @sql NVARCHAR(MAX) = N'';
SELECT @sql += N'
ALTER TABLE ' + QUOTENAME(OBJECT_SCHEMA_NAME(parent_object_id))
    + '.' + QUOTENAME(OBJECT_NAME(parent_object_id)) + 
    ' DROP CONSTRAINT ' + QUOTENAME(name) + ';'
FROM sys.foreign_keys;
PRINT @sql;
EXEC sp_executesql @sql;

--USUWANIE WSZYSTKICH TABEL JEDNOCZESNIE
DECLARE @sqlt NVARCHAR(max)=''
SELECT @sqlt += ' Drop table ' + QUOTENAME(TABLE_SCHEMA) + '.'+ QUOTENAME(TABLE_NAME) + '; '
FROM   INFORMATION_SCHEMA.TABLES
WHERE  TABLE_TYPE = 'BASE TABLE'
Exec Sp_executesql @sqlt

--TWORZENIE TABEL

CREATE TABLE Logowanie
(
	Login varchar(50) not null primary key,
	Haslo varchar(50) not null
);

CREATE TABLE Produkty
(
    IdProduktu int IDENTITY(1,1) not null primary key,
    NazwaProduktu varchar(50) not null,
	Ilosc float,
	CenaDetaliczna float,
	CenaHurtowa float,
	IdKategoriiProduktow int not null,
	DataWaznosci date
);

CREATE TABLE KategorieProduktow
(
	IdKategoriiProduktow int IDENTITY(1,1) not null primary key,
	NazwaKategorii	varchar(50) not null
);

CREATE TABLE Pracownicy
(
	IdPracownika int IDENTITY(1,1) not null primary key,
	Imie varchar(50) not null,
	Nazwisko varchar(50) not null,
	IdStanowiska int not null,
	PESEL varchar(20),
	RokZatrudnienia varchar(10),
	ZarobkiMiesieczne float,
	Email varchar(50),
	Telefon varchar(20)
);

CREATE TABLE Stanowiska
(
	IdStanowiska int IDENTITY(1,1) not null primary key,
	NazwaStanowiska	varchar(50) not null
);

CREATE TABLE Zadania
(
	IdZadania int IDENTITY(1,1) not null primary key,
	IdPracownika int not null,
	DataWykonania date,
	Tresc varchar(100) 
);

CREATE TABLE Statystyki
(
	IdStatystyki int IDENTITY(1,1) not null primary key,
	Miesiac varchar(50) not null,
	Zysk float not null
);

CREATE TABLE Faktury
(
	IdFaktury int IDENTITY(1,1) not null primary key,
	NumerFaktury varchar(50),
	IdWystawiajacego int not null,
	DataWystawienia date,
	KwotaNetto float not null,
	KwotaVAT float not null,
	KwotaBrutto float not null,
	IdNabywcy int not null,
	Zysk float
);

CREATE  UNIQUE INDEX IXU_NumerFaktury ON Faktury(NumerFaktury)

CREATE TABLE Nabywcy
(
	IdNabywcy int IDENTITY(1,1) not null primary key,
	NazwaNabywcy varchar(50) not null,
	AdresNabywcy varchar(50),
	NumerNIP varchar(50) not null
);

CREATE TABLE SzczegolyFaktur
(
	NumerId int IDENTITY(1,1) not null ,
	NumerFaktury varchar(50) not null primary key,
	NazwaProduktu varchar(50),
	Ilosc float,
	KwotaNetto float,
	KwotaVAT float,
	KwotaBrutto float,
	Zysk float
);

--TWORZENIE RELACJI

ALTER TABLE dbo.Pracownicy
ADD CONSTRAINT FK_IdStanowiska FOREIGN KEY(IdStanowiska)
REFERENCES dbo.Stanowiska (IdStanowiska);

ALTER TABLE dbo.Zadania
ADD CONSTRAINT FK_IdPracownika FOREIGN KEY(IdPracownika)
REFERENCES dbo.Pracownicy (IdPracownika);

ALTER TABLE dbo.Faktury
ADD CONSTRAINT FK_IdWystawiajacego FOREIGN KEY(IdWystawiajacego)
REFERENCES dbo.Pracownicy (IdPracownika);

ALTER TABLE dbo.Faktury
ADD CONSTRAINT FK_IdNabywcy FOREIGN KEY(IdNabywcy)
REFERENCES dbo.Nabywcy (IdNabywcy);

ALTER TABLE dbo.Produkty
ADD CONSTRAINT FK_IdKategoriiProduktow FOREIGN KEY(IdKategoriiProduktow)
REFERENCES dbo.KategorieProduktow (IdKategoriiProduktow);

ALTER TABLE dbo.SzczegolyFaktur
ADD CONSTRAINT FK_NumerFaktury FOREIGN KEY(NumerFaktury)
REFERENCES dbo.Faktury(NumerFaktury);

--PROCEDURY

CREATE PROCEDURE PobierzPracownikow
AS
SELECT IdPracownika, Imie, Nazwisko, Stanowiska.NazwaStanowiska, PESEL, RokZatrudnienia, ZarobkiMiesieczne, Email, Telefon FROM Pracownicy
JOIN Stanowiska
ON Stanowiska.IdStanowiska = Pracownicy.IdStanowiska
GO
--exec PobierzPracownikow;

CREATE PROCEDURE PobierzZadania
AS
SELECT IdZadania, Pracownicy.Imie, Pracownicy.Nazwisko, DataWykonania, Tresc, Pracownicy.Email, Pracownicy.Telefon FROM Zadania
JOIN Pracownicy
ON Pracownicy.IdPracownika = Zadania.IdPracownika
GO
--exec PobierzZadania;

CREATE PROCEDURE PobierzFaktury
AS
SELECT IdFaktury, NumerFaktury, Pracownicy.Imie, Pracownicy.Nazwisko, DataWystawienia, KwotaNetto, KwotaVAT, KwotaBrutto, Zysk, Nabywcy.NazwaNabywcy, Nabywcy.AdresNabywcy, Nabywcy.NumerNIP FROM Faktury
JOIN Pracownicy
ON Pracownicy.IdPracownika = Faktury.IdWystawiajacego
JOIN Nabywcy
ON Nabywcy.IdNabywcy = Faktury.IdNabywcy
GO
--exec PobierzFaktury;

CREATE PROCEDURE PobierzStatystyki
AS
SELECT Miesiac, Zysk FROM Statystyki
GO
--exec PobierzStatystyki;

CREATE PROCEDURE PobierzMiesiac
AS
SELECT Miesiac FROM Statystyki
GO
--exec PobierzMiesiac;

CREATE PROCEDURE PobierzProdukty
AS
SELECT IdProduktu, NazwaProduktu, Ilosc, CenaDetaliczna, CenaHurtowa, KategorieProduktow.NazwaKategorii, DataWaznosci FROM Produkty
JOIN KategorieProduktow
ON KategorieProduktow.IdKategoriiProduktow = Produkty.IdKategoriiProduktow
GO
--exec PobierzProdukty;

CREATE PROCEDURE PobierzKategorieProduktow
AS
SELECT NazwaKategorii FROM KategorieProduktow
GO
--exec PobierzKategorieProduktow;

CREATE PROCEDURE PobierzProduktyWedlugKategorii
@kategoria varchar(50)
AS
SELECT IdProduktu, NazwaProduktu, Ilosc, CenaDetaliczna, CenaHurtowa, KategorieProduktow.NazwaKategorii, DataWaznosci FROM Produkty
JOIN KategorieProduktow
ON KategorieProduktow.IdKategoriiProduktow = Produkty.IdKategoriiProduktow
WHERE KategorieProduktow.NazwaKategorii = @kategoria;
GO
--exec PobierzProduktyWedlugKategorii 'Owoce';

CREATE PROCEDURE PobierzSzczegolyFaktury
AS
SELECT NumerId, NumerFaktury, NazwaProduktu, Ilosc, KwotaNetto, KwotaVAT, KwotaBrutto, Zysk FROM SzczegolyFaktur
GO
--exec PobierzSzczegolyFaktury;

CREATE PROCEDURE DodajPracownika
@imie varchar(50),
@nazwisko varchar(50),
@nazwaStanowiska varchar(50),
@PESEL varchar(20),
@zarobkiMiesieczne float,
@email varchar(50),
@telefon varchar(20)
AS
BEGIN
	DECLARE @sukces INT = 1 ,@niepowodzenie INT = 0

	BEGIN TRAN tran_DodajPracownika

	BEGIN try
		INSERT INTO Pracownicy(Imie, Nazwisko, IdStanowiska, PESEL, RokZatrudnienia,ZarobkiMiesieczne,Email,Telefon)
		VALUES(@imie, @nazwisko, (SELECT IdStanowiska FROM Stanowiska WHERE NazwaStanowiska = @nazwaStanowiska), @PESEL, CAST(DATEPART(yy, GETDATE()) AS varchar(4)), @zarobkiMiesieczne, @email,@telefon);
			COMMIT TRAN tran_DodajPracownika
			SELECT @sukces;
	END try
	BEGIN catch
			ROLLBACK TRAN tran_DodajPracownika
			SELECT @niepowodzenie;
	END catch
END;
GO
--exec DodajPracownika 'Mariusz', 'Kowalski', 'Kasjer', '92031156098', '1900','mariusz.kowalski@gmail.com','+48666645978';

CREATE PROCEDURE DodajZadanie
@nazwaPracownika varchar(50),
@dataWykonania varchar(20),
@tresc varchar(100)
AS
BEGIN
	DECLARE @sukces INT = 1 ,@niepowodzenie INT = 0

	BEGIN TRAN tran_DodajZadanie

	BEGIN try
		INSERT INTO Zadania(IdPracownika, DataWykonania, Tresc)
		VALUES((SELECT IdPracownika FROM Pracownicy WHERE Imie + ' ' + Nazwisko = @nazwaPracownika), CAST(@dataWykonania AS DATE), @tresc);
			COMMIT TRAN tran_DodajZadanie
			SELECT @sukces;
	END try
	BEGIN catch
			ROLLBACK TRAN tran_DodajZadanie
			SELECT @niepowodzenie;
	END catch
END;
GO
--exec DodajZadanie 'Karolina Kubacka', '2018-12-12', 'Odebranie jablek od dostawcy.';

CREATE PROCEDURE DodajProdukt
@nazwaProduktu varchar(50),
@ilosc float,
@cenaDetaliczna float,
@cenaHurtowa float,
@nazwaKategorii varchar(50),
@dataWaznosci varchar(20)
AS
BEGIN
	DECLARE @sukces INT = 1 ,@niepowodzenie INT = 0

	BEGIN TRAN tran_DodajProdukt

	BEGIN try
		INSERT INTO Produkty(NazwaProduktu, Ilosc, CenaDetaliczna, CenaHurtowa, IdKategoriiProduktow, DataWaznosci)
		VALUES(@nazwaProduktu, @ilosc, @cenaDetaliczna, @cenaHurtowa, (SELECT IdKategoriiProduktow FROM KategorieProduktow WHERE NazwaKategorii = @nazwaKategorii),
			   CAST(@dataWaznosci AS DATE));
			COMMIT TRAN tran_DodajProdukt
			SELECT @sukces;
	END try
	BEGIN catch
			ROLLBACK TRAN tran_DodajProdukt
			SELECT @niepowodzenie;
	END catch
END;
GO
--exec DodajProdukt 'Likier','20','29.99','19.99','Alkohol','2019-03-15';

CREATE PROCEDURE DodajFakture
@numerFaktury varchar(50),
@nazwaWystawiajacego varchar(50),
@dataWystawienia varchar(20),
@nazwaNabywcy varchar(50),
@adresNabywcy varchar(50),
@numerNIP varchar(50)
AS
BEGIN
	DECLARE @sukces INT = 1 ,@niepowodzenie INT = 0

	BEGIN TRAN tran_DodajFakture

	BEGIN try
		INSERT INTO Nabywcy(NazwaNabywcy, AdresNabywcy, NumerNIP)
		VALUES(@nazwaNabywcy, @adresNabywcy, @numerNIP);
		INSERT INTO Faktury(NumerFaktury, IdWystawiajacego, DataWystawienia, KwotaNetto, KwotaVAT, KwotaBrutto, IdNabywcy, Zysk)
		VALUES(@numerFaktury, (SELECT IdPracownika FROM Pracownicy WHERE Imie + ' ' + Nazwisko = @nazwaWystawiajacego), CAST(@dataWystawienia AS DATE),
			   (SELECT SUM(KwotaNetto) FROM SzczegolyFaktur WHERE NumerFaktury = @numerFaktury), (SELECT SUM(KwotaVAT) FROM SzczegolyFaktur WHERE NumerFaktury = @numerFaktury),
			   (SELECT SUM(KwotaBrutto) FROM SzczegolyFaktur WHERE NumerFaktury = @numerFaktury), (SELECT IdNabywcy FROM Nabywcy WHERE NazwaNabywcy = @nazwaNabywcy) ,(SELECT SUM(Zysk) FROM SzczegolyFaktur WHERE NumerFaktury = @numerFaktury));
			COMMIT TRAN tran_DodajFakture
			SELECT @sukces;
	END try
	BEGIN catch
			ROLLBACK TRAN tran_DodajFakture
			SELECT @niepowodzenie;
	END catch
END;
GO
--exec DodajFakture '1/10-2018','Alan Buda','2018-11-11','Politechnika Lodzka','Zeromskiego 116, 90-924 Lodz','7270021895';

CREATE PROCEDURE UsunProdukt
@produkt varchar(50),
@ilosc float
AS
BEGIN
	DECLARE @sukces INT = 1 ,@niepowodzenie INT = 0

	BEGIN TRAN tran_UsunProdukt
	BEGIN try
		IF (SELECT Ilosc FROM Produkty where NazwaProduktu = @produkt) <= @ilosc
			BEGIN
				DELETE FROM Produkty
				WHERE IdProduktu = (select IdProduktu from Produkty where NazwaProduktu = @produkt);
				IF (@@ROWCOUNT > 0)
				BEGIN
				SELECT @sukces;
				END
				ELSE
				BEGIN
				SELECT @niepowodzenie;
				END				
				COMMIT TRAN tran_UsunProdukt
			END
		ELSE
			BEGIN
				UPDATE Produkty
				SET Ilosc = Ilosc - @ilosc
				WHERE NazwaProduktu = @produkt;
				SELECT @sukces;
				COMMIT TRAN tran_UsunProdukt
			END;

	END try
	BEGIN catch
			ROLLBACK TRAN tran_UsunProdukt
			SELECT @niepowodzenie;
	END catch
END;
GO
--exec UsunProdukt 'Wino','2';

CREATE PROCEDURE UsunPracownika
@nazwaPracownika varchar(50)
AS
BEGIN
	DECLARE @sukces INT = 1 ,@niepowodzenie INT = 0

	BEGIN TRAN tran_UsunPracownika
	BEGIN try
			DELETE FROM Pracownicy
			WHERE IdPracownika = (select IdPracownika from Pracownicy where Imie + ' ' + Nazwisko = @nazwaPracownika);
			IF (@@ROWCOUNT > 0)
			BEGIN
			SELECT @sukces;
			END
			ELSE
			BEGIN
			SELECT @niepowodzenie;
			END				
			COMMIT TRAN tran_UsunPracownika
	END try
	BEGIN catch
			ROLLBACK TRAN tran_UsunPracownika
			SELECT @niepowodzenie;
	END catch
END;
GO
--exec UsunPracownika 'Mariusz Kowalski';

CREATE PROCEDURE UsunZadanie
@trescZadania varchar(100)
AS
BEGIN
	DECLARE @sukces INT = 1 ,@niepowodzenie INT = 0

	BEGIN TRAN tran_UsunZadanie
	BEGIN try
			DELETE FROM Zadania
			WHERE IdZadania = (select IdZadania from Zadania where Tresc = @trescZadania);
			IF (@@ROWCOUNT > 0)
			BEGIN
			SELECT @sukces;
			END
			ELSE
			BEGIN
			SELECT @niepowodzenie;
			END				
			COMMIT TRAN tran_UsunZadanie
	END try
	BEGIN catch
			ROLLBACK TRAN tran_UsunZadanie
			SELECT @niepowodzenie;
	END catch
END;
GO
--exec UsunZadanie 'Odebranie jablek od dostawcy.';

CREATE PROCEDURE UsunFakture
@numerFaktury varchar(100)
AS
BEGIN
	DECLARE @sukces INT = 1 ,@niepowodzenie INT = 0

	BEGIN TRAN tran_UsunFakture
	BEGIN try
			DELETE FROM Faktury
			WHERE IdFaktury = (select IdFaktury from Faktury where NumerFaktury = @numerFaktury);
			DELETE FROM SzczegolyFaktur
			WHERE NumerFaktury = @numerFaktury;
			IF (@@ROWCOUNT > 0)
			BEGIN
			SELECT @sukces;
			END
			ELSE
			BEGIN
			SELECT @niepowodzenie;
			END				
			COMMIT TRAN tran_UsunFakture
	END try
	BEGIN catch
			ROLLBACK TRAN tran_UsunFakture
			SELECT @niepowodzenie;
	END catch
END;
GO
--exec UsunFakture '1/10-2018';

CREATE PROCEDURE UsunSzczegolyFaktury
@nazwaProduktu varchar(50),
@numerFaktury varchar(50)
AS
BEGIN
	DECLARE @sukces INT = 1 ,@niepowodzenie INT = 0

	BEGIN TRAN tran_UsunSzczegolyFaktury
	BEGIN try
			UPDATE Faktury SET Faktury.KwotaNetto = Faktury.KwotaNetto - SzczegolyFaktur.KwotaNetto FROM Faktury
			INNER JOIN SzczegolyFaktur ON Faktury.NumerFaktury = SzczegolyFaktur.NumerFaktury
			WHERE SzczegolyFaktur.NazwaProduktu = @nazwaProduktu
			UPDATE Faktury SET Faktury.KwotaVAT = Faktury.KwotaVAT - SzczegolyFaktur.KwotaVAT FROM Faktury
			INNER JOIN SzczegolyFaktur ON Faktury.NumerFaktury = SzczegolyFaktur.NumerFaktury
			WHERE SzczegolyFaktur.NazwaProduktu = @nazwaProduktu
			UPDATE Faktury SET Faktury.KwotaBrutto = Faktury.KwotaBrutto - SzczegolyFaktur.KwotaBrutto FROM Faktury
			INNER JOIN SzczegolyFaktur ON Faktury.NumerFaktury = SzczegolyFaktur.NumerFaktury
			WHERE SzczegolyFaktur.NazwaProduktu = @nazwaProduktu
			UPDATE Faktury SET Faktury.Zysk = Faktury.Zysk - SzczegolyFaktur.Zysk FROM Faktury
			INNER JOIN SzczegolyFaktur ON Faktury.NumerFaktury = SzczegolyFaktur.NumerFaktury
			WHERE SzczegolyFaktur.NazwaProduktu = @nazwaProduktu			
			UPDATE Produkty SET Ilosc = (Ilosc + @ilosc) WHERE NazwaProduktu = @nazwaProduktu 
			DELETE FROM SzczegolyFaktur
			WHERE NazwaProduktu = @nazwaProduktu;
			IF (@@ROWCOUNT > 0)
			BEGIN
			SELECT @sukces;
			END
			ELSE
			BEGIN
			SELECT @niepowodzenie;
			END				
			COMMIT TRAN tran_UsunSzczegolyFaktury
	END try
	BEGIN catch
			ROLLBACK TRAN tran_UsunSzczegolyFaktury
			SELECT @niepowodzenie;
	END catch
END;
GO
--exec UsunSzczegolyFaktury 'Likier','04-2018';


CREATE PROCEDURE DodajDoFaktury
@numerFaktury varchar(50),
@nazwaProduktu varchar(50),
@ilosc float,
@stawkaVAT float
AS
BEGIN
	DECLARE @sukces INT = 1 ,@niepowodzenie INT = 0

	BEGIN TRAN tran_DodajDoFaktury

	BEGIN try
			INSERT INTO SzczegolyFaktur(NumerFaktury,NazwaProduktu,Ilosc,KwotaNetto,KwotaVAT,KwotaBrutto,Zysk) VALUES(@numerFaktury,@nazwaProduktu,@ilosc,
			((SELECT CenaDetaliczna FROM Produkty WHERE NazwaProduktu = @nazwaProduktu) * @ilosc),
			((SELECT CenaDetaliczna FROM Produkty WHERE NazwaProduktu = @nazwaProduktu) * @ilosc) * @stawkaVAT,
			((SELECT CenaDetaliczna FROM Produkty WHERE NazwaProduktu = @nazwaProduktu) * @ilosc) + ((SELECT CenaDetaliczna FROM Produkty WHERE NazwaProduktu = @nazwaProduktu) * @ilosc) * @stawkaVAT,
			((SELECT CenaDetaliczna FROM Produkty WHERE NazwaProduktu = @nazwaProduktu)-(SELECT CenaHurtowa FROM Produkty WHERE NazwaProduktu = @nazwaProduktu)) * @ilosc)
			UPDATE Produkty SET Ilosc = (Ilosc - @ilosc) WHERE NazwaProduktu = @nazwaProduktu
			COMMIT TRAN tran_DodajDoFaktury
			SELECT @sukces;
	END try
	BEGIN catch
			ROLLBACK TRAN tran_DodajDoFaktury
			SELECT @niepowodzenie;
	END catch
END;
GO
--exec DodajDoFaktury '01-2019','Likier','3','0.23';



CREATE FUNCTION DodajNettoDoFaktury(@produkt varchar(50),@ilosc float)
RETURNS float
AS
BEGIN
	DECLARE @Netto float;
	SET @Netto = (SELECT CenaDetaliczna FROM Produkty WHERE NazwaProduktu = @produkt) * @ilosc;	
RETURN @Netto;
END;
GO
-- select [dbo].[DodajNettoDoFaktury]('Banan',5);

CREATE FUNCTION DodajZyskDoFaktury(@produkt varchar(50),@ilosc float)
RETURNS float
AS
BEGIN
	DECLARE @Zysk float;
	SET @Zysk = ((SELECT CenaDetaliczna FROM Produkty WHERE NazwaProduktu = @produkt)-(SELECT CenaHurtowa FROM Produkty WHERE NazwaProduktu = @produkt)) * @ilosc;
RETURN @Zysk;
END;
GO
-- select [dbo].[DodajZyskDoFaktury]('Banan',5);

CREATE FUNCTION SprawdzHaslo(@haslo varchar(50))
RETURNS int
AS
BEGIN
	RETURN ( CASE
				WHEN (SELECT Haslo FROM Logowanie WHERE Login = 'Administrator') = (SELECT CONVERT(VARCHAR(50), HashBytes('MD5', @haslo), 2)) THEN 1
				ELSE 0
			END
		);
END;
GO
-- select [dbo].[SprawdzHaslo]('1234');

CREATE PROCEDURE ZnajdzDzien
@miesiac varchar(50)
AS
BEGIN
 select CAST(DAY(DataWystawienia)AS varchar(50)) as Dzien,KwotaBrutto from faktury where MONTH(DataWystawienia)=@miesiac;
END;
GO
--exec ZnajdzDzien '10';

CREATE PROCEDURE ZmienHaslo
@stareHaslo varchar(50),
@noweHaslo varchar(50),
@powtorzHaslo varchar(50)
AS
BEGIN
	DECLARE @sukces INT = 1 ,@niepowodzenie INT = 0

	BEGIN TRAN tran_ZmienHaslo

	BEGIN try
		IF (SELECT Haslo FROM Logowanie WHERE Login = 'Administrator') = (SELECT CONVERT(VARCHAR(50), HashBytes('MD5',@stareHaslo), 2))
		BEGIN
			IF(@noweHaslo = @powtorzHaslo)
			BEGIN
					UPDATE Logowanie
					SET Haslo = (SELECT CONVERT(VARCHAR(50), HashBytes('MD5',@noweHaslo), 2)) WHERE Login = 'Administrator';
					COMMIT TRAN tran_ZmienHaslo
					SELECT @sukces;
			END;
		END;
	END try
	BEGIN catch
			ROLLBACK TRAN tran_ZmienHaslo
			SELECT @niepowodzenie;
	END catch
END;
GO
--exec ZmienHaslo '1234','1235','1235';

CREATE PROCEDURE KrotkaWaznosc
AS
SELECT IdProduktu, NazwaProduktu, Ilosc, CenaDetaliczna, CenaHurtowa, KategorieProduktow.NazwaKategorii, DataWaznosci FROM Produkty
JOIN KategorieProduktow
ON KategorieProduktow.IdKategoriiProduktow = Produkty.IdKategoriiProduktow
WHERE (DATEDIFF(day, GETDATE(),DataWaznosci) < 6) AND KategorieProduktow.NazwaKategorii NOT IN('Pieczywo','Owoce','Warzywa');
GO
--exec KrotkaWaznosc;

CREATE PROCEDURE NajwiekszyZarobek
AS
SELECT TOP (3) WITH TIES IdProduktu, NazwaProduktu, Ilosc, CenaDetaliczna, CenaHurtowa, KategorieProduktow.NazwaKategorii, DataWaznosci FROM Produkty
JOIN KategorieProduktow
ON KategorieProduktow.IdKategoriiProduktow = Produkty.IdKategoriiProduktow
ORDER BY ((CenaDetaliczna - CenaHurtowa) * Ilosc) DESC;
GO
--exec NajwiekszyZarobek;

CREATE PROCEDURE ZwiekszProdukt
@produkt varchar(50),
@ilosc float
AS
BEGIN
	DECLARE @sukces INT = 1 ,@niepowodzenie INT = 0

	BEGIN TRAN tran_ZwiekszProdukt
	BEGIN try
			UPDATE Produkty
			SET Ilosc = Ilosc + @ilosc WHERE IdProduktu = (select IdProduktu from Produkty where NazwaProduktu = @produkt);
			SELECT @sukces;		
			COMMIT TRAN tran_ZwiekszProdukt
	END try
	BEGIN catch
			ROLLBACK TRAN tran_ZwiekszProdukt
			SELECT @niepowodzenie;
	END catch
END;
GO
--exec ZwiekszProdukt 'Wino','3';

CREATE FUNCTION ObliczPrzychod(@miesiac int)
RETURNS float
AS
BEGIN
	DECLARE @Przychod float;
	SET @Przychod = (SELECT SUM(KwotaBrutto) FROM Faktury WHERE (MONTH(DataWystawienia) = @miesiac));	
RETURN @Przychod;
END;
GO
-- select [dbo].[ObliczPrzychod](11);

CREATE FUNCTION ObliczWydatki()
RETURNS float
AS
BEGIN
	DECLARE @Wydatki float;
	SET @Wydatki = 1200 + (SELECT SUM(ZarobkiMiesieczne) FROM Pracownicy);	
RETURN @Wydatki;
END;
GO
-- select [dbo].[ObliczWydatki]();

CREATE FUNCTION ObliczDochodBrutto(@przychod float, @wydatki float)
RETURNS float
AS
BEGIN
	DECLARE @Brutto float;
	SET @Brutto = @przychod - @wydatki;	
RETURN @Brutto;
END;
GO
-- select [dbo].[ObliczDochodBrutto](20,15);

CREATE FUNCTION ObliczDochodNetto(@brutto float)
RETURNS float
AS
BEGIN
	DECLARE @Netto float;
	SET @Netto = @brutto - (0.18 * @brutto);	
RETURN @Netto;
END;
GO
-- select [dbo].[ObliczDochodNetto](25);

CREATE PROCEDURE DodajStatystyki
@miesiac varchar(50),
@zysk float
AS
BEGIN
	DECLARE @sukces INT = 1 ,@niepowodzenie INT = 0

	BEGIN TRAN tran_DodajStatystyki

	BEGIN try

	IF((select count(*) from Statystyki where Miesiac = @miesiac) = 1)
	BEGIN
		UPDATE Statystyki
		SET Zysk = @zysk WHERE Miesiac = @miesiac;
	END
	ELSE
	BEGIN
		INSERT INTO Statystyki(Miesiac, Zysk)
		VALUES(@miesiac, @zysk);
	END
		COMMIT TRAN tran_DodajStatystyki
		SELECT @sukces;
	END try
	BEGIN catch
			ROLLBACK TRAN tran_DodajStatystyki
			SELECT @niepowodzenie;
	END catch
END;
GO
--exec DodajStatystyki 'Październik', '6888';

--WIDOKI

CREATE VIEW PracownicyView
AS
SELECT Imie,Nazwisko FROM Pracownicy;
GO

CREATE VIEW ProduktyView
AS
SELECT NazwaProduktu FROM Produkty;
GO

CREATE VIEW StanowiskaView
AS
SELECT NazwaStanowiska FROM Stanowiska;
GO

CREATE VIEW FakturaView
AS
SELECT IdFaktury, NumerFaktury, Pracownicy.Imie, Pracownicy.Nazwisko, DataWystawienia, KwotaNetto, KwotaVAT, KwotaBrutto FROM Faktury
JOIN Pracownicy
ON Pracownicy.IdPracownika = Faktury.IdWystawiajacego
GO

--INSERTY

INSERT INTO Logowanie (Login,Haslo) VALUES
('Administrator','1234' );

INSERT INTO KategorieProduktow(NazwaKategorii ) VALUES
('Pieczywo'), ('Owoce'), ('Warzywa'), ('Nabial'), ('Wedliny'), ('Makarony'), ('Slodycze'), ('Srodki czystosci'), ('Napoje'), ('Alkohol');

INSERT INTO Produkty(NazwaProduktu,Ilosc,CenaDetaliczna,CenaHurtowa,IdKategoriiProduktow,DataWaznosci ) VALUES
('Bulka kajzerka',450,0.29,0.09,1,'2018-10-25'), ('Chleb podluzny',150,2.59,1.89,1,'2018-10-25'), ('Jablko',150,1.39,0.89,2,'2018-10-25'),
('Banan',100,4.49,3.49,2,'2018-10-25'), ('Marchew',200,3.49,2.99,3,'2018-10-25'), ('Ziemniaki',500,1.69,1.09,3,'2018-10-25'),
('Ser zolty',200,17.29,15.89,4,'2018-10-25'), ('Ser twarogowy',200,11.09,9.79,4,'2018-10-25'), ('Szynka sopocka',180,40.19,35.29,5,'2018-10-25'),
('Salami',150,31.19,29.89,5,'2018-10-25'), ('Makaron swiderki',125,2.99,2.09,6,'2018-11-25'), ('Makaron spaghetti',125,3.39,2.29,6,'2018-11-25'),
('Chipsy',100,5.39,3.49,7,'2018-10-25'), ('Czekolada',145,3.59,1.99,7,'2018-10-25'), ('Plyn do szyb',60,13.39,10.89,8,'2019-10-25'),
('Spray do mebli',50,9.99,6.69,8,'2019-10-25'), ('Sok jablkowy',140,3.59,2.49,9,'2018-12-25'), ('Oranzada',220,4.39,2.89,9,'2018-12-25'),
('Piwo',150,3.39,2.69,10,'2018-12-25'), ('Wino',150,45.39,25.89,10,'2018-12-25');

INSERT INTO Stanowiska(NazwaStanowiska) VALUES
('Kierownik'), ('Kasjer'), ('Asystent');

INSERT INTO Pracownicy(Imie,Nazwisko,IdStanowiska,PESEL,RokZatrudnienia,ZarobkiMiesieczne) VALUES
('Alan','Buda',1,'95070700095','2016','4800','19alanb77@gmail.com','+48732483780'),('Mateusz','Zych',2,'98062467589','2017','2200','mateusz.zych@gmail.com','+48789456366'),
('Karolina','Kubacka',2,'84120645391','2017','2200','karolina.kubacka@gmail.com','+48684704854'), ('Piotr','Nowacki',3,'96110787854','2018','1800','piotr.nowacki@gmail.com','+48734835844');

--USUWANIE

DROP DATABASE projekt;