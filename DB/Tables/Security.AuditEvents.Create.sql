-- AuditEvents Table ========================
IF NOT EXISTS(SELECT * FROM sys.schemas WHERE name = 'Security')
BEGIN
EXEC('CREATE SCHEMA Security')
END

CREATE TABLE Security.AuditEvents (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    UserId nvarchar(200)  NULL,
    [Date] datetime2  NOT NULL,
    Event nvarchar(200)  NOT NULL,
    ItemType nvarchar(200)  NULL,
    ItemId nvarchar(500)  NULL,
    ItemData nvarchar(MAX)  NULL,
    UserIp nvarchar(200)  NULL
);

