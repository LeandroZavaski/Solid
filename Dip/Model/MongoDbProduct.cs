namespace Dip.Model
{
    public class MongoDbProduct : IDbProduct
    {
        public string GetProductById(string id)
        {
            return $"MongoDb: Exibindo dados do produto {id}";
        }
    }
}
