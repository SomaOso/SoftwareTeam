USE Library

CREATE TABLE Authors
(
	AuthorID INT IDENTITY (1,1) PRIMARY KEY,
	AuthorName NVARCHAR(50)
);
CREATE TABLE Books
(
	BookID INT IDENTITY(100,1) PRIMARY KEY,
	BookTitle NVARCHAR(50),
	BookDetails NVARCHAR(50),
	AuthorID INT FOREIGN KEY (AuthorID) REFERENCES Authors (AuthorID)
);

INSERT INTO Authors VALUES
('Pola'),
('Islam'),
('Adel'),
('Ahmed'),
('Saif')

INSERT INTO Books (BookTitle,BookDetails,AuthorID) VALUES
('Goat of Football','Sport',1),
('Nazi German','History',2),
('The art of programming','Programming',3),
('Altras Ahlawi','Sport',4),
('Communication skills','Community',5)

SELECT * FROM Authors
SELECT * FROM Books