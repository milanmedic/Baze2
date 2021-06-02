
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2021 05:42:48
-- Generated from EDMX file: C:\Users\User\Documents\BazePodataka2\BazePodataka2\Model\FurnitureDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FurnitureDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FurnitureStoreFurnitureFactory_FurnitureStore1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FurnitureStoreFurnitureFactory] DROP CONSTRAINT [FK_FurnitureStoreFurnitureFactory_FurnitureStore1];
GO
IF OBJECT_ID(N'[dbo].[FK_FurnitureStoreFurnitureFactory_FurnitureFactory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FurnitureStoreFurnitureFactory] DROP CONSTRAINT [FK_FurnitureStoreFurnitureFactory_FurnitureFactory];
GO
IF OBJECT_ID(N'[dbo].[FK_FurnitureStoreSector]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sectors] DROP CONSTRAINT [FK_FurnitureStoreSector];
GO
IF OBJECT_ID(N'[dbo].[FK_FurnitureFactoryProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_FurnitureFactoryProduct];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductProductType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductTypes] DROP CONSTRAINT [FK_ProductProductType];
GO
IF OBJECT_ID(N'[dbo].[FK_SellsProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Products] DROP CONSTRAINT [FK_SellsProduct];
GO
IF OBJECT_ID(N'[dbo].[FK_SectorEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_SectorEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeEmployee_Employee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeEmployee] DROP CONSTRAINT [FK_EmployeeEmployee_Employee];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeEmployee_Employee1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeEmployee] DROP CONSTRAINT [FK_EmployeeEmployee_Employee1];
GO
IF OBJECT_ID(N'[dbo].[FK_FurnitureReclamation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Furnitures] DROP CONSTRAINT [FK_FurnitureReclamation];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientFurniture]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Furnitures] DROP CONSTRAINT [FK_ClientFurniture];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientComplaint]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Complaints] DROP CONSTRAINT [FK_ClientComplaint];
GO
IF OBJECT_ID(N'[dbo].[FK_SalesSells]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sells] DROP CONSTRAINT [FK_SalesSells];
GO
IF OBJECT_ID(N'[dbo].[FK_ReclamationServiceReclamation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reclamations] DROP CONSTRAINT [FK_ReclamationServiceReclamation];
GO
IF OBJECT_ID(N'[dbo].[FK_CallCenterComplaint]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Complaints] DROP CONSTRAINT [FK_CallCenterComplaint];
GO
IF OBJECT_ID(N'[dbo].[FK_SellsClient_Sells]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SellsClient] DROP CONSTRAINT [FK_SellsClient_Sells];
GO
IF OBJECT_ID(N'[dbo].[FK_SellsClient_Client]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SellsClient] DROP CONSTRAINT [FK_SellsClient_Client];
GO
IF OBJECT_ID(N'[dbo].[FK_Sales_inherits_Sector]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sectors_Sales] DROP CONSTRAINT [FK_Sales_inherits_Sector];
GO
IF OBJECT_ID(N'[dbo].[FK_ReclamationService_inherits_Sector]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sectors_ReclamationService] DROP CONSTRAINT [FK_ReclamationService_inherits_Sector];
GO
IF OBJECT_ID(N'[dbo].[FK_CallCenter_inherits_Sector]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sectors_CallCenter] DROP CONSTRAINT [FK_CallCenter_inherits_Sector];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FurnitureStores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FurnitureStores];
GO
IF OBJECT_ID(N'[dbo].[FurnitureFactories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FurnitureFactories];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[ProductTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductTypes];
GO
IF OBJECT_ID(N'[dbo].[Sectors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sectors];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[Reclamations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reclamations];
GO
IF OBJECT_ID(N'[dbo].[Furnitures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Furnitures];
GO
IF OBJECT_ID(N'[dbo].[Clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clients];
GO
IF OBJECT_ID(N'[dbo].[Complaints]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Complaints];
GO
IF OBJECT_ID(N'[dbo].[Sells]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sells];
GO
IF OBJECT_ID(N'[dbo].[Sectors_Sales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sectors_Sales];
GO
IF OBJECT_ID(N'[dbo].[Sectors_ReclamationService]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sectors_ReclamationService];
GO
IF OBJECT_ID(N'[dbo].[Sectors_CallCenter]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sectors_CallCenter];
GO
IF OBJECT_ID(N'[dbo].[FurnitureStoreFurnitureFactory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FurnitureStoreFurnitureFactory];
GO
IF OBJECT_ID(N'[dbo].[EmployeeEmployee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeEmployee];
GO
IF OBJECT_ID(N'[dbo].[SellsClient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SellsClient];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'FurnitureStores'
CREATE TABLE [dbo].[FurnitureStores] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [StreetNum] int  NOT NULL,
    [Street] nvarchar(max)  NOT NULL,
    [StreetNumSuffix] nvarchar(max)  NOT NULL,
    [OpeningDate] datetime  NOT NULL
);
GO

-- Creating table 'FurnitureFactories'
CREATE TABLE [dbo].[FurnitureFactories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CountryOfOrigin] nvarchar(max)  NOT NULL,
    [Street] nvarchar(max)  NOT NULL,
    [StreetNum] int  NOT NULL,
    [StreetNumSuffix] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FurnitureFactoryId] int  NOT NULL,
    [SellsId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ManufacturingDate] datetime  NOT NULL,
    [Price] int  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [FactoryOrigin] nvarchar(max)  NOT NULL,
    [Material] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProductTypes'
CREATE TABLE [dbo].[ProductTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Product_Id] int  NOT NULL
);
GO

-- Creating table 'Sectors'
CREATE TABLE [dbo].[Sectors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [EmployeeCount] int  NOT NULL,
    [FurnitureStore_Id] int  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL,
    [DateOfBirth] datetime  NOT NULL,
    [Education] nvarchar(max)  NOT NULL,
    [Salary] int  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Sector_Id] int  NOT NULL
);
GO

-- Creating table 'Reclamations'
CREATE TABLE [dbo].[Reclamations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Status] bit  NOT NULL,
    [DateOfArrival] datetime  NOT NULL,
    [ReclamationDescription] nvarchar(max)  NOT NULL,
    [ReclamationServiceId] int  NOT NULL
);
GO

-- Creating table 'Furnitures'
CREATE TABLE [dbo].[Furnitures] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClientId] int  NOT NULL,
    [Brand] nvarchar(max)  NOT NULL,
    [ProductionDate] datetime  NOT NULL,
    [Color] nvarchar(max)  NOT NULL,
    [Collection] nvarchar(max)  NOT NULL,
    [Reclamation_Id] int  NOT NULL
);
GO

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Surname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Complaints'
CREATE TABLE [dbo].[Complaints] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClientId] int  NOT NULL,
    [CreationDate] datetime  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Status] bit  NOT NULL,
    [CallCenterId] int  NOT NULL
);
GO

-- Creating table 'Sells'
CREATE TABLE [dbo].[Sells] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SalesId] int  NOT NULL
);
GO

-- Creating table 'Sectors_Sales'
CREATE TABLE [dbo].[Sectors_Sales] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'Sectors_ReclamationService'
CREATE TABLE [dbo].[Sectors_ReclamationService] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'Sectors_CallCenter'
CREATE TABLE [dbo].[Sectors_CallCenter] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'FurnitureStoreFurnitureFactory'
CREATE TABLE [dbo].[FurnitureStoreFurnitureFactory] (
    [FurnitureStores_Id] int  NOT NULL,
    [FurnitureFactories_Id] int  NOT NULL
);
GO

-- Creating table 'EmployeeEmployee'
CREATE TABLE [dbo].[EmployeeEmployee] (
    [Employees1_Id] int  NOT NULL,
    [Employees_Id] int  NOT NULL
);
GO

-- Creating table 'SellsClient'
CREATE TABLE [dbo].[SellsClient] (
    [Sells_Id] int  NOT NULL,
    [Clients_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'FurnitureStores'
ALTER TABLE [dbo].[FurnitureStores]
ADD CONSTRAINT [PK_FurnitureStores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FurnitureFactories'
ALTER TABLE [dbo].[FurnitureFactories]
ADD CONSTRAINT [PK_FurnitureFactories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductTypes'
ALTER TABLE [dbo].[ProductTypes]
ADD CONSTRAINT [PK_ProductTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sectors'
ALTER TABLE [dbo].[Sectors]
ADD CONSTRAINT [PK_Sectors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reclamations'
ALTER TABLE [dbo].[Reclamations]
ADD CONSTRAINT [PK_Reclamations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Furnitures'
ALTER TABLE [dbo].[Furnitures]
ADD CONSTRAINT [PK_Furnitures]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Complaints'
ALTER TABLE [dbo].[Complaints]
ADD CONSTRAINT [PK_Complaints]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sells'
ALTER TABLE [dbo].[Sells]
ADD CONSTRAINT [PK_Sells]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sectors_Sales'
ALTER TABLE [dbo].[Sectors_Sales]
ADD CONSTRAINT [PK_Sectors_Sales]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sectors_ReclamationService'
ALTER TABLE [dbo].[Sectors_ReclamationService]
ADD CONSTRAINT [PK_Sectors_ReclamationService]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sectors_CallCenter'
ALTER TABLE [dbo].[Sectors_CallCenter]
ADD CONSTRAINT [PK_Sectors_CallCenter]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [FurnitureStores_Id], [FurnitureFactories_Id] in table 'FurnitureStoreFurnitureFactory'
ALTER TABLE [dbo].[FurnitureStoreFurnitureFactory]
ADD CONSTRAINT [PK_FurnitureStoreFurnitureFactory]
    PRIMARY KEY CLUSTERED ([FurnitureStores_Id], [FurnitureFactories_Id] ASC);
GO

-- Creating primary key on [Employees1_Id], [Employees_Id] in table 'EmployeeEmployee'
ALTER TABLE [dbo].[EmployeeEmployee]
ADD CONSTRAINT [PK_EmployeeEmployee]
    PRIMARY KEY CLUSTERED ([Employees1_Id], [Employees_Id] ASC);
GO

-- Creating primary key on [Sells_Id], [Clients_Id] in table 'SellsClient'
ALTER TABLE [dbo].[SellsClient]
ADD CONSTRAINT [PK_SellsClient]
    PRIMARY KEY CLUSTERED ([Sells_Id], [Clients_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FurnitureStores_Id] in table 'FurnitureStoreFurnitureFactory'
ALTER TABLE [dbo].[FurnitureStoreFurnitureFactory]
ADD CONSTRAINT [FK_FurnitureStoreFurnitureFactory_FurnitureStore1]
    FOREIGN KEY ([FurnitureStores_Id])
    REFERENCES [dbo].[FurnitureStores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [FurnitureFactories_Id] in table 'FurnitureStoreFurnitureFactory'
ALTER TABLE [dbo].[FurnitureStoreFurnitureFactory]
ADD CONSTRAINT [FK_FurnitureStoreFurnitureFactory_FurnitureFactory]
    FOREIGN KEY ([FurnitureFactories_Id])
    REFERENCES [dbo].[FurnitureFactories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FurnitureStoreFurnitureFactory_FurnitureFactory'
CREATE INDEX [IX_FK_FurnitureStoreFurnitureFactory_FurnitureFactory]
ON [dbo].[FurnitureStoreFurnitureFactory]
    ([FurnitureFactories_Id]);
GO

-- Creating foreign key on [FurnitureStore_Id] in table 'Sectors'
ALTER TABLE [dbo].[Sectors]
ADD CONSTRAINT [FK_FurnitureStoreSector]
    FOREIGN KEY ([FurnitureStore_Id])
    REFERENCES [dbo].[FurnitureStores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FurnitureStoreSector'
CREATE INDEX [IX_FK_FurnitureStoreSector]
ON [dbo].[Sectors]
    ([FurnitureStore_Id]);
GO

-- Creating foreign key on [FurnitureFactoryId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_FurnitureFactoryProduct]
    FOREIGN KEY ([FurnitureFactoryId])
    REFERENCES [dbo].[FurnitureFactories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FurnitureFactoryProduct'
CREATE INDEX [IX_FK_FurnitureFactoryProduct]
ON [dbo].[Products]
    ([FurnitureFactoryId]);
GO

-- Creating foreign key on [Product_Id] in table 'ProductTypes'
ALTER TABLE [dbo].[ProductTypes]
ADD CONSTRAINT [FK_ProductProductType]
    FOREIGN KEY ([Product_Id])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductProductType'
CREATE INDEX [IX_FK_ProductProductType]
ON [dbo].[ProductTypes]
    ([Product_Id]);
GO

-- Creating foreign key on [SellsId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [FK_SellsProduct]
    FOREIGN KEY ([SellsId])
    REFERENCES [dbo].[Sells]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SellsProduct'
CREATE INDEX [IX_FK_SellsProduct]
ON [dbo].[Products]
    ([SellsId]);
GO

-- Creating foreign key on [Sector_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_SectorEmployee]
    FOREIGN KEY ([Sector_Id])
    REFERENCES [dbo].[Sectors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SectorEmployee'
CREATE INDEX [IX_FK_SectorEmployee]
ON [dbo].[Employees]
    ([Sector_Id]);
GO

-- Creating foreign key on [Employees1_Id] in table 'EmployeeEmployee'
ALTER TABLE [dbo].[EmployeeEmployee]
ADD CONSTRAINT [FK_EmployeeEmployee_Employee]
    FOREIGN KEY ([Employees1_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Employees_Id] in table 'EmployeeEmployee'
ALTER TABLE [dbo].[EmployeeEmployee]
ADD CONSTRAINT [FK_EmployeeEmployee_Employee1]
    FOREIGN KEY ([Employees_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeEmployee_Employee1'
CREATE INDEX [IX_FK_EmployeeEmployee_Employee1]
ON [dbo].[EmployeeEmployee]
    ([Employees_Id]);
GO

-- Creating foreign key on [Reclamation_Id] in table 'Furnitures'
ALTER TABLE [dbo].[Furnitures]
ADD CONSTRAINT [FK_FurnitureReclamation]
    FOREIGN KEY ([Reclamation_Id])
    REFERENCES [dbo].[Reclamations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FurnitureReclamation'
CREATE INDEX [IX_FK_FurnitureReclamation]
ON [dbo].[Furnitures]
    ([Reclamation_Id]);
GO

-- Creating foreign key on [ClientId] in table 'Furnitures'
ALTER TABLE [dbo].[Furnitures]
ADD CONSTRAINT [FK_ClientFurniture]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientFurniture'
CREATE INDEX [IX_FK_ClientFurniture]
ON [dbo].[Furnitures]
    ([ClientId]);
GO

-- Creating foreign key on [ClientId] in table 'Complaints'
ALTER TABLE [dbo].[Complaints]
ADD CONSTRAINT [FK_ClientComplaint]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientComplaint'
CREATE INDEX [IX_FK_ClientComplaint]
ON [dbo].[Complaints]
    ([ClientId]);
GO

-- Creating foreign key on [SalesId] in table 'Sells'
ALTER TABLE [dbo].[Sells]
ADD CONSTRAINT [FK_SalesSells]
    FOREIGN KEY ([SalesId])
    REFERENCES [dbo].[Sectors_Sales]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SalesSells'
CREATE INDEX [IX_FK_SalesSells]
ON [dbo].[Sells]
    ([SalesId]);
GO

-- Creating foreign key on [ReclamationServiceId] in table 'Reclamations'
ALTER TABLE [dbo].[Reclamations]
ADD CONSTRAINT [FK_ReclamationServiceReclamation]
    FOREIGN KEY ([ReclamationServiceId])
    REFERENCES [dbo].[Sectors_ReclamationService]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReclamationServiceReclamation'
CREATE INDEX [IX_FK_ReclamationServiceReclamation]
ON [dbo].[Reclamations]
    ([ReclamationServiceId]);
GO

-- Creating foreign key on [CallCenterId] in table 'Complaints'
ALTER TABLE [dbo].[Complaints]
ADD CONSTRAINT [FK_CallCenterComplaint]
    FOREIGN KEY ([CallCenterId])
    REFERENCES [dbo].[Sectors_CallCenter]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CallCenterComplaint'
CREATE INDEX [IX_FK_CallCenterComplaint]
ON [dbo].[Complaints]
    ([CallCenterId]);
GO

-- Creating foreign key on [Sells_Id] in table 'SellsClient'
ALTER TABLE [dbo].[SellsClient]
ADD CONSTRAINT [FK_SellsClient_Sells]
    FOREIGN KEY ([Sells_Id])
    REFERENCES [dbo].[Sells]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Clients_Id] in table 'SellsClient'
ALTER TABLE [dbo].[SellsClient]
ADD CONSTRAINT [FK_SellsClient_Client]
    FOREIGN KEY ([Clients_Id])
    REFERENCES [dbo].[Clients]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SellsClient_Client'
CREATE INDEX [IX_FK_SellsClient_Client]
ON [dbo].[SellsClient]
    ([Clients_Id]);
GO

-- Creating foreign key on [Id] in table 'Sectors_Sales'
ALTER TABLE [dbo].[Sectors_Sales]
ADD CONSTRAINT [FK_Sales_inherits_Sector]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Sectors]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Sectors_ReclamationService'
ALTER TABLE [dbo].[Sectors_ReclamationService]
ADD CONSTRAINT [FK_ReclamationService_inherits_Sector]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Sectors]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Sectors_CallCenter'
ALTER TABLE [dbo].[Sectors_CallCenter]
ADD CONSTRAINT [FK_CallCenter_inherits_Sector]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Sectors]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------