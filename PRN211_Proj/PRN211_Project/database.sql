USE [master]
GO
/****** Object:  Database [HappyQuizz]    Script Date: 11/6/2022 10:04:08 AM ******/
CREATE DATABASE [HappyQuizz]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HappyQuizz', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\HappyQuizz.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HappyQuizz_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\HappyQuizz_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HappyQuizz] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HappyQuizz].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HappyQuizz] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HappyQuizz] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HappyQuizz] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HappyQuizz] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HappyQuizz] SET ARITHABORT OFF 
GO
ALTER DATABASE [HappyQuizz] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HappyQuizz] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HappyQuizz] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HappyQuizz] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HappyQuizz] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HappyQuizz] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HappyQuizz] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HappyQuizz] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HappyQuizz] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HappyQuizz] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HappyQuizz] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HappyQuizz] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HappyQuizz] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HappyQuizz] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HappyQuizz] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HappyQuizz] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HappyQuizz] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HappyQuizz] SET RECOVERY FULL 
GO
ALTER DATABASE [HappyQuizz] SET  MULTI_USER 
GO
ALTER DATABASE [HappyQuizz] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HappyQuizz] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HappyQuizz] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HappyQuizz] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HappyQuizz] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HappyQuizz] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HappyQuizz', N'ON'
GO
ALTER DATABASE [HappyQuizz] SET QUERY_STORE = OFF
GO
USE [HappyQuizz]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/6/2022 10:04:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](200) NOT NULL,
	[Password] [varchar](200) NOT NULL,
	[Role] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 11/6/2022 10:04:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answer](
	[AnswerId] [int] IDENTITY(1,1) NOT NULL,
	[Text] [varchar](200) NOT NULL,
	[IsCorrect] [bit] NULL,
	[QuestionId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AnswerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 11/6/2022 10:04:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[QuestionId] [int] IDENTITY(1,1) NOT NULL,
	[Text] [varchar](200) NOT NULL,
	[QuizzId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quizz]    Script Date: 11/6/2022 10:04:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quizz](
	[QuizzId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[Author] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[QuizzId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecordQuizz]    Script Date: 11/6/2022 10:04:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecordQuizz](
	[RecordQuizzId] [int] IDENTITY(1,1) NOT NULL,
	[LastTime] [datetime] NULL,
	[Count] [int] NULL,
	[MaxScore] [int] NULL,
	[Status] [bit] NULL,
	[UserId] [int] NULL,
	[QuizzId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[RecordQuizzId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResumeQuestion]    Script Date: 11/6/2022 10:04:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResumeQuestion](
	[ResumeQuestionId] [int] IDENTITY(1,1) NOT NULL,
	[QuestionId] [int] NOT NULL,
	[AnswerId] [int] NOT NULL,
	[RecordQuizzId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ResumeQuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([UserId], [UserName], [Password], [Role]) VALUES (1, N'hadt', N'hadt', 2)
INSERT [dbo].[Account] ([UserId], [UserName], [Password], [Role]) VALUES (2, N'kiendc', N'kiendc', 2)
INSERT [dbo].[Account] ([UserId], [UserName], [Password], [Role]) VALUES (3, N'quanth', N'quanth', 2)
INSERT [dbo].[Account] ([UserId], [UserName], [Password], [Role]) VALUES (4, N'anhpm', N'anhpm', 1)
INSERT [dbo].[Account] ([UserId], [UserName], [Password], [Role]) VALUES (5, N'tungld', N'tungld', 1)
INSERT [dbo].[Account] ([UserId], [UserName], [Password], [Role]) VALUES (6, N'giangqh', N'giangqh', 1)
INSERT [dbo].[Account] ([UserId], [UserName], [Password], [Role]) VALUES (7, N'tuanvm', N'tuanvm', 1)
INSERT [dbo].[Account] ([UserId], [UserName], [Password], [Role]) VALUES (8, N'quangtq', N'quangtq', 1)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Answer] ON 

INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (1, N'human human', 0, 1)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (2, N'susan 0175', 0, 1)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (3, N'correct answer', 1, 1)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (4, N'pick t con yasuo', 0, 1)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (5, N'human human', 0, 2)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (6, N'susan 0175', 0, 2)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (7, N'correct answer', 1, 2)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (8, N'pick t con yasuo', 0, 2)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (9, N'human human', 0, 3)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (10, N'susan 0175', 0, 3)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (11, N'correct answer', 1, 3)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (12, N'pick t con yasuo', 0, 3)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (13, N'human human', 0, 4)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (14, N'susan 0175', 0, 4)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (15, N'correct answer', 1, 4)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (16, N'pick t con yasuo', 0, 4)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (17, N'human human', 0, 5)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (18, N'susan 0175', 0, 5)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (19, N'correct answer', 1, 5)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (20, N'pick t con yasuo', 0, 5)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (21, N'human human', 0, 6)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (22, N'susan 0175', 0, 6)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (23, N'correct answer', 1, 6)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (24, N'pick t con yasuo', 0, 6)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (25, N'human human', 0, 7)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (26, N'susan 0175', 0, 7)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (27, N'correct answer', 1, 7)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (28, N'pick t con yasuo', 0, 7)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (29, N'human human', 0, 8)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (30, N'susan 0175', 0, 8)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (31, N'correct answer', 1, 8)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (32, N'pick t con yasuo', 0, 8)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (33, N'human human', 0, 9)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (34, N'susan 0175', 0, 9)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (35, N'correct answer', 1, 9)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (36, N'pick t con yasuo', 0, 9)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (37, N'human human', 0, 10)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (38, N'susan 0175', 0, 10)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (39, N'correct answer', 1, 10)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (40, N'pick t con yasuo', 0, 10)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (41, N'human human', 0, 11)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (42, N'susan 0175', 0, 11)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (43, N'correct answer', 1, 11)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (44, N'pick t con yasuo', 0, 11)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (45, N'human human', 0, 12)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (46, N'susan 0175', 0, 12)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (47, N'correct answer', 1, 12)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (48, N'pick t con yasuo', 0, 12)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (49, N'human human', 0, 13)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (50, N'susan 0175', 0, 13)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (51, N'correct answer', 1, 13)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (52, N'pick t con yasuo', 0, 13)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (53, N'human human', 0, 14)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (54, N'susan 0175', 0, 14)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (55, N'correct answer', 1, 14)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (56, N'pick t con yasuo', 0, 14)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (57, N'human human', 0, 15)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (58, N'susan 0175', 0, 15)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (59, N'correct answer', 1, 15)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (60, N'pick t con yasuo', 0, 15)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (61, N'human human', 0, 16)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (62, N'susan 0175', 0, 16)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (63, N'correct answer', 1, 16)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (64, N'pick t con yasuo', 0, 16)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (65, N'human human', 0, 17)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (66, N'susan 0175', 0, 17)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (67, N'correct answer', 1, 17)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (68, N'pick t con yasuo', 0, 17)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (69, N'human human', 0, 18)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (70, N'susan 0175', 0, 18)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (71, N'correct answer', 1, 18)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (72, N'pick t con yasuo', 0, 18)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (73, N'human human', 0, 19)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (74, N'susan 0175', 0, 19)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (75, N'correct answer', 1, 19)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (76, N'pick t con yasuo', 0, 19)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (77, N'human human', 0, 20)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (78, N'susan 0175', 0, 20)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (79, N'correct answer', 1, 20)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (80, N'pick t con yasuo', 0, 20)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (81, N'human human', 0, 21)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (82, N'susan 0175', 0, 21)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (83, N'correct answer', 1, 21)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (84, N'pick t con yasuo', 0, 21)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (85, N'human human', 0, 22)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (86, N'susan 0175', 0, 22)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (87, N'correct answer', 1, 22)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (88, N'pick t con yasuo', 0, 22)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (89, N'human human', 0, 23)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (90, N'susan 0175', 0, 23)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (91, N'correct answer', 1, 23)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (92, N'pick t con yasuo', 0, 23)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (93, N'human human', 0, 24)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (94, N'susan 0175', 0, 24)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (95, N'correct answer', 1, 24)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (96, N'pick t con yasuo', 0, 24)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (97, N'human human', 0, 25)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (98, N'susan 0175', 0, 25)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (99, N'correct answer', 1, 25)
GO
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (100, N'pick t con yasuo', 0, 25)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (101, N'human human', 0, 26)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (102, N'susan 0175', 0, 26)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (103, N'correct answer', 1, 26)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (104, N'pick t con yasuo', 0, 26)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (105, N'human human', 0, 27)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (106, N'susan 0175', 0, 27)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (107, N'correct answer', 1, 27)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (108, N'pick t con yasuo', 0, 27)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (109, N'human human', 0, 28)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (110, N'susan 0175', 0, 28)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (111, N'correct answer', 1, 28)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (112, N'pick t con yasuo', 0, 28)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (113, N'human human', 0, 29)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (114, N'susan 0175', 0, 29)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (115, N'correct answer', 1, 29)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (116, N'pick t con yasuo', 0, 29)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (117, N'human human', 0, 30)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (118, N'susan 0175', 0, 30)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (119, N'correct answer', 1, 30)
INSERT [dbo].[Answer] ([AnswerId], [Text], [IsCorrect], [QuestionId]) VALUES (120, N'pick t con yasuo', 0, 30)
SET IDENTITY_INSERT [dbo].[Answer] OFF
GO
SET IDENTITY_INSERT [dbo].[Question] ON 

INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (1, N'What Does the Fox Say?', 1)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (2, N'What Does the Dog Say?', 1)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (3, N'What Does the Cat Say?', 1)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (4, N'What Does the Mouse Say?', 1)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (5, N'What Does the Snake Say?', 1)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (6, N'What Does the Elephant Say?', 1)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (7, N'What Does the Bird Say?', 1)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (8, N'What Does the Pig Say?', 1)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (9, N'What Does the Cow Say?', 1)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (10, N'What Does the Tiger Say?', 1)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (11, N'What Does the Fox Say?', 2)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (12, N'What Does the Dog Say?', 2)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (13, N'What Does the Cat Say?', 2)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (14, N'What Does the Mouse Say?', 2)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (15, N'What Does the Snake Say?', 2)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (16, N'What Does the Elephant Say?', 2)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (17, N'What Does the Bird Say?', 2)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (18, N'What Does the Pig Say?', 2)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (19, N'What Does the Cow Say?', 2)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (20, N'What Does the Tiger Say?', 2)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (21, N'What Does the Fox Say?', 3)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (22, N'What Does the Dog Say?', 3)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (23, N'What Does the Cat Say?', 3)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (24, N'What Does the Mouse Say?', 3)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (25, N'What Does the Snake Say?', 3)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (26, N'What Does the Elephant Say?', 3)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (27, N'What Does the Bird Say?', 3)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (28, N'What Does the Pig Say?', 3)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (29, N'What Does the Cow Say?', 3)
INSERT [dbo].[Question] ([QuestionId], [Text], [QuizzId]) VALUES (30, N'What Does the Tiger Say?', 3)
SET IDENTITY_INSERT [dbo].[Question] OFF
GO
SET IDENTITY_INSERT [dbo].[Quizz] ON 

INSERT [dbo].[Quizz] ([QuizzId], [Title], [Author]) VALUES (1, N'SWT301', 1)
INSERT [dbo].[Quizz] ([QuizzId], [Title], [Author]) VALUES (2, N'PRN211', 2)
INSERT [dbo].[Quizz] ([QuizzId], [Title], [Author]) VALUES (3, N'PRO192', 3)
SET IDENTITY_INSERT [dbo].[Quizz] OFF
GO
ALTER TABLE [dbo].[Answer] ADD  DEFAULT ((0)) FOR [IsCorrect]
GO
ALTER TABLE [dbo].[RecordQuizz] ADD  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([QuestionId])
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD FOREIGN KEY([QuizzId])
REFERENCES [dbo].[Quizz] ([QuizzId])
GO
ALTER TABLE [dbo].[Quizz]  WITH CHECK ADD FOREIGN KEY([Author])
REFERENCES [dbo].[Account] ([UserId])
GO
ALTER TABLE [dbo].[RecordQuizz]  WITH CHECK ADD FOREIGN KEY([QuizzId])
REFERENCES [dbo].[Quizz] ([QuizzId])
GO
ALTER TABLE [dbo].[RecordQuizz]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Account] ([UserId])
GO
ALTER TABLE [dbo].[ResumeQuestion]  WITH CHECK ADD FOREIGN KEY([RecordQuizzId])
REFERENCES [dbo].[RecordQuizz] ([RecordQuizzId])
GO
USE [master]
GO
ALTER DATABASE [HappyQuizz] SET  READ_WRITE 
GO
