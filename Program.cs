namespace Assignment.LinQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //var Result = ListGenerator.ProductList.Where(p => p.Category == "Seafood");
            //DisplayResult(Result);
            #endregion

            #region Q02
            //var Result = ListGenerator.ProductList.Select(p => new { p.ProductName });
            //DisplayResult(Result);
            #endregion

            #region Q03
            //var Result = ListGenerator.ProductList.OrderBy(P => P.UnitPrice);
            //DisplayResult(Result);
            #endregion

            #region Q04
            //var Result = ListGenerator.ProductList.Where(P => P.UnitPrice > 10 && P.UnitPrice < 30);
            //DisplayResult(Result);
            #endregion

            #region Q05
            //var Result = ListGenerator.ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Condiments");
            //foreach (var r in Result)
            //    Console.WriteLine($"{r.ProductName} - {r.UnitPrice} - {r.Category}");
            #endregion

            #region Q06
            //var Result = ListGenerator.ProductList.Select(P => new 
            //                                              { 
            //                                              Name = P.ProductName,
            //                                              Price = P.UnitPrice,
            //                                              StockStatus = P.UnitsInStock > 0 ? "Available" : "Out of Stock"

            //});

            //    foreach (var r in Result)
            //        Console.WriteLine($"{r.Name} | {r.Price} | {r.StockStatus}");

            #endregion

            #region Q07
            //var Result = ListGenerator.ProductList.Select((p, index) => new { Index = index + 1, p.ProductName });
            //foreach (var r in Result)
            //    Console.WriteLine(String.Join(". ", r.Index, r.ProductName));
            #endregion

            #region Q08
            //var Result = ListGenerator.ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);
            //foreach (var r in Result)
            //    Console.WriteLine($"{r.Category} - {r.UnitPrice}");
            #endregion

            #region Q09
            //var Result = ListGenerator.ProductList.Where(P => P.Category == "Beverages").OrderByDescending(P => P.UnitsInStock);
            //foreach (var r in Result)
            //    Console.WriteLine($"{r.ProductName} - {r.UnitsInStock}");
            #endregion

            #region Q10
            //var Result = from C in ListGenerator.CustomerList
            //             from O in C.Orders
            //             where O.OrderDate.Year >= 1971
            //             select new { C.CustomerID, O.OrderDate };

            //foreach (var r in Result)
            //    Console.WriteLine($"{r.CustomerID} - {r.OrderDate}");
            #endregion
        }
        static void DisplayResult(IEnumerable<Product> result)
        {
            foreach (var r in result)
                Console.WriteLine($"{r.ProductName} - {r.UnitPrice}");
        }
    }
}
