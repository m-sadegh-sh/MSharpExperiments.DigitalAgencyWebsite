-- Testimonies Table ========================
IF NOT EXISTS(SELECT * FROM sys.schemas WHERE name = 'Cms')
BEGIN
EXEC('CREATE SCHEMA Cms')
END

CREATE TABLE Cms.Testimonies (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Name nvarchar(200)  NOT NULL,
    [Position] nvarchar(200)  NOT NULL,
    Content nvarchar(2000)  NOT NULL,
    Image_FileName nvarchar(1500)  NULL,
    DisplayOrder int  NULL
);

