USE [SistemaUcheta]
GO
/****** Object:  Table [dbo].[Events]    Script Date: 04.06.2022 3:49:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Events](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[TypeId] [int] NULL,
	[SoldTicketsCount] [int] NULL,
	[GainTicketsCount] [int] NULL,
	[Cost] [int] NULL,
	[Date] [nvarchar](50) NOT NULL,
	[Time] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[Eduacation] [nvarchar](50) NULL,
	[Profession] [nvarchar](50) NULL,
	[VenueId] [int] NULL,
	[Couch] [nvarchar](50) NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventType]    Script Date: 04.06.2022 3:49:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_EventType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 04.06.2022 3:49:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Login] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[Eduacation] [nvarchar](50) NULL,
	[Profession] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venue]    Script Date: 04.06.2022 3:49:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venue](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VenueTypeId] [int] NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Venue] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VenueType]    Script Date: 04.06.2022 3:49:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VenueType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
 CONSTRAINT [PK_VenueType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Events] ON 

INSERT [dbo].[Events] ([Id], [Name], [TypeId], [SoldTicketsCount], [GainTicketsCount], [Cost], [Date], [Time], [Age], [Eduacation], [Profession], [VenueId], [Couch]) VALUES (1, N'ТОЛЬКО ДЛЯ ЖЕНЩИН', 2, 157, 542, 500, N'05.06.2022', N'18:00:00', 18, N'-', N'-', 5, N'Мишустина')
INSERT [dbo].[Events] ([Id], [Name], [TypeId], [SoldTicketsCount], [GainTicketsCount], [Cost], [Date], [Time], [Age], [Eduacation], [Profession], [VenueId], [Couch]) VALUES (2, N'КОНСТАНТИН РАЙКИН', 5, 699, 1, 1000, N'26.06.2022', N'19:00:00', 16, N'-', N'-', 1, N'Лапкина')
SET IDENTITY_INSERT [dbo].[Events] OFF
GO
SET IDENTITY_INSERT [dbo].[EventType] ON 

INSERT [dbo].[EventType] ([Id], [Name]) VALUES (1, N'Кинофильм')
INSERT [dbo].[EventType] ([Id], [Name]) VALUES (2, N'Спектакль')
INSERT [dbo].[EventType] ([Id], [Name]) VALUES (3, N'Выставка')
INSERT [dbo].[EventType] ([Id], [Name]) VALUES (4, N'Экскурсия')
INSERT [dbo].[EventType] ([Id], [Name]) VALUES (5, N'Моноспектакль')
SET IDENTITY_INSERT [dbo].[EventType] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Login], [Password], [Age], [Eduacation], [Profession]) VALUES (1, N'Павел Кононов', N'1', N'1', 18, N'СРЕДНЕЕ ПРОФЕССИОНАЛЬНОЕ', N'Программист')
INSERT [dbo].[Users] ([Id], [Name], [Login], [Password], [Age], [Eduacation], [Profession]) VALUES (2, N'Мария Жмышенко', N'2', N'2', 1755, N'СРЕДНЕЕ ОБЩЕЕ', N'Школьник')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Venue] ON 

INSERT [dbo].[Venue] ([Id], [VenueTypeId], [Name]) VALUES (1, 5, N'ДВОРЕЦ ТВОРЧЕСТВА И СПОРТА')
INSERT [dbo].[Venue] ([Id], [VenueTypeId], [Name]) VALUES (2, 1, N'ТЮМЕНСКИЙ БОЛЬШОЙ ДРАМАТИЧЕСКИЙ ТЕАТР')
INSERT [dbo].[Venue] ([Id], [VenueTypeId], [Name]) VALUES (3, 2, N'Краеведческий музей "Городская Дума"')
INSERT [dbo].[Venue] ([Id], [VenueTypeId], [Name]) VALUES (4, 3, N'ТЮМЕНСКИЙ ГОСУДАРСТВЕННЫЙ ЦИРК')
INSERT [dbo].[Venue] ([Id], [VenueTypeId], [Name]) VALUES (5, 4, N'КИНОМАКС')
SET IDENTITY_INSERT [dbo].[Venue] OFF
GO
SET IDENTITY_INSERT [dbo].[VenueType] ON 

INSERT [dbo].[VenueType] ([Id], [Name], [Type]) VALUES (1, N'Театр', N'ТЮМЕНСКИЙ БОЛЬШОЙ ДРАМАТИЧЕСКИЙ ТЕАТР')
INSERT [dbo].[VenueType] ([Id], [Name], [Type]) VALUES (2, N'Музей', N'Краеведческий музей "Городская Дума"')
INSERT [dbo].[VenueType] ([Id], [Name], [Type]) VALUES (3, N'Цирк', N'ТЮМЕНСКИЙ ГОСУДАРСТВЕННЫЙ ЦИРК')
INSERT [dbo].[VenueType] ([Id], [Name], [Type]) VALUES (4, N'Кинотеатр', N'КИНОМАКС')
INSERT [dbo].[VenueType] ([Id], [Name], [Type]) VALUES (5, N'Дворец культуры', N'ДВОРЕЦ ТВОРЧЕСТВА И СПОРТА')
SET IDENTITY_INSERT [dbo].[VenueType] OFF
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_EventType] FOREIGN KEY([TypeId])
REFERENCES [dbo].[EventType] ([Id])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_EventType]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Venue] FOREIGN KEY([VenueId])
REFERENCES [dbo].[Venue] ([Id])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Venue]
GO
ALTER TABLE [dbo].[Venue]  WITH CHECK ADD  CONSTRAINT [FK_Venue_VenueType] FOREIGN KEY([VenueTypeId])
REFERENCES [dbo].[VenueType] ([Id])
GO
ALTER TABLE [dbo].[Venue] CHECK CONSTRAINT [FK_Venue_VenueType]
GO
