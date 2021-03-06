USE [master]
GO
/****** Object:  Database [STEMMA]    Script Date: 1/9/2018 9:27:01 PM ******/
CREATE DATABASE [STEMMA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'STEMMA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\STEMMA.mdf' , SIZE = 4000KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'STEMMA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\STEMMA_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [STEMMA] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [STEMMA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [STEMMA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [STEMMA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [STEMMA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [STEMMA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [STEMMA] SET ARITHABORT OFF 
GO
ALTER DATABASE [STEMMA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [STEMMA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [STEMMA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [STEMMA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [STEMMA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [STEMMA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [STEMMA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [STEMMA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [STEMMA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [STEMMA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [STEMMA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [STEMMA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [STEMMA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [STEMMA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [STEMMA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [STEMMA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [STEMMA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [STEMMA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [STEMMA] SET  MULTI_USER 
GO
ALTER DATABASE [STEMMA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [STEMMA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [STEMMA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [STEMMA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [STEMMA] SET DELAYED_DURABILITY = DISABLED 
GO
USE [STEMMA]
GO
/****** Object:  Table [dbo].[Career]    Script Date: 1/9/2018 9:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Career](
	[CareerID] [int] IDENTITY(1,1) NOT NULL,
	[AttendedCollege] [bit] NULL,
	[Graduations] [bit] NULL,
	[HaveJob] [bit] NULL,
	[HadJob] [bit] NULL,
	[Accomplishments] [bit] NULL,
	[FirstDayOfSchool] [bit] NULL,
	[ArmedForces] [bit] NULL,
	[Volunteer] [bit] NULL,
	[Legacies] [bit] NULL,
	[TechSchool] [bit] NULL,
	[LicensesCertifications] [bit] NULL,
	[FirstJob] [bit] NULL,
	[WorstJob] [bit] NULL,
	[AnythingElse] [bit] NULL,
 CONSTRAINT [PK_Career] PRIMARY KEY CLUSTERED 
(
	[CareerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Celebration]    Script Date: 1/9/2018 9:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Celebration](
	[CelebrationID] [int] IDENTITY(1,1) NOT NULL,
	[HolidayRecently] [bit] NULL,
	[PartyRecently] [bit] NULL,
	[MilestoneRecently] [bit] NULL,
	[CelebrateChristmas] [bit] NULL,
	[CelebrateNYE] [bit] NULL,
	[CelebrateThanksgiving] [bit] NULL,
	[CelebrateValentine] [bit] NULL,
	[CelebrateEaster] [bit] NULL,
	[CelebrateIndependenceDay] [bit] NULL,
	[CelebrateHalloween] [bit] NULL,
	[CelebrateMemorialDay] [bit] NULL,
	[CelebrateLaborDay] [bit] NULL,
	[CelebrateMothersDay] [bit] NULL,
	[CelebrateFathersDay] [bit] NULL,
	[CelebrateChaunakah] [bit] NULL,
	[CelebratePassover] [bit] NULL,
	[CelebrateRoshHashanah] [bit] NULL,
	[CelerateYomKippur] [bit] NULL,
	[CelebrateRamadan] [bit] NULL,
	[CelebrateEID] [bit] NULL,
	[CelebrateSTPat] [bit] NULL,
	[CelebrateBirthdays] [bit] NULL,
	[CelebrateChineseNewYear] [bit] NULL,
	[CelebrateQuinceanera] [bit] NULL,
	[CelebrateBarBatMitzvah] [bit] NULL,
	[CelebrateDayOfTheDead] [bit] NULL,
	[CelebrateVeteransDay] [bit] NULL,
	[CelebrateCincoDeMayo] [bit] NULL,
	[AnythingElse] [bit] NULL,
 CONSTRAINT [PK_Celebration] PRIMARY KEY CLUSTERED 
(
	[CelebrationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EventTable]    Script Date: 1/9/2018 9:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventTable](
	[EventID] [int] IDENTITY(1,1) NOT NULL,
	[DateCreated] [timestamp] NOT NULL,
	[EventTitle] [nvarchar](50) NOT NULL,
	[EventDay] [int] NULL,
	[EventMonth] [nvarchar](12) NULL,
	[EventYear] [int] NOT NULL,
	[PeopleInvolved] [nvarchar](300) NULL,
	[EventCaption] [nvarchar](750) NULL,
	[UploadMedia] [nvarchar](max) NULL,
 CONSTRAINT [PK_EventTable] PRIMARY KEY CLUSTERED 
(
	[EventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HobbyTable]    Script Date: 1/9/2018 9:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HobbyTable](
	[HobbyID] [int] IDENTITY(1,1) NOT NULL,
	[PlaySports] [bit] NULL,
	[InAShow] [bit] NULL,
	[Travel] [bit] NULL,
	[OutdoorPerson] [bit] NULL,
	[TravelAbroad] [bit] NULL,
	[Passions] [bit] NULL,
	[Talents] [bit] NULL,
	[Trophies] [bit] NULL,
	[Exercise] [bit] NULL,
	[FamilyVacation] [bit] NULL,
	[ChildhoodVacation] [bit] NULL,
	[AnythingElse] [bit] NULL,
 CONSTRAINT [PK_HobbyTable] PRIMARY KEY CLUSTERED 
(
	[HobbyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Media]    Script Date: 1/9/2018 9:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Media](
	[MediaID] [int] IDENTITY(1,1) NOT NULL,
	[FilePath] [nvarchar](max) NULL,
	[EventID] [int] NULL,
 CONSTRAINT [PK_Media] PRIMARY KEY CLUSTERED 
(
	[MediaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Memories]    Script Date: 1/9/2018 9:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Memories](
	[MemoryID] [int] IDENTITY(1,1) NOT NULL,
	[BrokenBones] [bit] NULL,
	[OwnHome] [bit] NULL,
	[DriversLicense] [bit] NULL,
	[FirstTooth] [bit] NULL,
	[PersonalNickName] [bit] NULL,
	[FamilyNickName] [bit] NULL,
	[RideBike] [bit] NULL,
	[CommitCrime] [bit] NULL,
	[BigMove] [bit] NULL,
	[Vote] [bit] NULL,
	[FamilyTraditions] [bit] NULL,
	[EmbarrassingMoment] [bit] NULL,
	[ProudestMoments] [bit] NULL,
	[ChildhoodCamp] [bit] NULL,
	[MemorializeSomeone] [bit] NULL,
	[Concerts] [bit] NULL,
	[FamilyPet] [bit] NULL,
	[CurrentPet] [bit] NULL,
	[HSDance] [bit] NULL,
	[AnythingElse] [bit] NULL,
 CONSTRAINT [PK_Memories] PRIMARY KEY CLUSTERED 
(
	[MemoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Relationship]    Script Date: 1/9/2018 9:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Relationship](
	[RelationshipsID] [int] IDENTITY(1,1) NOT NULL,
	[CurrentlyMarried] [bit] NULL,
	[InARelationship] [bit] NULL,
	[PreviousRomance] [bit] NULL,
	[HaveChildren] [bit] NULL,
	[HaveGrandchildren] [bit] NULL,
	[OtherYoungsters] [bit] NULL,
	[HaveParents] [bit] NULL,
	[HaveGrandparents] [bit] NULL,
	[OtherAdults] [bit] NULL,
	[HaveSiblings] [bit] NULL,
	[OtherCloseRelatives] [bit] NULL,
	[GoodFriendships] [bit] NULL,
	[EverythingElse] [bit] NULL,
 CONSTRAINT [PK_Relationship] PRIMARY KEY CLUSTERED 
(
	[RelationshipsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserProfile]    Script Date: 1/9/2018 9:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserProfile](
	[UserProfileID] [int] IDENTITY(1,1) NOT NULL,
	[Birthdate] [datetime] NOT NULL,
	[RelationshipsID] [int] NOT NULL,
	[CareerID] [int] NOT NULL,
	[CelebrationID] [int] NOT NULL,
	[HobbyID] [int] NOT NULL,
	[MemoryID] [int] NOT NULL,
	[WorldEventID] [int] NOT NULL,
	[EventID] [int] NOT NULL,
 CONSTRAINT [PK_UserProfile] PRIMARY KEY CLUSTERED 
(
	[UserProfileID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WorldEvents]    Script Date: 1/9/2018 9:27:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorldEvents](
	[WorldEventID] [int] IDENTITY(1,1) NOT NULL,
	[September11] [bit] NULL,
	[MoonLanding] [bit] NULL,
	[NixonResigns] [bit] NULL,
	[ElvisDies] [bit] NULL,
	[ChallengerExplodes] [bit] NULL,
	[WorldWar2Ends] [bit] NULL,
	[KennedyDies] [bit] NULL,
	[NotableElection] [bit] NULL,
	[MLKAssassination] [bit] NULL,
	[Y2K] [bit] NULL,
	[BerlinWall] [bit] NULL,
	[OJSimpsonCarChase] [bit] NULL,
	[EndOfProhibition] [bit] NULL,
	[VietnamWar] [bit] NULL,
	[AnythingElse] [bit] NULL,
 CONSTRAINT [PK_WorldEvents] PRIMARY KEY CLUSTERED 
(
	[WorldEventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Career] ON 

INSERT [dbo].[Career] ([CareerID], [AttendedCollege], [Graduations], [HaveJob], [HadJob], [Accomplishments], [FirstDayOfSchool], [ArmedForces], [Volunteer], [Legacies], [TechSchool], [LicensesCertifications], [FirstJob], [WorstJob], [AnythingElse]) VALUES (1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, NULL)
INSERT [dbo].[Career] ([CareerID], [AttendedCollege], [Graduations], [HaveJob], [HadJob], [Accomplishments], [FirstDayOfSchool], [ArmedForces], [Volunteer], [Legacies], [TechSchool], [LicensesCertifications], [FirstJob], [WorstJob], [AnythingElse]) VALUES (2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, NULL)
SET IDENTITY_INSERT [dbo].[Career] OFF
SET IDENTITY_INSERT [dbo].[Celebration] ON 

INSERT [dbo].[Celebration] ([CelebrationID], [HolidayRecently], [PartyRecently], [MilestoneRecently], [CelebrateChristmas], [CelebrateNYE], [CelebrateThanksgiving], [CelebrateValentine], [CelebrateEaster], [CelebrateIndependenceDay], [CelebrateHalloween], [CelebrateMemorialDay], [CelebrateLaborDay], [CelebrateMothersDay], [CelebrateFathersDay], [CelebrateChaunakah], [CelebratePassover], [CelebrateRoshHashanah], [CelerateYomKippur], [CelebrateRamadan], [CelebrateEID], [CelebrateSTPat], [CelebrateBirthdays], [CelebrateChineseNewYear], [CelebrateQuinceanera], [CelebrateBarBatMitzvah], [CelebrateDayOfTheDead], [CelebrateVeteransDay], [CelebrateCincoDeMayo], [AnythingElse]) VALUES (1, 1, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Celebration] ([CelebrationID], [HolidayRecently], [PartyRecently], [MilestoneRecently], [CelebrateChristmas], [CelebrateNYE], [CelebrateThanksgiving], [CelebrateValentine], [CelebrateEaster], [CelebrateIndependenceDay], [CelebrateHalloween], [CelebrateMemorialDay], [CelebrateLaborDay], [CelebrateMothersDay], [CelebrateFathersDay], [CelebrateChaunakah], [CelebratePassover], [CelebrateRoshHashanah], [CelerateYomKippur], [CelebrateRamadan], [CelebrateEID], [CelebrateSTPat], [CelebrateBirthdays], [CelebrateChineseNewYear], [CelebrateQuinceanera], [CelebrateBarBatMitzvah], [CelebrateDayOfTheDead], [CelebrateVeteransDay], [CelebrateCincoDeMayo], [AnythingElse]) VALUES (2, 1, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Celebration] ([CelebrationID], [HolidayRecently], [PartyRecently], [MilestoneRecently], [CelebrateChristmas], [CelebrateNYE], [CelebrateThanksgiving], [CelebrateValentine], [CelebrateEaster], [CelebrateIndependenceDay], [CelebrateHalloween], [CelebrateMemorialDay], [CelebrateLaborDay], [CelebrateMothersDay], [CelebrateFathersDay], [CelebrateChaunakah], [CelebratePassover], [CelebrateRoshHashanah], [CelerateYomKippur], [CelebrateRamadan], [CelebrateEID], [CelebrateSTPat], [CelebrateBirthdays], [CelebrateChineseNewYear], [CelebrateQuinceanera], [CelebrateBarBatMitzvah], [CelebrateDayOfTheDead], [CelebrateVeteransDay], [CelebrateCincoDeMayo], [AnythingElse]) VALUES (3, 1, 1, 1, 0, 0, 0, 1, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1)
INSERT [dbo].[Celebration] ([CelebrationID], [HolidayRecently], [PartyRecently], [MilestoneRecently], [CelebrateChristmas], [CelebrateNYE], [CelebrateThanksgiving], [CelebrateValentine], [CelebrateEaster], [CelebrateIndependenceDay], [CelebrateHalloween], [CelebrateMemorialDay], [CelebrateLaborDay], [CelebrateMothersDay], [CelebrateFathersDay], [CelebrateChaunakah], [CelebratePassover], [CelebrateRoshHashanah], [CelerateYomKippur], [CelebrateRamadan], [CelebrateEID], [CelebrateSTPat], [CelebrateBirthdays], [CelebrateChineseNewYear], [CelebrateQuinceanera], [CelebrateBarBatMitzvah], [CelebrateDayOfTheDead], [CelebrateVeteransDay], [CelebrateCincoDeMayo], [AnythingElse]) VALUES (4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Celebration] OFF
SET IDENTITY_INSERT [dbo].[EventTable] ON 

INSERT [dbo].[EventTable] ([EventID], [EventTitle], [EventDay], [EventMonth], [EventYear], [PeopleInvolved], [EventCaption], [UploadMedia]) VALUES (1, N'Happy Day', 12, N'March', 2007, N'Just Me', N'Oh hello', N'https://i.amz.mshcdn.com/oz75gS6Ke1aRMwWuu4M_jP6LSLE=/356x205/https%3A%2F%2Fblueprint-api-production.s3.amazonaws.com%2Fuploads%2Fstory%2Fthumbnail%2F62429%2F0cb95ccb-ac64-41e7-a30f-b7d1d01b094d.png')
SET IDENTITY_INSERT [dbo].[EventTable] OFF
SET IDENTITY_INSERT [dbo].[HobbyTable] ON 

INSERT [dbo].[HobbyTable] ([HobbyID], [PlaySports], [InAShow], [Travel], [OutdoorPerson], [TravelAbroad], [Passions], [Talents], [Trophies], [Exercise], [FamilyVacation], [ChildhoodVacation], [AnythingElse]) VALUES (1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1)
INSERT [dbo].[HobbyTable] ([HobbyID], [PlaySports], [InAShow], [Travel], [OutdoorPerson], [TravelAbroad], [Passions], [Talents], [Trophies], [Exercise], [FamilyVacation], [ChildhoodVacation], [AnythingElse]) VALUES (2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[HobbyTable] ([HobbyID], [PlaySports], [InAShow], [Travel], [OutdoorPerson], [TravelAbroad], [Passions], [Talents], [Trophies], [Exercise], [FamilyVacation], [ChildhoodVacation], [AnythingElse]) VALUES (3, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0)
INSERT [dbo].[HobbyTable] ([HobbyID], [PlaySports], [InAShow], [Travel], [OutdoorPerson], [TravelAbroad], [Passions], [Talents], [Trophies], [Exercise], [FamilyVacation], [ChildhoodVacation], [AnythingElse]) VALUES (4, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[HobbyTable] ([HobbyID], [PlaySports], [InAShow], [Travel], [OutdoorPerson], [TravelAbroad], [Passions], [Talents], [Trophies], [Exercise], [FamilyVacation], [ChildhoodVacation], [AnythingElse]) VALUES (5, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[HobbyTable] ([HobbyID], [PlaySports], [InAShow], [Travel], [OutdoorPerson], [TravelAbroad], [Passions], [Talents], [Trophies], [Exercise], [FamilyVacation], [ChildhoodVacation], [AnythingElse]) VALUES (6, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[HobbyTable] ([HobbyID], [PlaySports], [InAShow], [Travel], [OutdoorPerson], [TravelAbroad], [Passions], [Talents], [Trophies], [Exercise], [FamilyVacation], [ChildhoodVacation], [AnythingElse]) VALUES (7, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0)
SET IDENTITY_INSERT [dbo].[HobbyTable] OFF
SET IDENTITY_INSERT [dbo].[Memories] ON 

INSERT [dbo].[Memories] ([MemoryID], [BrokenBones], [OwnHome], [DriversLicense], [FirstTooth], [PersonalNickName], [FamilyNickName], [RideBike], [CommitCrime], [BigMove], [Vote], [FamilyTraditions], [EmbarrassingMoment], [ProudestMoments], [ChildhoodCamp], [MemorializeSomeone], [Concerts], [FamilyPet], [CurrentPet], [HSDance], [AnythingElse]) VALUES (1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Memories] ([MemoryID], [BrokenBones], [OwnHome], [DriversLicense], [FirstTooth], [PersonalNickName], [FamilyNickName], [RideBike], [CommitCrime], [BigMove], [Vote], [FamilyTraditions], [EmbarrassingMoment], [ProudestMoments], [ChildhoodCamp], [MemorializeSomeone], [Concerts], [FamilyPet], [CurrentPet], [HSDance], [AnythingElse]) VALUES (2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Memories] ([MemoryID], [BrokenBones], [OwnHome], [DriversLicense], [FirstTooth], [PersonalNickName], [FamilyNickName], [RideBike], [CommitCrime], [BigMove], [Vote], [FamilyTraditions], [EmbarrassingMoment], [ProudestMoments], [ChildhoodCamp], [MemorializeSomeone], [Concerts], [FamilyPet], [CurrentPet], [HSDance], [AnythingElse]) VALUES (3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Memories] OFF
SET IDENTITY_INSERT [dbo].[Relationship] ON 

INSERT [dbo].[Relationship] ([RelationshipsID], [CurrentlyMarried], [InARelationship], [PreviousRomance], [HaveChildren], [HaveGrandchildren], [OtherYoungsters], [HaveParents], [HaveGrandparents], [OtherAdults], [HaveSiblings], [OtherCloseRelatives], [GoodFriendships], [EverythingElse]) VALUES (7, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0)
INSERT [dbo].[Relationship] ([RelationshipsID], [CurrentlyMarried], [InARelationship], [PreviousRomance], [HaveChildren], [HaveGrandchildren], [OtherYoungsters], [HaveParents], [HaveGrandparents], [OtherAdults], [HaveSiblings], [OtherCloseRelatives], [GoodFriendships], [EverythingElse]) VALUES (8, 1, 0, 1, 0, 0, NULL, 0, 1, 1, 1, 1, 0, 0)
INSERT [dbo].[Relationship] ([RelationshipsID], [CurrentlyMarried], [InARelationship], [PreviousRomance], [HaveChildren], [HaveGrandchildren], [OtherYoungsters], [HaveParents], [HaveGrandparents], [OtherAdults], [HaveSiblings], [OtherCloseRelatives], [GoodFriendships], [EverythingElse]) VALUES (9, 1, 1, 1, 0, 0, NULL, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[Relationship] ([RelationshipsID], [CurrentlyMarried], [InARelationship], [PreviousRomance], [HaveChildren], [HaveGrandchildren], [OtherYoungsters], [HaveParents], [HaveGrandparents], [OtherAdults], [HaveSiblings], [OtherCloseRelatives], [GoodFriendships], [EverythingElse]) VALUES (10, 0, 0, 0, 0, 0, NULL, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[Relationship] ([RelationshipsID], [CurrentlyMarried], [InARelationship], [PreviousRomance], [HaveChildren], [HaveGrandchildren], [OtherYoungsters], [HaveParents], [HaveGrandparents], [OtherAdults], [HaveSiblings], [OtherCloseRelatives], [GoodFriendships], [EverythingElse]) VALUES (11, 0, 0, 0, 0, 0, NULL, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[Relationship] ([RelationshipsID], [CurrentlyMarried], [InARelationship], [PreviousRomance], [HaveChildren], [HaveGrandchildren], [OtherYoungsters], [HaveParents], [HaveGrandparents], [OtherAdults], [HaveSiblings], [OtherCloseRelatives], [GoodFriendships], [EverythingElse]) VALUES (12, 1, 0, 0, 0, 0, NULL, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[Relationship] ([RelationshipsID], [CurrentlyMarried], [InARelationship], [PreviousRomance], [HaveChildren], [HaveGrandchildren], [OtherYoungsters], [HaveParents], [HaveGrandparents], [OtherAdults], [HaveSiblings], [OtherCloseRelatives], [GoodFriendships], [EverythingElse]) VALUES (13, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Relationship] ([RelationshipsID], [CurrentlyMarried], [InARelationship], [PreviousRomance], [HaveChildren], [HaveGrandchildren], [OtherYoungsters], [HaveParents], [HaveGrandparents], [OtherAdults], [HaveSiblings], [OtherCloseRelatives], [GoodFriendships], [EverythingElse]) VALUES (14, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Relationship] ([RelationshipsID], [CurrentlyMarried], [InARelationship], [PreviousRomance], [HaveChildren], [HaveGrandchildren], [OtherYoungsters], [HaveParents], [HaveGrandparents], [OtherAdults], [HaveSiblings], [OtherCloseRelatives], [GoodFriendships], [EverythingElse]) VALUES (15, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Relationship] ([RelationshipsID], [CurrentlyMarried], [InARelationship], [PreviousRomance], [HaveChildren], [HaveGrandchildren], [OtherYoungsters], [HaveParents], [HaveGrandparents], [OtherAdults], [HaveSiblings], [OtherCloseRelatives], [GoodFriendships], [EverythingElse]) VALUES (16, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Relationship] ([RelationshipsID], [CurrentlyMarried], [InARelationship], [PreviousRomance], [HaveChildren], [HaveGrandchildren], [OtherYoungsters], [HaveParents], [HaveGrandparents], [OtherAdults], [HaveSiblings], [OtherCloseRelatives], [GoodFriendships], [EverythingElse]) VALUES (17, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Relationship] ([RelationshipsID], [CurrentlyMarried], [InARelationship], [PreviousRomance], [HaveChildren], [HaveGrandchildren], [OtherYoungsters], [HaveParents], [HaveGrandparents], [OtherAdults], [HaveSiblings], [OtherCloseRelatives], [GoodFriendships], [EverythingElse]) VALUES (18, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Relationship] ([RelationshipsID], [CurrentlyMarried], [InARelationship], [PreviousRomance], [HaveChildren], [HaveGrandchildren], [OtherYoungsters], [HaveParents], [HaveGrandparents], [OtherAdults], [HaveSiblings], [OtherCloseRelatives], [GoodFriendships], [EverythingElse]) VALUES (19, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Relationship] ([RelationshipsID], [CurrentlyMarried], [InARelationship], [PreviousRomance], [HaveChildren], [HaveGrandchildren], [OtherYoungsters], [HaveParents], [HaveGrandparents], [OtherAdults], [HaveSiblings], [OtherCloseRelatives], [GoodFriendships], [EverythingElse]) VALUES (20, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Relationship] OFF
SET IDENTITY_INSERT [dbo].[WorldEvents] ON 

INSERT [dbo].[WorldEvents] ([WorldEventID], [September11], [MoonLanding], [NixonResigns], [ElvisDies], [ChallengerExplodes], [WorldWar2Ends], [KennedyDies], [NotableElection], [MLKAssassination], [Y2K], [BerlinWall], [OJSimpsonCarChase], [EndOfProhibition], [VietnamWar], [AnythingElse]) VALUES (1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, NULL, 1)
INSERT [dbo].[WorldEvents] ([WorldEventID], [September11], [MoonLanding], [NixonResigns], [ElvisDies], [ChallengerExplodes], [WorldWar2Ends], [KennedyDies], [NotableElection], [MLKAssassination], [Y2K], [BerlinWall], [OJSimpsonCarChase], [EndOfProhibition], [VietnamWar], [AnythingElse]) VALUES (2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, NULL, 1)
INSERT [dbo].[WorldEvents] ([WorldEventID], [September11], [MoonLanding], [NixonResigns], [ElvisDies], [ChallengerExplodes], [WorldWar2Ends], [KennedyDies], [NotableElection], [MLKAssassination], [Y2K], [BerlinWall], [OJSimpsonCarChase], [EndOfProhibition], [VietnamWar], [AnythingElse]) VALUES (3, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, NULL, 0)
SET IDENTITY_INSERT [dbo].[WorldEvents] OFF
ALTER TABLE [dbo].[Media]  WITH CHECK ADD  CONSTRAINT [FK_Media_EventTable] FOREIGN KEY([EventID])
REFERENCES [dbo].[EventTable] ([EventID])
GO
ALTER TABLE [dbo].[Media] CHECK CONSTRAINT [FK_Media_EventTable]
GO
ALTER TABLE [dbo].[UserProfile]  WITH CHECK ADD  CONSTRAINT [FK_UserProfile_Career] FOREIGN KEY([CareerID])
REFERENCES [dbo].[Career] ([CareerID])
GO
ALTER TABLE [dbo].[UserProfile] CHECK CONSTRAINT [FK_UserProfile_Career]
GO
ALTER TABLE [dbo].[UserProfile]  WITH CHECK ADD  CONSTRAINT [FK_UserProfile_Celebration] FOREIGN KEY([CelebrationID])
REFERENCES [dbo].[Celebration] ([CelebrationID])
GO
ALTER TABLE [dbo].[UserProfile] CHECK CONSTRAINT [FK_UserProfile_Celebration]
GO
ALTER TABLE [dbo].[UserProfile]  WITH CHECK ADD  CONSTRAINT [FK_UserProfile_EventTable] FOREIGN KEY([EventID])
REFERENCES [dbo].[EventTable] ([EventID])
GO
ALTER TABLE [dbo].[UserProfile] CHECK CONSTRAINT [FK_UserProfile_EventTable]
GO
ALTER TABLE [dbo].[UserProfile]  WITH CHECK ADD  CONSTRAINT [FK_UserProfile_HobbyTable] FOREIGN KEY([HobbyID])
REFERENCES [dbo].[HobbyTable] ([HobbyID])
GO
ALTER TABLE [dbo].[UserProfile] CHECK CONSTRAINT [FK_UserProfile_HobbyTable]
GO
ALTER TABLE [dbo].[UserProfile]  WITH CHECK ADD  CONSTRAINT [FK_UserProfile_Memories] FOREIGN KEY([MemoryID])
REFERENCES [dbo].[Memories] ([MemoryID])
GO
ALTER TABLE [dbo].[UserProfile] CHECK CONSTRAINT [FK_UserProfile_Memories]
GO
ALTER TABLE [dbo].[UserProfile]  WITH CHECK ADD  CONSTRAINT [FK_UserProfile_Relationship] FOREIGN KEY([RelationshipsID])
REFERENCES [dbo].[Relationship] ([RelationshipsID])
GO
ALTER TABLE [dbo].[UserProfile] CHECK CONSTRAINT [FK_UserProfile_Relationship]
GO
ALTER TABLE [dbo].[UserProfile]  WITH CHECK ADD  CONSTRAINT [FK_UserProfile_WorldEvents] FOREIGN KEY([WorldEventID])
REFERENCES [dbo].[WorldEvents] ([WorldEventID])
GO
ALTER TABLE [dbo].[UserProfile] CHECK CONSTRAINT [FK_UserProfile_WorldEvents]
GO
USE [master]
GO
ALTER DATABASE [STEMMA] SET  READ_WRITE 
GO
