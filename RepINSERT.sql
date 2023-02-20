USE Repair
GO

ALTER TABLE Client
ALTER COLUMN Telephone VARCHAR(20);

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

 
