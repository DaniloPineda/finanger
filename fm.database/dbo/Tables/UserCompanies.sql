CREATE TABLE [dbo].[UserCompanies] (
    [UserId]      BIGINT             NOT NULL,
    [CompanyId]   BIGINT             NOT NULL,
    [CreatedDate] DATETIMEOFFSET (7) NOT NULL,
    CONSTRAINT [FK_Company_UserCompanies] FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Companies] ([CompanyId]),
    CONSTRAINT [FK_UserCompanies_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

