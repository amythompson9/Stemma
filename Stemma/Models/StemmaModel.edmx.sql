
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/10/2018 13:44:46
-- Generated from EDMX file: C:\Users\WeCanCodeIT\Documents\Visual Studio 2015\Projects\Stemma\Stemma\Models\StemmaModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [STEMMA];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_Media_EventTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Media] DROP CONSTRAINT [FK_Media_EventTable];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProfile_Career]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserProfile] DROP CONSTRAINT [FK_UserProfile_Career];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProfile_Celebration]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserProfile] DROP CONSTRAINT [FK_UserProfile_Celebration];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProfile_EventTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserProfile] DROP CONSTRAINT [FK_UserProfile_EventTable];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProfile_HobbyTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserProfile] DROP CONSTRAINT [FK_UserProfile_HobbyTable];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProfile_Memories]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserProfile] DROP CONSTRAINT [FK_UserProfile_Memories];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProfile_Relationship]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserProfile] DROP CONSTRAINT [FK_UserProfile_Relationship];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProfile_WorldEvents]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserProfile] DROP CONSTRAINT [FK_UserProfile_WorldEvents];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[__MigrationHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[__MigrationHistory];
GO
IF OBJECT_ID(N'[dbo].[AspNetRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserClaims]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserClaims];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserLogins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserLogins];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[Career]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Career];
GO
IF OBJECT_ID(N'[dbo].[Celebration]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Celebration];
GO
IF OBJECT_ID(N'[dbo].[EventTable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventTable];
GO
IF OBJECT_ID(N'[dbo].[HobbyTable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HobbyTable];
GO
IF OBJECT_ID(N'[dbo].[Media]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Media];
GO
IF OBJECT_ID(N'[dbo].[Memories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Memories];
GO
IF OBJECT_ID(N'[dbo].[RegisterUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RegisterUser];
GO
IF OBJECT_ID(N'[dbo].[Relationship]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Relationship];
GO
IF OBJECT_ID(N'[dbo].[UserProfile]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserProfile];
GO
IF OBJECT_ID(N'[dbo].[WorldEvents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorldEvents];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Careers'
CREATE TABLE [dbo].[Careers] (
    [CareerID] int IDENTITY(1,1) NOT NULL,
    [AttendedCollege] bit  NULL,
    [Graduations] bit  NULL,
    [HaveJob] bit  NULL,
    [HadJob] bit  NULL,
    [Accomplishments] bit  NULL,
    [FirstDayOfSchool] bit  NULL,
    [ArmedForces] bit  NULL,
    [Volunteer] bit  NULL,
    [Legacies] bit  NULL,
    [TechSchool] bit  NULL,
    [LicensesCertifications] bit  NULL,
    [FirstJob] bit  NULL,
    [WorstJob] bit  NULL,
    [AnythingElse] bit  NULL
);
GO

-- Creating table 'Celebrations'
CREATE TABLE [dbo].[Celebrations] (
    [CelebrationID] int IDENTITY(1,1) NOT NULL,
    [HolidayRecently] bit  NULL,
    [PartyRecently] bit  NULL,
    [MilestoneRecently] bit  NULL,
    [CelebrateChristmas] bit  NULL,
    [CelebrateNYE] bit  NULL,
    [CelebrateThanksgiving] bit  NULL,
    [CelebrateValentine] bit  NULL,
    [CelebrateEaster] bit  NULL,
    [CelebrateIndependenceDay] bit  NULL,
    [CelebrateHalloween] bit  NULL,
    [CelebrateMemorialDay] bit  NULL,
    [CelebrateLaborDay] bit  NULL,
    [CelebrateMothersDay] bit  NULL,
    [CelebrateFathersDay] bit  NULL,
    [CelebrateChaunakah] bit  NULL,
    [CelebratePassover] bit  NULL,
    [CelebrateRoshHashanah] bit  NULL,
    [CelerateYomKippur] bit  NULL,
    [CelebrateRamadan] bit  NULL,
    [CelebrateEID] bit  NULL,
    [CelebrateSTPat] bit  NULL,
    [CelebrateBirthdays] bit  NULL,
    [CelebrateChineseNewYear] bit  NULL,
    [CelebrateQuinceanera] bit  NULL,
    [CelebrateBarBatMitzvah] bit  NULL,
    [CelebrateDayOfTheDead] bit  NULL,
    [CelebrateVeteransDay] bit  NULL,
    [CelebrateCincoDeMayo] bit  NULL,
    [AnythingElse] bit  NULL
);
GO

-- Creating table 'HobbyTables'
CREATE TABLE [dbo].[HobbyTables] (
    [HobbyID] int IDENTITY(1,1) NOT NULL,
    [PlaySports] bit  NULL,
    [InAShow] bit  NULL,
    [Travel] bit  NULL,
    [OutdoorPerson] bit  NULL,
    [TravelAbroad] bit  NULL,
    [Passions] bit  NULL,
    [Talents] bit  NULL,
    [Trophies] bit  NULL,
    [Exercise] bit  NULL,
    [FamilyVacation] bit  NULL,
    [ChildhoodVacation] bit  NULL,
    [AnythingElse] bit  NULL
);
GO

-- Creating table 'Media'
CREATE TABLE [dbo].[Media] (
    [MediaID] int IDENTITY(1,1) NOT NULL,
    [FilePath] nvarchar(max)  NULL,
    [EventID] int  NULL
);
GO

-- Creating table 'Memories'
CREATE TABLE [dbo].[Memories] (
    [MemoryID] int IDENTITY(1,1) NOT NULL,
    [BrokenBones] bit  NULL,
    [OwnHome] bit  NULL,
    [DriversLicense] bit  NULL,
    [FirstTooth] bit  NULL,
    [PersonalNickName] bit  NULL,
    [FamilyNickName] bit  NULL,
    [RideBike] bit  NULL,
    [CommitCrime] bit  NULL,
    [BigMove] bit  NULL,
    [Vote] bit  NULL,
    [FamilyTraditions] bit  NULL,
    [EmbarrassingMoment] bit  NULL,
    [ProudestMoments] bit  NULL,
    [ChildhoodCamp] bit  NULL,
    [MemorializeSomeone] bit  NULL,
    [Concerts] bit  NULL,
    [FamilyPet] bit  NULL,
    [CurrentPet] bit  NULL,
    [HSDance] bit  NULL,
    [AnythingElse] bit  NULL
);
GO

-- Creating table 'WorldEvents'
CREATE TABLE [dbo].[WorldEvents] (
    [WorldEventID] int IDENTITY(1,1) NOT NULL,
    [September11] bit  NULL,
    [MoonLanding] bit  NULL,
    [NixonResigns] bit  NULL,
    [ElvisDies] bit  NULL,
    [ChallengerExplodes] bit  NULL,
    [WorldWar2Ends] bit  NULL,
    [KennedyDies] bit  NULL,
    [NotableElection] bit  NULL,
    [MLKAssassination] bit  NULL,
    [Y2K] bit  NULL,
    [BerlinWall] bit  NULL,
    [OJSimpsonCarChase] bit  NULL,
    [EndOfProhibition] bit  NULL,
    [AnythingElse] bit  NULL,
    [VietnamWar] bit  NULL
);
GO

-- Creating table 'Relationships'
CREATE TABLE [dbo].[Relationships] (
    [RelationshipsID] int IDENTITY(1,1) NOT NULL,
    [CurrentlyMarried] bit  NULL,
    [InARelationship] bit  NULL,
    [PreviousRomance] bit  NULL,
    [HaveChildren] bit  NULL,
    [HaveGrandchildren] bit  NULL,
    [OtherYoungsters] bit  NULL,
    [HaveParents] bit  NULL,
    [HaveGrandparents] bit  NULL,
    [OtherAdults] bit  NULL,
    [HaveSiblings] bit  NULL,
    [OtherCloseRelatives] bit  NULL,
    [GoodFriendships] bit  NULL,
    [EverythingElse] bit  NULL
);
GO

-- Creating table 'EventTables'
CREATE TABLE [dbo].[EventTables] (
    [EventID] int IDENTITY(1,1) NOT NULL,
    [DateCreated] binary(8)  NOT NULL,
    [EventTitle] nvarchar(50)  NOT NULL,
    [EventDay] int  NULL,
    [EventMonth] nvarchar(12)  NULL,
    [EventYear] int  NOT NULL,
    [PeopleInvolved] nvarchar(300)  NULL,
    [EventCaption] nvarchar(750)  NULL,
    [UploadMedia] nvarchar(max)  NULL
);
GO

-- Creating table 'UserProfiles'
CREATE TABLE [dbo].[UserProfiles] (
    [UserProfileID] int IDENTITY(1,1) NOT NULL,
    [Birthdate] datetime  NOT NULL,
    [RelationshipsID] int  NOT NULL,
    [CareerID] int  NOT NULL,
    [CelebrationID] int  NOT NULL,
    [HobbyID] int  NOT NULL,
    [MemoryID] int  NOT NULL,
    [WorldEventID] int  NOT NULL,
    [EventID] int  NOT NULL
);
GO

-- Creating table 'C__MigrationHistory'
CREATE TABLE [dbo].[C__MigrationHistory] (
    [MigrationId] nvarchar(150)  NOT NULL,
    [ContextKey] nvarchar(300)  NOT NULL,
    [Model] varbinary(max)  NOT NULL,
    [ProductVersion] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'AspNetRoles'
CREATE TABLE [dbo].[AspNetRoles] (
    [Id] nvarchar(128)  NOT NULL,
    [Name] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'AspNetUserClaims'
CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] nvarchar(128)  NOT NULL,
    [ClaimType] nvarchar(max)  NULL,
    [ClaimValue] nvarchar(max)  NULL
);
GO

-- Creating table 'AspNetUserLogins'
CREATE TABLE [dbo].[AspNetUserLogins] (
    [LoginProvider] nvarchar(128)  NOT NULL,
    [ProviderKey] nvarchar(128)  NOT NULL,
    [UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'AspNetUsers'
CREATE TABLE [dbo].[AspNetUsers] (
    [Id] nvarchar(128)  NOT NULL,
    [Email] nvarchar(256)  NULL,
    [EmailConfirmed] bit  NOT NULL,
    [PasswordHash] nvarchar(max)  NULL,
    [SecurityStamp] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [PhoneNumberConfirmed] bit  NOT NULL,
    [TwoFactorEnabled] bit  NOT NULL,
    [LockoutEndDateUtc] datetime  NULL,
    [LockoutEnabled] bit  NOT NULL,
    [AccessFailedCount] int  NOT NULL,
    [UserName] nvarchar(256)  NOT NULL
);
GO

-- Creating table 'RegisterUsers'
CREATE TABLE [dbo].[RegisterUsers] (
    [RegisterUserID] int IDENTITY(1,1) NOT NULL,
    [LoginID] int  NOT NULL,
    [Email] int  NOT NULL
);
GO

-- Creating table 'AspNetUserRoles'
CREATE TABLE [dbo].[AspNetUserRoles] (
    [AspNetRoles_Id] nvarchar(128)  NOT NULL,
    [AspNetUsers_Id] nvarchar(128)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CareerID] in table 'Careers'
ALTER TABLE [dbo].[Careers]
ADD CONSTRAINT [PK_Careers]
    PRIMARY KEY CLUSTERED ([CareerID] ASC);
GO

-- Creating primary key on [CelebrationID] in table 'Celebrations'
ALTER TABLE [dbo].[Celebrations]
ADD CONSTRAINT [PK_Celebrations]
    PRIMARY KEY CLUSTERED ([CelebrationID] ASC);
GO

-- Creating primary key on [HobbyID] in table 'HobbyTables'
ALTER TABLE [dbo].[HobbyTables]
ADD CONSTRAINT [PK_HobbyTables]
    PRIMARY KEY CLUSTERED ([HobbyID] ASC);
GO

-- Creating primary key on [MediaID] in table 'Media'
ALTER TABLE [dbo].[Media]
ADD CONSTRAINT [PK_Media]
    PRIMARY KEY CLUSTERED ([MediaID] ASC);
GO

-- Creating primary key on [MemoryID] in table 'Memories'
ALTER TABLE [dbo].[Memories]
ADD CONSTRAINT [PK_Memories]
    PRIMARY KEY CLUSTERED ([MemoryID] ASC);
GO

-- Creating primary key on [WorldEventID] in table 'WorldEvents'
ALTER TABLE [dbo].[WorldEvents]
ADD CONSTRAINT [PK_WorldEvents]
    PRIMARY KEY CLUSTERED ([WorldEventID] ASC);
GO

-- Creating primary key on [RelationshipsID] in table 'Relationships'
ALTER TABLE [dbo].[Relationships]
ADD CONSTRAINT [PK_Relationships]
    PRIMARY KEY CLUSTERED ([RelationshipsID] ASC);
GO

-- Creating primary key on [EventID] in table 'EventTables'
ALTER TABLE [dbo].[EventTables]
ADD CONSTRAINT [PK_EventTables]
    PRIMARY KEY CLUSTERED ([EventID] ASC);
GO

-- Creating primary key on [UserProfileID] in table 'UserProfiles'
ALTER TABLE [dbo].[UserProfiles]
ADD CONSTRAINT [PK_UserProfiles]
    PRIMARY KEY CLUSTERED ([UserProfileID] ASC);
GO

-- Creating primary key on [MigrationId], [ContextKey] in table 'C__MigrationHistory'
ALTER TABLE [dbo].[C__MigrationHistory]
ADD CONSTRAINT [PK_C__MigrationHistory]
    PRIMARY KEY CLUSTERED ([MigrationId], [ContextKey] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetRoles'
ALTER TABLE [dbo].[AspNetRoles]
ADD CONSTRAINT [PK_AspNetRoles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [PK_AspNetUserClaims]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [LoginProvider], [ProviderKey], [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [PK_AspNetUserLogins]
    PRIMARY KEY CLUSTERED ([LoginProvider], [ProviderKey], [UserId] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUsers'
ALTER TABLE [dbo].[AspNetUsers]
ADD CONSTRAINT [PK_AspNetUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [RegisterUserID] in table 'RegisterUsers'
ALTER TABLE [dbo].[RegisterUsers]
ADD CONSTRAINT [PK_RegisterUsers]
    PRIMARY KEY CLUSTERED ([RegisterUserID] ASC);
GO

-- Creating primary key on [AspNetRoles_Id], [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [PK_AspNetUserRoles]
    PRIMARY KEY CLUSTERED ([AspNetRoles_Id], [AspNetUsers_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EventID] in table 'Media'
ALTER TABLE [dbo].[Media]
ADD CONSTRAINT [FK_Media_EventTable]
    FOREIGN KEY ([EventID])
    REFERENCES [dbo].[EventTables]
        ([EventID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Media_EventTable'
CREATE INDEX [IX_FK_Media_EventTable]
ON [dbo].[Media]
    ([EventID]);
GO

-- Creating foreign key on [CareerID] in table 'UserProfiles'
ALTER TABLE [dbo].[UserProfiles]
ADD CONSTRAINT [FK_UserProfile_Career]
    FOREIGN KEY ([CareerID])
    REFERENCES [dbo].[Careers]
        ([CareerID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProfile_Career'
CREATE INDEX [IX_FK_UserProfile_Career]
ON [dbo].[UserProfiles]
    ([CareerID]);
GO

-- Creating foreign key on [CelebrationID] in table 'UserProfiles'
ALTER TABLE [dbo].[UserProfiles]
ADD CONSTRAINT [FK_UserProfile_Celebration]
    FOREIGN KEY ([CelebrationID])
    REFERENCES [dbo].[Celebrations]
        ([CelebrationID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProfile_Celebration'
CREATE INDEX [IX_FK_UserProfile_Celebration]
ON [dbo].[UserProfiles]
    ([CelebrationID]);
GO

-- Creating foreign key on [EventID] in table 'UserProfiles'
ALTER TABLE [dbo].[UserProfiles]
ADD CONSTRAINT [FK_UserProfile_EventTable]
    FOREIGN KEY ([EventID])
    REFERENCES [dbo].[EventTables]
        ([EventID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProfile_EventTable'
CREATE INDEX [IX_FK_UserProfile_EventTable]
ON [dbo].[UserProfiles]
    ([EventID]);
GO

-- Creating foreign key on [HobbyID] in table 'UserProfiles'
ALTER TABLE [dbo].[UserProfiles]
ADD CONSTRAINT [FK_UserProfile_HobbyTable]
    FOREIGN KEY ([HobbyID])
    REFERENCES [dbo].[HobbyTables]
        ([HobbyID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProfile_HobbyTable'
CREATE INDEX [IX_FK_UserProfile_HobbyTable]
ON [dbo].[UserProfiles]
    ([HobbyID]);
GO

-- Creating foreign key on [MemoryID] in table 'UserProfiles'
ALTER TABLE [dbo].[UserProfiles]
ADD CONSTRAINT [FK_UserProfile_Memories]
    FOREIGN KEY ([MemoryID])
    REFERENCES [dbo].[Memories]
        ([MemoryID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProfile_Memories'
CREATE INDEX [IX_FK_UserProfile_Memories]
ON [dbo].[UserProfiles]
    ([MemoryID]);
GO

-- Creating foreign key on [RelationshipsID] in table 'UserProfiles'
ALTER TABLE [dbo].[UserProfiles]
ADD CONSTRAINT [FK_UserProfile_Relationship]
    FOREIGN KEY ([RelationshipsID])
    REFERENCES [dbo].[Relationships]
        ([RelationshipsID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProfile_Relationship'
CREATE INDEX [IX_FK_UserProfile_Relationship]
ON [dbo].[UserProfiles]
    ([RelationshipsID]);
GO

-- Creating foreign key on [WorldEventID] in table 'UserProfiles'
ALTER TABLE [dbo].[UserProfiles]
ADD CONSTRAINT [FK_UserProfile_WorldEvents]
    FOREIGN KEY ([WorldEventID])
    REFERENCES [dbo].[WorldEvents]
        ([WorldEventID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProfile_WorldEvents'
CREATE INDEX [IX_FK_UserProfile_WorldEvents]
ON [dbo].[UserProfiles]
    ([WorldEventID]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserClaims]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserLogins]
    ([UserId]);
GO

-- Creating foreign key on [AspNetRoles_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetRole]
    FOREIGN KEY ([AspNetRoles_Id])
    REFERENCES [dbo].[AspNetRoles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [AspNetUsers_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_AspNetUserRoles_AspNetUser]
    FOREIGN KEY ([AspNetUsers_Id])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AspNetUserRoles_AspNetUser'
CREATE INDEX [IX_FK_AspNetUserRoles_AspNetUser]
ON [dbo].[AspNetUserRoles]
    ([AspNetUsers_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------