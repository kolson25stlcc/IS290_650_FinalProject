Alter table [dbo].[Artist_Song_Collection]
Add CONSTRAINT FK_Artist_Song_Collection_Artist_ID
	FOREIGN KEY (Artist_ID)
	REFERENCES [dbo].[Artist] (Artist_ID)
	ON DELETE CASCADE
	ON UPDATE CASCADE
 GO