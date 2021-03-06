﻿CREATE TABLE [dbo].[Portfolio] (
    [PortfolioId] BIGINT             IDENTITY (1, 1) NOT NULL,
    [CompanyId]   BIGINT             NULL,
    [Description] NVARCHAR (1000)    NULL,
    [Ammount]     MONEY              NOT NULL,
    [IsActive]    BIT                NOT NULL,
    [CreatedDate] DATETIMEOFFSET (7) NOT NULL,
    [CreatedBy]   BIGINT             NOT NULL,
    CONSTRAINT [PK_Portfolio] PRIMARY KEY CLUSTERED ([PortfolioId] ASC),
    CONSTRAINT [FK_Company_Portfolio] FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Companies] ([CompanyId])
);

