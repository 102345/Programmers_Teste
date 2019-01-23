USE [ProgrammersTeste]
GO

INSERT INTO [dbo].[Price]
           ([idEvent]
           ,[audience]
           ,[value])
     VALUES
           (1
           ,30
           ,40000.000)
GO
INSERT INTO [dbo].[Price]
           ([idEvent]
           ,[audience]
           ,[value])
     VALUES
           (2
           ,20
           ,30000.000)
GO

select * from price

--delete from price
