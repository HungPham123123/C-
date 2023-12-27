using System;
using System.Collections.Generic;

public abstract class BaseEntity
{
    public int Id { get; set; }
}

public class Customer : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Email: {Email}";
    }
}

public class Student : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {FirstName} {LastName}";
    }
}

public class Product : BaseEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Price: {Price:C}";
    }
}

public interface IRepository<T> where T : BaseEntity
{
    T GetById(int id);
    IEnumerable<T> GetAll();
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
}

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private List<T> entities = new List<T>();

    public T GetById(int id)
    {
        return entities.Find(e => e.Id == id);
    }

    public IEnumerable<T> GetAll()
    {
        return entities;
    }

    public void Add(T entity)
    {
        entity.Id = entities.Count + 1;
        entities.Add(entity);
        Console.WriteLine($"{typeof(T).Name} added: {entity}");
    }

    public void Update(T entity)
    {
        var existingEntity = entities.Find(e => e.Id == entity.Id);
        if (existingEntity != null)
        {
            entities[entities.IndexOf(existingEntity)] = entity;
            Console.WriteLine($"{typeof(T).Name} updated: {entity}");
        }
        else
        {
            Console.WriteLine($"{typeof(T).Name} not found for update");
        }
    }

    public void Delete(int id)
    {
        var entityToDelete = entities.Find(e => e.Id == id);
        if (entityToDelete != null)
        {
            entities.Remove(entityToDelete);
            Console.WriteLine($"{typeof(T).Name} deleted: {id}");
        }
        else
        {
            Console.WriteLine($"{typeof(T).Name} not found for deletion");
        }
    }
}

class Program
{
    static void Main()
    {
        IRepository<Customer> customerRepository = new Repository<Customer>();
        IRepository<Student> studentRepository = new Repository<Student>();
        IRepository<Product> productRepository = new Repository<Product>();

        customerRepository.Add(new Customer { Name = "John Doe", Email = "john@example.com" });
        studentRepository.Add(new Student { FirstName = "Alice", LastName = "Smith" });
        productRepository.Add(new Product { Name = "Laptop", Price = 999.99m });

        customerRepository.Update(new Customer { Id = 1, Name = "Updated John Doe", Email = "john@example.com" });
        studentRepository.Update(new Student { Id = 1, FirstName = "Updated Alice", LastName = "Smith" });
        productRepository.Update(new Product { Id = 1, Name = "Updated Laptop", Price = 1099.99m });

        customerRepository.Delete(1);
        studentRepository.Delete(1);
        productRepository.Delete(1);

        Console.WriteLine("\nAll Customers:");
        foreach (var customer in customerRepository.GetAll())
        {
            Console.WriteLine(customer);
        }

        Console.WriteLine("\nAll Students:");
        foreach (var student in studentRepository.GetAll())
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("\nAll Products:");
        foreach (var product in productRepository.GetAll())
        {
            Console.WriteLine(product);
        }
    }
}
