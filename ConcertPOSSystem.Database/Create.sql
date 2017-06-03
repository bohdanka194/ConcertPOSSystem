--CREATE DATABASE ConcertSystemDB;

-- missing statement
-- use ConcertSystemDB;
-- all the tables will be generated in default database


CREATE TABLE [dbo].[Place]
(
    --name should be Id
	[ID]  UNIQUEIDENTIFIER  NOT NULL DEFAULT (newid()),
	[Name] NVARCHAR(50) NOT NULL,
	[City] NVARCHAR(30) NOT NULL,
	[Address] NVARCHAR(40) NOT NULL,
	[CountRow] INT NOT NULL,
	[CountSeatInRow] INT NOT NULL,
	CONSTRAINT PK_tblPlace_ID PRIMARY KEY(ID),
	CONSTRAINT UQ_tblPlace_Name UNIQUE([Name]),
	CONSTRAINT Check_tblPlace_Row CHECK([CountRow]>0),
	CONSTRAINT Check_tblPlace_Seat CHECK([CountSeatInRow]>0)
)
GO

CREATE TABLE [dbo].[User]
(
	[ID]  UNIQUEIDENTIFIER  NOT NULL DEFAULT (newid()),
	[FirstName] NVARCHAR(40) NOT NULL,
	[LastName] NVARCHAR(40) NOT NULL,
	[Login] NVARCHAR(60) NOT NULL ,
	
	CONSTRAINT PK_tblUser_ID PRIMARY KEY(ID),
	CONSTRAINT UQ_tblUser_Login UNIQUE([Login])
)
GO

CREATE TABLE [dbo].[Concert]
(
	[ID]  UNIQUEIDENTIFIER  NOT NULL DEFAULT (newid()),
	[OrganizerID] UNIQUEIDENTIFIER   NOT NULL,
	[PlaceID] UNIQUEIDENTIFIER  NOT NULL,
	[Time] DATETIME NOT NULL,
	CONSTRAINT PK_tblConcert_ID PRIMARY KEY(ID),
	
)

CREATE TABLE [dbo].[Ticket]
(
	[ID]   UNIQUEIDENTIFIER  NOT NULL DEFAULT (newid()),
	[ConcertID] UNIQUEIDENTIFIER NOT NULL,
	[UserID] UNIQUEIDENTIFIER NULL,
	[Price] MONEY NOT NULL,
	[Row] INT NOT NULL,
	[Seat] INT NOT NULL,
	CONSTRAINT PK_tblTicket_ID PRIMARY KEY([ID]),
	CONSTRAINT Check_tblTicket_Row CHECK([Row]>0),
	CONSTRAINT Check_tblTicket_Seat CHECK([Seat]>0),
	CONSTRAINT Check_tblTicket_Price CHECK([Price]>0),
	CONSTRAINT FK_tblTicket_Concert FOREIGN KEY (ConcertID) REFERENCES [Concert](ID),
	CONSTRAINT FK_tblTicket_User FOREIGN KEY (UserID) REFERENCES [User](ID)
)
GO

CREATE TABLE [dbo].[Organizer]
(
	[ID]  UNIQUEIDENTIFIER  NOT NULL DEFAULT (newid()),
	[Login] NVARCHAR(60) NOT NULL,
	[OrganizerName] NVARCHAR(40) NOT NULL,
	
	CONSTRAINT PK_tblOrganizer_ID PRIMARY KEY(ID),
	CONSTRAINT UQ_tblOrganizer_Login UNIQUE([Login])
)
GO

ALTER TABLE [dbo].[Concert]
ADD CONSTRAINT FK_tblConcert_Organizer FOREIGN KEY (OrganizerID) REFERENCES [Organizer](ID),
    CONSTRAINT FK_tblConcert_Place FOREIGN KEY (PlaceID) REFERENCES [Place](ID)
GO
