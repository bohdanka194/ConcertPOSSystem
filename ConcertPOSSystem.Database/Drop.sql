DROP DATABASE ConcertSystemDB;

-- bad approach, you should delete all the objects inside database
-- if u want to drop database like this, u should close all connections to it, everybody will encounter error
-- like this Msg 3702, Level 16, State 3, Line 1
-- Cannot drop database "ConcertSystemDB" because it is currently in use.
