namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Product
    {
        public Product(string title,
                string description,
                string image,
                string price,
                string quantityOnHand)
        {
            Title = title;
            Description = description;
            Image = image;
            Price = price;
            QuantityOnHand = quantityOnHand;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public decimal Price { get; private set; }
        public string QuantityOnHand { get; private set; }
    }
}