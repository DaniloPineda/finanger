CREATE TABLE [dbo].[Companies] (
    [CompanyId]   BIGINT             IDENTITY (1, 1) NOT NULL,
    [CompanyName] NVARCHAR (100)     NOT NULL,
    [Address]     NVARCHAR (500)     NOT NULL,
    [IsDeleted]   BIT                NOT NULL,
    [CreatedDate] DATETIMEOFFSET (7) NOT NULL,
    [DeletedDate] DATETIMEOFFSET (7) NULL
);

