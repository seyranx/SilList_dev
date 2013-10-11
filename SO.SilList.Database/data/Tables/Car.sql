﻿CREATE TABLE [data].[Car] (
    [carId]               UNIQUEIDENTIFIER NOT NULL,
    [modelTypeId]         INT              NULL,
    [year]                INT              NULL,
    [millage]             INT              NULL,
    [price]               INT              NULL,
    [vin]                 NVARCHAR (50)    NULL,
    [description]         NVARCHAR (MAX)   NULL,
    [address]             NVARCHAR (MAX)   NULL,
    [cityId]              INT              NULL,
    [stateId]             INT              NULL,
    [countryId]           INT              NULL,
    [zip]                 INT              NULL,
    [phone]               NVARCHAR (50)    NULL,
    [fax]                 NVARCHAR (50)    NULL,
    [carBodyTypeId]       INT              NULL,
    [siteId]              INT              NULL,
    [transmissionTypeId]  INT              NULL,
    [engineTypeId]        INT              NULL,
    [driveTypeId]         INT              NULL,
    [fuelTypeId]          INT              NULL,
    [doorTypeId]          INT              NULL,
    [exteriorColorTypeId] INT              NULL,
    [interiorColorTypeId] INT              NULL,
    [startDate]           DATE             NOT NULL,
    [endDate]             DATE             NOT NULL,
    [isApproved]          BIT              DEFAULT ((0)) NOT NULL,
    [created]             DATETIME         CONSTRAINT [DF__Car__created__19AACF41] DEFAULT (getdate()) NOT NULL,
    [modified]            DATETIME         CONSTRAINT [DF__Car__modified__1A9EF37A] DEFAULT (getdate()) NOT NULL,
    [createdBy]           INT              NULL,
    [modifiedBy]          INT              NULL,
    [isActive]            BIT              CONSTRAINT [DF__Car__isActive__1B9317B3] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK__Car__1436F1744758F06A] PRIMARY KEY CLUSTERED ([carId] ASC),
    CONSTRAINT [FK_Car_CarBodyType] FOREIGN KEY ([carBodyTypeId]) REFERENCES [app].[CarBodyType] ([carBodyTypeId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Car_CarDoorType] FOREIGN KEY ([doorTypeId]) REFERENCES [app].[CarDoorType] ([carDoorTypeId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Car_CarDriveType] FOREIGN KEY ([driveTypeId]) REFERENCES [app].[CarDriveType] ([carDriveTypeId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Car_CarEngineType] FOREIGN KEY ([engineTypeId]) REFERENCES [app].[CarEngineType] ([carEngineId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Car_CarFuelType] FOREIGN KEY ([fuelTypeId]) REFERENCES [app].[CarFuelType] ([carFuelTypeId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Car_CityType] FOREIGN KEY ([cityId]) REFERENCES [app].[CityType] ([cityTypeId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Car_CountryType] FOREIGN KEY ([countryId]) REFERENCES [app].[CountryType] ([countryTypeId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Car_ModelType] FOREIGN KEY ([modelTypeId]) REFERENCES [app].[ModelType] ([modelTypeId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Car_Site] FOREIGN KEY ([siteId]) REFERENCES [app].[Site] ([siteId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Car_StateType] FOREIGN KEY ([stateId]) REFERENCES [app].[StateType] ([stateTypeId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Car_TransmissionType] FOREIGN KEY ([transmissionTypeId]) REFERENCES [app].[TransmissionType] ([transmissionTypeId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_CarExt_CarColorType] FOREIGN KEY ([exteriorColorTypeId]) REFERENCES [app].[CarColorType] ([carColorTypeId]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_CarInt_CarColorType] FOREIGN KEY ([interiorColorTypeId]) REFERENCES [app].[CarColorType] ([carColorTypeId])
);








