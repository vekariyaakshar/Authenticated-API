namespace ShoppingCartAPIModels
{
public class Catagory
{
   public class ShoppingCart
{
    public int Id { get; set; }
    public string User { get; set; } // Assuming User is identified by a simple string. Adjust based on your user identification strategy.
    public List<Product> Products { get; set; } = new List<Product>();
}
   }
}