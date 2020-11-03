-- PasswordResetTickets Table ========================
IF NOT EXISTS(SELECT * FROM sys.schemas WHERE name = 'Security')
BEGIN
EXEC('CREATE SCHEMA Security')
END

CREATE TABLE Security.PasswordResetTickets (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    [User] uniqueidentifier  NOT NULL,
    DateCreated datetime2  NOT NULL,
    IsUsed bit  NOT NULL
);
CREATE INDEX [IX_PasswordResetTickets->User] ON Security.PasswordResetTickets ([User]);

GO

