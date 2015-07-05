-- Create database structure
CREATE DATABASE TablePerTypeDemo;
GO
USE TablePerTypeDemo;
GO

CREATE TABLE Base ( 
	ID INTEGER IDENTITY NOT NULL,
	Name NVARCHAR(20),

	CONSTRAINT PK_BASE PRIMARY KEY (ID)
);
GO

CREATE TABLE Derivate (
	DerivateID INTEGER NOT NULL,
	Description NVARCHAR(30),

	CONSTRAINT PK_DERIVATE PRIMARY KEY (DerivateID),
	CONSTRAINT FK_BASE FOREIGN KEY (DerivateID) REFERENCES Base(ID)
);


-- add dummy data
INSERT INTO Base(Name) 
VALUES ('first'), ('second'), ('third');

INSERT INTO Derivate(DerivateID, Description)
SELECT ID, Name 
FROM Base;

-- visualize data
SELECT * FROM Base B JOIN Derivate D ON B.ID = D.DerivateID