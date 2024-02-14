using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;
namespace MyclassLibraryTests;


[TestClass]
public class UnitTest1
{

    
 //Addition 



    [TestMethod]
     public void Add_WhenCalledWithTwoPositiveNumbers_ReturnsSum()
    {      
         
        decimal a = 7;
        decimal b = 8;
        decimal expectedSum = a + b;       
        string result = StringLibrary.Add(a, b);       
        Assert.AreEqual($"Hello Reader.\nThe Addition of {a} and {b} is = {expectedSum}", result);
    }

    [TestMethod]
    public void Add_WhenCalledWithNegativeAndPositiveNumbers_ReturnsSum()
    {
        decimal a = 7;
        decimal b = -2;
        decimal expectedSum = a + b;       
        string result = StringLibrary.Add(a, b);       
        Assert.AreEqual($"Hello Reader.\nThe Addition of {a} and {b} is = {expectedSum}", result);
    }

    

    [TestMethod]
    public void Add_WhenCalledWithTwoNegativeNumbers_ReturnsSum()
    {
        decimal a = -9;
        decimal b = -2;
        decimal expectedSum = a + b;       
        string result = StringLibrary.Add(a, b);       
        Assert.AreEqual($"Hello Reader.\nThe Addition of {a} and {b} is = {expectedSum}", result);
    }

    [TestMethod]
    public void Add_WhenCalledWithZero_ReturnsOtherNumber()
    {
        decimal a = 87;
        decimal b = 0;              
        string result = StringLibrary.Add(a, b);       
       Assert.AreEqual($"Hello Reader.\nThe Addition of {a} and {b} is = {a}", result);
    }

    [TestMethod]
    public void Add_WhenCalledWithTwoZeros_ReturnsZero()
    {
        
        decimal a = 0;
        decimal b = 0;
        string result = StringLibrary.Add(a, b);
        Assert.AreEqual($"Hello Reader.\nThe Addition of {a} and {b} is = 0", result);
    }


        //Sunstraction 



    [TestMethod]    
    public void Subtract_TwoPositiveNumbers_ReturnsDifference()
    {    
        decimal a = 9;
        decimal b = 4;
        decimal expectedDifference = a - b;
        string result = StringLibrary.Subtract(a, b);
        Assert.AreEqual($"Hello Reader.\nThe Subtraction of {a} and {b} is = {expectedDifference}", result);
    }
    [TestMethod] 
    public void Subtract_ZeroFromPositiveNumber_ReturnsPositiveNumber()
    {    
         decimal a = 7;
         decimal b = 0;   
         string result = StringLibrary.Subtract(a, b);   
         Assert.AreEqual($"Hello Reader.\nThe Subtraction of {a} and {b} is = {a}", result);
    }
    [TestMethod] 
    public void Subtract_PositiveNumberFromZero_ReturnsNegativeNumber()
    {

        decimal a = 0;
        decimal b = 10;
        string result = StringLibrary.Subtract(a, b); 
        Assert.AreEqual($"Hello Reader.\nThe Subtraction of {a} and {b} is = -{b}", result);
    }
    [TestMethod] 
    public void Subtract_TwoNegativeNumbers_ReturnsNegativeDifference()
    {
   
        decimal a = -5;
        decimal b = -3;
        decimal expectedDifference = a - b;   
        string result = StringLibrary.Subtract(a, b);   
        Assert.AreEqual($"Hello Reader.\nThe Subtraction of {a} and {b} is = {expectedDifference}", result);
    }
    [TestMethod] 
    public void Subtract_PositiveNumberFromNegativeNumber_ReturnsNegativeDifference()
    {    
        decimal a = -8;
        decimal b = 3;
        decimal expectedDifference = a - b;    
        string result = StringLibrary.Subtract(a, b);  
        Assert.AreEqual($"Hello Reader.\nThe Subtraction of {a} and {b} is = {expectedDifference}", result);
    }

    //Multiplication
     [TestMethod]
    public void Multiply_TwoPositiveNumbers_ReturnsProduct()
    {       
        decimal a = 15;
        decimal b = 3;
        decimal expectedProduct = a * b;      
        string result = StringLibrary.Multiply(a, b);       
        Assert.AreEqual($"Hello Reader.\nThe Multiplication of {a} and {b} is = {expectedProduct}", result);
    }

    [TestMethod]
    public void Multiply_PositiveNumberByZero_ReturnsZero()
    {       
        decimal a = 10;       
        string result = StringLibrary.Multiply(a, 0);       
        Assert.AreEqual($"Hello Reader.\nThe Multiplication of {a} and 0 is = 0", result);
    }

    [TestMethod]
    public void Multiply_TwoNegativeNumbers_ReturnsProduct()
    {       
        decimal a = -4;
        decimal b = -2;
        decimal expectedProduct = a * b;    
        string result = StringLibrary.Multiply(a, b);    
        Assert.AreEqual($"Hello Reader.\nThe Multiplication of {a} and {b} is = {expectedProduct}", result);
    }

    [TestMethod]
    public void Multiply_PositiveNumberByOne_ReturnsSameNumber()
    {       
        decimal a = 21;     
        string result = StringLibrary.Multiply(a, 1);      
        Assert.AreEqual($"Hello Reader.\nThe Multiplication of {a} and 1 is = {a}", result);
    }

    [TestMethod]
    public void Multiply_ZeroByAnyNumber_ReturnsZero()
    {       
        decimal a = 30;  
        string result = StringLibrary.Multiply(0, a); 
        Assert.AreEqual($"Hello Reader.\nThe Multiplication of 0 and {a} is = 0", result);
    }

    
    //Division



    [TestMethod]
    public void Divide_TwoPositiveNumbers_ReturnsQuotientString()
    {        
        decimal a = 4;
        decimal b = 2;        
        string result = StringLibrary.Divide(a, b);        
        Assert.AreEqual($"Hello Reader.\nThe Division of {a} and {b} is = {a / b}", result);
    }

    [TestMethod]
    public void Divide_PositiveNumberByOne_ReturnsSameNumberString()
    {        
        decimal a = 10;       
        string result = StringLibrary.Divide(a, 1);       
        Assert.AreEqual($"Hello Reader.\nThe Division of {a} and 1 is = {a}", result);
    }

    [TestMethod]
    public void Divide_AnyNumberByZero()
    {       
        decimal a = 30;   
        string result = StringLibrary.Divide(a, 0);
        Assert.AreEqual("can not divided by 0", result);
    }

    [TestMethod]
     public void Divide_ZeroByAnyNumber_ReturnsZeroString()
    {      
        decimal a = 20;     
        string result = StringLibrary.Divide(0, a);       
        Assert.AreEqual($"Hello Reader.\nThe Division of 0 and {a} is = 0", result);
    }
   
   [TestMethod]
    public void Divide_PositiveNumberByZero_ReturnsErrorMessage()
    {        
        decimal a = 10;      
        string result = StringLibrary.Divide(a, 0);
        Assert.AreEqual("can not divided by 0", result);
    }

}
