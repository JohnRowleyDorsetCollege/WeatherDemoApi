namespace WeatherDemoApi.Models
{
    public abstract class PredictionEngine
    {
    }

    public class Magic8Ball  : PredictionEngine { 
  
        public Magic8Ball() { }

        public List<string> predictions()
        {
            return new List<string> { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
        }

    
    }
}
