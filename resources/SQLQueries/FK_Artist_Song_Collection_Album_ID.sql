Alter table [dbo].[Artist_Song_Collection]
Add CONSTRAINT FK_Artist_Song_Collection_Album_ID
	FOREIGN KEY (Album_ID)
	REFERENCES [dbo].[Album] (Album_ID)
	ON DELETE CASCADE
	ON UPDATE CASCADE
 GO