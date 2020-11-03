-- Slides Table ========================
IF NOT EXISTS(SELECT * FROM sys.schemas WHERE name = 'Cms')
BEGIN
EXEC('CREATE SCHEMA Cms')
END

CREATE TABLE Cms.Slides (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Title nvarchar(200)  NOT NULL,
    Description nvarchar(2000)  NOT NULL,
    Image_FileName nvarchar(1500)  NULL,
    LinkUrl nvarchar(200)  NULL,
    LinkText nvarchar(200)  NULL,
    DisplayOrder int  NULL
);

