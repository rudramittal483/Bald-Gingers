CREATE PROCEDURE [dbo].[sproc_tblCustomer_Update]
    -- create the parameters for the stored procedure
    @CustomerNo INT,
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Email VARCHAR(50),
    @DateJoined DATE,
    @IsActiveAccount BIT
AS
BEGIN
    -- update the record as specified by the @CustomerNo value
    UPDATE [dbo].[tblCustomer]
    SET 
        FirstName = @FirstName,
        LastName = @LastName,
        Email = @Email,
        DateJoined = @DateJoined,
        IsActiveAccount = @IsActiveAccount
    WHERE 
        CustomerNo = @CustomerNo;
END