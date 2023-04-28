--sql code for init git
--CREATE DATABASE SalonDeTheDB;
use SalonDeTheDB;

-- Création de la table Serveurs
CREATE TABLE Serveurs (
    IdServeur INT PRIMARY KEY IDENTITY(1,1),
    Nom NVARCHAR(50) NOT NULL,
    Prenom NVARCHAR(50) NOT NULL
);

-- Création de la table Boissons
CREATE TABLE Boissons (
    IdBoisson INT PRIMARY KEY IDENTITY(1,1),
    Designation NVARCHAR(100) NOT NULL,
    Prix DECIMAL(10,2) NOT NULL,
    QteStock INT NOT NULL
);

-- Création de la table Commandes
CREATE TABLE Commandes (
    IdCommande INT PRIMARY KEY IDENTITY(1,1),
    DateCom DATE NOT NULL,
    HeureCom TIME NOT NULL,
    IdServeur INT NOT NULL FOREIGN KEY REFERENCES Serveurs(IdServeur)
);

-- Création de la table BoissonsCommandees
CREATE TABLE BoissonsCommandees (
    IdBoisson INT NOT NULL FOREIGN KEY REFERENCES Boissons(IdBoisson),
    IdCommande INT NOT NULL FOREIGN KEY REFERENCES Commandes(IdCommande),
    QuantiteCommandee INT NOT NULL,
    PRIMARY KEY (IdBoisson, IdCommande)
);

-- Données de préchargement pour la table Serveurs
INSERT INTO Serveurs (Nom, Prenom)
VALUES ('Dupont', 'Pierre'),
       ('Martin', 'Sophie'),
       ('Leroy', 'Lucas');

-- Données de préchargement pour la table Boissons
INSERT INTO Boissons (Designation, Prix, QteStock)
VALUES ('Thé vert', 2.50, 100),
       ('Thé noir', 2.50, 100),
       ('Café', 2.00, 150),
       ('Chocolat chaud', 3.00, 50);

-- Données de préchargement pour la table Commandes
INSERT INTO Commandes (DateCom, HeureCom, IdServeur)
VALUES ('2023-04-28', '09:30:00', 1),
       ('2023-04-28', '10:15:00', 2),
       ('2023-04-28', '11:00:00', 3);

-- Données de préchargement pour la table BoissonsCommandees
INSERT INTO BoissonsCommandees (IdBoisson, IdCommande, QuantiteCommandee)
VALUES (1, 1, 2),
       (2, 1, 1),
       (3, 2, 3),
       (4, 3, 1),
       (1, 3, 1);
