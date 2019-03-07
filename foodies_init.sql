use foodies

--DROP TABLE Comment
--DROP TABLE Post
--DROP TABLE DaPrUser

CREATE TABLE DaPrUser (
	UserID int IDENTITY(1,1) NOT NULL primary key,
	UserName Varchar(100) NOT NULL,
	UserEmail Varchar(100) NOT NULL,
	UserBio Varchar(1000)
)
GO

CREATE TABLE Post (
	PostID int IDENTITY(1,1) NOT NULL primary key,
	PostTitle Varchar(100) NOT NULL,
	PostURL Varchar(500) NOT NULL,
	PostImageURL Varchar(500),
	PostText Varchar (3000)
)
GO

CREATE TABLE Comment (
	UserID INT NOT NULL,
	PostID INT NOT NULL,
	TXT Varchar (1000) NOT NULL
)
GO
   
ALTER TABLE Comment     
ADD CONSTRAINT FK_Comment_User_ID FOREIGN KEY (UserID)     
    REFERENCES DaPrUser (UserID)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE      
;    
GO    

ALTER TABLE Comment    
ADD CONSTRAINT FK_Comment_Post_ID FOREIGN KEY (PostID)     
    REFERENCES Post (PostID)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE  
;    
GO      