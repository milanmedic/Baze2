Create function ReturnFurnitureFactory()      
returns table       
as      
return(select * from FurnitureDB.dbo.FurnitureFactories) 