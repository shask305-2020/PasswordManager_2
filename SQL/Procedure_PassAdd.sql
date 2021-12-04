CREATE PROCEDURE [dbo].[PassAdd]
    @Name nvarchar(50),
    @Site nvarchar(50),
    @Login nvarchar(50),
    @Pass nvarchar(50)

    AS
    INSERT INTO Password
    (
    Name,
    Site,
    Login,
    Password
    )
    VALUES
    (
    @Name,
    @Site,
    @Login,
    @Pass
    )