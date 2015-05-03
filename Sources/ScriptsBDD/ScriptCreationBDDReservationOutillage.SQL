DROP TABLE IF EXISTS Factures CASCADE;
DROP SEQUENCE IF EXISTS Factures_Id_seq;
DROP TABLE IF EXISTS Marques CASCADE;
DROP TABLE IF EXISTS Materiels CASCADE;
DROP SEQUENCE IF EXISTS Materiels_Id_seq;
DROP TABLE IF EXISTS MaterielsDuPret CASCADE;
DROP TABLE IF EXISTS MoyensPaiement CASCADE;
DROP SEQUENCE IF EXISTS MoyensPaiement_Id_seq;
DROP TABLE IF EXISTS ParametresApplication CASCADE;
DROP TABLE IF EXISTS Personnes CASCADE;
DROP SEQUENCE IF EXISTS Personnes_Id_seq;
DROP TABLE IF EXISTS Prets CASCADE;
DROP SEQUENCE IF EXISTS Prets_Id_seq;

CREATE SEQUENCE Factures_Id_seq INCREMENT 1 START 1;

CREATE TABLE Factures ( 
	Id integer DEFAULT nextval(('Factures_Id_seq'::text)::regclass) NOT NULL,
	IdPret integer NOT NULL,
	EstReglee boolean DEFAULT false NOT NULL,
	DateReglement timestamp,
	MontantEnCentimes integer NOT NULL,
	IdMoyenPaiement integer
);

CREATE TABLE Marques ( 
	Id integer NOT NULL,
	Nom varchar(50) NOT NULL
);

CREATE SEQUENCE Materiels_Id_seq INCREMENT 1 START 1;

CREATE TABLE Materiels ( 
	Id integer DEFAULT nextval(('Materiels_Id_seq'::text)::regclass) NOT NULL,
	NumeroSerie text NOT NULL,
	LibelleAffichage text,
	IdMarque integer,
	Modele text,
	EstFonctionnel boolean DEFAULT true NOT NULL
);

CREATE TABLE MaterielsDuPret ( 
	IdPret integer NOT NULL,
	IdMateriel integer NOT NULL
);

CREATE SEQUENCE MoyensPaiement_Id_seq INCREMENT 1 START 1;

CREATE TABLE MoyensPaiement ( 
	Id integer DEFAULT nextval(('MoyensPaiement_Id_seq'::text)::regclass) NOT NULL,
	Libelle text NOT NULL
);

CREATE TABLE ParametresApplication ( 
	Clef text NOT NULL,
	Valeur text
);

CREATE SEQUENCE Personnes_Id_seq INCREMENT 1 START 1;

CREATE TABLE Personnes ( 
	Id integer DEFAULT nextval(('Personnes_Id_seq'::text)::regclass) NOT NULL,
	Nom text NOT NULL,
	Prenom text NOT NULL,
	AdresseMail text,
	EstMembreCE boolean DEFAULT false NOT NULL
);

CREATE SEQUENCE Prets_Id_seq INCREMENT 1 START 1;

CREATE TABLE Prets ( 
	Id integer DEFAULT nextval(('Prets_Id_seq'::text)::regclass) NOT NULL,
	IdPersonne integer NOT NULL,
	DateEmprunt timestamp NOT NULL,
	DateRetour timestamp
);


ALTER TABLE Factures ADD CONSTRAINT PK_factures 
	PRIMARY KEY (IdPret);


ALTER TABLE Marques ADD CONSTRAINT PK_marques 
	PRIMARY KEY (Nom);


ALTER TABLE Materiels ADD CONSTRAINT PK_materiels 
	PRIMARY KEY (NumeroSerie);


ALTER TABLE MaterielsDuPret ADD CONSTRAINT PK_MaterielsDuPret 
	PRIMARY KEY (IdPret, IdMateriel);


ALTER TABLE MoyensPaiement ADD CONSTRAINT PK_moyens_paiement 
	PRIMARY KEY (Libelle);


ALTER TABLE ParametresApplication ADD CONSTRAINT PK_parametres 
	PRIMARY KEY (Clef);


ALTER TABLE Personnes ADD CONSTRAINT PK_personnes 
	PRIMARY KEY (Nom, Prenom);


ALTER TABLE Prets ADD CONSTRAINT PK_prets 
	PRIMARY KEY (IdPersonne, DateEmprunt);



ALTER TABLE Factures
	ADD CONSTRAINT UQ_Factures_Id UNIQUE (Id);
ALTER TABLE Factures
	ADD CONSTRAINT UQ_Factures_IdPret UNIQUE (IdPret);
ALTER TABLE Marques
	ADD CONSTRAINT UQ_Marques_Id UNIQUE (Id);
ALTER TABLE Marques
	ADD CONSTRAINT UQ_Marques_Nom UNIQUE (Nom);
ALTER TABLE Materiels
	ADD CONSTRAINT UQ_Materiels_Id UNIQUE (Id);
ALTER TABLE Materiels
	ADD CONSTRAINT UQ_Materiels_NumeroSerie UNIQUE (NumeroSerie);
ALTER TABLE MoyensPaiement
	ADD CONSTRAINT UQ_MoyensPaiement_Id UNIQUE (Id);
ALTER TABLE MoyensPaiement
	ADD CONSTRAINT UQ_MoyensPaiement_Libelle UNIQUE (Libelle);
ALTER TABLE ParametresApplication
	ADD CONSTRAINT UQ_ParametresApplication_Clef UNIQUE (Clef);
ALTER TABLE Personnes
	ADD CONSTRAINT UQ_Personnes_Id UNIQUE (Id);
ALTER TABLE Personnes
	ADD CONSTRAINT UQ_Personnes_Nom UNIQUE (Nom);
ALTER TABLE Personnes
	ADD CONSTRAINT UQ_Personnes_Prenom UNIQUE (Prenom);
ALTER TABLE Prets
	ADD CONSTRAINT UQ_Prets_Id UNIQUE (Id);

ALTER TABLE Factures ADD CONSTRAINT FK_factures_prets 
	FOREIGN KEY (IdPret) REFERENCES Prets (Id)
ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE Materiels ADD CONSTRAINT FK_materiels_marques 
	FOREIGN KEY (IdMarque) REFERENCES Marques (Id);

ALTER TABLE MaterielsDuPret ADD CONSTRAINT FK_MaterielsDuPret_Materiels 
	FOREIGN KEY (IdMateriel) REFERENCES Materiels (Id);

ALTER TABLE MaterielsDuPret ADD CONSTRAINT FK_MaterielsDuPret_Prets 
	FOREIGN KEY (IdPret) REFERENCES Prets (Id);

ALTER TABLE Prets ADD CONSTRAINT FK_prets_personnes 
	FOREIGN KEY (IdPersonne) REFERENCES Personnes (Id)
ON DELETE CASCADE ON UPDATE CASCADE;
