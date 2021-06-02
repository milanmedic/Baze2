using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    public class CreateAccess
    {
        private ReadAccess read;
        public CreateAccess()
        {
            read = new ReadAccess();
        }
        public Tuple<bool, string> CreateFurniture(int id, string brand, DateTime productionDate, string color, string collection)
        {
            if (id == 0 || String.IsNullOrEmpty(brand) || String.IsNullOrEmpty(color) || String.IsNullOrEmpty(collection) || productionDate == null)
            {
                return new Tuple<bool, string>(false, "Fill all the fields!");
            }
            else if (read.ReadFurniture(id) != null)
            {
                return new Tuple<bool, string>(false, $"Piece of Furniture already exists!");
            }
            using (var db = new FurnitureDBContainer())
            {
                var furniture = new Furniture
                {
                    Id = id,
                    Brand = brand,
                    ProductionDate = productionDate,
                    Color = color,
                    Collection = collection
                };

                db.Furnitures.Add(furniture);
                db.SaveChanges();
                return new Tuple<bool, string>(true, $"Added new piece of furniture - {id} ");
            };
        }

        public Tuple<bool, string> CreateClient(int id, string name, string surname)
        {
            if (id == 0 || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname))
            {
                return new Tuple<bool, string>(false, "Fill all the fields!");
            }
            else if (read.ReadFurniture(id) != null)
            {
                return new Tuple<bool, string>(false, $"Client already exists!");
            }
            using (var db = new FurnitureDBContainer())
            {
                var client = new Client
                {
                    Id = id,
                    Name = name,
                    Surname = surname
                };

                db.Clients.Add(client);
                db.SaveChanges();
                return new Tuple<bool, string>(true, $"Added new client - {id} ");
            };
        }

        public Tuple<bool, string> CreateComplaint(int id, DateTime creationDate, string description, bool status)
        {
            if (id == 0 || String.IsNullOrEmpty(description) || creationDate == null)
            {
                return new Tuple<bool, string>(false, "Fill all the fields!");
            }
            else if (read.ReadFurniture(id) != null)
            {
                return new Tuple<bool, string>(false, $"Complaint already exists!");
            }
            using (var db = new FurnitureDBContainer())
            {
                var complaint = new Complaint
                {
                    Id = id,
                    CreationDate = creationDate,
                    Description = description,
                    Status = status
                };

                db.Complaints.Add(complaint);
                db.SaveChanges();
                return new Tuple<bool, string>(true, $"Added new complaint - {id} ");
            };
        }

        public Tuple<bool, string> CreateEmployee(int id, string name, string surname, DateTime dateOfBirth, string education, int salary, string title)
        {
            if (id == 0 || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(education) || dateOfBirth == null || String.IsNullOrEmpty(title))
            {
                return new Tuple<bool, string>(false, "Fill all the fields!");
            }
            else if (read.ReadFurniture(id) != null)
            {
                return new Tuple<bool, string>(false, $"Employee already exists!");
            }
            using (var db = new FurnitureDBContainer())
            {
                var employee = new Employee
                {
                    Id = id,
                    Name = name,
                    Surname = surname,
                    DateOfBirth = dateOfBirth,
                    Education = education,
                    Salary = salary,
                    Title = title
                };

                db.Employees.Add(employee);
                db.SaveChanges();
                return new Tuple<bool, string>(true, $"Added new employe - {id} ");
            };
        }

        public Tuple<bool, string> CreateFurnitureStore(int id, string name, string city, int streetNum, string streetNumSuffix, DateTime openingDate)
        {
            if (id == 0 || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(city) || String.IsNullOrEmpty(streetNumSuffix) || openingDate == null)
            {
                return new Tuple<bool, string>(false, "Fill all the fields!");
            }
            else if (read.ReadFurniture(id) != null)
            {
                return new Tuple<bool, string>(false, $"Store already exists!");
            }
            using (var db = new FurnitureDBContainer())
            {
                var furnitureStore = new FurnitureStore
                {
                    Id = id,
                    Name = name,
                    City = city,
                    StreetNum = streetNum,
                    StreetNumSuffix = streetNumSuffix,
                    OpeningDate = openingDate
                };

                db.FurnitureStores.Add(furnitureStore);
                db.SaveChanges();
                return new Tuple<bool, string>(true, $"Added new Store - {id} ");
            };
        }

        public Tuple<bool, string> CreateFurnitureFactory(int id, string name, string country, string street, int streetNum, string streetNumSuffix)
        {
            if (id == 0 || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(country) || String.IsNullOrEmpty(street) || String.IsNullOrEmpty(streetNumSuffix))
            {
                return new Tuple<bool, string>(false, "Fill all the fields!");
            }
            else if (read.ReadFurniture(id) != null)
            {
                return new Tuple<bool, string>(false, $"Factory already exists!");
            }
            using (var db = new FurnitureDBContainer())
            {
                var furnitureFactory = new FurnitureFactory
                {
                    Id = id,
                    Name = name,
                    CountryOfOrigin = country,
                    Street = street,
                    StreetNum = streetNum,
                    StreetNumSuffix = streetNumSuffix
                };

                db.FurnitureFactories.Add(furnitureFactory);
                db.SaveChanges();
                return new Tuple<bool, string>(true, $"Added new Factory - {id} ");
            };
        }

        public Tuple<bool, string> CreateReclamation(int id, bool status, DateTime dateOfArrival, string description)
        {
            if (id == 0 || String.IsNullOrEmpty(description) || dateOfArrival == null)
            {
                return new Tuple<bool, string>(false, "Fill all the fields!");
            }
            else if (read.ReadFurniture(id) != null)
            {
                return new Tuple<bool, string>(false, $"Reclamation already exists!");
            }
            using (var db = new FurnitureDBContainer())
            {
                var reclamation = new Reclamation
                {
                    Id = id,
                    Status = status,
                    DateOfArrival = dateOfArrival,
                    ReclamationDescription = description
                };

                db.Reclamations.Add(reclamation);
                db.SaveChanges();
                return new Tuple<bool, string>(true, $"Added new Reclamation - {id} ");
            };
        }

        public Tuple<bool, string> CreateReclamationService(int id, string name, int employeeCount)
        {
            if (id == 0 || String.IsNullOrEmpty(name))
            {
                return new Tuple<bool, string>(false, "Fill all the fields!");
            }
            else if (read.ReadFurniture(id) != null)
            {
                return new Tuple<bool, string>(false, $"Reclamation Service already exists!");
            }
            using (var db = new FurnitureDBContainer())
            {
                var reclamationService = new ReclamationService
                {
                    Id = id,
                    Name = name,
                    EmployeeCount = employeeCount
                };

                db.Sectors.Add(reclamationService);
                db.SaveChanges();
                return new Tuple<bool, string>(true, $"Added new Reclamation Service - {id} ");
            };
        }

        public Tuple<bool, string> CreateProduct(int id, string name, DateTime manufacturingDate, int price, string description, string factoryOfOrigin, string material)
        {
            if (id == 0 || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(description) || String.IsNullOrEmpty(factoryOfOrigin) || String.IsNullOrEmpty(material) || manufacturingDate == null)
            {
                return new Tuple<bool, string>(false, "Fill all the fields!");
            }
            else if (read.ReadFurniture(id) != null)
            {
                return new Tuple<bool, string>(false, $"Product already exists!");
            }
            using (var db = new FurnitureDBContainer())
            {
                var product = new Product
                {
                    Id = id,
                    Name = name,
                    ManufacturingDate = manufacturingDate,
                    Price = price,
                    Description = description,
                    FactoryOrigin = factoryOfOrigin,
                    Material = material
                };

                db.Products.Add(product);
                db.SaveChanges();
                return new Tuple<bool, string>(true, $"Added new Product - {id} ");
            };
        }

        public Tuple<bool, string> CreateProductType(int id, string name)
        {
            if (id == 0 || String.IsNullOrEmpty(name))
            {
                return new Tuple<bool, string>(false, "Fill all the fields!");
            }
            else if (read.ReadFurniture(id) != null)
            {
                return new Tuple<bool, string>(false, $"Product Type already exists!");
            }
            using (var db = new FurnitureDBContainer())
            {
                var productType = new ProductType
                {
                    Id = id,
                    Name = name
                };

                db.ProductTypes.Add(productType);
                db.SaveChanges();
                return new Tuple<bool, string>(true, $"Added new Product Type - {id} ");
            };
        }

        public Tuple<bool, string> CreateSector(int id, string name, int employeeCount)
        {
            if (id == 0 || String.IsNullOrEmpty(name))
            {
                return new Tuple<bool, string>(false, "Fill all the fields!");
            }
            else if (read.ReadFurniture(id) != null)
            {
                return new Tuple<bool, string>(false, $"Sector already exists!");
            }
            using (var db = new FurnitureDBContainer())
            {
                var sector = new Sector
                {
                    Id = id,
                    Name = name,
                    EmployeeCount = employeeCount
                };

                db.Sectors.Add(sector);
                db.SaveChanges();
                return new Tuple<bool, string>(true, $"Added new Sector - {id} ");
            };
        }

        public Tuple<bool, string> CreateCallCenter(int id, string name, int employeeCount)
        {
            if (id == 0 || String.IsNullOrEmpty(name))
            {
                return new Tuple<bool, string>(false, "Fill all the fields!");
            }
            else if (read.ReadFurniture(id) != null)
            {
                return new Tuple<bool, string>(false, $"Call Center already exists!");
            }
            using (var db = new FurnitureDBContainer())
            {
                var callCenters = new CallCenter
                {
                    Id = id,
                    Name = name,
                    EmployeeCount = employeeCount
                };

                db.Sectors.Add(callCenters);
                db.SaveChanges();
                return new Tuple<bool, string>(true, $"Added new CallCenter - {id} ");
            };
        }

        public Tuple<bool, string> CreateSales(int id, string name, int employeeCount)
        {
            if (id == 0 || String.IsNullOrEmpty(name))
            {
                return new Tuple<bool, string>(false, "Fill all the fields!");
            }
            else if (read.ReadFurniture(id) != null)
            {
                return new Tuple<bool, string>(false, $"Sales already exists!");
            }
            using (var db = new FurnitureDBContainer())
            {
                var sales = new Sales
                {
                    Id = id,
                    Name = name,
                    EmployeeCount = employeeCount
                };

                db.Sectors.Add(sales);
                db.SaveChanges();
                return new Tuple<bool, string>(true, $"Added new Sales - {id} ");
            };
        }
        public Tuple<bool, string> CreateSells(int id)
        {
            if (id == 0)
            {
                return new Tuple<bool, string>(false, "Fill all the fields!");
            }
            else if (read.ReadFurniture(id) != null)
            {
                return new Tuple<bool, string>(false, $"Sells already exists!");
            }
            using (var db = new FurnitureDBContainer())
            {
                var sell = new Sells
                {
                    Id = id
                };

                db.Sells.Add(sell);
                db.SaveChanges();
                return new Tuple<bool, string>(true, $"Added new Sells - {id} ");
            };
        }
    }
}
