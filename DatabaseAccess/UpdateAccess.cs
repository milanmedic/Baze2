using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    public class UpdateAccess
    {
        private ReadAccess read;
        public UpdateAccess()
        {
            read = new ReadAccess();
        }
        public void UpdateClient(int id, string name, string surname)
        {
            var client = read.ReadClient(id);

            client.Name = name != client.Name
                ? name
                : client.Name;
            client.Surname = surname != client.Surname
                ? surname
                : client.Surname;
            
            using (var db = new FurnitureDBContainer())
            {
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateComplaint(int id, DateTime creationDate, string description, bool status)
        {
            var complaint = read.ReadComplaint(id);

            complaint.CreationDate = creationDate != complaint.CreationDate
                ? creationDate
                : complaint.CreationDate;
            complaint.Description = description != complaint.Description
                ? description
                : complaint.Description;
            complaint.Status = status != complaint.Status
                ? status
                : complaint.Status;

            using (var db = new FurnitureDBContainer())
            {
                db.Entry(complaint).State = EntityState.Modified;
                db.SaveChanges();
            }

        }
        public void UpdateEmployee(int id, string name, string surname, DateTime dateOfBirth, string education, int salary, string title)
        {
            var employee = read.ReadEmployee(id);

            employee.Name = name != employee.Name
                ? name
                : employee.Name;
            employee.Surname = surname != employee.Surname
                ? surname
                : employee.Surname;
            employee.DateOfBirth = dateOfBirth != employee.DateOfBirth
                ? dateOfBirth
                : employee.DateOfBirth;
            employee.Education = education != employee.Education
                ? education
                : employee.Education;
            employee.Salary = salary != employee.Salary
                ? salary
                : employee.Salary;
            employee.Title = title != employee.Title
                ? title
                : employee.Title;

            using (var db = new FurnitureDBContainer())
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateFurniture(int id, string brand, DateTime productionDate, string color, string collection)
        {
            var furniture = read.ReadFurniture(id);

            furniture.Brand = brand != furniture.Brand
                ? brand
                : furniture.Brand;
            furniture.ProductionDate = productionDate != furniture.ProductionDate
                ? productionDate
                : furniture.ProductionDate;
            furniture.Color = color != furniture.Color
               ? color
               : furniture.Color;
            furniture.Collection = collection != furniture.Collection
               ? collection
               : furniture.Collection;

            using (var db = new FurnitureDBContainer())
            {
                db.Entry(furniture).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateFurnitureFactory(int id, string name, string country, string street, int streetNum, string streetNumSuffix)
        {
            var factory = read.ReadFurnitureFactory(id);

            factory.Name = name != factory.Name
                ? name
                : factory.Name;
            factory.CountryOfOrigin = country != factory.CountryOfOrigin
                ? country
                : factory.CountryOfOrigin;
            factory.Street = street != factory.Street
                ? street
                : factory.Street;
            factory.StreetNum = streetNum != factory.StreetNum
                ? streetNum
                : factory.StreetNum;
            factory.StreetNumSuffix = streetNumSuffix != factory.StreetNumSuffix
                ? streetNumSuffix
                : factory.StreetNumSuffix;

            using (var db = new FurnitureDBContainer())
            {
                db.Entry(factory).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateFurnitureStore(int id, string name, string city, string street, int streetNum, string streetNumSuffix, DateTime openingDate)
        {
            var store = read.ReadFurnitureStore(id);

            store.Name = name != store.Name
                ? name
                : store.Name;
            store.City = city != store.City
                ? city
                : store.City;
            store.Street = street != store.Street
                ? street
                : store.Street;
            store.StreetNum = streetNum != store.StreetNum
                ? streetNum
                : store.StreetNum;
            store.StreetNumSuffix = streetNumSuffix != store.StreetNumSuffix
                ? streetNumSuffix
                : store.StreetNumSuffix;
            store.OpeningDate = openingDate != store.OpeningDate
                ? openingDate
                : store.OpeningDate;

            using (var db = new FurnitureDBContainer())
            {
                db.Entry(store).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateProduct(int id, string name, int price, string description, string origin, string material)
        {
            var product = read.ReadProduct(id);

            product.Name = name != product.Name
                ? name
                : product.Name;
            product.Price = price != product.Price
                ? price
                : product.Price;
            product.Description = description != product.Description
                ? description
                : product.Description;
            product.FactoryOrigin = origin != product.FactoryOrigin
                ? origin
                : product.FactoryOrigin;
            product.Material = material != product.Material
                ? material
                : product.Material;

            using (var db = new FurnitureDBContainer())
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateProductType(int id, string name)
        {
            var type = read.ReadProductType(id);

            type.Name = name != type.Name
                ? name
                : type.Name;

            using (var db = new FurnitureDBContainer())
            {
                db.Entry(type).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateReclamation(int id, bool status, DateTime dateOfArrival, string reclamationDescription)
        {
            var reclamation = read.ReadReclamation(id);

            reclamation.Status = status != reclamation.Status
                ? status
                : reclamation.Status;
            reclamation.DateOfArrival = dateOfArrival != reclamation.DateOfArrival
                ? dateOfArrival
                : reclamation.DateOfArrival;
            reclamation.ReclamationDescription = reclamationDescription != reclamation.ReclamationDescription
                ? reclamationDescription
                : reclamation.ReclamationDescription;

            using (var db = new FurnitureDBContainer())
            {
                db.Entry(reclamation).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateSector(int id, string name, int employeeCount)
        {
            var sector = read.ReadSector(id);

            sector.Name = name != sector.Name
                ? name
                : sector.Name;
            sector.EmployeeCount = employeeCount != sector.EmployeeCount
                ? employeeCount
                : sector.EmployeeCount;

            using (var db = new FurnitureDBContainer())
            {
                db.Entry(sector).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateCallCenter(int id, string name, int employeeCount)
        {
            var callCenter = read.ReadCallCenter(id);

            callCenter.Name = name != callCenter.Name
                ? name
                : callCenter.Name;
            callCenter.EmployeeCount = employeeCount != callCenter.EmployeeCount
                ? employeeCount
                : callCenter.EmployeeCount;

            using (var db = new FurnitureDBContainer())
            {
                db.Entry(callCenter).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateReclamationService(int id, string name, int employeeCount)
        {
            var reclamationService = read.ReadReclamationService(id);

            reclamationService.Name = name != reclamationService.Name
                ? name
                : reclamationService.Name;
            reclamationService.EmployeeCount = employeeCount != reclamationService.EmployeeCount
                ? employeeCount
                : reclamationService.EmployeeCount;

            using (var db = new FurnitureDBContainer())
            {
                db.Entry(reclamationService).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateSales(int id, string name, int employeeCount)
        {
            var sales = read.ReadSales(id);

            sales.Name = name != sales.Name
                ? name
                : sales.Name;
            sales.EmployeeCount = employeeCount != sales.EmployeeCount
                ? employeeCount
                : sales.EmployeeCount;

            using (var db = new FurnitureDBContainer())
            {
                db.Entry(sales).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void UpdateSells(int id)
        {
            var sells = read.ReadSells(id);

            using (var db = new FurnitureDBContainer())
            {
                db.Entry(sells).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
