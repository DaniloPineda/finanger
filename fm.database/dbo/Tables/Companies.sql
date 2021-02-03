CREATE TABLE [dbo].[Companies] (
    [CompanyId]      BIGINT             IDENTITY (1, 1) NOT NULL,
    [CompanyName]    NVARCHAR (100)     NOT NULL,
    [DocumentTypeId] BIGINT             NULL,
    [DocumentNumber] NVARCHAR (100)     NULL,
    [Address]        NVARCHAR (500)     NOT NULL,
    [IsDeleted]      BIT                NOT NULL,
    [CreatedDate]    DATETIMEOFFSET (7) NOT NULL,
    [DeletedDate]    DATETIMEOFFSET (7) NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED ([CompanyId] ASC),
    CONSTRAINT [FK_Company_DocumentType] FOREIGN KEY ([DocumentTypeId]) REFERENCES [dbo].[DocumentTypes] ([DocTypeId])
);

