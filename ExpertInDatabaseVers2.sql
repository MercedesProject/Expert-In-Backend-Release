--CREATE 
CREATE TABLE [dbo].[ApplicationJobs] (
    [ApplicationJobId]     INT           NOT NULL IDENTITY,
    [JobId]                INT           NOT NULL,
    [EmployerId]           INT           NOT NULL,
    [ApplicationJobStatus] NVARCHAR (20) NOT NULL, 
    CONSTRAINT [PK_ApplicationJobs] PRIMARY KEY ([ApplicationJobId])
);

GO

CREATE TABLE [dbo].[Jobs] (
    [JobId]          INT            NOT NULL IDENTITY,
    [CompanyId]      INT            NOT NULL,
    [JobName]        NVARCHAR (20)  NOT NULL,
    [JobDescription] NVARCHAR (200) NULL,
    [JobSalary]      INT            NULL, 
    [JobForm]	 NVARCHAR(50) NULL, 
    [JobType] 	NVARCHAR(50) NULL,
    CONSTRAINT [PK_Jobs] PRIMARY KEY ([JobId])
);

GO


CREATE TABLE [dbo].[UserTypes] (
    [UserTypeCategory] NVARCHAR (20) NOT NULL,
    [UserTypeId]       INT           NOT NULL IDENTITY,
    CONSTRAINT [PK_UserTypes] PRIMARY KEY CLUSTERED ([UserTypeId] ASC)
);

GO

CREATE TABLE [dbo].[Employers] (
    [EmployerId]          INT            NOT NULL IDENTITY,
    [UserTypeId]              INT            NOT NULL,
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
    CONSTRAINT [PK_Employers] PRIMARY KEY CLUSTERED ([EmployerId] ASC)
);

GO

CREATE TABLE [dbo].[Sectors] (
    [SectorId]   INT           NOT NULL IDENTITY,
    [SectorName] NVARCHAR (20) NOT NULL, 
    CONSTRAINT [PK_Sectors] PRIMARY KEY ([SectorId])
);

GO

CREATE TABLE [dbo].[Companies] (
    [CompanyId]          INT            NOT NULL IDENTITY,
    [UserTypeId]             INT            NOT NULL,
    [SectorId]           INT            NOT NULL,
    [CompanyName]        NVARCHAR (20)  NOT NULL,
    [CompanyLocation]    NVARCHAR (20)  NULL,
    [CompanyPhoneNumber] INT            NULL,
    [CompanyEMail]       NVARCHAR (40)  NULL,
    [CompanyWebSite]     NVARCHAR (30)  NULL,
    [CompanyDescription] NVARCHAR (200) NULL,
    [CompanyPhoto]       NVARCHAR (200) NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED ([CompanyId] ASC)
);

GO

CREATE TABLE [dbo].[Certificates] (
    [CertificateId]          INT           NOT NULL IDENTITY,
    [EmployerId]             INT           NOT NULL,
    [CertificateTitle]       NVARCHAR (20) NOT NULL,
    [CertificateDescription] NVARCHAR (50) NOT NULL, 
    CONSTRAINT [PK_Certificates] PRIMARY KEY ([CertificateId])
);

GO

CREATE TABLE [dbo].[Educations] (
    [EducationId]           INT           NOT NULL IDENTITY,
    [EmployerId]            INT           NOT NULL,
    [EducationSchool]       NVARCHAR (20) NULL,
    [EducationDegree]       NVARCHAR (20) NULL,
    [EducationStudy]        NVARCHAR (20) NULL,
    [EducationStartingDate] DATETIME      NULL,
    [EducationEndingDate]   DATETIME      NULL,
    CONSTRAINT [PK_Educations] PRIMARY KEY CLUSTERED ([EducationId] ASC)
);

GO

CREATE TABLE [dbo].[Experience] (
    [ExperienceId]            INT            NOT NULL IDENTITY,
    [EmployerId]              INT            NOT NULL,
    [ExperienceTitle]         NVARCHAR (20)  NOT NULL,
    [ExperienceCompanyName]   NVARCHAR (20)  NOT NULL,
    [ExperienceLocation]      NVARCHAR (20)  NOT NULL,
    [ExperienceStartingDate]  DATETIME       NULL,
    [ExperienceEndingDate]    DATETIME       NULL,
    [ExperienceCurrentStatus] NVARCHAR (20)  NULL,
    [ExperienceDescription]   NVARCHAR (200) NULL, 
    CONSTRAINT [PK_Experience] PRIMARY KEY ([ExperienceId])
);

GO

CREATE TABLE [dbo].[FavoriteJobs] (
    [FavoriteJobId] INT NOT NULL IDENTITY,
    [JobId]         INT NOT NULL,
    [EmployerId]    INT NOT NULL, 
    CONSTRAINT [PK_FavoriteJobs] PRIMARY KEY ([FavoriteJobId])
);

GO

CREATE TABLE [dbo].[Projects] (
    [ProjectId]            INT            NOT NULL IDENTITY,
    [EmployerId]           INT            NOT NULL,
    [ProjectName]          NVARCHAR (20)  NOT NULL,
    [ProjectStartingDate]  DATETIME       NULL,
    [ProjectEndingDate]    DATETIME       NULL,
    [ProjectCurrentStatus] NVARCHAR (20)  NULL,
    [ProjectUrl]           NVARCHAR (30)  NULL,
    [ProjectDescription]   NVARCHAR (200) NULL, 
    CONSTRAINT [PK_Projects] PRIMARY KEY ([ProjectId])
);

GO

CREATE TABLE [dbo].[SaveSkills] (
    [SaveSkillId] INT NOT NULL IDENTITY,
    [SectorId]    INT NOT NULL,
    [EmployerId]  INT NOT NULL, 
    CONSTRAINT [PK_SaveSkills] PRIMARY KEY ([SaveSkillId])
);

GO

CREATE TABLE [dbo].[Skills] (
    [SkillId]   INT           NOT NULL IDENTITY,
    [SkillName] NVARCHAR (20) NOT NULL, 
    CONSTRAINT [PK_Skills] PRIMARY KEY ([SkillId])
);

GO

CREATE TABLE [dbo].[UserOperationClaims]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserId] INT NOT NULL, 
    [OperationClaimId] INT NOT NULL IDENTITY
)

GO


CREATE TABLE [dbo].[OperationClaims]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(250) NOT NULL
)

GO


CREATE TABLE [dbo].[Users] (
    [Id]       INT           NOT NULL IDENTITY,
    [FirstName] VARCHAR(50) NOT NULL,
    [LastName] VARCHAR(50)  NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [PasswordHash] VARBINARY(500) NOT NULL, 
    [PasswordSalt] VARBINARY(500) NOT NULL, 
    [Status] BIT NOT NULL, 
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED  ([Id] ASC)
);


GO
--FOREIGN KEY
--applicationjobs
ALTER TABLE [ApplicationJobs]
ADD CONSTRAINT [FK_ApplicationJobs_Employers] FOREIGN KEY (EmployerId) REFERENCES Employers(EmployerId) ;

GO

ALTER TABLE [ApplicationJobs]
ADD CONSTRAINT [FK_ApplicationJobs_Jobs] FOREIGN KEY (JobId) REFERENCES Jobs(JobId) ;

GO

--jobs
ALTER TABLE [Jobs]
ADD CONSTRAINT [FK_Jobs_Companies] FOREIGN KEY (CompanyId) REFERENCES Companies(CompanyId)

GO

--empl
ALTER TABLE [Employers] 
ADD CONSTRAINT [FK_Employers_UserTypes] FOREIGN KEY ([UserTypeId]) REFERENCES [dbo].[UserTypes] ([UserTypeId])

GO

--comp
ALTER TABLE [Companies]  
ADD CONSTRAINT [FK_Companies_Sectors] FOREIGN KEY ([SectorId]) REFERENCES [dbo].[Sectors] ([SectorId])

GO

ALTER TABLE [Companies]  
ADD CONSTRAINT [FK_Companies_UserTypes] FOREIGN KEY ([UserTypeId]) REFERENCES [dbo].[UserTypes] ([UserTypeId])

GO

--[Certificates] 				
ALTER TABLE [Certificates] 
ADD CONSTRAINT [FK_Certificates_Employers] FOREIGN KEY ([EmployerId]) REFERENCES [Employers]([EmployerId])

GO

--[Educations] 
ALTER TABLE [Educations]  
ADD CONSTRAINT [FK_Educations_Employers] FOREIGN KEY (EmployerId) REFERENCES Employers(EmployerId)

GO

--[Experience] 
ALTER TABLE [Experience]   
ADD CONSTRAINT [FK_Experience_Employers] FOREIGN KEY (EmployerId) REFERENCES Employers(EmployerId)

GO

--[FavoriteJobs] 
ALTER TABLE [FavoriteJobs]  
ADD CONSTRAINT [FK_FavoriteJobs_Employers] FOREIGN KEY ([EmployerId]) REFERENCES [Employers]([EmployerId])

GO

--[Projects] 
ALTER TABLE [Projects]    
ADD CONSTRAINT [FK_Projects_Employers] FOREIGN KEY ([EmployerId]) REFERENCES [Employers]([EmployerId])

GO

--[SaveSkills] 
ALTER TABLE [SaveSkills]    
ADD CONSTRAINT [FK_SaveSkills_Sectors] FOREIGN KEY ([SectorId]) REFERENCES [Sectors]([SectorId])

GO

ALTER TABLE [SaveSkills]    
ADD CONSTRAINT [FK_SaveSkills_Employers] FOREIGN KEY ([EmployerId]) REFERENCES [Employers]([EmployerId])

GO

--INSERT
INSERT INTO UserTypes VALUES('employers')
INSERT INTO UserTypes VALUES('company')
INSERT INTO Employers VALUES(1,'Tugba','Oguncmert','Ogrenci','Istanbul',4605408,'tugba@gmail.com','tugba.com.tr','helloworld',null,null)
INSERT INTO Employers VALUES(1,'Busra','Sari','Ogrenci','Istanbul',0843723,'busra@gmail.com','busra.com.tr','hellopurple',null,null)
INSERT INTO Sectors VALUES ('teknoloji')
INSERT INTO Companies VALUES(2,1,'Mercedes','Istanbul',null,null,null,null,null)
INSERT INTO Jobs VALUES (1,'Developer','developerarıyorum','1000','Remote','Junior Frontend developer')

--SELECT
SELECT * FROM Employers
SELECT * FROM Sectors
SELECT * FROM UserTypes
SELECT * FROM Companies
SELECT * FROM Jobs
