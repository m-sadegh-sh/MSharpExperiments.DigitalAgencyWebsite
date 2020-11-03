-- Clients Table ========================
IF NOT EXISTS(SELECT * FROM sys.schemas WHERE name = 'Cms')
BEGIN
EXEC('CREATE SCHEMA Cms')
END

CREATE TABLE Cms.Clients (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NOT NULL,
    Image_FileName nvarchar(1500)  NULL
);

