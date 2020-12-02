using System;
using System.IO;
using System.Collections.Generic;


static class MenuOptions 
    {
        // Main Menu
        public static readonly Dictionary<int, System.Action> MainFunctions = new Dictionary<int, System.Action> ()
        {
            {1, MainClass.DisplayShoppingMenu}, {2, MainClass.DisplayManagementMenu}, {3, MainClass.Exit}
        };
        public static readonly string[] MainText = {"Go Shopping", "Management Menu", "Quit the program"};
        

        // Shopping Menu
        public static readonly Dictionary<int, System.Action> ShoppingFunctions = new Dictionary<int, System.Action> ()
        {
            {1, ShoppingMenu.AddItemToCart}, {2, ShoppingMenu.Checkout}, {3, MainClass.DisplayMainMenu}
        };
        public static readonly string[] ShoppingText = {"Choose an item", "Checkout", "Return to Main Menu"};
        
		
        // Management Menu
        public static readonly Dictionary<int, System.Action> ManagementFunctions = new Dictionary<int, System.Action> ()
        {
            {1, ManagementMenu.GetCustomerName}, {2, ManagementMenu.ListAllItems}, {3, ManagementMenu.AddItemToStore},
            {4, ManagementMenu.ChangeQoh},       {5, ManagementMenu.ChangePrice},  {6, MainClass.DisplayMainMenu}
        };
        public static readonly string[] ManagementText =
        {
            "Browse sales receipts", "View all items", "Add an item", 
            "Change Quantity On Hand", "Change Item Price", "Return to Main Menu"
        };
    }
