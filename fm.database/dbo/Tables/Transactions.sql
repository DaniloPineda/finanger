CREATE TABLE [dbo].[Transactions] (
    [TransactionId]     BIGINT             IDENTITY (1, 1) NOT NULL,
    [TransactionTypeId] BIGINT             NOT NULL,
    [Amount]            MONEY              NOT NULL,
    [Description]       NVARCHAR (500)     NOT NULL,
    [CreatedDate]       DATETIMEOFFSET (7) NOT NULL,
    [UpdatedDate]       DATETIMEOFFSET (7) NULL,
    CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED ([TransactionId] ASC),
    CONSTRAINT [FK_Transactions_TransactionTypes] FOREIGN KEY ([TransactionTypeId]) REFERENCES [dbo].[TransactionTypes] ([TransactionTypeId])
);

