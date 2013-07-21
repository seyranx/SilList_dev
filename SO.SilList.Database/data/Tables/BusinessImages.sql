﻿CREATE TABLE [data].[BusinessImages]
(
	[imageId] UNIQUEIDENTIFIER NOT NULL, 
    [businessId] UNIQUEIDENTIFIER NOT NULL, 
    [created] DATETIME NULL DEFAULT getdate(), 
    [modified] DATETIME NULL DEFAULT getdate(), 
    [craetedBy] INT NULL, 
    [modifiedBy] INT NULL, 
    [isActive] BIT NULL 
	)