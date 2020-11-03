ALTER TABLE Security.Administrators ADD CONSTRAINT 
[FK_Administrator.Id->User] FOREIGN KEY (Id) 
REFERENCES Security.Users (ID)
 ON DELETE CASCADE;


GO