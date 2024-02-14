//using Microsoft.AspNetCore.Mvc;

namespace UtilityLibraries;

   // [Route("[controller]/[action]")]
   // [ApiController]
    public static class MyclassLibrary
    {  
        public static decimal Add(decimal a = 5, decimal b = 2)
        {
            decimal result = a+b;
            return result;
        }  
      
         public static decimal Subtract(decimal a = 5, decimal b = 2)
        {
             decimal result = a-b;
            return result;
        }   
       
        public static decimal Multiply(decimal a = 5, decimal b = 2)
        {
            decimal result = a*b;
            return result;
        } 
       
        public static string Divide(decimal a = 5, decimal b = 2)
        {
            if( b != 0) 
            {
                return $"Hello Reader.\nThe Division of {a} and {b} is = {a / b}";
            }
            else
            {
                return $"can not divided by 0";
            }

        } 
       
         public static string Modulo(decimal a = 5, decimal b = 2)
        {
            return $"Hello Reader.\nThe Remainder of {a} and {b} is = {a % b}";
        }   


       

    }
