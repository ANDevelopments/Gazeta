USE Repair
GO

CREATE TABLE Register(
UserID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
UserLogin VARCHAR(50) NOT NULL,
UserPassword VARCHAR(50) NOT NULL
);

CREATE TABLE Client(
ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
FullName VARCHAR(50) NOT NULL,
Adress VARCHAR(100),
Telephone VARCHAR(20),
);

CREATE TABLE Serv(
ServiceName VARCHAR(50) PRIMARY KEY NOT NULL,
Price MONEY NOT NULL,
ID INT IDENTITY(1,1) NOT NULL
);

CREATE TABLE Progress(
Progress VARCHAR(20) PRIMARY KEY NOT NULL
);

CREATE TABLE Orders(
ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
ClientID INT NOT NULL,
ServiceName VARCHAR(50) NOT NULL,
Descript VARCHAR(200),
OrderDate DATE NOT NULL DEFAULT GETDATE(),
Execution DATE,
Progress VARCHAR(20) NOT NULL,
FOREIGN KEY(ClientID) REFERENCES Client(ID),
FOREIGN KEY(ServiceName) REFERENCES Serv(ServiceName),
FOREIGN KEY(Progress) REFERENCES Progress(Progress)
);

CREATE TABLE Document(
ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
ClientID INT NOT NULL,
ClientName VARCHAR(50),
OrderID INT NOT NULL,
Total MONEY,
DocumentDate DATE NOT NULL DEFAULT GETDATE(),
FOREIGN KEY(ClientID) REFERENCES Client(ID),
FOREIGN KEY(OrderID) REFERENCES Orders(ID)
);

INSERT INTO Client (FullName, Adress, Telephone)
VALUES
('Иван Иванович Иванов', 'Пролетарская', '+7(951)999-5675'),
('Петр Петрович Петров', 'Колхозная', '+7(951)999-6666'),
('Анастасия Валерьевна', 'Свободы', '+7(351)255-4332'),
('Илья Ильич', 'Коммуны', '+7(666)543-2345');

INSERT INTO Serv (ServiceName, Price)
VALUES
('Проводка под ключ', 50000),
('Санузел под ключ', 60000),
('Натяжной потолок', 30000);

INSERT Progress
VALUES ('В процессе'), ('Выполнено');

INSERT INTO Orders (ClientID, ServiceName, Descript, Execution, Progress)
VALUES
(1, 'Санузел под ключ', 'Санузел 10кв м', '23-04-2023', 'В процессе'),
(2, 'Натяжной потолок', 'Натяжной потолок 20 кв м', '17-03-2023', 'В процессе');

