CREATE PROCEDURE [dbo].[sproc_tblAddress_Update]
    -- create the parameters for the stored procedure
    @AddressId INT,
    @CustomerNo INT,
    @Emirate VARCHAR(15),
    @BuildingName VARCHAR(50),
    @StreetName VARCHAR(50),
    @AddressType VARCHAR(9),
    @Postcode INT,
    @IsDefault BIT
AS
BEGIN
    -- update the record as specified by the @AddressId value
    UPDATE [dbo].[tblAddress]
    SET 
        CustomerNo = @CustomerNo,
        Emirate = @Emirate,
        BuildingName = @BuildingName,
        StreetName = @StreetName,
        AddressType = @AddressType,
        Postcode = @Postcode,
        IsDefault = @IsDefault
    WHERE 
        AddressId = @AddressId;
END