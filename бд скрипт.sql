USE [master]
GO
/****** Object:  Database [VKR01]    Script Date: 26.05.2022 17:07:05 ******/
CREATE DATABASE [VKR01]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VKR01', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MYSERVER\MSSQL\DATA\VKR01.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VKR01_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MYSERVER\MSSQL\DATA\VKR01_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [VKR01] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VKR01].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VKR01] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VKR01] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VKR01] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VKR01] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VKR01] SET ARITHABORT OFF 
GO
ALTER DATABASE [VKR01] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VKR01] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VKR01] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VKR01] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VKR01] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VKR01] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VKR01] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VKR01] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VKR01] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VKR01] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VKR01] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VKR01] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VKR01] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VKR01] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VKR01] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VKR01] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VKR01] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VKR01] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VKR01] SET  MULTI_USER 
GO
ALTER DATABASE [VKR01] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VKR01] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VKR01] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VKR01] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VKR01] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VKR01] SET QUERY_STORE = OFF
GO
USE [VKR01]
GO
/****** Object:  Table [dbo].[doljnosti]    Script Date: 26.05.2022 17:07:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doljnosti](
	[id_dolj] [int] IDENTITY(1,1) NOT NULL,
	[nazv_dolj] [nvarchar](250) NOT NULL,
	[oklad] [money] NOT NULL,
 CONSTRAINT [PK_doljnosti] PRIMARY KEY CLUSTERED 
(
	[id_dolj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[praktikanti]    Script Date: 26.05.2022 17:07:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[praktikanti](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[login_prak] [nvarchar](50) NOT NULL,
	[pass_prak] [nvarchar](50) NOT NULL,
	[name_prak] [nvarchar](50) NOT NULL,
	[surename_prak] [nvarchar](50) NOT NULL,
	[pat_prak] [nvarchar](50) NULL,
	[phone_prak] [varchar](17) NOT NULL,
	[facultet_prak] [nvarchar](150) NOT NULL,
	[group_prak] [nvarchar](50) NOT NULL,
	[rukovod_prak] [int] NOT NULL,
	[sex_prak] [int] NOT NULL,
	[begin_prak] [nvarchar](50) NOT NULL,
	[end_prak] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_praktikanti] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sex]    Script Date: 26.05.2022 17:07:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sex](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[sex] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_sex] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sotrudniki]    Script Date: 26.05.2022 17:07:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sotrudniki](
	[id_sotrud] [int] IDENTITY(1,1) NOT NULL,
	[login_sotrud] [nvarchar](50) NOT NULL,
	[password_sotrud] [nvarchar](50) NOT NULL,
	[f_s] [nvarchar](50) NOT NULL,
	[i_s] [nvarchar](50) NOT NULL,
	[o_s] [nvarchar](50) NULL,
	[phone_number_sotrud] [varchar](17) NOT NULL,
	[date_birth] [nvarchar](50) NOT NULL,
	[passport_sotrud] [nvarchar](250) NOT NULL,
	[obrazov_sotrud] [nvarchar](250) NOT NULL,
	[sex_sotrud] [int] NOT NULL,
	[dolj_s] [int] NOT NULL,
 CONSTRAINT [PK_sotrudniki] PRIMARY KEY CLUSTERED 
(
	[id_sotrud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[praktikanti]  WITH CHECK ADD  CONSTRAINT [FK_praktikanti_sex] FOREIGN KEY([sex_prak])
REFERENCES [dbo].[sex] ([ID])
GO
ALTER TABLE [dbo].[praktikanti] CHECK CONSTRAINT [FK_praktikanti_sex]
GO
ALTER TABLE [dbo].[praktikanti]  WITH CHECK ADD  CONSTRAINT [FK_praktikanti_sotrudniki] FOREIGN KEY([rukovod_prak])
REFERENCES [dbo].[sotrudniki] ([id_sotrud])
GO
ALTER TABLE [dbo].[praktikanti] CHECK CONSTRAINT [FK_praktikanti_sotrudniki]
GO
ALTER TABLE [dbo].[sotrudniki]  WITH CHECK ADD  CONSTRAINT [FK_sotrudniki_doljnosti] FOREIGN KEY([dolj_s])
REFERENCES [dbo].[doljnosti] ([id_dolj])
GO
ALTER TABLE [dbo].[sotrudniki] CHECK CONSTRAINT [FK_sotrudniki_doljnosti]
GO
ALTER TABLE [dbo].[sotrudniki]  WITH CHECK ADD  CONSTRAINT [FK_sotrudniki_sex] FOREIGN KEY([sex_sotrud])
REFERENCES [dbo].[sex] ([ID])
GO
ALTER TABLE [dbo].[sotrudniki] CHECK CONSTRAINT [FK_sotrudniki_sex]
GO
/****** Object:  StoredProcedure [dbo].[add_praktikanta]    Script Date: 26.05.2022 17:07:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[add_praktikanta]
@login_prak [nvarchar] (50), @pass_prak [nvarchar] (50),@name_prak [nvarchar] (50),@surename_prak [nvarchar] (50),@pat_prak [nvarchar] (50) ,@phone_prak [varchar] (17) ,@date_birth_prak [nvarchar] (50) ,@facultet_prak [nvarchar] (150) , @group_prak [nvarchar] (50), @passport_prak [nvarchar] (250)  , @rukovod_prak int , @sex_prak int  ,@begin_prak [nvarchar] (50), @end_prak [nvarchar] (50)
as 
	insert into [dbo].[praktikanti] (login_prak, pass_prak, name_prak,surename_prak ,pat_prak , phone_prak,date_birth_prak ,facultet_prak ,group_prak, passport_prak, rukovod_prak, sex_prak, begin_prak, end_prak )
	values (@login_prak, @pass_prak, @name_prak,@surename_prak , @pat_prak, @phone_prak,@date_birth_prak ,@facultet_prak, @group_prak, @passport_prak, @rukovod_prak, @sex_prak, @begin_prak, @end_prak)
GO
/****** Object:  StoredProcedure [dbo].[add1_praktikanta]    Script Date: 26.05.2022 17:07:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[add1_praktikanta]
@login_prak [nvarchar] (50), @pass_prak [nvarchar] (50),@name_prak [nvarchar] (50),@surename_prak [nvarchar] (50),@pat_prak [nvarchar] (50) ,@phone_prak [varchar] (17) ,@facultet_prak [nvarchar] (150) , @group_prak [nvarchar] (50),  @rukovod_prak int , @sex_prak int  ,@begin_prak [nvarchar] (50), @end_prak [nvarchar] (50)
as 
	insert into [dbo].[praktikanti] (login_prak, pass_prak, name_prak,surename_prak ,pat_prak , phone_prak,facultet_prak ,group_prak, rukovod_prak, sex_prak, begin_prak, end_prak )
	values (@login_prak, @pass_prak, @name_prak,@surename_prak , @pat_prak, @phone_prak ,@facultet_prak, @group_prak, @rukovod_prak, @sex_prak, @begin_prak, @end_prak)
GO
/****** Object:  StoredProcedure [dbo].[praktikant_Delete]    Script Date: 26.05.2022 17:07:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[praktikant_Delete]
@Id [int]
as
	delete from [dbo].[praktikanti]
	where
		ID = @Id
GO
USE [master]
GO
ALTER DATABASE [VKR01] SET  READ_WRITE 
GO
