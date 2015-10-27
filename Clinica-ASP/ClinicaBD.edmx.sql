
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/27/2015 15:32:37
-- Generated from EDMX file: C:\Users\ASUS\Documents\ClinicaAsp\Clinica-ASP\Clinica-ASP\ClinicaBD.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ClinicaAsp];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Cita__CedulaM__0DAF0CB0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cita] DROP CONSTRAINT [FK__Cita__CedulaM__0DAF0CB0];
GO
IF OBJECT_ID(N'[dbo].[FK__Cita__CedulaPaci__0CBAE877]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cita] DROP CONSTRAINT [FK__Cita__CedulaPaci__0CBAE877];
GO
IF OBJECT_ID(N'[dbo].[FK__FormulaMe__IdCit__1273C1CD]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FormulaMedica] DROP CONSTRAINT [FK__FormulaMe__IdCit__1273C1CD];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cita]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cita];
GO
IF OBJECT_ID(N'[dbo].[FormulaMedica]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormulaMedica];
GO
IF OBJECT_ID(N'[dbo].[Medico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Medico];
GO
IF OBJECT_ID(N'[dbo].[Paciente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Paciente];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Citas'
CREATE TABLE [dbo].[Citas] (
    [IdCita] int  NOT NULL,
    [CedulaPaciente] int  NULL,
    [CedulaM] int  NULL,
    [fechacita] varchar(50)  NOT NULL,
    [HoraCita] varchar(50)  NOT NULL,
    [Descripcion] varchar(100)  NULL
);
GO

-- Creating table 'FormulaMedicas'
CREATE TABLE [dbo].[FormulaMedicas] (
    [IdFormulaMedica] int  NOT NULL,
    [IdCita] int  NOT NULL,
    [RecetaMedica] varchar(150)  NOT NULL
);
GO

-- Creating table 'Medicos'
CREATE TABLE [dbo].[Medicos] (
    [CedulaM] int  NOT NULL,
    [NombreM] varchar(50)  NOT NULL,
    [ApellidoM] varchar(50)  NOT NULL,
    [EmailM] varchar(100)  NOT NULL,
    [contrasena] varchar(100)  NOT NULL,
    [anionacimiento] datetime  NOT NULL,
    [telefono] int  NULL,
    [Especialidad] varchar(100)  NOT NULL
);
GO

-- Creating table 'Pacientes'
CREATE TABLE [dbo].[Pacientes] (
    [CedulaPaciente] int  NOT NULL,
    [NombrePaciente] varchar(50)  NOT NULL,
    [ApellidoPaciente] varchar(50)  NOT NULL,
    [Email] varchar(100)  NOT NULL,
    [contrasena] varchar(100)  NOT NULL,
    [anionacimiento] datetime  NOT NULL,
    [telefono] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCita] in table 'Citas'
ALTER TABLE [dbo].[Citas]
ADD CONSTRAINT [PK_Citas]
    PRIMARY KEY CLUSTERED ([IdCita] ASC);
GO

-- Creating primary key on [IdFormulaMedica] in table 'FormulaMedicas'
ALTER TABLE [dbo].[FormulaMedicas]
ADD CONSTRAINT [PK_FormulaMedicas]
    PRIMARY KEY CLUSTERED ([IdFormulaMedica] ASC);
GO

-- Creating primary key on [CedulaM] in table 'Medicos'
ALTER TABLE [dbo].[Medicos]
ADD CONSTRAINT [PK_Medicos]
    PRIMARY KEY CLUSTERED ([CedulaM] ASC);
GO

-- Creating primary key on [CedulaPaciente] in table 'Pacientes'
ALTER TABLE [dbo].[Pacientes]
ADD CONSTRAINT [PK_Pacientes]
    PRIMARY KEY CLUSTERED ([CedulaPaciente] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CedulaM] in table 'Citas'
ALTER TABLE [dbo].[Citas]
ADD CONSTRAINT [FK__Cita__CedulaM__0DAF0CB0]
    FOREIGN KEY ([CedulaM])
    REFERENCES [dbo].[Medicos]
        ([CedulaM])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__Cita__CedulaM__0DAF0CB0'
CREATE INDEX [IX_FK__Cita__CedulaM__0DAF0CB0]
ON [dbo].[Citas]
    ([CedulaM]);
GO

-- Creating foreign key on [CedulaPaciente] in table 'Citas'
ALTER TABLE [dbo].[Citas]
ADD CONSTRAINT [FK__Cita__CedulaPaci__0CBAE877]
    FOREIGN KEY ([CedulaPaciente])
    REFERENCES [dbo].[Pacientes]
        ([CedulaPaciente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__Cita__CedulaPaci__0CBAE877'
CREATE INDEX [IX_FK__Cita__CedulaPaci__0CBAE877]
ON [dbo].[Citas]
    ([CedulaPaciente]);
GO

-- Creating foreign key on [IdCita] in table 'FormulaMedicas'
ALTER TABLE [dbo].[FormulaMedicas]
ADD CONSTRAINT [FK__FormulaMe__IdCit__1273C1CD]
    FOREIGN KEY ([IdCita])
    REFERENCES [dbo].[Citas]
        ([IdCita])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__FormulaMe__IdCit__1273C1CD'
CREATE INDEX [IX_FK__FormulaMe__IdCit__1273C1CD]
ON [dbo].[FormulaMedicas]
    ([IdCita]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------