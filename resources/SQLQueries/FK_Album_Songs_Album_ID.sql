Alter table [dbo].[Album_Songs]
Add CONSTRAINT FK_Album_Songs_Album_ID
	FOREIGN KEY (Album_ID)
	REFERENCES [dbo].[Album] (Album_ID)
	ON DELETE CASCADE
	ON UPDATE CASCADE
 GO