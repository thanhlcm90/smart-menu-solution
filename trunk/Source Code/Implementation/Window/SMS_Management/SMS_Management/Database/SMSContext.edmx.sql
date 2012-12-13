
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/13/2012 23:16:46
-- Generated from EDMX file: D:\My Documents\Hoc tap\Do an\smart-menu-solution\Source Code\Implementation\Window\SMS_Management\SMS_Management\Database\SMSContext.edmx
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

IF OBJECT_ID(N'[dbo].[FK_DISH_TYPEDISH]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DISH] DROP CONSTRAINT [FK_DISH_TYPEDISH];
GO
IF OBJECT_ID(N'[dbo].[FK_TABLES_INFOPROCESSING]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PROCESSING] DROP CONSTRAINT [FK_TABLES_INFOPROCESSING];
GO
IF OBJECT_ID(N'[dbo].[FK_WAITER_INFOTABLES_INFO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TABLES_INFO] DROP CONSTRAINT [FK_WAITER_INFOTABLES_INFO];
GO
IF OBJECT_ID(N'[dbo].[FK_BILLINGBILLING_DETAIL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BILLING_DETAIL] DROP CONSTRAINT [FK_BILLINGBILLING_DETAIL];
GO
IF OBJECT_ID(N'[dbo].[FK_TABLES_INFOBILLING]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BILLING] DROP CONSTRAINT [FK_TABLES_INFOBILLING];
GO
IF OBJECT_ID(N'[dbo].[FK_DISHBILLING_DETAIL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BILLING_DETAIL] DROP CONSTRAINT [FK_DISHBILLING_DETAIL];
GO
IF OBJECT_ID(N'[dbo].[FK_CHEF_INFOPROCESSING]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PROCESSING] DROP CONSTRAINT [FK_CHEF_INFOPROCESSING];
GO
IF OBJECT_ID(N'[dbo].[FK_TABLES_INFOORDERED]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ORDER] DROP CONSTRAINT [FK_TABLES_INFOORDERED];
GO
IF OBJECT_ID(N'[dbo].[FK_DISHPROCESSING]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PROCESSING] DROP CONSTRAINT [FK_DISHPROCESSING];
GO
IF OBJECT_ID(N'[dbo].[FK_ORDERORDER_DETAIL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ORDER_DETAIL] DROP CONSTRAINT [FK_ORDERORDER_DETAIL];
GO
IF OBJECT_ID(N'[dbo].[FK_CHEF_INFOORDER_DETAIL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ORDER_DETAIL] DROP CONSTRAINT [FK_CHEF_INFOORDER_DETAIL];
GO
IF OBJECT_ID(N'[dbo].[FK_DISHORDER_DETAIL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ORDER_DETAIL] DROP CONSTRAINT [FK_DISHORDER_DETAIL];
GO
IF OBJECT_ID(N'[dbo].[FK_CHEF_INFOBILLING_DETAIL]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BILLING_DETAIL] DROP CONSTRAINT [FK_CHEF_INFOBILLING_DETAIL];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CHEF_INFO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CHEF_INFO];
GO
IF OBJECT_ID(N'[dbo].[DISH]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DISH];
GO
IF OBJECT_ID(N'[dbo].[DISH_TYPE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DISH_TYPE];
GO
IF OBJECT_ID(N'[dbo].[PROCESSING]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PROCESSING];
GO
IF OBJECT_ID(N'[dbo].[TABLES_INFO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TABLES_INFO];
GO
IF OBJECT_ID(N'[dbo].[WAITER_INFO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WAITER_INFO];
GO
IF OBJECT_ID(N'[dbo].[BILLING]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BILLING];
GO
IF OBJECT_ID(N'[dbo].[BILLING_DETAIL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BILLING_DETAIL];
GO
IF OBJECT_ID(N'[dbo].[ORDER]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ORDER];
GO
IF OBJECT_ID(N'[dbo].[ORDER_DETAIL]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ORDER_DETAIL];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CHEF_INFO'
CREATE TABLE [dbo].[CHEF_INFO] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(255)  NOT NULL,
    [BIRTHDAY] datetime  NULL,
    [PHONE] nchar(15)  NULL,
    [ADDRESS] nvarchar(255)  NULL
);
GO

-- Creating table 'DISH'
CREATE TABLE [dbo].[DISH] (
    [Id] uniqueidentifier  NOT NULL,
    [CODE] int  NOT NULL,
    [NAME_VN] nvarchar(255)  NOT NULL,
    [NAME_EN] nvarchar(255)  NULL,
    [DISHTYPE_ID] uniqueidentifier  NOT NULL,
    [PRICE] decimal(18,0)  NOT NULL,
    [MATERIAL] nvarchar(255)  NULL,
    [AREA] nvarchar(255)  NULL
);
GO

-- Creating table 'DISH_TYPE'
CREATE TABLE [dbo].[DISH_TYPE] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(255)  NOT NULL
);
GO

-- Creating table 'PROCESSING'
CREATE TABLE [dbo].[PROCESSING] (
    [Id] uniqueidentifier  NOT NULL,
    [DISH_ID] uniqueidentifier  NOT NULL,
    [PRIORITY] int  NOT NULL,
    [AMOUNT] int  NOT NULL,
    [STATUS] nvarchar(255)  NOT NULL,
    [COMMENT] nvarchar(255)  NULL,
    [TALBLE_ID] uniqueidentifier  NOT NULL,
    [CHEF_ID] uniqueidentifier  NULL,
    [ORDERDTL_ID] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'TABLES_INFO'
CREATE TABLE [dbo].[TABLES_INFO] (
    [Id] uniqueidentifier  NOT NULL,
    [CODE] int  NOT NULL,
    [WAITER_ID] uniqueidentifier  NULL,
    [NAME] nvarchar(255)  NOT NULL
);
GO

-- Creating table 'WAITER_INFO'
CREATE TABLE [dbo].[WAITER_INFO] (
    [Id] uniqueidentifier  NOT NULL,
    [NAME] nvarchar(255)  NOT NULL,
    [BIRTHDAY] datetime  NULL,
    [PHONE] nchar(15)  NULL,
    [ADDRESS] nvarchar(255)  NULL
);
GO

-- Creating table 'BILLING'
CREATE TABLE [dbo].[BILLING] (
    [Id] uniqueidentifier  NOT NULL,
    [SELL_DATE] datetime  NOT NULL,
    [MONEY] decimal(18,0)  NOT NULL,
    [TABLE_ID] uniqueidentifier  NOT NULL,
    [STATUS] nvarchar(255)  NULL
);
GO

-- Creating table 'BILLING_DETAIL'
CREATE TABLE [dbo].[BILLING_DETAIL] (
    [Id] uniqueidentifier  NOT NULL,
    [AMOUNT] int  NOT NULL,
    [DISH_ID] uniqueidentifier  NOT NULL,
    [BILL_ID] uniqueidentifier  NOT NULL,
    [CHEF_ID] uniqueidentifier  NULL
);
GO

-- Creating table 'ORDER'
CREATE TABLE [dbo].[ORDER] (
    [Id] uniqueidentifier  NOT NULL,
    [TABLE_ID] uniqueidentifier  NOT NULL,
    [STATUS] nvarchar(255)  NULL,
    [ADD_TIME] datetime  NULL
);
GO

-- Creating table 'ORDER_DETAIL'
CREATE TABLE [dbo].[ORDER_DETAIL] (
    [Id] uniqueidentifier  NOT NULL,
    [DISH_ID] uniqueidentifier  NOT NULL,
    [STATUS] nvarchar(255)  NULL,
    [AMOUNT] int  NOT NULL,
    [CHEF_ID] uniqueidentifier  NULL,
    [ORDER_ID] uniqueidentifier  NOT NULL
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

-- Creating primary key on [Id] in table 'DISH'
ALTER TABLE [dbo].[DISH]
ADD CONSTRAINT [PK_DISH]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DISH_TYPE'
ALTER TABLE [dbo].[DISH_TYPE]
ADD CONSTRAINT [PK_DISH_TYPE]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PROCESSING'
ALTER TABLE [dbo].[PROCESSING]
ADD CONSTRAINT [PK_PROCESSING]
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

-- Creating primary key on [Id] in table 'BILLING'
ALTER TABLE [dbo].[BILLING]
ADD CONSTRAINT [PK_BILLING]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BILLING_DETAIL'
ALTER TABLE [dbo].[BILLING_DETAIL]
ADD CONSTRAINT [PK_BILLING_DETAIL]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ORDER'
ALTER TABLE [dbo].[ORDER]
ADD CONSTRAINT [PK_ORDER]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ORDER_DETAIL'
ALTER TABLE [dbo].[ORDER_DETAIL]
ADD CONSTRAINT [PK_ORDER_DETAIL]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DISHTYPE_ID] in table 'DISH'
ALTER TABLE [dbo].[DISH]
ADD CONSTRAINT [FK_DISH_TYPEDISH]
    FOREIGN KEY ([DISHTYPE_ID])
    REFERENCES [dbo].[DISH_TYPE]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DISH_TYPEDISH'
CREATE INDEX [IX_FK_DISH_TYPEDISH]
ON [dbo].[DISH]
    ([DISHTYPE_ID]);
GO

-- Creating foreign key on [TALBLE_ID] in table 'PROCESSING'
ALTER TABLE [dbo].[PROCESSING]
ADD CONSTRAINT [FK_TABLES_INFOPROCESSING]
    FOREIGN KEY ([TALBLE_ID])
    REFERENCES [dbo].[TABLES_INFO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TABLES_INFOPROCESSING'
CREATE INDEX [IX_FK_TABLES_INFOPROCESSING]
ON [dbo].[PROCESSING]
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

-- Creating foreign key on [BILL_ID] in table 'BILLING_DETAIL'
ALTER TABLE [dbo].[BILLING_DETAIL]
ADD CONSTRAINT [FK_BILLINGBILLING_DETAIL]
    FOREIGN KEY ([BILL_ID])
    REFERENCES [dbo].[BILLING]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BILLINGBILLING_DETAIL'
CREATE INDEX [IX_FK_BILLINGBILLING_DETAIL]
ON [dbo].[BILLING_DETAIL]
    ([BILL_ID]);
GO

-- Creating foreign key on [TABLE_ID] in table 'BILLING'
ALTER TABLE [dbo].[BILLING]
ADD CONSTRAINT [FK_TABLES_INFOBILLING]
    FOREIGN KEY ([TABLE_ID])
    REFERENCES [dbo].[TABLES_INFO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TABLES_INFOBILLING'
CREATE INDEX [IX_FK_TABLES_INFOBILLING]
ON [dbo].[BILLING]
    ([TABLE_ID]);
GO

-- Creating foreign key on [DISH_ID] in table 'BILLING_DETAIL'
ALTER TABLE [dbo].[BILLING_DETAIL]
ADD CONSTRAINT [FK_DISHBILLING_DETAIL]
    FOREIGN KEY ([DISH_ID])
    REFERENCES [dbo].[DISH]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DISHBILLING_DETAIL'
CREATE INDEX [IX_FK_DISHBILLING_DETAIL]
ON [dbo].[BILLING_DETAIL]
    ([DISH_ID]);
GO

-- Creating foreign key on [CHEF_ID] in table 'PROCESSING'
ALTER TABLE [dbo].[PROCESSING]
ADD CONSTRAINT [FK_CHEF_INFOPROCESSING]
    FOREIGN KEY ([CHEF_ID])
    REFERENCES [dbo].[CHEF_INFO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CHEF_INFOPROCESSING'
CREATE INDEX [IX_FK_CHEF_INFOPROCESSING]
ON [dbo].[PROCESSING]
    ([CHEF_ID]);
GO

-- Creating foreign key on [TABLE_ID] in table 'ORDER'
ALTER TABLE [dbo].[ORDER]
ADD CONSTRAINT [FK_TABLES_INFOORDERED]
    FOREIGN KEY ([TABLE_ID])
    REFERENCES [dbo].[TABLES_INFO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TABLES_INFOORDERED'
CREATE INDEX [IX_FK_TABLES_INFOORDERED]
ON [dbo].[ORDER]
    ([TABLE_ID]);
GO

-- Creating foreign key on [DISH_ID] in table 'PROCESSING'
ALTER TABLE [dbo].[PROCESSING]
ADD CONSTRAINT [FK_DISHPROCESSING]
    FOREIGN KEY ([DISH_ID])
    REFERENCES [dbo].[DISH]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DISHPROCESSING'
CREATE INDEX [IX_FK_DISHPROCESSING]
ON [dbo].[PROCESSING]
    ([DISH_ID]);
GO

-- Creating foreign key on [ORDER_ID] in table 'ORDER_DETAIL'
ALTER TABLE [dbo].[ORDER_DETAIL]
ADD CONSTRAINT [FK_ORDERORDER_DETAIL]
    FOREIGN KEY ([ORDER_ID])
    REFERENCES [dbo].[ORDER]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ORDERORDER_DETAIL'
CREATE INDEX [IX_FK_ORDERORDER_DETAIL]
ON [dbo].[ORDER_DETAIL]
    ([ORDER_ID]);
GO

-- Creating foreign key on [CHEF_ID] in table 'ORDER_DETAIL'
ALTER TABLE [dbo].[ORDER_DETAIL]
ADD CONSTRAINT [FK_CHEF_INFOORDER_DETAIL]
    FOREIGN KEY ([CHEF_ID])
    REFERENCES [dbo].[CHEF_INFO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CHEF_INFOORDER_DETAIL'
CREATE INDEX [IX_FK_CHEF_INFOORDER_DETAIL]
ON [dbo].[ORDER_DETAIL]
    ([CHEF_ID]);
GO

-- Creating foreign key on [DISH_ID] in table 'ORDER_DETAIL'
ALTER TABLE [dbo].[ORDER_DETAIL]
ADD CONSTRAINT [FK_DISHORDER_DETAIL]
    FOREIGN KEY ([DISH_ID])
    REFERENCES [dbo].[DISH]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DISHORDER_DETAIL'
CREATE INDEX [IX_FK_DISHORDER_DETAIL]
ON [dbo].[ORDER_DETAIL]
    ([DISH_ID]);
GO

-- Creating foreign key on [CHEF_ID] in table 'BILLING_DETAIL'
ALTER TABLE [dbo].[BILLING_DETAIL]
ADD CONSTRAINT [FK_CHEF_INFOBILLING_DETAIL]
    FOREIGN KEY ([CHEF_ID])
    REFERENCES [dbo].[CHEF_INFO]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CHEF_INFOBILLING_DETAIL'
CREATE INDEX [IX_FK_CHEF_INFOBILLING_DETAIL]
ON [dbo].[BILLING_DETAIL]
    ([CHEF_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------