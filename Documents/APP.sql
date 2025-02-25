USE [master]
GO
/****** Object:  Database [ToDoDB]    Script Date: 16.12.2018 18:35:39 ******/
CREATE DATABASE [ToDoDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ToDoDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ToDoDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ToDoDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ToDoDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ToDoDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ToDoDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ToDoDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ToDoDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ToDoDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ToDoDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ToDoDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ToDoDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ToDoDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ToDoDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ToDoDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ToDoDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ToDoDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ToDoDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ToDoDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ToDoDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ToDoDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ToDoDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ToDoDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ToDoDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ToDoDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ToDoDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ToDoDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ToDoDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ToDoDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ToDoDB] SET  MULTI_USER 
GO
ALTER DATABASE [ToDoDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ToDoDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ToDoDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ToDoDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ToDoDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ToDoDB] SET QUERY_STORE = OFF
GO
USE [ToDoDB]
GO
/****** Object:  Table [dbo].[Labels]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Labels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Colour] [nvarchar](50) NULL,
 CONSTRAINT [PK_Labels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabelsTasks]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabelsTasks](
	[Id] [nchar](10) NULL,
	[LabelID] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tags]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tags](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tag] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tags] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TagsTasks]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TagsTasks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TagID] [int] NULL,
	[TaskID] [int] NULL,
 CONSTRAINT [PK_TagsTasks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskDetails]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Aciklama] [nvarchar](50) NULL,
	[Checked] [bit] NULL,
 CONSTRAINT [PK_TaskDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Roles]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Role] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tbl_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Tasks]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Tasks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[task] [nvarchar](50) NOT NULL,
	[date] [datetime] NOT NULL,
	[userID] [int] NULL,
	[labelID] [int] NULL,
	[detailID] [int] NULL,
 CONSTRAINT [PK_Tbl_Tasks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Tur]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Tur](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[turAd] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl_Tur] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Users]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](50) NOT NULL,
	[userPass] [nchar](14) NOT NULL,
	[userEmail] [nvarchar](50) NOT NULL,
	[onlined] [bit] NULL,
 CONSTRAINT [PK__Tbl_User__3214EC07B797CE12] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TurTask]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TurTask](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TurID] [int] NULL,
	[TaskID] [int] NULL,
 CONSTRAINT [PK_TurTask] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersRoles]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersRoles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[RoleID] [int] NULL,
 CONSTRAINT [PK_UsersRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserStatus]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[StatusID] [int] NULL,
 CONSTRAINT [PK_UserStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Tbl_Users]    Script Date: 16.12.2018 18:35:39 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Tbl_Users] ON [dbo].[Tbl_Users]
(
	[userEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Tbl_Users_2]    Script Date: 16.12.2018 18:35:39 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Tbl_Users_2] ON [dbo].[Tbl_Users]
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TagsTasks]  WITH CHECK ADD  CONSTRAINT [FK_TagsTasks_Tags] FOREIGN KEY([TagID])
REFERENCES [dbo].[Tags] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TagsTasks] CHECK CONSTRAINT [FK_TagsTasks_Tags]
GO
ALTER TABLE [dbo].[TagsTasks]  WITH CHECK ADD  CONSTRAINT [FK_TagsTasks_Tbl_Tasks] FOREIGN KEY([TaskID])
REFERENCES [dbo].[Tbl_Tasks] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TagsTasks] CHECK CONSTRAINT [FK_TagsTasks_Tbl_Tasks]
GO
ALTER TABLE [dbo].[Tbl_Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Tasks_Labels] FOREIGN KEY([labelID])
REFERENCES [dbo].[Labels] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tbl_Tasks] CHECK CONSTRAINT [FK_Tbl_Tasks_Labels]
GO
ALTER TABLE [dbo].[Tbl_Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Tasks_TaskDetails] FOREIGN KEY([detailID])
REFERENCES [dbo].[TaskDetails] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tbl_Tasks] CHECK CONSTRAINT [FK_Tbl_Tasks_TaskDetails]
GO
ALTER TABLE [dbo].[Tbl_Tasks]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Tasks_Tbl_Users] FOREIGN KEY([userID])
REFERENCES [dbo].[Tbl_Users] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tbl_Tasks] CHECK CONSTRAINT [FK_Tbl_Tasks_Tbl_Users]
GO
ALTER TABLE [dbo].[TurTask]  WITH CHECK ADD  CONSTRAINT [FK_TurTask_Tbl_Tasks] FOREIGN KEY([TaskID])
REFERENCES [dbo].[Tbl_Tasks] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TurTask] CHECK CONSTRAINT [FK_TurTask_Tbl_Tasks]
GO
ALTER TABLE [dbo].[TurTask]  WITH CHECK ADD  CONSTRAINT [FK_TurTask_Tbl_Tur] FOREIGN KEY([TurID])
REFERENCES [dbo].[Tbl_Tur] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TurTask] CHECK CONSTRAINT [FK_TurTask_Tbl_Tur]
GO
ALTER TABLE [dbo].[UsersRoles]  WITH CHECK ADD  CONSTRAINT [FK_UsersRoles_Tbl_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Tbl_Roles] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UsersRoles] CHECK CONSTRAINT [FK_UsersRoles_Tbl_Roles]
GO
ALTER TABLE [dbo].[UsersRoles]  WITH CHECK ADD  CONSTRAINT [FK_UsersRoles_Tbl_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Tbl_Users] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UsersRoles] CHECK CONSTRAINT [FK_UsersRoles_Tbl_Users]
GO
ALTER TABLE [dbo].[UserStatus]  WITH CHECK ADD  CONSTRAINT [FK_UserStatus_Status] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Status] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserStatus] CHECK CONSTRAINT [FK_UserStatus_Status]
GO
ALTER TABLE [dbo].[UserStatus]  WITH CHECK ADD  CONSTRAINT [FK_UserStatus_Tbl_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Tbl_Users] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserStatus] CHECK CONSTRAINT [FK_UserStatus_Tbl_Users]
GO
/****** Object:  StoredProcedure [dbo].[GETALLTASKS]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[GETALLTASKS]
(
@id int
)
AS
Begin 
Select * from Tbl_Tasks where userID = @id
End
GO
/****** Object:  StoredProcedure [dbo].[GETTASKID]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[GETTASKID]
(
@task nvarchar(50)
)
AS
Begin 
Select Id FROM Tbl_Tasks WHERE task = @task
End

GO
/****** Object:  StoredProcedure [dbo].[GETTURID]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[GETTURID]
(
@turAd nvarchar(50)
)
AS
Begin 
Select Id FROM Tbl_Tur WHERE turAd = @turAd
End

GO
/****** Object:  StoredProcedure [dbo].[TURLIST]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[TURLIST]
AS
Begin 
Select * from Tbl_Tur
End
GO
/****** Object:  Trigger [dbo].[ADDTAG]    Script Date: 16.12.2018 18:35:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[ADDTAG]
on [dbo].[Tbl_Tasks] 
for insert
as 
declare @taskID int 
select @taskID=Id from inserted
insert TagsTasks(TagID,TaskID) Values(1,@taskID)
GO
ALTER TABLE [dbo].[Tbl_Tasks] ENABLE TRIGGER [ADDTAG]
GO
/****** Object:  Trigger [dbo].[updateTask]    Script Date: 16.12.2018 18:35:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[updateTask] 
on [dbo].[Tbl_Tasks] 
after Insert
as 
select * from inserted
GO
ALTER TABLE [dbo].[Tbl_Tasks] ENABLE TRIGGER [updateTask]
GO
/****** Object:  Trigger [dbo].[updateroles]    Script Date: 16.12.2018 18:35:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[updateroles]
on [dbo].[Tbl_Users]
for insert
as 
declare @userID int 
select @userID=Id from inserted
insert UsersRoles (UserID,RoleID) Values(@userID,1)
GO
ALTER TABLE [dbo].[Tbl_Users] ENABLE TRIGGER [updateroles]
GO
/****** Object:  Trigger [dbo].[updatestatus]    Script Date: 16.12.2018 18:35:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[updatestatus]
on [dbo].[Tbl_Users]
after update
as 
declare @isonline bit, @userID int 
select @isonline = onlined from inserted
if @isonline = 1
update UserStatus set UserID=@userID,StatusID=1
else 
update UserStatus set UserID=@userID,StatusID=0
GO
ALTER TABLE [dbo].[Tbl_Users] ENABLE TRIGGER [updatestatus]
GO
USE [master]
GO
ALTER DATABASE [ToDoDB] SET  READ_WRITE 
GO
