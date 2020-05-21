USE [PersonalFinance]
GO

INSERT INTO [dbo].[tblUsers]
           ([FirstName]
           ,[LastName]
           ,[EmailAddress]
           ,[Password]
           ,[Date])
     VALUES
           (<FirstName, nvarchar(50),>
           ,<LastName, nvarchar(50),>
           ,<EmailAddress, nvarchar(max),>
           ,<Password, nvarchar(50),>
           ,<Date, date,>)
GO


Update tblFinance
Set EmailAddress = (Select EmailAddress From tblUsers where tblFinance.EmailAddress = tblUsers.EmailAddress);
END

