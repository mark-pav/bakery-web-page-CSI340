﻿namespace bakery_web_page_CSI340.Models
{
    public class MenuItems
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int NumberOfCalories { get; set; }
        public bool IsVegan { get; set; }
        public bool IsVegeterian { get; set; }

        public MenuItems()
        {

        }
    }
}
