
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/17/2015 12:17:53
-- Generated from EDMX file: C:\hr_git\hrapp\test2\HRAPP.EF\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [shrapp_db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CriteriaCategoryCriteriaCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriterionCategories] DROP CONSTRAINT [FK_CriteriaCategoryCriteriaCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_CriterionCriteriaCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Criteria] DROP CONSTRAINT [FK_CriterionCriteriaCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_CriterionCriterionType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Criteria] DROP CONSTRAINT [FK_CriterionCriterionType];
GO
IF OBJECT_ID(N'[dbo].[FK_TestTestType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tests] DROP CONSTRAINT [FK_TestTestType];
GO
IF OBJECT_ID(N'[dbo].[FK_TestItemTest]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TestItems] DROP CONSTRAINT [FK_TestItemTest];
GO
IF OBJECT_ID(N'[dbo].[FK_TestItemTestValue]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TestValues] DROP CONSTRAINT [FK_TestItemTestValue];
GO
IF OBJECT_ID(N'[dbo].[FK_CriterionCriterionValues]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CriterionValues] DROP CONSTRAINT [FK_CriterionCriterionValues];
GO
IF OBJECT_ID(N'[dbo].[FK_CreterionTestCriterion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CreterionTests] DROP CONSTRAINT [FK_CreterionTestCriterion];
GO
IF OBJECT_ID(N'[dbo].[FK_TestCreterionTest]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CreterionTests] DROP CONSTRAINT [FK_TestCreterionTest];
GO
IF OBJECT_ID(N'[dbo].[FK_GroupCompany]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Groups] DROP CONSTRAINT [FK_GroupCompany];
GO
IF OBJECT_ID(N'[dbo].[FK_EmploeeCriterionEmploee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmploeeCriterions] DROP CONSTRAINT [FK_EmploeeCriterionEmploee];
GO
IF OBJECT_ID(N'[dbo].[FK_EmploeeCriterionCriterion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmploeeCriterions] DROP CONSTRAINT [FK_EmploeeCriterionCriterion];
GO
IF OBJECT_ID(N'[dbo].[FK_EmploeeGroupGroup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmploeeGroups] DROP CONSTRAINT [FK_EmploeeGroupGroup];
GO
IF OBJECT_ID(N'[dbo].[FK_EmploeeGroupEmploee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmploeeGroups] DROP CONSTRAINT [FK_EmploeeGroupEmploee];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Criteria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Criteria];
GO
IF OBJECT_ID(N'[dbo].[CriterionCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CriterionCategories];
GO
IF OBJECT_ID(N'[dbo].[CriterionValues]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CriterionValues];
GO
IF OBJECT_ID(N'[dbo].[CriterionTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CriterionTypes];
GO
IF OBJECT_ID(N'[dbo].[Tests]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tests];
GO
IF OBJECT_ID(N'[dbo].[TestValues]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TestValues];
GO
IF OBJECT_ID(N'[dbo].[TestTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TestTypes];
GO
IF OBJECT_ID(N'[dbo].[TestItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TestItems];
GO
IF OBJECT_ID(N'[dbo].[CreterionTests]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CreterionTests];
GO
IF OBJECT_ID(N'[dbo].[Emploees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Emploees];
GO
IF OBJECT_ID(N'[dbo].[EmploeeCriterions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmploeeCriterions];
GO
IF OBJECT_ID(N'[dbo].[Groups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Groups];
GO
IF OBJECT_ID(N'[dbo].[EmploeeGroups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmploeeGroups];
GO
IF OBJECT_ID(N'[dbo].[Companies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Companies];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Criteria'
CREATE TABLE [dbo].[Criteria] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CategoryId] int  NOT NULL,
    [TypeId] int  NOT NULL
);
GO

-- Creating table 'CriterionCategories'
CREATE TABLE [dbo].[CriterionCategories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CategoryId] int  NOT NULL
);
GO

-- Creating table 'CriterionValues'
CREATE TABLE [dbo].[CriterionValues] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CriterionId] int  NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [Sort] smallint  NOT NULL
);
GO

-- Creating table 'CriterionTypes1'
CREATE TABLE [dbo].[CriterionTypes1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tests'
CREATE TABLE [dbo].[Tests] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [TypeId] int  NOT NULL
);
GO

-- Creating table 'TestValues'
CREATE TABLE [dbo].[TestValues] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [TestItemId] int  NOT NULL,
    [Sort] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TestTypes'
CREATE TABLE [dbo].[TestTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TestItems'
CREATE TABLE [dbo].[TestItems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [TestId] int  NOT NULL,
    [Sort] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CreterionTests'
CREATE TABLE [dbo].[CreterionTests] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CriterionId] int  NOT NULL,
    [TestId] int  NOT NULL
);
GO

-- Creating table 'Emploees'
CREATE TABLE [dbo].[Emploees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EmploeeCriterions'
CREATE TABLE [dbo].[EmploeeCriterions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EmploeeId] int  NOT NULL,
    [CriterionId] int  NOT NULL,
    [Value] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Groups'
CREATE TABLE [dbo].[Groups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CompanyId] int  NOT NULL
);
GO

-- Creating table 'EmploeeGroups'
CREATE TABLE [dbo].[EmploeeGroups] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EmploeeId] int  NOT NULL,
    [GroupId] int  NOT NULL
);
GO

-- Creating table 'Companies'
CREATE TABLE [dbo].[Companies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Site] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'Positions'
CREATE TABLE [dbo].[Positions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CompanyId] int  NOT NULL
);
GO

-- Creating table 'EmploeePositions'
CREATE TABLE [dbo].[EmploeePositions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EmploeeId] int  NOT NULL,
    [PositionId] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Criteria'
ALTER TABLE [dbo].[Criteria]
ADD CONSTRAINT [PK_Criteria]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CriterionCategories'
ALTER TABLE [dbo].[CriterionCategories]
ADD CONSTRAINT [PK_CriterionCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CriterionValues'
ALTER TABLE [dbo].[CriterionValues]
ADD CONSTRAINT [PK_CriterionValues]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CriterionTypes1'
ALTER TABLE [dbo].[CriterionTypes1]
ADD CONSTRAINT [PK_CriterionTypes1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tests'
ALTER TABLE [dbo].[Tests]
ADD CONSTRAINT [PK_Tests]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TestValues'
ALTER TABLE [dbo].[TestValues]
ADD CONSTRAINT [PK_TestValues]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TestTypes'
ALTER TABLE [dbo].[TestTypes]
ADD CONSTRAINT [PK_TestTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TestItems'
ALTER TABLE [dbo].[TestItems]
ADD CONSTRAINT [PK_TestItems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CreterionTests'
ALTER TABLE [dbo].[CreterionTests]
ADD CONSTRAINT [PK_CreterionTests]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Emploees'
ALTER TABLE [dbo].[Emploees]
ADD CONSTRAINT [PK_Emploees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmploeeCriterions'
ALTER TABLE [dbo].[EmploeeCriterions]
ADD CONSTRAINT [PK_EmploeeCriterions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Groups'
ALTER TABLE [dbo].[Groups]
ADD CONSTRAINT [PK_Groups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmploeeGroups'
ALTER TABLE [dbo].[EmploeeGroups]
ADD CONSTRAINT [PK_EmploeeGroups]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [PK_Companies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Positions'
ALTER TABLE [dbo].[Positions]
ADD CONSTRAINT [PK_Positions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmploeePositions'
ALTER TABLE [dbo].[EmploeePositions]
ADD CONSTRAINT [PK_EmploeePositions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CategoryId] in table 'CriterionCategories'
ALTER TABLE [dbo].[CriterionCategories]
ADD CONSTRAINT [FK_CriteriaCategoryCriteriaCategory]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[CriterionCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CriteriaCategoryCriteriaCategory'
CREATE INDEX [IX_FK_CriteriaCategoryCriteriaCategory]
ON [dbo].[CriterionCategories]
    ([CategoryId]);
GO

-- Creating foreign key on [CategoryId] in table 'Criteria'
ALTER TABLE [dbo].[Criteria]
ADD CONSTRAINT [FK_CriterionCriteriaCategory]
    FOREIGN KEY ([CategoryId])
    REFERENCES [dbo].[CriterionCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CriterionCriteriaCategory'
CREATE INDEX [IX_FK_CriterionCriteriaCategory]
ON [dbo].[Criteria]
    ([CategoryId]);
GO

-- Creating foreign key on [TypeId] in table 'Criteria'
ALTER TABLE [dbo].[Criteria]
ADD CONSTRAINT [FK_CriterionCriterionType]
    FOREIGN KEY ([TypeId])
    REFERENCES [dbo].[CriterionTypes1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CriterionCriterionType'
CREATE INDEX [IX_FK_CriterionCriterionType]
ON [dbo].[Criteria]
    ([TypeId]);
GO

-- Creating foreign key on [TypeId] in table 'Tests'
ALTER TABLE [dbo].[Tests]
ADD CONSTRAINT [FK_TestTestType]
    FOREIGN KEY ([TypeId])
    REFERENCES [dbo].[TestTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TestTestType'
CREATE INDEX [IX_FK_TestTestType]
ON [dbo].[Tests]
    ([TypeId]);
GO

-- Creating foreign key on [TestId] in table 'TestItems'
ALTER TABLE [dbo].[TestItems]
ADD CONSTRAINT [FK_TestItemTest]
    FOREIGN KEY ([TestId])
    REFERENCES [dbo].[Tests]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TestItemTest'
CREATE INDEX [IX_FK_TestItemTest]
ON [dbo].[TestItems]
    ([TestId]);
GO

-- Creating foreign key on [TestItemId] in table 'TestValues'
ALTER TABLE [dbo].[TestValues]
ADD CONSTRAINT [FK_TestItemTestValue]
    FOREIGN KEY ([TestItemId])
    REFERENCES [dbo].[TestItems]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TestItemTestValue'
CREATE INDEX [IX_FK_TestItemTestValue]
ON [dbo].[TestValues]
    ([TestItemId]);
GO

-- Creating foreign key on [CriterionId] in table 'CriterionValues'
ALTER TABLE [dbo].[CriterionValues]
ADD CONSTRAINT [FK_CriterionCriterionValues]
    FOREIGN KEY ([CriterionId])
    REFERENCES [dbo].[Criteria]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CriterionCriterionValues'
CREATE INDEX [IX_FK_CriterionCriterionValues]
ON [dbo].[CriterionValues]
    ([CriterionId]);
GO

-- Creating foreign key on [CriterionId] in table 'CreterionTests'
ALTER TABLE [dbo].[CreterionTests]
ADD CONSTRAINT [FK_CreterionTestCriterion]
    FOREIGN KEY ([CriterionId])
    REFERENCES [dbo].[Criteria]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CreterionTestCriterion'
CREATE INDEX [IX_FK_CreterionTestCriterion]
ON [dbo].[CreterionTests]
    ([CriterionId]);
GO

-- Creating foreign key on [TestId] in table 'CreterionTests'
ALTER TABLE [dbo].[CreterionTests]
ADD CONSTRAINT [FK_TestCreterionTest]
    FOREIGN KEY ([TestId])
    REFERENCES [dbo].[Tests]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TestCreterionTest'
CREATE INDEX [IX_FK_TestCreterionTest]
ON [dbo].[CreterionTests]
    ([TestId]);
GO

-- Creating foreign key on [CompanyId] in table 'Groups'
ALTER TABLE [dbo].[Groups]
ADD CONSTRAINT [FK_GroupCompany]
    FOREIGN KEY ([CompanyId])
    REFERENCES [dbo].[Companies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GroupCompany'
CREATE INDEX [IX_FK_GroupCompany]
ON [dbo].[Groups]
    ([CompanyId]);
GO

-- Creating foreign key on [EmploeeId] in table 'EmploeeCriterions'
ALTER TABLE [dbo].[EmploeeCriterions]
ADD CONSTRAINT [FK_EmploeeCriterionEmploee]
    FOREIGN KEY ([EmploeeId])
    REFERENCES [dbo].[Emploees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmploeeCriterionEmploee'
CREATE INDEX [IX_FK_EmploeeCriterionEmploee]
ON [dbo].[EmploeeCriterions]
    ([EmploeeId]);
GO

-- Creating foreign key on [CriterionId] in table 'EmploeeCriterions'
ALTER TABLE [dbo].[EmploeeCriterions]
ADD CONSTRAINT [FK_EmploeeCriterionCriterion]
    FOREIGN KEY ([CriterionId])
    REFERENCES [dbo].[Criteria]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmploeeCriterionCriterion'
CREATE INDEX [IX_FK_EmploeeCriterionCriterion]
ON [dbo].[EmploeeCriterions]
    ([CriterionId]);
GO

-- Creating foreign key on [GroupId] in table 'EmploeeGroups'
ALTER TABLE [dbo].[EmploeeGroups]
ADD CONSTRAINT [FK_EmploeeGroupGroup]
    FOREIGN KEY ([GroupId])
    REFERENCES [dbo].[Groups]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmploeeGroupGroup'
CREATE INDEX [IX_FK_EmploeeGroupGroup]
ON [dbo].[EmploeeGroups]
    ([GroupId]);
GO

-- Creating foreign key on [EmploeeId] in table 'EmploeeGroups'
ALTER TABLE [dbo].[EmploeeGroups]
ADD CONSTRAINT [FK_EmploeeGroupEmploee]
    FOREIGN KEY ([EmploeeId])
    REFERENCES [dbo].[Emploees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmploeeGroupEmploee'
CREATE INDEX [IX_FK_EmploeeGroupEmploee]
ON [dbo].[EmploeeGroups]
    ([EmploeeId]);
GO

-- Creating foreign key on [CompanyId] in table 'Positions'
ALTER TABLE [dbo].[Positions]
ADD CONSTRAINT [FK_CompanyPosition]
    FOREIGN KEY ([CompanyId])
    REFERENCES [dbo].[Companies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyPosition'
CREATE INDEX [IX_FK_CompanyPosition]
ON [dbo].[Positions]
    ([CompanyId]);
GO

-- Creating foreign key on [EmploeeId] in table 'EmploeePositions'
ALTER TABLE [dbo].[EmploeePositions]
ADD CONSTRAINT [FK_EmploeeEmploeePosition]
    FOREIGN KEY ([EmploeeId])
    REFERENCES [dbo].[Emploees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmploeeEmploeePosition'
CREATE INDEX [IX_FK_EmploeeEmploeePosition]
ON [dbo].[EmploeePositions]
    ([EmploeeId]);
GO

-- Creating foreign key on [PositionId] in table 'EmploeePositions'
ALTER TABLE [dbo].[EmploeePositions]
ADD CONSTRAINT [FK_EmploeePositionPosition]
    FOREIGN KEY ([PositionId])
    REFERENCES [dbo].[Positions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmploeePositionPosition'
CREATE INDEX [IX_FK_EmploeePositionPosition]
ON [dbo].[EmploeePositions]
    ([PositionId]);
GO

-- Creating foreign key on [UserId] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [FK_UserCompany]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCompany'
CREATE INDEX [IX_FK_UserCompany]
ON [dbo].[Companies]
    ([UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------