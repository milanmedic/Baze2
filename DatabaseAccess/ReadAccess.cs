using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    public class ReadAccess
    {
        public Client ReadClient(int id) 
        {
            using (var db = new FurnitureDBContainer())
            {
                return db.Clients.FirstOrDefault(x => x.Id.Equals(id));
            }
        }
        public Complaint ReadComplaint(int id) 
        {
            using (var db = new FurnitureDBContainer())
            {
                return db.Complaints.FirstOrDefault(x => x.Id.Equals(id));
            }
        }
        public Employee ReadEmployee(int id) 
        {
            using (var db = new FurnitureDBContainer())
            {
                return db.Employees.FirstOrDefault(x => x.Id.Equals(id));
            }
        }
        public Furniture ReadFurniture(int id) 
        {
            using (var db = new FurnitureDBContainer())
            {
                return db.Furnitures.FirstOrDefault(x => x.Id.Equals(id));
            }
        }
        public FurnitureFactory ReadFurnitureFactory(int id) 
        {
            using (var db = new FurnitureDBContainer())
            {
                return db.FurnitureFactories.FirstOrDefault(x => x.Id.Equals(id));
            }
        }
        public FurnitureStore ReadFurnitureStore(int id) 
        {
            using (var db = new FurnitureDBContainer())
            {
                return db.FurnitureStores.FirstOrDefault(x => x.Id.Equals(id));
            }
        }
        public Product ReadProduct(int id) 
        {
            using (var db = new FurnitureDBContainer())
            {
                return db.Products.FirstOrDefault(x => x.Id.Equals(id));
            }
        }
        public ProductType ReadProductType(int id) 
        {
            using (var db = new FurnitureDBContainer())
            {
                return db.ProductTypes.FirstOrDefault(x => x.Id.Equals(id));
            }
        }
        public Reclamation ReadReclamation(int id) 
        {
            using (var db = new FurnitureDBContainer())
            {
                return db.Reclamations.FirstOrDefault(x => x.Id.Equals(id));
            }
        }
        public ReclamationService ReadReclamationService(int id) 
        {
            using (var db = new FurnitureDBContainer())
            {
                return (ReclamationService)db.Sectors.FirstOrDefault(x => x.Id.Equals(id));
            }
        }
        public Sales ReadSales(int id) 
        {
            using (var db = new FurnitureDBContainer())
            {
                return (Sales)db.Sectors.FirstOrDefault(x => x.Id.Equals(id));
            }
        }
        public Sector ReadSector(int id) 
        {
            using (var db = new FurnitureDBContainer())
            {
                return db.Sectors.FirstOrDefault(x => x.Id.Equals(id));
            }
        }
        public CallCenter ReadCallCenter(int id) 
        {
            using (var db = new FurnitureDBContainer())
            {
                return (CallCenter)db.Sectors.FirstOrDefault(x => x.Id.Equals(id));
            }
        }
        public Sells ReadSells(int id) 
        {
            using (var db = new FurnitureDBContainer())
            {
                return (Sells)db.Sells.FirstOrDefault(x => x.Id.Equals(id));
            }
        }

        public List<Client> ReadClients()
        {
            using (var db = new FurnitureDBContainer())
            {
                List<Client> list = db.Clients.ToList();

                return (list != null) ? list : new List<Client>();
            }
        }

        public List<Complaint> ReadComplaints()
        {
            using (var db = new FurnitureDBContainer())
            {
                List<Complaint> list = db.Complaints.ToList();

                return (list != null) ? list : new List<Complaint>();
            }
        }
        public List<Employee> ReadEmployees()
        {
            using (var db = new FurnitureDBContainer())
            {
                List<Employee> list = db.Employees.ToList();

                return (list != null) ? list : new List<Employee>();
            }
        }
        public List<FurnitureFactory> ReadFurnitureFactories()
        {
            using (var db = new FurnitureDBContainer())
            {
                List<FurnitureFactory> list = db.FurnitureFactories.ToList();

                return (list != null) ? list : new List<FurnitureFactory>();
            }
        }
        public List<FurnitureStore> ReadFurnitureStore()
        {
            using (var db = new FurnitureDBContainer())
            {
                List<FurnitureStore> list = db.FurnitureStores.ToList();

                return (list != null) ? list : new List<FurnitureStore>();
            }
        }
        public List<Product> ReadProducts()
        {
            using (var db = new FurnitureDBContainer())
            {
                List<Product> list = db.Products.ToList();

                return (list != null) ? list : new List<Product>();
            }
        }
        public List<ProductType> ReadProductTypes()
        {
            using (var db = new FurnitureDBContainer())
            {
                List<ProductType> list = db.ProductTypes.ToList();

                return (list != null) ? list : new List<ProductType>();
            }
        }
        public List<Reclamation> ReadReclamations()
        {
            using (var db = new FurnitureDBContainer())
            {
                List<Reclamation> list = db.Reclamations.ToList();

                return (list != null) ? list : new List<Reclamation>();
            }
        }
        public List<Sector> ReadSectors()
        {
            using (var db = new FurnitureDBContainer())
            {
                List<Sector> list = db.Sectors.ToList();

                return (list != null) ? list : new List<Sector>();
            }
        }
        public List<Sells> ReadSells()
        {
            using (var db = new FurnitureDBContainer())
            {
                List<Sells> list = db.Sells.ToList();

                return (list != null) ? list : new List<Sells>();
            }
        }
    }
}
