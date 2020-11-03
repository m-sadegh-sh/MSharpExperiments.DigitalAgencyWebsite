-- LogonFailures Table ========================
IF NOT EXISTS(SELECT * FROM sys.schemas WHERE name = 'Security')
BEGIN
EXEC('CREATE SCHEMA Security')
END

CREATE TABLE Security.LogonFailures (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Email nvarchar(200)  NOT NULL,
    IP nvarchar(200)  NOT NULL,
    Attempts int  NOT NULL,
    [Date] datetime2  NOT NULL
);

