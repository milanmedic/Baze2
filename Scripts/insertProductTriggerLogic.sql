CREATE TRIGGER dbo.ProductsInsert
ON dbo.Products
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO product_audits(
        product_id, 
        product_name,
        manufacturing_date,
        updated_at, 
        operation
    )
	SELECT
        i.Id,
        i.Name,
        i.ManufacturingDate,
        GETDATE(),
        'INS'
    FROM
        inserted i
END