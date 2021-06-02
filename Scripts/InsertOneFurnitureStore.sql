INSERT INTO dbo.FurnitureStores(
	Name,
	City,
	StreetNum,
	Street,
	StreetNumSuffix,
	OpeningDate
)
VALUES (
    'Ikea Novi Sad',
	'Novi Sad',
	12,
	'Radoja Domagoja',
	'AB',
	GETDATE()
);