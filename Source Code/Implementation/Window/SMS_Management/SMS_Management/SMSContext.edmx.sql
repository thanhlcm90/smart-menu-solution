
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/08/2012 11:28:22
-- Generated from EDMX file: D:\My Documents\Hoc tap\Do an\smart-menu-solution\Source Code\Implementation\Window\SMS_Management\SMS_Management\SMSContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SMS_Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BILLING]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BILLING];
GO
IF OBJECT_ID(N'[dbo].[BILLING_DETAIL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BILLING_DETAIL];
GO
IF OBJECT_ID(N'[dbo].[CHEF_INFO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CHEF_INFO];
GO
IF OBJECT_ID(N'[dbo].[CURENCY_TYPE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CURENCY_TYPE];
GO
IF OBJECT_ID(N'[dbo].[DISH_TYPE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DISH_TYPE];
GO
IF OBJECT_ID(N'[dbo].[STATUS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[STATUS];
GO
IF OBJECT_ID(N'[dbo].[TABLES_INFO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TABLES_INFO];
GO
IF OBJECT_ID(N'[dbo].[WAITER_INFO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WAITER_INFO];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CHEF_INFO'
CREATE TABLE [dbo].[CHEF_INFO] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(50)  NOT NULL,
    [BIRTHDAY] datetime  NULL,
    [PHONE] nchar(15)  NULL,
    [ADDRESS] nvarchar(250)  NULL
);
GO

-- Creating table 'CURENCY_TYPE'
CREATE TABLE [dbo].[CURENCY_TYPE] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(250)  NOT NULL
);
GO

-- Creating table 'DISHes'
CREATE TABLE [dbo].[DISHes] (
    [Id] uniqueidentifier  NOT NULL,
    [CODE] nchar(3)  NOT NULL,
    [NAME_VN] nvarchar(250)  NOT NULL,
    [NAME_EN] nvarchar(250)  NULL,
    [DISHTYPE_ID] uniqueidentifier  NOT NULL,
    [PRICE] decimal(18,0)  NOT NULL,
    [CURENCYTYPE_ID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'DISH_TYPE'
CREATE TABLE [dbo].[DISH_TYPE] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(250)  NOT NULL
);
GO

-- Creating table 'PROCESSINGs'
CREATE TABLE [dbo].[PROCESSINGs] (
    [Id] uniqueidentifier  NOT NULL,
    [DISH_ID] uniqueidentifier  NOT NULL,
    [PRIORITY] int  NOT NULL,
    [AMOUNT] int  NOT NULL,
    [STATUS_ID] uniqueidentifier  NOT NULL,
    [COMMENT] nvarchar(250)  NULL,
    [TALBLE_ID] uniqueidentifier  NOT NULL,
    [CHEF_ID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'STATUS'
CREATE TABLE [dbo].[STATUS] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(250)  NOT NULL
);
GO

-- Creating table 'TABLES_INFO'
CREATE TABLE [dbo].[TABLES_INFO] (
    [Id] uniqueidentifier  NOT NULL,
    [CODE] nchar(2)  NOT NULL,
    [WAITER_ID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'WAITER_INFO'
CREATE TABLE [dbo].[WAITER_INFO] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(50)  NOT NULL,
    [BIRTHDAY] datetime  NULL,
    [PHONE] nchar(15)  NULL,
    [ADDRESS] nvarchar(250)  NULL
);
GO

-- Creating table 'BILLINGs'
CREATE TABLE [dbo].[BILLINGs] (
    [Id] uniqueidentifier  NOT NULL,
    [SELL_DATE] datetime  NOT NULL,
    [MONEY] decimal(18,0)  NOT NULL,
    [TABLE_ID] uniqueidentifier  NOT NULL,
    [CHEF_ID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'BILLING_DETAIL'
CREATE TABLE [dbo].[BILLING_DETAIL] (
    [Id] uniqueidentifier  NOT NULL,
    [AMOUNT] int  NOT NULL,
    [COMMENT] nvarchar(250)  NULL,
    [DISH_ID] uniqueidentifier  NOT NULL,
    [BILL_ID] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CHEF_INFO'
ALTER TABLE [dbo].[CHEF_INFO]
ADD CONSTRAINT [PK_CHEF_INFO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CURENCY_TYPE'
ALTER TABLE [dbo].[CURENCY_TYPE]
ADD CONSTRAINT [PK_CURENCY_TYPE]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DISHes'
ALTER TABLE [dbo].[DISHes]
ADD CONSTRAINT [PK_DISHes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DISH_TYPE'
ALTER TABLE [dbo].[DISH_TYPE]
ADD CONSTRAINT [PK_DISH_TYPE]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PROCESSINGs'
ALTER TABLE [dbo].[PROCESSINGs]
ADD CONSTRAINT [PK_PROCESSINGs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'STATUS'
ALTER TABLE [dbo].[STATUS]
ADD CONSTRAINT [PK_STATUS]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TABLES_INFO'
ALTER TABLE [dbo].[TABLES_INFO]
ADD CONSTRAINT [PK_TABLES_INFO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WAITER_INFO'
ALTER TABLE [dbo].[WAITER_INFO]
ADD CONSTRAINT [PK_WAITER_INFO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BILLINGs'
ALTER TABLE [dbo].[BILLINGs]
ADD CONSTRAINT [PK_BILLINGs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BILLING_DETAIL'
ALTER TABLE [dbo].[BILLING_DETAIL]
ADD CONSTRAINT [PK_BILLING_DETAIL]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DISHTYPE_ID] in table 'DISHes'
ALTER TABLE [dbo].[DISHes]
ADD CONSTRAINT [FK_DISH_TYPEDISH]
    FOREIGN KEY ([DISHTYPE_ID])
    REFERENCES [dbo].[DISH_TYPE]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DISH_TYPEDISH'
CREATE INDEX [IX_FK_DISH_TYPEDISH]
ON [dbo].[DISHes]
    ([DISHTYPE_ID]);
GO

-- Creating foreign key on [STATUS_ID] in table 'PROCESSINGs'
ALTER TABLE [dbo].[PROCESSINGs]
ADD CONSTRAINT [FK_STATUSPROCESSING]
    FOREIGN KEY ([STATUS_ID])
    REFERENCES [dbo].[STATUS]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_STATUSPROCESSING'
CREATE INDEX [IX_FK_STATUSPROCESSING]
ON [dbo].[PROCESSINGs]
    ([STATUS_ID]);
GO

-- Creating foreign key on [TALBLE_ID] in table 'PROCESSINGs'
ALTER TABLE [dbo].[PROCESSINGs]
ADD CONSTRAINT [FK_TABLES_INFOPROCESSING]
    FOREIGN KEY ([TALBLE_ID])
    REFERENCES [dbo].[TABLES_INFO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TABLES_INFOPROCESSING'
CREATE INDEX [IX_FK_TABLES_INFOPROCESSING]
ON [dbo].[PROCESSINGs]
    ([TALBLE_ID]);
GO

-- Creating foreign key on [WAITER_ID] in table 'TABLES_INFO'
ALTER TABLE [dbo].[TABLES_INFO]
ADD CONSTRAINT [FK_WAITER_INFOTABLES_INFO]
    FOREIGN KEY ([WAITER_ID])
    REFERENCES [dbo].[WAITER_INFO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_WAITER_INFOTABLES_INFO'
CREATE INDEX [IX_FK_WAITER_INFOTABLES_INFO]
ON [dbo].[TABLES_INFO]
    ([WAITER_ID]);
GO

-- Creating foreign key on [DISH_ID] in table 'BILLING_DETAIL'
ALTER TABLE [dbo].[BILLING_DETAIL]
ADD CONSTRAINT [FK_BILLINGBILLING_DETAIL]
    FOREIGN KEY ([DISH_ID])
    REFERENCES [dbo].[BILLINGs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BILLINGBILLING_DETAIL'
CREATE INDEX [IX_FK_BILLINGBILLING_DETAIL]
ON [dbo].[BILLING_DETAIL]
    ([DISH_ID]);
GO

-- Creating foreign key on [TABLE_ID] in table 'BILLINGs'
ALTER TABLE [dbo].[BILLINGs]
ADD CONSTRAINT [FK_TABLES_INFOBILLING]
    FOREIGN KEY ([TABLE_ID])
    REFERENCES [dbo].[TABLES_INFO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TABLES_INFOBILLING'
CREATE INDEX [IX_FK_TABLES_INFOBILLING]
ON [dbo].[BILLINGs]
    ([TABLE_ID]);
GO

-- Creating foreign key on [DISH_ID] in table 'BILLING_DETAIL'
ALTER TABLE [dbo].[BILLING_DETAIL]
ADD CONSTRAINT [FK_DISHBILLING_DETAIL]
    FOREIGN KEY ([DISH_ID])
    REFERENCES [dbo].[DISHes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DISHBILLING_DETAIL'
CREATE INDEX [IX_FK_DISHBILLING_DETAIL]
ON [dbo].[BILLING_DETAIL]
    ([DISH_ID]);
GO

-- Creating foreign key on [CHEF_ID] in table 'BILLINGs'
ALTER TABLE [dbo].[BILLINGs]
ADD CONSTRAINT [FK_CHEF_INFOBILLING]
    FOREIGN KEY ([CHEF_ID])
    REFERENCES [dbo].[CHEF_INFO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CHEF_INFOBILLING'
CREATE INDEX [IX_FK_CHEF_INFOBILLING]
ON [dbo].[BILLINGs]
    ([CHEF_ID]);
GO

-- Creating foreign key on [CHEF_ID] in table 'PROCESSINGs'
ALTER TABLE [dbo].[PROCESSINGs]
ADD CONSTRAINT [FK_CHEF_INFOPROCESSING]
    FOREIGN KEY ([CHEF_ID])
    REFERENCES [dbo].[CHEF_INFO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CHEF_INFOPROCESSING'
CREATE INDEX [IX_FK_CHEF_INFOPROCESSING]
ON [dbo].[PROCESSINGs]
    ([CHEF_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------