namespace bakery_web_page_CSI340.Models
{
    public class ItemIngredients
    {
        public int Id { get; set; }

        public int MenuItemID { get; set; }

        public int IngredientIDs { get; set; }

        public MenuItems MenuItems { get; set; }

        public Ingredients Ingredients { get; set; }

    }
}
