INSERT INTO dbo.Products(
	Name,
	ManufacturingDate,
	Price,
	Description,
	FactoryOrigin,
	Material,
	FurnitureFactoryId,
	SellsId
)
VALUES (
    'Test product',
    GETDATE(),
    1200,
    'Ikea stolica iz Svedske',
    'Svedska Geto Fabrika',
	'Drvo',
	1,
	3
);