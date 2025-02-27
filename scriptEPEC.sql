USE [EPEC]
GO
/****** Object:  Table [dbo].[Contratos]    Script Date: 20/06/2024 13:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contratos](
	[numero] [int] IDENTITY(1,1) NOT NULL,
	[cliente] [varchar](50) NOT NULL,
	[tarifa] [int] NOT NULL,
	[tipo] [char](1) NOT NULL,
	[fechaInicio] [date] NOT NULL,
 CONSTRAINT [PK_Contratos] PRIMARY KEY CLUSTERED 
(
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarifas]    Script Date: 20/06/2024 13:52:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarifas](
	[idTarifa] [int] IDENTITY(1,1) NOT NULL,
	[nombreTarifa] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tarifas] PRIMARY KEY CLUSTERED 
(
	[idTarifa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Contratos] ON 

INSERT [dbo].[Contratos] ([numero], [cliente], [tarifa], [tipo], [fechaInicio]) VALUES (1, N'Juan Perez', 1, N'M', CAST(N'2020-10-10' AS Date))
INSERT [dbo].[Contratos] ([numero], [cliente], [tarifa], [tipo], [fechaInicio]) VALUES (2, N'Renault Argentina SA', 4, N'T', CAST(N'2000-05-05' AS Date))
SET IDENTITY_INSERT [dbo].[Contratos] OFF
GO
SET IDENTITY_INSERT [dbo].[Tarifas] ON 

INSERT [dbo].[Tarifas] ([idTarifa], [nombreTarifa]) VALUES (1, N'Residencial')
INSERT [dbo].[Tarifas] ([idTarifa], [nombreTarifa]) VALUES (2, N'Comercial')
INSERT [dbo].[Tarifas] ([idTarifa], [nombreTarifa]) VALUES (3, N'Social')
INSERT [dbo].[Tarifas] ([idTarifa], [nombreTarifa]) VALUES (4, N'Industrial')
SET IDENTITY_INSERT [dbo].[Tarifas] OFF
GO
