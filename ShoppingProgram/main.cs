using System;
using System.IO;
using System.Collections.Generic;


class MainClass 
{
	public static List<string> itemDescription = new List<string>();
	public static List<double> itemPrice = new List<double>();
	public static List<int> itemQoh = new List<int>();

	public static List<string> salesCustomerName = new List<string>();
	public static List<string> salesItemDescription = new List<string>();
	public static List<double> salesItemPrice = new List<double>();
	public static List<int> salesQuantity = new List<int>();

	private static int _userMenuOption;


	public static void Main (string[] args)
	{
		while (true)
		{
			DisplayMainMenu();  // Display the main menu MenuOptions
			
		}
	}


	public static int GetMenuOption() 
	{
	Console.WriteLine("Please enter your choice: ");
	string userMenuInput = Console.ReadLine();
	bool isInt = Int32.TryParse(userMenuInput, out _userMenuOption);

	try 
	{
		if (!isInt)
		{
			throw new FormatException();
		}
	}
	catch (FormatException) 
	{
		Console.WriteLine(userMenuInput + " is not a valid integer. Menu MenuOptions must be in integer format.");
		GetMenuOption();
	}

	// return the response
	return _userMenuOption;
	}


	public static void DisplayMainMenu ()
	{
		Console.Clear();
		Console.WriteLine("========== Main Menu ==========");  // Display to user that they're at the Main Menu

		for (int i = 0; i < MenuOptions.MainFunctions.Count; i++) 
		{
			Console.WriteLine($"{i+1}. " + MenuOptions.MainText[i]);
		}

		MenuOptions.MainFunctions[GetMenuOption()]();
	}


	public static void DisplayShoppingMenu ()
	{
		Console.Clear();
		Console.WriteLine("========== Shopping Menu ==========");  // Display to user that they're at the Shopping Menu

		for (int i = 0; i < MenuOptions.ShoppingFunctions.Count; i++) 
		{
			Console.WriteLine($"{i+1}. " + MenuOptions.ShoppingText[i]);
		}
		
		MenuOptions.ShoppingFunctions[GetMenuOption()]();
	}


	public static void DisplayManagementMenu ()
	{
		Console.Clear();
		Console.WriteLine("========== Management Menu ==========");  // Display to user that they're at the Management Menu

		for (int i = 0; i < MenuOptions.ManagementFunctions.Count; i++) 
		{
			Console.WriteLine($"{i+1}. " + MenuOptions.ManagementText[i]);
		}
		
		MenuOptions.ManagementFunctions[GetMenuOption()]();
	}

	public static void Exit ()
	{
		Console.WriteLine ("Thank you for shopping");
		System.Environment.Exit(1);
	}
}