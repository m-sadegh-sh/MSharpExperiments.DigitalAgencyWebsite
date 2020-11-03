ALTER TABLE Security.PasswordResetTickets ADD Constraint
                [FK_PasswordResetTicket.User]
                FOREIGN KEY ([User])
                REFERENCES Security.Users (ID)
                ON DELETE NO ACTION;
GO