CREATE TABLE [dbo].[Languages] (
    [LanguageCode] NVARCHAR (10)      NOT NULL,
    [LanguageName] NVARCHAR (500)     NOT NULL,
    [CreatedDate]  DATETIMEOFFSET (7) NOT NULL,
    PRIMARY KEY CLUSTERED ([LanguageCode] ASC)
);

