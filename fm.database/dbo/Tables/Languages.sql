CREATE TABLE [dbo].[Languages] (
    [LanguageId]   BIGINT             NOT NULL,
    [LanguageName] NVARCHAR (500)     NOT NULL,
    [CreatedDate]  DATETIMEOFFSET (7) NOT NULL,
    CONSTRAINT [PK__Language__8B8C8A352426C025] PRIMARY KEY CLUSTERED ([LanguageId] ASC)
);

