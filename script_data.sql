USE [master]
GO
/****** Object:  Database [personal]    Script Date: 15.03.2019 1:38:00 ******/
CREATE DATABASE [personal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'personal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\personal.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'personal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\personal_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [personal] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [personal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [personal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [personal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [personal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [personal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [personal] SET ARITHABORT OFF 
GO
ALTER DATABASE [personal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [personal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [personal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [personal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [personal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [personal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [personal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [personal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [personal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [personal] SET  DISABLE_BROKER 
GO
ALTER DATABASE [personal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [personal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [personal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [personal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [personal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [personal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [personal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [personal] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [personal] SET  MULTI_USER 
GO
ALTER DATABASE [personal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [personal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [personal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [personal] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [personal] SET DELAYED_DURABILITY = DISABLED 
GO
USE [personal]
GO
/****** Object:  Table [dbo].[Keeled]    Script Date: 15.03.2019 1:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Keeled](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Keel] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Keeled] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KeeleTasud]    Script Date: 15.03.2019 1:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KeeleTasud](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Tase] [char](2) NOT NULL,
	[Summa] [decimal](8, 2) NOT NULL CONSTRAINT [DF_KeeleTasud_Summa]  DEFAULT ((0)),
 CONSTRAINT [PK_KeeleTasud] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Personal]    Script Date: 15.03.2019 1:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Perekonnanimi] [nvarchar](50) NOT NULL,
	[Eesnimi] [nvarchar](50) NOT NULL,
	[Sugu] [tinyint] NOT NULL CONSTRAINT [DF_Personal_Sugu]  DEFAULT ((0)),
	[Sunnipaev] [date] NOT NULL,
	[Palk] [decimal](8, 2) NOT NULL CONSTRAINT [DF_Personal_Palk]  DEFAULT ((0)),
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonalKeeled]    Script Date: 15.03.2019 1:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonalKeeled](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idPersonal] [int] NOT NULL,
	[idKeeled] [tinyint] NOT NULL,
	[Tase] [char](2) NOT NULL,
 CONSTRAINT [PK_PersonalKeeled] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tooaeg]    Script Date: 15.03.2019 1:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tooaeg](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[idPersonal] [int] NOT NULL,
	[Kuupaev] [date] NOT NULL,
	[Tootunnid] [decimal](5, 2) NOT NULL CONSTRAINT [DF_Tooaeg_Tootunnid]  DEFAULT ((0)),
 CONSTRAINT [PK_Tooaeg] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_KeeleTasud]    Script Date: 15.03.2019 1:38:00 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_KeeleTasud] ON [dbo].[KeeleTasud]
(
	[Tase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PersonalKeeled]  WITH CHECK ADD  CONSTRAINT [FK_PersonalKeeled_Keeled] FOREIGN KEY([idKeeled])
REFERENCES [dbo].[Keeled] ([Id])
GO
ALTER TABLE [dbo].[PersonalKeeled] CHECK CONSTRAINT [FK_PersonalKeeled_Keeled]
GO
ALTER TABLE [dbo].[PersonalKeeled]  WITH CHECK ADD  CONSTRAINT [FK_PersonalKeeled_Personal] FOREIGN KEY([idPersonal])
REFERENCES [dbo].[Personal] ([Id])
GO
ALTER TABLE [dbo].[PersonalKeeled] CHECK CONSTRAINT [FK_PersonalKeeled_Personal]
GO
ALTER TABLE [dbo].[Tooaeg]  WITH CHECK ADD  CONSTRAINT [FK_Tooaeg_Personal] FOREIGN KEY([idPersonal])
REFERENCES [dbo].[Personal] ([Id])
GO
ALTER TABLE [dbo].[Tooaeg] CHECK CONSTRAINT [FK_Tooaeg_Personal]
GO
/****** Object:  StoredProcedure [dbo].[proc_palk]    Script Date: 15.03.2019 1:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Oleg
-- Create date: 12.03.2019
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[proc_palk]
	@Kuu tinyint = NULL,
	@Aasta smallint = NULL,
	@idPersonal int = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @SQLString nvarchar(1024)
	DECLARE @ParmDefinition nvarchar(512)

	SET @SQLString = 
		N'SELECT ROW_NUMBER() OVER(ORDER BY P.Id ASC) AS Id, P.Perekonnanimi + '' '' + P.Eesnimi AS Nimi, T.Kuu, T.Aasta, P.Palk,
			T.Tootunnid AS Tootunnid, (P.Palk * SUM(T.Tootunnid)) AS Palga_summa, COALESCE(SUM(KT.KeeleTasud), 0) KeeleTasud,
			(P.Palk * SUM(T.Tootunnid) + COALESCE(SUM(KT.KeeleTasud), 0)) Kokku
		FROM [dbo].[Personal] P
			JOIN (
				SELECT _P.Id idPersonal, MONTH(_T.Kuupaev) Kuu, YEAR(_T.Kuupaev) Aasta, SUM(_T.Tootunnid) Tootunnid
				FROM [dbo].[Personal] _P, [dbo].[Tooaeg] _T
				WHERE _P.Id = _T.idPersonal'
				IF @Kuu IS NOT NULL
					SET @SQLString += ' AND MONTH(_T.Kuupaev) = @Kuu'

				IF @Aasta IS NOT NULL
					SET @SQLString += ' AND YEAR(_T.Kuupaev) = @Aasta'

				SET @SQLString += ' GROUP BY _P.Id, MONTH(_T.Kuupaev), YEAR(_T.Kuupaev)
			) T ON P.Id = T.idPersonal
			LEFT JOIN (
				SELECT _PK.idPersonal, SUM(_KT.Summa) KeeleTasud
				FROM [dbo].[PersonalKeeled] _PK, [dbo].[KeeleTasud] _KT
				WHERE _PK.Tase = _KT.Tase
				GROUP BY _PK.idPersonal
			) KT ON P.Id = KT.idPersonal'
	IF @idPersonal IS NOT NULL
		SET @SQLString += ' WHERE P.Id = @idPersonal'

	SET @SQLString += ' GROUP BY P.Id, P.Perekonnanimi, P.Eesnimi, T.Kuu, T.Aasta, P.Palk, T.Tootunnid'

	SET @ParmDefinition = N'@Kuu tinyint, @Aasta smallint, @idPersonal int'
	
	EXECUTE sp_executesql @SQLString, @ParmDefinition, @Kuu, @Aasta, @idPersonal
END

GO
/****** Object:  StoredProcedure [dbo].[proc_personal]    Script Date: 15.03.2019 1:38:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Oleg
-- Create date: 11.03.2019
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[proc_personal] 
	@Keel nvarchar(50) = '*', 
	@Tase char(2) = '*',
	@VanusAlates tinyint = 0,
	@VanusKuni tinyint = 100,
	@Sugu tinyint = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @datetime datetime = GETDATE()
	DECLARE @SQLString nvarchar(1024)
	DECLARE @ParmDefinition nvarchar(512)
	
	SET @SQLString = 
		N'SELECT ROW_NUMBER() OVER(ORDER BY P.Id ASC) Id, P.Perekonnanimi + '' '' + P.Eesnimi Nimi, P.Sugu,
			P.Sunnipaev, (YEAR(@datetime) - YEAR(P.Sunnipaev)) Vanus,
			COALESCE(K.Keel, '''') Keel, COALESCE(PK.Tase, '''') Tase, COALESCE(KT.Summa, 0) KeeleTasud
		FROM [dbo].[Personal] P LEFT JOIN [dbo].[PersonalKeeled] PK ON P.Id = PK.idPersonal
			LEFT JOIN [dbo].[Keeled] K ON PK.idKeeled = K.Id
			LEFT JOIN [dbo].[KeeleTasud] KT ON KT.Tase = PK.Tase
		WHERE (YEAR(@datetime) - YEAR(P.Sunnipaev)) >= @VanusAlates AND (YEAR(@datetime) - YEAR(P.Sunnipaev)) <= @VanusKuni'
	IF @Keel IS NULL
		SET @SQLString += ' AND K.Keel IS NULL'
	ELSE IF @Keel != '*'
		SET @SQLString += ' AND K.Keel = @Keel'
	
	IF @Tase IS NULL
		SET @SQLString += ' AND PK.Tase IS NULL'
	IF @Tase != '*'
		SET @SQLString += ' AND PK.Tase = @Tase'

	IF @Sugu > 0
		SET @SQLString += ' AND P.Sugu = @Sugu'
	SET @ParmDefinition = N'@datetime datetime, @Keel nvarchar(50), @Tase char(2), @Sugu tinyint, @VanusAlates tinyint, @VanusKuni tinyint'
	
	EXECUTE sp_executesql @SQLString, @ParmDefinition, @datetime, @Keel, @Tase, @Sugu, @VanusAlates, @VanusKuni
END

GO
USE [master]
GO
ALTER DATABASE [personal] SET  READ_WRITE 
GO
