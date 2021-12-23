CREATE TABLE [dbo].[Employers] (
    [EmployerId]          INT            NOT NULL,
    [UserID]              INT            NOT NULL,
    [EmployerName]        NVARCHAR (20)  NOT NULL,
    [EmployerSurname]     NVARCHAR (20)  NOT NULL,
    [EmployerTitle]       NVARCHAR (20)  NULL,
    [EmployerLocation]    NVARCHAR (20)  NULL,
    [EmployerPhoneNumber] INT            NULL,
    [EmployerEMail]       NVARCHAR (40)  NULL,
    [EmployerWebSite]     NVARCHAR (30)  NULL,
    [EmployerAboutMe]     NVARCHAR (200) NULL,
    [EmployerPhoto]       IMAGE          NULL,
    [EmployerResume]      NVARCHAR (30)  NULL,
    PRIMARY KEY CLUSTERED ([EmployerId] ASC)
);
GO
CREATE TABLE [dbo].[ApplicationJobs] (

    [ApplicationJobId]	INT	NOT NULL, --pk
    [JobId]				INT	NOT NULL, --fk
    [EmployerId]        INT	NOT NULL, --fk
    [ApplicationJobStatus]     NVARCHAR (20)  NOT NULL,

);
GO

CREATE TABLE [dbo].[Certificates] (

    [CertificateId]	INT	NOT NULL, --pk
    [EmployerId]        INT	NOT NULL, --fk
    [CertificateTitle]     NVARCHAR (20)  NOT NULL,
    [CertificateDescription]     NVARCHAR (50)  NOT NULL,

);
GO

CREATE TABLE [dbo].[Companies] (
    [CompanyId]          INT            NOT NULL, --pk
    [UserID]              INT            NOT NULL, --fk
    [SectorId]        INT  NOT NULL, --fk
    [CompanyName]     NVARCHAR (20)  NOT NULL,
    [CompanyLocation]       NVARCHAR (20)  NULL,
    [CompanyPhoneNumber] INT            NULL,
    [CompanyEMail]       NVARCHAR (40)  NULL,
    [CompanyWebSite]     NVARCHAR (30)  NULL,
    [CompanyDescription]     NVARCHAR (200) NULL,
    [CompanyPhoto]     NVARCHAR (200) NULL,
);
GO

CREATE TABLE [dbo].[Educations] (
    [EducationId]          INT            NOT NULL, --pk
    [EmployerId]              INT            NOT NULL, --fk
    [EducationSchool]     NVARCHAR (20)  NULL,
    [EducationDegree]       NVARCHAR (20)  NULL,
    [EducationStudy] NVARCHAR (20)  NULL,
    [EducationStartingDate]  DATETIME  NULL,
    [EducationEndingDate]     DATETIME  NULL,
    --[EducationCurrentStatus]  boolean NULL,
    CONSTRAINT [PK_Educations] PRIMARY KEY ([EducationId])
);
GO

CREATE TABLE [dbo].[Users] (

    [UserId]	INT	NOT NULL, --pk
    [UserCategory]     NVARCHAR (20)  NOT NULL,

);
GO

CREATE TABLE [dbo].[Skills] (

    [SkillId]	INT	NOT NULL, --pk
    [SkillName]     NVARCHAR (20)  NOT NULL,

);
GO

CREATE TABLE [dbo].[Sectors] (

    [SectorId]	INT	NOT NULL, --pk
    [SectorName]     NVARCHAR (20)  NOT NULL,

);
GO

CREATE TABLE [dbo].[SaveSkills] (

    [SaveSkillId]	INT	NOT NULL, --pk
    [SectorId]	INT	NOT NULL, --fk
    [EmployerId]	INT	NOT NULL, --fk

);
GO

CREATE TABLE [dbo].[Projects] (
    [ProjectId]          INT            NOT NULL, --pk
    [EmployerId]              INT            NOT NULL, --fk
    [ProjectName]     NVARCHAR (20) NOT NULL,
    [ProjectStartingDate]  DATETIME  NULL,
    [ProjectEndingDate]     DATETIME  NULL,
    [ProjectCurrentStatus]  NVARCHAR (20) NULL, 
    [ProjectUrl]     NVARCHAR (30)  NULL,
    [ProjectDescription]     NVARCHAR (200) NULL,
);
GO

CREATE TABLE [dbo].[FavoriteJobs] (

    [FavoriteJobId]	INT	NOT NULL, --pk
    [JobId]	INT	NOT NULL, --fk
    [EmployerId]	INT	NOT NULL, --fk

);
GO

CREATE TABLE [dbo].[Jobs] (

    [JobId]	INT	NOT NULL, --pk
    [CompanyId]	INT	NOT NULL, --fk
    [JobName]     NVARCHAR (20) NOT NULL,
	[JobDescription]     NVARCHAR (200) NULL,
	[JobSalary]     INT NULL,
);
GO

CREATE TABLE [dbo].[Experience] (
    [ExperienceId]          INT            NOT NULL, --pk
    [EmployerId]              INT            NOT NULL, --fk
    [ExperienceTitle]     NVARCHAR (20) NOT NULL,
    [ExperienceCompanyName]     NVARCHAR (20) NOT NULL,
    [ExperienceLocation]     NVARCHAR (20) NOT NULL,
    [ExperienceStartingDate]  DATETIME  NULL,
    [ExperienceEndingDate]     DATETIME  NULL,
    [ExperienceCurrentStatus]   NVARCHAR (20)NULL,
    [ExperienceDescription]     NVARCHAR (200) NULL,
);
GO