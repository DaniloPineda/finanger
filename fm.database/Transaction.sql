CREATE TABLE [dbo].[Transaction]
(
	[Id] BIGINT NOT NULL PRIMARY KEY, 
    [TransactionName] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(300) NULL, 
    [Type] BIGINT NOT NULL, 
    [Category] BIGINT NOT NULL, 
    [Amount] MONEY NOT NULL, 
    [Currency] BIGINT NOT NULL, 
    [Date] DATETIME NOT NULL, 
    CONSTRAINT [FK_Transaction_ToType] FOREIGN KEY ([Type]) REFERENCES [dbo].[TransactionType]([Id]), 
    CONSTRAINT [FK_Transaction_ToCategory] FOREIGN KEY ([Category]) REFERENCES [dbo].[TransactionCategory]([Id]), 
    CONSTRAINT [FK_Transaction_ToCurrency] FOREIGN KEY ([Currency]) REFERENCES [dbo].[Currency]([Id])
)
