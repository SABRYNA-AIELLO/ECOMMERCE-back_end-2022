using Back_End.Models;

namespace Back_End.Repositories
{
    public class ProductRepository
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            Product product1 = new Product(1, "Producto 1", 3000, false, false);
            product1.Description = "Remera basica blanca";
            product1.category = new Category(1, "Remeras");
            products.Add(product1);

            Product product2 = new Product(2, "Producto 2", 800, true, false);
            product2.Description = "Buzo canguro sin capucha";
            product2.category = new Category(2, "Buzos");
            products.Add(product2);

            Product product3 = new Product(3, "Producto 3", 1000, false, false);
            product3.Size = "XXXL";
            products.Add(product3);

            Product product4 = new Product(4, "Producto 4", 1000, true, false);
            product4.Description = "Buzo canguro con capucha";
            product4.category = new Category(2, "Buzos");
            products.Add(product4);

            Product product5 = new Product(5, "Producto 5", 2000, false, true);
            product5.Description = "Remera roja Navidad";
            product5.category = new Category(3, "Navidad");
            products.Add(product5);

            Product product6 = new Product(6, "Producto 6", 2000, false, false);
            product6.Description = "Remera basica roja";
            product6.category = new Category(1, "Remeras");
            products.Add(product6);

            Product product7 = new Product(7, "Producto 7", 1500, false, true);
            product7.Description = "Remera verde Navidad";
            product7.category = new Category(3, "Navidad");
            products.Add(product7);

            return products;
        }
    }
}
