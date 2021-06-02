using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    public class DeleteAccess
    {
        private ReadAccess read;
        public DeleteAccess()
        {
            read = new ReadAccess();
        }
        public void DeleteFurnitureFactory(FurnitureFactory furnitureFactory)
        {
            using (var db = new FurnitureDBContainer())
            {
                foreach (var product in furnitureFactory.Products)
                {
                    db.Products.Remove(product);
                }

                foreach (var furnitureStore in furnitureFactory.FurnitureStores)
                {
                    db.FurnitureStores.Remove(furnitureStore);
                }

                db.FurnitureFactories.Remove(furnitureFactory);
                db.SaveChanges();
            }
        }

        public void DeleteClient(Client client)
        {
            using (var db = new FurnitureDBContainer())
            {
                foreach (var complaint in client.Complaints)
                {
                    db.Complaints.Remove(complaint);
                }

                foreach (var furniture in client.Furnitures)
                {
                    db.Furnitures.Remove(furniture);
                }

                foreach (var sells in client.Sells)
                {
                    db.Sells.Remove(sells);
                }

                db.Clients.Remove(client);
                db.SaveChanges();
            }
        }

        public void DeleteComplaint(Complaint complaint)
        {
            using (var db = new FurnitureDBContainer())
            {
                db.Complaints.Remove(complaint);
                db.SaveChanges();
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            using (var db = new FurnitureDBContainer())
            {
                foreach (var employee1 in employee.Employees)
                {
                    db.Employees.Remove(employee1);
                }

                foreach (var employees11 in employee.Employees1)
                {
                    db.Employees.Remove(employees11);
                }

                db.Employees.Remove(employee);
                db.SaveChanges();
            }
        }

        public void DeleteFurnitureStore(FurnitureStore furnitureStore)
        {
            using (var db = new FurnitureDBContainer())
            {
                foreach (var fFactory in furnitureStore.FurnitureFactories)
                {
                    db.FurnitureFactories.Remove(fFactory);
                }

                foreach (var sector in furnitureStore.Sectors)
                {
                    db.Sectors.Remove(sector);
                }

                db.FurnitureStores.Remove(furnitureStore);
                db.SaveChanges();
            }
        }
        public void DeleteFurniture(Furniture furniture)
        {
            using (var db = new FurnitureDBContainer())
            {
                db.Furnitures.Remove(furniture);
                db.SaveChanges();
            }
        }

        public void DeleteReclamation(Reclamation reclamation)
        {
            using (var db = new FurnitureDBContainer())
            {
                db.Reclamations.Remove(reclamation);
                db.SaveChanges();
            }
        }

        public void DeleteProduct(Product product)
        {
            using (var db = new FurnitureDBContainer())
            {
                foreach (var productType in product.ProductTypes)
                {
                    db.ProductTypes.Remove(productType);
                }

                db.Products.Remove(product);
                db.SaveChanges();
            }
        }
        public void DeleteProductType(ProductType productType)
        {
            using (var db = new FurnitureDBContainer())
            {
                db.ProductTypes.Remove(productType);
                db.SaveChanges();
            }
        }
        public void DeleteSector(Sector sector)
        {
            using (var db = new FurnitureDBContainer())
            {
                foreach (var employee in sector.Employees)
                {
                    db.Employees.Remove(employee);
                }

                db.Sectors.Remove(sector);
                db.SaveChanges();
            }
        }
        public void DeleteReclamationService(ReclamationService reclamationService)
        {
            using (var db = new FurnitureDBContainer())
            {
                foreach (var reclamation in reclamationService.Reclamations)
                {
                    db.Reclamations.Remove(reclamation);
                }
                db.Sectors.Remove(reclamationService);
                db.SaveChanges();
            }
        }
        public void DeleteCallCenter(CallCenter callCenter)
        {
            using (var db = new FurnitureDBContainer())
            {
                foreach (var complaint in callCenter.Complaints)
                {
                    db.Complaints.Remove(complaint);
                }
                db.Sectors.Remove(callCenter);
                db.SaveChanges();
            }
        }
        public void DeleteSales(Sales sales)
        {
            using (var db = new FurnitureDBContainer())
            {
                foreach (var sell in sales.Sells)
                {
                    db.Sells.Remove(sell);
                }
                db.Sectors.Remove(sales);
                db.SaveChanges();
            }
        }

        public void DeleteSells(Sells sell)
        {
            using (var db = new FurnitureDBContainer())
            {
                foreach (var product in sell.Products)
                {
                    db.Products.Remove(product);
                }
                foreach (var client in sell.Clients)
                {
                    db.Clients.Remove(client);
                }
                db.Sells.Remove(sell);
                db.SaveChanges();
            }
        }

        // TODO:
        // FINISH DELETE
        // ADD INDEXES
        // TRY TO ADD FUNCTIONS AND PROCEDURES AND TRIGGERS
        //
        //-1: nema bar tri povezane tabele
        //-1: nema bar jedan loop
        //-1: nema nijedan kursor
    }
}
