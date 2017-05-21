USE ConcertSystemDB;

INSERT INTO [dbo].[Place]([Name],[City],[Address],[CountRow],[CountSeatInRow])
VALUES 
('Malevich','Lviv','Chornovola 9', 10,17),
('Circus', 'Lviv','Gorodotska 140',16,42)

INSERT INTO [dbo].[User]([FirstName],[LastName],[Login])
VALUES 
('Bohdana', 'Arterchuk','bohdanka194'),
('Andrew', 'Pavlyuk', 'andew123')

INSERT INTO [dbo].[Organizer]([Login],[OrganizerName])
VALUES 
('gastrolilviv','gastroli.ua'),
('gastrolikharkiv','gastroli.kh.ua'),
('karabaskyiv','karabas.com')

INSERT INTO [dbo].[Concert]([OrganizerID],[PlaceID],[Time])
VALUES 
('78F1523A-0607-42E5-A250-B4220097B610','224CD71E-825E-4B36-BAB3-C5607570F640','2018-10-15')

INSERT INTO [dbo].[Ticket]([ConcertID],[Price],[Row],[Seat])
VALUES 
('4F8F4269-22FA-437D-A50C-2414A5160F03', 100, 2,1 ),
('4F8F4269-22FA-437D-A50C-2414A5160F03', 120, 3,1 ),
('4F8F4269-22FA-437D-A50C-2414A5160F03', 120, 3,2 ),
('4F8F4269-22FA-437D-A50C-2414A5160F03', 120, 3,3 ),
('4F8F4269-22FA-437D-A50C-2414A5160F03', 120, 3,4 ),
('4F8F4269-22FA-437D-A50C-2414A5160F03', 150, 1,1)