CREATE TABLE [dbo].[Roles] (
    [RoleId]      BIGINT             IDENTITY (1, 1) NOT NULL,
    [RoleName]    NVARCHAR (100)     NOT NULL,
    [IsDeleted]   BIT                NOT NULL,
    [CreatedDate] DATETIMEOFFSET (7) NOT NULL,
    [DeletedDate] DATETIMEOFFSET (7) NULL
);

