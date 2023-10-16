namespace WeatherDemoApi.Models
{
    public abstract class AbstractProduct
    {
    }
    public class Product : AbstractProduct
    {
        public List<string> List()
        {
            return new List<string> { "Ladder", "Ball", "Coffee" };
        }
    }
}
