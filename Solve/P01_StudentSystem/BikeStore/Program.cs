using BikeStore.Data;
using BikeStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            try
            {
                /* 1-Retrieve all categories from the production.categories table*/
                //var categories = context.Categories.ToList();
                //foreach(var item in categories)
                //{
                //    Console.WriteLine($" CategoryId = {item.CategoryId} ,CategoryName = {item.CategoryName}");
                //}



                /* 2- Retrieve the first product from the production.products table*/
                //var products = context.Products.First();
                //Console.WriteLine($"ProductName = {products.ProductName} ," +
                //$"ProductId ={products.ProductId}, " +
                //$"listprice = {products.ListPrice},ModelYear = {products.ModelYear} , " +
                //$"brand_id ={products.BrandId},category_id={products.CategoryId}");



                /*Retrieve a specific product from the production.products table by ID*/
                //var products = context.Products.Find(5);
                //Console.WriteLine(products);
                //Console.WriteLine($"ProductName = {products.ProductName} ," +
                //$"ProductId ={products.ProductId}, " +
                //$"listprice = {products.ListPrice},ModelYear = {products.ModelYear} , " +
                //$"brand_id ={products.BrandId},category_id={products.CategoryId}");




                /*Retrieve all products from the production.products table with a certain model year*/
                //var products = context.Products.Where(e=>e.ModelYear == 2016);
                //foreach(var item in products)
                //{
                //   Console.WriteLine($"ProductName =  {item.ProductName}");
                //}



                /*Retrieve a specific customer from the sales.customers table by ID*/
                //var customers = context.Customers.Find(5);
                //Console.WriteLine($"CustomerId = {customers.CustomerId}" +
                //    $" First_Name = {customers.FirstName} ," +
                //    $"  Last_Name={customers.LastName} " +
                //    $",City {customers.City}, " +
                //    $"Zip_code = {customers.ZipCode}" +
                //    $", Email= {customers.Email}" +
                //    $", phone = {customers.Phone}");



                /*Retrieve a list of product names and their corresponding brand names*/
                //var products = context.Products.Include(e=>e.Brand).ToList();
                //foreach(var item in products)
                //{
                //    Console.WriteLine($"Product_Name= {item.ProductName}   , Brand_name ={item.Brand.BrandName}");
                //}



                /*Calculate the average list price of products*/
                //var products = context.Products.Average(e => e.ListPrice);
                //Console.WriteLine(products);


                /*Retrieve orders that are completed*/
                //var orders = context.Orders.Select(e => new { e.OrderId ,e.OrderStatus}).Where(e=>e.OrderStatus==4);
                //foreach(var item in orders)
                //{
                //    Console.WriteLine(item);
                //}



                
            }
            catch
            {
                Console.WriteLine("there Is Erorr");
            }



        }
    }
}
