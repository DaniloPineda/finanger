CREATE TABLE [dbo].[Users] (
    [UserId]              BIGINT         IDENTITY (1, 1) NOT NULL,
    [UserName]            NVARCHAR (100) NOT NULL,
    [UserLastName]        NVARCHAR (100) NOT NULL,
    [BirthDate]           DATE           NOT NULL,
    [DocumentType]        BIGINT         NOT NULL,
    [DocumentNumber]      NVARCHAR (100) NOT NULL,
    [PhoneNumber]         NVARCHAR (15)  NULL,
    [Address]             NVARCHAR (100) NULL,
    [IsApproved]          BIT            NOT NULL,
    [PreferredLanguageId] BIGINT         NOT NULL
);

