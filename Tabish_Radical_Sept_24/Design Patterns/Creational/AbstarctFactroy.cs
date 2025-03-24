using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24.Design_Patterns.Creational
{
    using System;

    namespace Tabish_Radical_Sept_24.Design_Patterns.Creational
    {
        // Product interface
        public interface IProduct
        {
            string GetProductDetails();
        }

        // Package interface
        public interface IPackage
        {
            string GetPackage();
        }

        // Concrete product implementation
        public class ProductDetails : IProduct
        {
            public string GetProductDetails()
            {
                return "Product details information.";
            }
        }

        // Concrete package implementation
        public class Package : IPackage
        {
            public string GetPackage()
            {
                return "Package information.";
            }
        }

        // Abstract factory interface
        public interface IAbstractFactory
        {
            IProduct CreateProduct();
            IPackage CreatePackage();
        }

        // Concrete factory implementation
        public class ConcreteFactory : IAbstractFactory
        {
            public IProduct CreateProduct()
            {
                return new ProductDetails();
            }

            public IPackage CreatePackage()
            {
                return new Package();
            }
        }

        internal class AbstarctFactroy
        {
            // Example usage
            public void ExampleUsage()
            {
                IAbstractFactory factory = new ConcreteFactory();
                IProduct product = factory.CreateProduct();
                IPackage package = factory.CreatePackage();

                Console.WriteLine(product.GetProductDetails());
                Console.WriteLine(package.GetPackage());
            }
        }
    }
}
