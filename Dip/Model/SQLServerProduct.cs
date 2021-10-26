namespace Dip.Model
{
    public class SqlServerProduct : IDbProduct
    {
        public string GetProductById(string id)
        {
            return $"SQLServer: Exibindo dados do produto {id}";
        }
    }
}
