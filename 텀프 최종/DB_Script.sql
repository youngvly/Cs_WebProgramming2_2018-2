USE [master]
GO
/****** Object:  Database [plan_db]    Script Date: 2018-12-05 오후 6:41:45 ******/
CREATE DATABASE [plan_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'plan_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\plan_db.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'plan_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\plan_db_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [plan_db] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [plan_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [plan_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [plan_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [plan_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [plan_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [plan_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [plan_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [plan_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [plan_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [plan_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [plan_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [plan_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [plan_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [plan_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [plan_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [plan_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [plan_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [plan_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [plan_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [plan_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [plan_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [plan_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [plan_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [plan_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [plan_db] SET  MULTI_USER 
GO
ALTER DATABASE [plan_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [plan_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [plan_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [plan_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [plan_db] SET DELAYED_DURABILITY = DISABLED 
GO
USE [plan_db]
GO
/****** Object:  Table [dbo].[plans]    Script Date: 2018-12-05 오후 6:41:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[plans](
	[subject] [varchar](250) NOT NULL,
	[title] [varchar](250) NOT NULL,
	[contents] [text] NULL,
	[fixed] [int] NOT NULL,
	[userid] [int] NOT NULL,
	[startDate] [datetime] NULL,
	[endDate] [datetime] NULL,
	[planid] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[planid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 2018-12-05 오후 6:41:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[id] [varchar](50) NOT NULL,
	[pass] [varchar](255) NOT NULL,
	[email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[weekPlan]    Script Date: 2018-12-05 오후 6:41:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[weekPlan](
	[dayOfWeek] [varchar](50) NOT NULL,
	[title] [varchar](250) NOT NULL,
	[contents] [varchar](250) NULL,
	[userid] [int] NOT NULL,
	[weekPlanId] [int] IDENTITY(1,1) NOT NULL,
	[startTime] [varchar](250) NULL,
	[endTime] [varchar](250) NULL,
 CONSTRAINT [PK_weekPlan] PRIMARY KEY CLUSTERED 
(
	[weekPlanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[plans]  WITH CHECK ADD  CONSTRAINT [FK_plan_users] FOREIGN KEY([userid])
REFERENCES [dbo].[users] ([userid])
GO
ALTER TABLE [dbo].[plans] CHECK CONSTRAINT [FK_plan_users]
GO
USE [master]
GO
ALTER DATABASE [plan_db] SET  READ_WRITE 
GO
