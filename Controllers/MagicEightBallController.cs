using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherDemoApi.Models;

namespace WeatherDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagicEightBallController : ControllerBase
    {
        private readonly Magic8Ball magic8Ball = new Magic8Ball();

        public MagicEightBallController()
        {
            
        }


        [HttpGet("list")]
        
        public List<string> GetList()
        {
        
            return magic8Ball.predictions();
        }

        [HttpGet("prediction")]

        public string GetPrediction()
        {
            Random rnd = new Random();
          

            List<string> predictions = magic8Ball.predictions();

            int predictionIndex = rnd.Next(0, predictions.Count); // creates a number between 1 and 12
          
            return predictions.ToArray()[predictionIndex];
        }

        [HttpGet("prediction/{id}")]

        public string GetSpecificPrediction(int id)
        {
           
            return magic8Ball.predictions().ToArray()[id];
        }
    }
}
