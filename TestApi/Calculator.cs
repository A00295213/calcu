using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[Action]")]
    [ApiController]
    public class Calculator : ControllerBase
    {
          [HttpGet]
        public decimal Add(decimal a,decimal b){
            decimal result = a+b;
            return result;
        }
         [HttpGet]
        public decimal Subtract(decimal a,decimal b){
            decimal result = a-b;
            return result;
        }
         [HttpGet]
        public decimal Multiply(decimal a,decimal b){
            decimal result = a*b;
            return result;
        }
         [HttpGet]
        public ActionResult Divide(decimal a,decimal b){
            if(b==0){
                return BadRequest("can not divide by 0.");
            }
            decimal result = a/b;
            return Ok(result);
        }
         public ActionResult Modulo(decimal a,decimal b){
            if(b==0){
                return BadRequest("can not calculate by 0.");
            }
            decimal result = a%b;
            return Ok(result);
        }
    }
}
