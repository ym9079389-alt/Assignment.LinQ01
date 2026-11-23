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
        }
        static void DisplayResult(IEnumerable<Product> result)
        {
            foreach (var r in result)
                Console.WriteLine($"{r.ProductName} - {r.UnitPrice}");
        }
    }
}
