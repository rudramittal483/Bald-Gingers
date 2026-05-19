CREATE PROCEDURE [dbo].[sproc_tblCustomer_Insert]
    -- create the parameters for the stored procedure
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(50),
    @DateJoined DATE,
    @IsActiveAccount BIT
AS
BEGIN
    -- insert the new record
    INSERT INTO [dbo].[tblCustomer] 
        ([FirstName], [LastName], [Email], [DateJoined], [IsActiveAccount])
    VALUES 
        (@FirstName, @LastName, @Email, @DateJoined, @IsActiveAccount);

    -- return the primary key value of the new record
    RETURN @@Identity;
END