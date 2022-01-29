namespace bakery_web_page_CSI340.Models
{
    public class ItemIngredients
    {
        public int ConnectionID { get; set; }

        public int MenuItemId { get; set; }

        public int IngridientID { get; set; }

        public MenuItems MenuItems { get; set; }

        public Ingredients Ingredients { get; set; }

    }
}
