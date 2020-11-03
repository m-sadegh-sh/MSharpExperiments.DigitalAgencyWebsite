-- Administrators Table ========================
IF NOT EXISTS(SELECT * FROM sys.schemas WHERE name = 'Security')
BEGIN
EXEC('CREATE SCHEMA Security')
END

CREATE TABLE Security.Administrators (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    ImpersonationToken nvarchar(40)  NULL
);

