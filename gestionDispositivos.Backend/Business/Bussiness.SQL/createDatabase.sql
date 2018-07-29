IF  NOT EXISTS (SELECT * FROM sys.databases WHERE name = N'Devices')
    BEGIN
        CREATE DATABASE [Devices];	
    END;
	