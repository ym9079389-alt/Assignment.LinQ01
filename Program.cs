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


        }
        static void DisplayResult(IEnumerable<Product> result)
        {
            foreach (var r in result)
                Console.WriteLine($"{r.ProductName} - {r.UnitPrice}");
        }
    }
}
