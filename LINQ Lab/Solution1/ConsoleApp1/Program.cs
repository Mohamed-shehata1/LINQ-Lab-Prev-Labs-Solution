using L2O___D09;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Xml;
using static L2O___D09.ListGenerators;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // // 1. Restriction Operators
            // Console.WriteLine("=== RESTRICTION OPERATORS ===\n");

            // // 1. Find all products that are out of stock.
            // Console.WriteLine("1. Products out of stock:");
            // var productsOutOfStock = ProductList.Where(p => p.UnitsInStock == 0);
            // foreach (var item in productsOutOfStock)
            // {
            //  Console.WriteLine(item);
            // }

            // // 2. Find all products that are in stock and cost more than 3.00 per unit.
            // Console.WriteLine("\n2. Products in stock and cost more than 3.00:");
            // var productsInStockAndPriceOver3 = ProductList.Where(p => p.UnitsInStock != 0).Where(p => p.UnitPrice > 3);
            // foreach (var item in productsInStockAndPriceOver3)
            // {
            //  Console.WriteLine(item);
            // }

            // // 3. Returns digits whose name is shorter than their value.
            // Console.WriteLine("\n3. Digits whose name is shorter than their value:");
            // string[] digitsArray = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            // var digitsNames = digitsArray.Where((digit, index) => digit.Length < index);

            // foreach (var item in digitsNames)
            // {
            //  Console.WriteLine(item);
            // }

            // // element operators
            // Console.WriteLine("\n=== ELEMENT OPERATORS ===");

            // // 1. Get first Product out of Stock 
            // Console.WriteLine("1. First product out of stock:");
            // var firstOutOfStock = ProductList.First(p => p.UnitsInStock == 0);
            // Console.WriteLine(firstOutOfStock);

            // // 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            // Console.WriteLine("\n2. First product with price > 1000 (or null):");
            // var firstOver1000OrNull = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            // Console.WriteLine(firstOver1000OrNull);

            // // 3. Retrieve the second number greater than 5 
            // Console.WriteLine("\n3. Second number greater than 5:");
            // int[] numbers1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var secondGreaterThan5 = numbers1.Where(a => a > 5).Skip(1).First();
            // Console.WriteLine(secondGreaterThan5);

            // // Set Operators
            // Console.WriteLine("\n=== SET OPERATORS ===");
            // // 1. Find the unique Category names from Product List
            // Console.WriteLine("1. Unique category names:");
            // var uniqueCategories = ProductList.DistinctBy(p => p.Category).Select(p => p.Category);
            // foreach (var item in uniqueCategories)
            // {
            //  Console.WriteLine(item);
            // }

            // // 2.Produce a Sequence containing the unique first letter from both product and customer names.
            // Console.WriteLine("\n2. Unique first letters from both product and customer names:");
            // var uniqueFirstLetters = ProductList
            //  .Select(p => p.ProductName[0])
            //  .Union(CustomerList.Select(c => c.CompanyName[0]));

            // foreach (var item in uniqueFirstLetters)
            // {
            //  Console.Write(item + " ");
            // }
            // Console.WriteLine();

            // // 3. Create one sequence that contains the common first letter from both product and customer names.
            // Console.WriteLine("\n3. Common first letters from both product and customer names:");
            // var commonFirstLetters = ProductList
            //   .Select(p => p.ProductName[0])                 
            //   .Intersect(CustomerList.Select(c => c.CompanyName[0]));

            // foreach (var item in commonFirstLetters)
            // {
            //   Console.Write(item);
            // }
            // Console.WriteLine();

            // // 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            // Console.WriteLine("\n4. First letters of product names not in customer names:");
            // var FirstLettersNotInCustomers = ProductList
            //   .Select(p => p.ProductName[0])
            //   .Except(CustomerList.Select(c => c.CompanyName[0]));

            // foreach (var item in FirstLettersNotInCustomers)
            // {
            //   Console.Write(item);
            // }
            // Console.WriteLine();

            // // 5. Create one sequence that contains the last Three Characters in each names of all customers and products,
            // // including any duplicates
            // Console.WriteLine("\n5. Last three characters of all product and customer names:");
            // var lastThreeChars = ProductList
            //   .Select(p => p.ProductName.Length >= 3 ? p.ProductName.Substring(p.ProductName.Length - 3) : p.ProductName)
            //   .Concat(CustomerList
            //       .Select(c => c.CompanyName.Length >= 3 ? c.CompanyName.Substring(c.CompanyName.Length - 3) : c.CompanyName));

            // foreach (var item in lastThreeChars)
            // {
            //   Console.Write(item + " ");
            // }
            // Console.WriteLine();

            // // Aggregate Operators
            // Console.WriteLine("=== AGGREGATE OPERATORS ===\n");

            // // 1. Uses Count to get the number of odd numbers in the array.
            // Console.WriteLine("\n1. number of odd numbers in the array.");
            // int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // int countOdd = numbers2.Where(i => i % 2 != 0).Count();
            // Console.WriteLine(countOdd);

            // //2.Return a list of customers and how many orders each has.
            // Console.WriteLine("\n2. list of customers and how many orders each has.");
            // var customersWithOrders = CustomerList.Select(c => new { CustomerName = c.CompanyName, OrdersCount = c.Orders.Count() });
            // foreach (var item in customersWithOrders)
            // {
            //    Console.WriteLine(item.CustomerName + " : " + item.OrdersCount);
            // }

            // // 3. Return a list of categories and how many products each has
            // Console.WriteLine("\n3. list of categories and how many products each has");
            // var categoriesAndProductCount = ProductList.GroupBy(p => p.Category).Select(group => new { Category = group.Key, ProductsCount = group.Count() });

            // foreach (var item in categoriesAndProductCount)
            // {
            //    Console.WriteLine(item.Category + " : " + item.ProductsCount);
            // }

            // // 4. Get the total of the numbers in an array.
            // Console.WriteLine("\n4. total of the numbers in an array.");
            // int[] numbers3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // var sum = numbers3.Sum();
            // Console.WriteLine(sum);

            // // 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            // Console.WriteLine("\n5. total number of characters of all words in dictionary_english.txt");
            // string[] dictWords = default;
            // try
            // {
            //     dictWords = File.ReadAllLines("dictionary_english.txt");
            // }
            // catch (IOException e)
            // {
            //     Console.WriteLine($"Error reading file: {e.Message}");
            // }

            // int countChars = 0;
            // for (int i = 0; i < dictWords?.Length; i++)
            // {
            //    countChars += dictWords[i].Length;
            // }
            // Console.WriteLine(countChars);

            // // 6. Get the total units in stock for each product category.
            // Console.WriteLine("\n6. Total units in stock for each product category:");
            // var categoriesAndUnitsCount = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) });
            // foreach (var item in categoriesAndUnitsCount)
            // {
            //    Console.WriteLine($"{item.Category} : {item.TotalUnits}");
            // }

            // // 7. Get the length of the shortest word in dictionary_english.txt
            // Console.WriteLine("\n7. Length of the shortest word in dictionary:");
            // if (dictWords?.Length > 0)
            //    Console.WriteLine(dictWords?.Min(w => w.Length));
            // else
            //    Console.WriteLine("NA");

            // // 8. Get the cheapest price among each category's products
            // Console.WriteLine("\n8. Cheapest price among each category's products:");
            // var minPricePerCategory = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, MinPrice = g.Min(p => p.UnitPrice) });
            // foreach (var item in minPricePerCategory)
            // {
            //    Console.WriteLine($"{item.Category} : {item.MinPrice}");
            // }

            // // 9. Get the products with the cheapest price in each category (Use Let)
            // Console.WriteLine("\n9. Products with the cheapest price in each category:");
            // var cheapestProductsPerCategory =
            //    from p in ProductList
            //    group p by p.Category into g
            //    let minPrice = g.Min(x => x.UnitPrice)
            //    select new { Category = g.Key, Products = g.Where(x => x.UnitPrice == minPrice) };
            // foreach (var group in cheapestProductsPerCategory)
            // {
            //    Console.WriteLine(group.Category + ":");
            //    foreach (var p in group.Products)
            //    {
            //        Console.WriteLine($"  {p.ProductName} ({p.UnitPrice})");
            //    }
            // }

            // // 10. Get the length of the longest word in dictionary_english.txt
            // Console.WriteLine("\n10. Length of the longest word in dictionary:");
            // if (dictWords?.Length > 0)
            //    Console.WriteLine(dictWords.Max(w => w.Length));
            // else
            //    Console.WriteLine("NA");

            // // 11. Get the most expensive price among each category's products.
            // Console.WriteLine("\n11. Most expensive price among each category's products:");
            // var maxPricePerCategory = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, MaxPrice = g.Max(p => p.UnitPrice) });
            // foreach (var item in maxPricePerCategory)
            // {
            //    Console.WriteLine($"{item.Category} : {item.MaxPrice}");
            // }

            // // 12. Get the products with the most expensive price in each category.
            // Console.WriteLine("\n12. Products with the most expensive price in each category:");
            // var mostExpensiveProductsPerCategory =
            //    from p in ProductList
            //    group p by p.Category into g
            //    let maxPrice = g.Max(x => x.UnitPrice)
            //    select new { Category = g.Key, Products = g.Where(x => x.UnitPrice == maxPrice) };
            // foreach (var group in mostExpensiveProductsPerCategory)
            // {
            //    Console.WriteLine(group.Category + ":");
            //    foreach (var p in group.Products)
            //    {
            //        Console.WriteLine($"  {p.ProductName} ({p.UnitPrice})");
            //    }
            // }

            // // 13. Get the average length of the words in dictionary_english.txt
            // Console.WriteLine("\n13. Average length of dictionary words:");
            // if (dictWords.Length > 0)
            //    Console.WriteLine(dictWords.Average(w => w.Length));
            // else
            //    Console.WriteLine("NA");

            // // 14. Get the average price of each category's products.
            // Console.WriteLine("\n14. Average price of each category's products:");
            // var avgPricePerCategory = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, AvgPrice = g.Average(p => p.UnitPrice) });
            // foreach (var item in avgPricePerCategory)
            // {
            //    Console.WriteLine($"{item.Category} : {item.AvgPrice}");
            // }

            // // Ordering Operators
            // Console.WriteLine("\n=== ORDERING OPERATORS ===\n");

            // // 1. Sort a list of products by name
            // Console.WriteLine("1. Products sorted by name:");
            // foreach (var p in ProductList.OrderBy(p => p.ProductName))
            //    Console.WriteLine(p.ProductName);

            // // 2. Case-insensitive sort of words in an array
            // Console.WriteLine("\n2. Case-insensitive sort of words:");
            // string[] words1 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            // foreach (var w in words1.OrderBy(w => w, StringComparer.OrdinalIgnoreCase))
            //    Console.WriteLine(w);

            // // 3. Products by units in stock from highest to lowest
            // Console.WriteLine("\n3. Products by units in stock (desc):");
            // foreach (var p in ProductList.OrderByDescending(p => p.UnitsInStock))
            //    Console.WriteLine($"{p.ProductName} : {p.UnitsInStock}");

            // // 4. Digits sorted by name length then alphabetically
            // Console.WriteLine("\n4. Digits sorted by length then alphabetically:");
            // string[] digitsArray2 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            // foreach (var d in digitsArray2.OrderBy(d => d.Length).ThenBy(d => d))
            //    Console.WriteLine(d);

            // // 5. Words sorted by length then case-insensitive word
            // Console.WriteLine("\n5. Words sorted by length then case-insensitive:");
            // string[] words2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            // foreach (var w in words2.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase))
            //    Console.WriteLine(w);

            // // 6. Products sorted by category then unit price desc
            // Console.WriteLine("\n6. Products sorted by category, then price desc:");
            // foreach (var p in ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice))
            //    Console.WriteLine($"{p.Category} - {p.ProductName} : {p.UnitPrice}");

            // // 7. Words sorted by length then case-insensitive descending
            // Console.WriteLine("\n7. Words sorted by length then case-insensitive descending:");
            // string[] words3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            // foreach (var w in words3.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase))
            //    Console.WriteLine(w);

            // // 8. Digits whose second letter is 'i' reversed from original order
            // Console.WriteLine("\n8. Digits whose second letter is 'i' reversed:");
            // string[] digitsArray3 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            // foreach (var d in digitsArray3.Where(d => d.Length > 1 && d[1] == 'i').Reverse())
            //    Console.WriteLine(d);

            //// Partitioning Operators
            //Console.WriteLine("\n=== PARTITIONING OPERATORS ===\n");

            //// 1. First 3 orders from customers in Washington
            //Console.WriteLine("1. First 3 orders from customers in WA:");
            //var waOrders = CustomerList.Where(c => c.Region == "WA").SelectMany(c => c.Orders);
            //foreach (var o in waOrders.Take(3))
            //   Console.WriteLine(o);

            //// 2. All but first 2 orders from customers in Washington
            //Console.WriteLine("\n2. All but first 2 orders from customers in WA:");
            //foreach (var o in waOrders.Skip(2))
            //   Console.WriteLine(o);

            //// 3. Take while number not less than its position
            //Console.WriteLine("\n3. Numbers until a number is less than its index:");
            //int[] numbers4 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //foreach (var n in numbers4.TakeWhile((n, i) => n >= i))
            //   Console.WriteLine(n);


            //// 4. Elements starting from first divisible by 3
            //Console.WriteLine("\n4. Elements starting from first divisible by 3:");
            //foreach (var n in numbers4.SkipWhile(n => n % 3 != 0))
            //    Console.WriteLine(n);

            //// 5. Elements starting from first element less than its position
            //Console.WriteLine("\n5. Elements starting from first element less than its index:");
            //foreach (var n in numbers4.SkipWhile((n, i) => n >= i))
            //    Console.WriteLine(n);

            /****************************************************************************************************************************/

            // Projection Operators
            Console.WriteLine("\n=== PROJECTION OPERATORS ===\n");

            // 1. Sequence of product names
            Console.WriteLine("\n1. Product names:");
            foreach (var name in ProductList.Select(p => p.ProductName))
                Console.WriteLine(name);

            // 2. Uppercase and lowercase versions (Anonymous Types)
            Console.WriteLine("\n2. Uppercase and lowercase versions:");
            string[] words4 = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var upperLower = words4.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
            foreach (var x in upperLower)
                Console.WriteLine($"{x.Upper} | {x.Lower}");

            // 3. Some properties of Products with Price alias
            Console.WriteLine("\n3. Products projection with Price alias:");
            var productProj = ProductList.Select(p => new { p.ProductName, p.Category, Price = p.UnitPrice });
            foreach (var x in productProj)
                Console.WriteLine($"{x.ProductName} - {x.Category} - {x.Price}");

            // 4. Determine if ints match their position
            Console.WriteLine("\n4. Numbers: In-place?");
            int[] arrProj = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var inPlace = arrProj.Select((val, idx) => new { Number = val, InPlace = val == idx });
            foreach (var x in inPlace)
                Console.WriteLine($"{x.Number}: {x.InPlace}");

            // 5. All pairs where a < b
            Console.WriteLine("\n5. Pairs where a < b:");
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var pairs = from a in numbersA
                        from b in numbersB
                        where a < b
                        select new { a, b };
            foreach (var p in pairs)
                Console.WriteLine($"{p.a} is less than {p.b}");

            // 6. Select all orders where total < 500.00
            Console.WriteLine("\n6. Orders with total < 500.00:");
            var smallOrders = CustomerList.SelectMany(c => c.Orders.Where(o => o.Total < 500.00m));
            foreach (var o in smallOrders)
                Console.WriteLine(o);

            // 7. Orders made in 1998 or later
            Console.WriteLine("\n7. Orders in 1998 or later:");
            var recentOrders = CustomerList.SelectMany(c => c.Orders.Where(o => o.OrderDate.Year >= 1998));
            foreach (var o in recentOrders)
                Console.WriteLine(o);

            // // Quantifiers
            // Console.WriteLine("\n=== QUANTIFIERS ===\n");

            // // 1. Any dictionary word contains 'ei'
            // Console.WriteLine("1. Any word contains 'ei':");
            // Console.WriteLine(dictWords.Any(w => w.Contains("ei")));

            // // 2. Categories with at least one product out of stock (grouped)
            // Console.WriteLine("\n2. Categories with at least one out-of-stock product:");
            // var anyOutOfStock = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Any(p => p.UnitsInStock == 0));
            // foreach (var g in anyOutOfStock)
            // {
            //    Console.WriteLine(g.Key + ":");
            //    foreach (var p in g)
            //        Console.WriteLine("  " + p.ProductName);
            // }

            // // 3. Categories with all products in stock (grouped)
            // Console.WriteLine("\n3. Categories with all products in stock:");
            // var allInStock = ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0));
            // foreach (var g in allInStock)
            // {
            //    Console.WriteLine(g.Key + ":");
            //    foreach (var p in g)
            //        Console.WriteLine("  " + p.ProductName);
            // }

            // // Grouping Operators
            // Console.WriteLine("\n=== GROUPING OPERATORS ===\n");

            // // 1. Group numbers by remainder when divided by 5
            // Console.WriteLine("1. Numbers grouped by remainder mod 5:");
            // int[] toGroup = { 0, 5, 10, 1, 6, 11, 7, 2, 12, 3, 8, 13, 4, 9, 14 };
            // var groupedByRemainder = toGroup.GroupBy(n => n % 5).OrderBy(g => g.Key);
            // foreach (var g in groupedByRemainder)
            // {
            //    Console.WriteLine($"Numbers with a remainder of {g.Key} when divided by 5:");
            //    foreach (var n in g)
            //        Console.WriteLine(n);
            // }

            // // 2. Group dictionary words by their first letter
            // Console.WriteLine("\n2. Dictionary words grouped by first letter:");
            // var dictByFirst = dictWords
            //    .Where(w => !string.IsNullOrEmpty(w))
            //    .GroupBy(w => char.ToUpperInvariant(w[0]))
            //    .OrderBy(g => g.Key);
            // foreach (var g in dictByFirst)
            // {
            //    Console.WriteLine(g.Key + ":");
            //    foreach (var w in g.Take(5)) // show sample to keep output reasonable
            //        Console.WriteLine("  " + w);
            // }

            // // 3. Group by anagram equivalence (same characters)
            // Console.WriteLine("\n3. Group by same characters (anagrams):");
            // string[] anagramArr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
            // static string Normalize(string s)
            // {
            //    var trimmed = new string((s ?? string.Empty).Where(c => !char.IsWhiteSpace(c)).ToArray()).ToLowerInvariant();
            //    var chars = trimmed.ToCharArray();
            //    Array.Sort(chars);
            //    return new string(chars);
            // }
            // var anagramGroups = anagramArr
            //    .GroupBy(s => Normalize(s))
            //    .OrderBy(g => g.Key);
            // foreach (var g in anagramGroups)
            // {
            //    foreach (var s in g)
            //        Console.WriteLine(s.Trim());
            //    Console.WriteLine();
            // }

        }
    }
}
