CREATE TABLE [dbo].[TransactionTypes] (
    [TransactionTypeId]   BIGINT             IDENTITY (1, 1) NOT NULL,
    [TransactionTypeName] NVARCHAR (100)     NOT NULL,
    [IsDeleted]           BIT                NOT NULL,
    [CreatedDate]         DATETIMEOFFSET (7) NOT NULL,
    [DeletedDate]         DATETIMEOFFSET (7) NULL,
    CONSTRAINT [PK_TransactionTypes] PRIMARY KEY CLUSTERED ([TransactionTypeId] ASC)
);

