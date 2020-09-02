using System;
using Gauge.CSharp.Lib.Attribute;

namespace netcore.template
{
    public class StepImplementation
    {
        [Step("Fetch and print products")]
        public void PrintProducts()
        {
            using (var context = new NorthWindContext())
            {
                foreach (var product in context.Products)
                {
                    Console.WriteLine($"{product.ID} - {product.ProductName}");
                }
            }
        }
    }
}
