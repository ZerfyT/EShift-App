CREATE TABLE Customers (
    CustomerID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Address VARCHAR(255) NOT NULL,
    PhoneNumber VARCHAR(20) UNIQUE NOT NULL,
    Email VARCHAR(100) UNIQUE,
    RegistrationDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Drivers (
    DriverID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    LicenseNumber VARCHAR(50) UNIQUE NOT NULL,
    PhoneNumber VARCHAR(20) UNIQUE NOT NULL,
    HireDate DATE
);

CREATE TABLE Assistants (
    AssistantID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    PhoneNumber VARCHAR(20) UNIQUE NOT NULL,
    HireDate DATE
);

CREATE TABLE Lorries (
    LorryID INT AUTO_INCREMENT PRIMARY KEY,
    RegistrationNumber VARCHAR(20) UNIQUE NOT NULL,
    Model VARCHAR(50),
    Capacity DECIMAL(10, 2) COMMENT 'Capacity in cubic meters or kilograms'
);

CREATE TABLE Containers (
    ContainerID INT AUTO_INCREMENT PRIMARY KEY,
    ContainerNumber VARCHAR(50) UNIQUE NOT NULL,
    Capacity DECIMAL(10, 2) COMMENT 'Capacity in cubic meters',
    Status ENUM('Available', 'In Use', 'Maintenance') DEFAULT 'Available'
);

CREATE TABLE TransportUnits (
    TransportUnitID INT AUTO_INCREMENT PRIMARY KEY,
    LorryID INT,
    DriverID INT,
    AssistantID INT,
    FOREIGN KEY (LorryID) REFERENCES Lorries(LorryID),
    FOREIGN KEY (DriverID) REFERENCES Drivers(DriverID),
    FOREIGN KEY (AssistantID) REFERENCES Assistants(AssistantID)
);

CREATE TABLE Jobs (
    JobID INT AUTO_INCREMENT PRIMARY KEY,
    JobNumber VARCHAR(50) UNIQUE NOT NULL,
    CustomerID INT,
    StartLocation VARCHAR(255) NOT NULL,
    Destination VARCHAR(255) NOT NULL,
    JobDate DATE NOT NULL,
    Status ENUM('Pending', 'In Progress', 'Completed', 'Cancelled') DEFAULT 'Pending',
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE Loads (
    LoadID INT AUTO_INCREMENT PRIMARY KEY,
    LoadNumber VARCHAR(50) UNIQUE NOT NULL,
    JobID INT,
    ContainerID INT,
    TransportUnitID INT,
    Description TEXT,
    Weight DECIMAL(10, 2) COMMENT 'Weight in kilograms',
    Volume DECIMAL(10, 2) COMMENT 'Volume in cubic meters',
    PickupDateTime TIMESTAMP NULL,
    DeliveryDateTime TIMESTAMP NULL,
    FOREIGN KEY (JobID) REFERENCES Jobs(JobID),
    FOREIGN KEY (ContainerID) REFERENCES Containers(ContainerID),
    FOREIGN KEY (TransportUnitID) REFERENCES TransportUnits(TransportUnitID)
);


INSERT INTO Customers (FirstName, LastName, Address, PhoneNumber, Email, RegistrationDate) VALUES
('Nimal', 'Perera', '123 Galle Road, Colombo 3', '0771234567', 'nimal.p@email.com', '2024-01-15 10:00:00'),
('Sunil', 'Fernando', '45 Kandy Road, Kadawatha', '0717654321', 'sunil.f@email.com', '2024-02-20 11:30:00'),
('Priya', 'Devi', '78 Stanley Road, Jaffna', '0765551212', 'priya.d@email.com', '2024-03-10 09:00:00'),
('Kamal', 'Silva', '22 Beach Road, Matara', '0778889999', 'kamal.s@email.com', '2024-04-05 14:00:00'),
('Fathima', 'Rizwan', '99 Main Street, Kandy', '0712345678', 'fathima.r@email.com', '2024-05-01 16:45:00');

INSERT INTO Drivers (FirstName, LastName, LicenseNumber, PhoneNumber, HireDate) VALUES
('Bandara', 'Kulathunga', 'B1234567', '0772223333', '2022-01-10'),
('Ravi', 'Kumar', 'B7654321', '0714445555', '2022-03-15'),
('Ajith', 'Jayalath', 'B2468135', '0761112222', '2023-05-20'),
('Saman', 'Disanayaka', 'B1357924', '0773334444', '2023-08-01');

INSERT INTO Assistants (FirstName, LastName, PhoneNumber, HireDate) VALUES
('Kasun', 'Sampath', '0719876543', '2022-02-11'),
('Mohamed', 'Iqbal', '0776543210', '2022-04-16'),
('Gayan', 'Madushanka', '0763210987', '2023-06-21'),
('Dinesh', 'Chandimal', '0715556666', '2023-09-02');

INSERT INTO Lorries (RegistrationNumber, Model, Capacity) VALUES
('WP LH-1234', 'Isuzu Elf', 3500.00),
('SP ND-5678', 'Mitsubishi Canter', 4500.00),
('CP LG-9101', 'Tata LPT 407', 4000.00),
('WP LI-1121', 'Fuso Canter', 3500.00);

INSERT INTO Containers (ContainerNumber, Capacity, Status) VALUES
('ESH-C001', 20.0, 'Available'),
('ESH-C002', 20.0, 'Available'),
('ESH-C003', 25.0, 'Available'),
('ESH-C004', 25.0, 'Available'),
('ESH-C005', 20.0, 'Maintenance');

-- TransportUnits table (Combining staff and vehicles)
INSERT INTO TransportUnits (LorryID, DriverID, AssistantID) VALUES
(1, 1, 1), -- Lorry LH-1234 with Bandara and Kasun
(2, 2, 2), -- Lorry ND-5678 with Ravi and Mohamed
(3, 3, 3), -- Lorry LG-9101 with Ajith and Gayan
(4, 4, 4); -- Lorry LI-1121 with Saman and Dinesh

-- Jobs table
INSERT INTO Jobs (JobNumber, CustomerID, StartLocation, Destination, JobDate, Status) VALUES
('ESH-J0001', 1, 'Wellawatte, Colombo 6', 'Unawatuna, Galle', '2025-07-15', 'Pending'),
('ESH-J0002', 2, 'Nugegoda, Colombo', 'Peradeniya, Kandy', '2025-07-18', 'Pending'),
('ESH-J0003', 3, 'Jaffna Town, Jaffna', 'Vavuniya Town, Vavuniya', '2025-07-22', 'Pending'),
('ESH-J0004', 1, 'Dehiwala, Colombo', 'Mount Lavinia, Colombo', '2025-08-01', 'Pending');

-- Loads table
INSERT INTO Loads (LoadNumber, JobID, ContainerID, TransportUnitID, Description, Weight, Volume, PickupDateTime, DeliveryDateTime) VALUES
-- Loads for Job 1 (ESH-J0001)
('ESH-L0001A', 1, 1, 1, 'Living room furniture and kitchen appliances', 800.50, 15.0, NULL, NULL),
('ESH-L0001B', 1, 2, 2, 'Bedroom sets and personal boxes', 650.00, 12.5, NULL, NULL),
-- Load for Job 2 (ESH-J0002)
('ESH-L0002A', 2, 3, 3, 'Full house shifting contents including garden pots', 1500.00, 22.0, NULL, NULL),
-- Load for Job 3 (ESH-J0003)
('ESH-L0003A', 3, 4, 4, 'Office equipment and documents', 950.75, 18.0, NULL, NULL),
-- Load for Job 4 (ESH-J0004)
('ESH-L0004A', 4, 1, 1, 'Studio apartment contents', 500.00, 8.0, NULL, NULL);
