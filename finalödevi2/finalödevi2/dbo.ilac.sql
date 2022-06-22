USE [eczaneilacstok]
GO

/****** Object: Table [dbo].[ilac] Script Date: 19.06.2022 18:22:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[ilac];


GO
CREATE TABLE [dbo].[ilac] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [ilacad]        NVARCHAR (50) NULL,
    [ilacsirketi]   NVARCHAR (50) NULL,
    [ilacturu]      NVARCHAR (50) NULL,
    [ilackutuadeti] NVARCHAR (50) NULL
);


