USE [ProjetGestion]
GO

/****** Object:  Table [dbo].[HP]    Script Date: 22/11/2018 10:47:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HP](
	[hp_id] [int] IDENTITY(1,1) NOT NULL,
	[hp_date] [date] NOT NULL,
	[hp_tj] [float] NOT NULL,
	[hp_codeU] [varchar](5) NOT NULL,
	[hp_codeP] [varchar](5) NULL,
 CONSTRAINT [PK_HP] PRIMARY KEY CLUSTERED 
(
	[hp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[HP]  WITH CHECK ADD  CONSTRAINT [FK_HP_Projet] FOREIGN KEY([hp_codeP])
REFERENCES [dbo].[Projet] ([p_code])
GO

ALTER TABLE [dbo].[HP] CHECK CONSTRAINT [FK_HP_Projet]
GO

ALTER TABLE [dbo].[HP]  WITH CHECK ADD  CONSTRAINT [FK_HP_Utilisateur] FOREIGN KEY([hp_codeU])
REFERENCES [dbo].[Utilisateur] ([u_code])
GO

ALTER TABLE [dbo].[HP] CHECK CONSTRAINT [FK_HP_Utilisateur]
GO


