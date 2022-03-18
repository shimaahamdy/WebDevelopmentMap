using System.Text.RegularExpressions;
using static lab.ListGenerators;
namespace lab
{
    public class Program
    {
        /* note change directory of dicionary english if you want to test */
        public static void Main()
        {
            #region LINQ - Restriction Operators  
            
            //1. Find all products that are out of stock.
            var Result = ProductList.Where((p) => p.UnitsInStock == 0);
          

            //2. Find all products that are in stock and cost more than 3.00 per unit.
            Result = ProductList.Where((p) => p.UnitsInStock != 0 && p.UnitPrice>3);

            //3.Returns digits whose name is shorter than their value.
            string[] digtsarr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var difits = digtsarr.Where((digit, index) => digit.Length < index);

            #endregion

            #region LINQ - Element Operators               

            //1. Get first Product out of Stock 
            var result = ProductList.First((p) => p.UnitsInStock == 0);

            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            result = ProductList.FirstOrDefault((p) => p.UnitPrice>1000);
           

            //3. Retrieve the second number greater than 5 
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var second = (from e in Arr
                      where e > 5 && e != (Arr.FirstOrDefault((e) => e > 5))
                      select e).FirstOrDefault();
            #endregion


            #region LINQ - Set Operators                     
            // 1. Find the unique Category names from Product List
            var uniqueCat = ProductList.Distinct(new UniqueName()).Select(p => p.Category);
            

            //2. Produce a Sequence containing the unique first letter from both product and customer names.
            var list1 = ProductList.Select(P => P.ProductName.ToCharArray()[0]);
            var list2 = CustomerList.Select(C => C.CustomerID.ToCharArray()[0]);
            var UniqueList = list1.Union(list2);

            //foreach (var item in UniqueList) {Console.WriteLine(item);}

            //3. Create one sequence that contains the common first letter from both product and customer names.
            var CommonList = list1.Intersect(list2);
            

            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            var exceptList = list1.Except(list2);
           

            //5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates
            var list3 = ProductList.Select(P => P.ProductName.Remove(0,P.ProductName.Length-3));
            var list4 = CustomerList.Select(C => C.CompanyName.Remove(0,C.CustomerID.Length-3));
            var dubList = list3.Concat(list4);
            #endregion

            #region LINQ - Aggregate Operators
            //1. Uses Count to get the number of odd numbers in the array
            int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var num = Arr2.Count(e => e % 2 == 1);
            //Console.WriteLine(num);

            //2. Return a list of customers and how many orders each has.
            var cusList = CustomerList.Select(e => new {e.CustomerID, orderNumbers = e.Orders.Count()});
            //foreach(var item in cusList)Console.WriteLine(item);

            //3. Return a list of categories and how many products each has
            var catList = ProductList.GroupBy(P => P.Category).Select(PG => new {PG.Key , productsNum=PG.Count()});
            //foreach (var item in catList) Console.WriteLine(item);

            //4. Get the total of the numbers in an array.
            var totalNum = Arr2.Sum();
            //Console.WriteLine(totalNum);

            //5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            string path = @"E:\software engineering\ITI\tasks\15_C#\day10\tasks\Assignment Files\dictionary_english.txt";
            string[] lines = File.ReadAllLines(path);

            var words = lines.Select(l => new { l, l.Length });
            //foreach (var item in words)Console.WriteLine(item);

            //6. Get the total units in stock for each product category.
            var unitList = ProductList.GroupBy(P => P.Category).Select(PG => new {PG.Key, unitsInStock = PG.Sum(p => p.UnitsInStock)});
            //foreach (var item in unitList) Console.WriteLine(item);

            //7. Get the length of the shortest word in dictionary_english.txt
            var shotWord = lines.Min(l => l.Length);
            //Console.WriteLine(shotWord);

            //8. Get the cheapest price among each category's products
            var cheapList = ProductList.GroupBy(P => P.Category).Select(PG => new { PG.Key, cheapest = PG.Min(p => p.UnitPrice) });
            //foreach (var item in cheapList) Console.WriteLine(item);


            //9. Get the products with the cheapest price in each category (Use Let)
            var cheapProd = from P in ProductList
                            group P by P.Category into C
                            let CheapPrice = C.OrderBy(p => p.UnitPrice).FirstOrDefault()
                            select new { C.Key, CheapProduct = CheapPrice };
            //foreach (var item in cheapProd) Console.WriteLine(item);

            //10. Get the length of the longest word in dictionary_english.txt
            var longWord = lines.Max(l => l.Length);
            //Console.WriteLine(longWord)

            //11. Get the most expensive price among each category's products.
            var expenList = ProductList.GroupBy(P => P.Category).Select(PG => new { PG.Key, expensive = PG.Max(p => p.UnitPrice) });
            //foreach (var item in expenList) Console.WriteLine(item);

            //12. Get the products with the most expensive price in each category.
            var expenProd = from P in ProductList
                            group P by P.Category into E
                            let CheapPrice = E.OrderByDescending(p => p.UnitPrice).FirstOrDefault()
                            select new { E.Key, CheapProduct = CheapPrice };
            //foreach (var item in expenProd) Console.WriteLine(item);

            //13. Get the average length of the words in dictionary_english.
            var avgWord = lines.Average(l => l.Length);
            //Console.WriteLine(avgWord);

            //14. Get the average price of each category's products.
            var avgList = ProductList.GroupBy(P => P.Category).Select(PG => new { PG.Key, average = PG.Average(p => p.UnitPrice) });
            //foreach (var item in avgList) Console.WriteLine(item);
            #endregion

            #region LINQ - Ordering Operators
            //1. Sort a list of products by name
            var sortedProd = ProductList.OrderBy(P => P.ProductName);
            //foreach(var item in sortedProd) Console.WriteLine(item);

            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            string[] words2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedArr3 = words2.OrderBy(e => e,new CaseInSenestive());
            //foreach (var item in sortedArr3) Console.WriteLine(item);

            //3. Sort a list of products by units in stock from highest to lowest.
            var sortedProdDec = ProductList.OrderByDescending(P => P.UnitPrice);
            //foreach (var item in sortedProdDec) Console.WriteLine(item);

            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            string[] Arr3 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var sortedArr4 = Arr3.OrderBy(E => E.Length).ThenBy (E => E);
            //foreach (var item in sortedArr4) Console.WriteLine(item);

            //5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            string[] words3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedwords3 = words3.OrderBy(E => E.Length).ThenBy(E => E,new CaseInSenestive());
            //foreach (var item in sortedwords3) Console.WriteLine(item);

            //6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            var sortProd3 = ProductList.OrderByDescending(P => P.Category).ThenByDescending(P => P.UnitPrice);
            //foreach (var item in sortProd3) Console.WriteLine(item);

            //7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            var sortwords4 = words3.OrderBy(E => E.Length).ThenByDescending(E => E, new CaseInSenestive());
            //foreach (var item in sortwords4) Console.WriteLine(item);

            //8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            var sortedArr5 = Arr3.Reverse().Where(Index => Index[1] == 'i');
            //foreach (var item in sortedArr5) Console.WriteLine(item);
            #endregion

            #region LINQ - Partitioning Operators
            //1. Get the first 3 orders from customers in Washington
            var order3 = CustomerList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).Take(3); ;
            //foreach (var item in order3)Console.WriteLine(item);

            //2. Get all but the first 2 orders from customers in Washington.
            var order4 = CustomerList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).Skip(2); ;
            //foreach (var item in order4) Console.WriteLine(item);

            //3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var elements1 = numbers.TakeWhile((v, i) => v > i);
            //foreach (var item in elements1) Console.WriteLine(item);

            //4. Get the elements of the array starting from the first element divisible by 3.
            var elments2 = numbers.Where(i => i % 3 == 0 && i!=0);
            //foreach (var item in elments2) Console.WriteLine(item);

            //5. 5. Get the elements of the array starting from the first element less than its position.
            var element3 = numbers.SkipWhile((v, i) => v >= i);
            //foreach (var item in element3) Console.WriteLine(item);
            #endregion

            #region LINQ - Projection Operators
            //1. Return a sequence of just the names of a list of products.
            var productsnames = ProductList.Select(P => P.ProductName);

            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            string[] words4 = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var seq1 = words4.Select(w => w.ToLower());
            var seq2 = words4.Select(w => w.ToUpper());
            var seq = seq1.Union(seq2);
            //foreach (var item in seq) Console.WriteLine(item);

            //3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            var seq4 = ProductList.Select(P => new { P.ProductName, Price = P.UnitPrice });
            //foreach (var item in seq4) Console.WriteLine(item);

            //4. Determine if the value of ints in an array match their position in the array.
            int[] Arr6 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var check = Arr6.Select((v,i) => $"{v}:{v==i}");
            //foreach (var item in check)Console.WriteLine(item);

            //5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var pa = numbersA.SelectMany(nA => numbersB, (a, b) => new { a, b }).Where(num => num.a < num.b);
            //foreach (var item in pa)Console.WriteLine(item);

            //6. Select all orders where the order total is less than 500.00.
            var ordersTotal = CustomerList.SelectMany(c => c.Orders).Where(o => o.Total > 500);
            //foreach (var item in ordersTotal)Console.WriteLine(item);

            //7. Select all orders where the order was made in 1998 or later.
            var ordersTotal2 = CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);
            //foreach (var item in ordersTotal2)Console.WriteLine(item);

            #endregion

            #region LINQ - Quantifiers
            //1. Determine if any of the words in dictionary_english.txt contain the substring 'ei'.
            var eiwords = lines.Any(l => l.Contains("ei"));
            //Console.WriteLine(eiwords);

            //2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            var groubProdList = ProductList.GroupBy(p => p.Category).Where(PG => PG.Count(p => p.UnitsInStock == 0) > 0);
            /*foreach (var item in groubProdList)
            {
                Console.WriteLine(item);
                foreach (var prod in item)
                    Console.WriteLine(prod);
            }*/

            //3. Return a grouped a list of products only for categories that have all of their products in stock.
            var groupedlist = ProductList.GroupBy(P => P.Category).Where(PG => PG.All(P => P.UnitsInStock > 0));
            /*foreach (var item in groubProdList)
            {
                Console.WriteLine(item);
                foreach (var prod in item)
                    Console.WriteLine(prod);
            }*/
            #endregion

            #region LINQ - Grouping Operators

            //1. Use group by to partition a list of numbers by their remainder when divided by 5
            var numberGroups = numbers.GroupBy(N => N % 5);
            /*foreach (var item in numberGroups)
            {
                Console.WriteLine($"Numbers with a remainder of {item.Key} when divided by 5:");
                foreach (var prod in item)
                    Console.WriteLine(prod);
            }*/

            //2. Uses group by to partition a list of words by their first letter.
            var wordsgroup = lines.GroupBy(l => l[0]);
            /* foreach (var item in wordsgroup)
            {
                Console.WriteLine($"********{item.Key}******:");
                foreach (var prod in item)
                    Console.WriteLine(prod);
            }*/

           
            #endregion




        }


    }
}
