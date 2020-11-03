-- Features Table ========================
IF NOT EXISTS(SELECT * FROM sys.schemas WHERE name = 'Cms')
BEGIN
EXEC('CREATE SCHEMA Cms')
END

CREATE TABLE Cms.Features (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Title nvarchar(200)  NOT NULL,
    Description nvarchar(2000)  NOT NULL
);

