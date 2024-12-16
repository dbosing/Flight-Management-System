CREATE DATABASE FlightManagementDB;

USE FlightManagementDB;

-- Create Flights table with FlightCode as NVARCHAR
CREATE TABLE Flights (
    FlightCode NVARCHAR(10) PRIMARY KEY,  -- Changed to NVARCHAR for flight code
    Airline NVARCHAR(100),
    Destination NVARCHAR(100),
    DepartureTime DATETIME,
    SeatsAvailable INT
);

CREATE TABLE Passengers (
    PassengerId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    FlightCode NVARCHAR(10),  -- Changed to match FlightCode in Flights table
    FOREIGN KEY (FlightCode) REFERENCES Flights(FlightCode)
);

-- Insert flights data with airline-specific flight codes
INSERT INTO Flights (FlightCode, Airline, Destination, DepartureTime, SeatsAvailable)
VALUES 
    ('AC101', 'Air Canada', 'Toronto', '2024-12-15 08:30:00', 100),
    ('WS201', 'WestJet', 'Vancouver', '2024-12-15 09:45:00', 120),
    ('DL301', 'Delta', 'New York', '2024-12-15 10:15:00', 90),
    ('UA401', 'United Airlines', 'Chicago', '2024-12-15 11:00:00', 85),
    ('AS501', 'Alaska Airlines', 'Seattle', '2024-12-15 12:30:00', 95),
    ('AA601', 'American Airlines', 'Miami', '2024-12-15 14:00:00', 110),
    ('BA701', 'British Airways', 'London', '2024-12-15 16:45:00', 75),
    ('LH801', 'Lufthansa', 'Frankfurt', '2024-12-15 18:00:00', 80),
    ('QF901', 'Qantas', 'Sydney', '2024-12-16 09:00:00', 50),
    ('EK1001', 'Emirates', 'Dubai', '2024-12-16 21:00:00', 60),
    ('AF1101', 'Air France', 'Paris', '2024-12-16 08:30:00', 100),
    ('KLM1201', 'KLM', 'Amsterdam', '2024-12-16 10:00:00', 150),
    ('LH1301', 'Lufthansa', 'Berlin', '2024-12-16 11:15:00', 140),
    ('SQ1401', 'Singapore Airlines', 'Singapore', '2024-12-16 14:30:00', 200),
    ('VA1501', 'Virgin Australia', 'Brisbane', '2024-12-16 16:00:00', 110),
    ('JL1601', 'Japan Airlines', 'Tokyo', '2024-12-17 00:15:00', 85),
    ('CX1701', 'Cathay Pacific', 'Hong Kong', '2024-12-17 08:00:00', 130),
    ('TAM1801', 'LATAM Airlines', 'Sao Paulo', '2024-12-17 09:45:00', 100);

-- Insert passenger data, assigning them to the appropriate FlightCode
INSERT INTO Passengers (Name, FlightCode)
VALUES 
    ('John Doe', 'AC101'),        -- Air Canada - Toronto
    ('Jane Smith', 'WS201'),      -- WestJet - Vancouver
    ('Alice Johnson', 'DL301'),   -- Delta - New York
    ('Bob Brown', 'UA401'),       -- United Airlines - Chicago
    ('Charlie Davis', 'AS501'),   -- Alaska Airlines - Seattle
    ('David Wilson', 'AA601'),    -- American Airlines - Miami
    ('Eva Taylor', 'BA701'),      -- British Airways - London
    ('Frank Harris', 'LH801'),    -- Lufthansa - Frankfurt
    ('Grace White', 'QF901'),     -- Qantas - Sydney
    ('Henry Martin', 'EK1001'),   -- Emirates - Dubai
    ('Isabelle Clark', 'AF1101'), -- Air France - Paris
    ('Jack Green', 'KLM1201'),    -- KLM - Amsterdam
    ('Liam Moore', 'LH1301'),     -- Lufthansa - Berlin
    ('Monica King', 'SQ1401'),    -- Singapore Airlines - Singapore
    ('Nathan Scott', 'VA1501'),   -- Virgin Australia - Brisbane
    ('Olivia Walker', 'JL1601'),  -- Japan Airlines - Tokyo
    ('Paul Lee', 'CX1701'),       -- Cathay Pacific - Hong Kong
    ('Quinn King', 'TAM1801');    -- LATAM Airlines - Sao Paulo

