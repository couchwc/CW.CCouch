// See https://aka.ms/new-console-template for more information

/* **************************************************
 * Introduction
 * ************************************************** */
Console.WriteLine("Hello, World!");
Console.WriteLine();
Console.WriteLine($"{DateTime.Now.ToString(CW.CCouch.SharedKernel.Formatting.Constants.FullDateTimeFormat)} Begin...");
Console.WriteLine();

/* ************************************************** */

/* **************************************************
 * Do Work
 * ************************************************** */

// RGB To Hex Conversion Exercise
var rgbToHexConversionOutput =
    CW.CCouch.Seeding.Exersices.RGBToHexConversion.Exercise();

Console.WriteLine($"{rgbToHexConversionOutput}");
Console.WriteLine();

// Sorting Integer Collection Exercise
var sortingInegerCollectionOutput =
    CW.CCouch.Seeding.Exersices.SortingIntegerCollection.Exercise();

Console.WriteLine($"{sortingInegerCollectionOutput}");
Console.WriteLine();

/* ************************************************** */

/* **************************************************
 * Conclusion 
 * ************************************************** */
Console.WriteLine($"{DateTime.Now.ToString(CW.CCouch.SharedKernel.Formatting.Constants.FullDateTimeFormat)} End...");
Console.WriteLine();
Console.WriteLine("Goodbye!");

/* ************************************************** */
