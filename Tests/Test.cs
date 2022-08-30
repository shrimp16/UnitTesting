using Xunit;

public class Test
{

    [Fact]
    public void PassingAddIntegers()
    {
        Calculator calculator = new Calculator();
        Assert.Equal(6, calculator.AddIntegers(5, 1));
        Assert.Equal(3, calculator.AddIntegers(2, 1));
        Assert.Equal(27, calculator.AddIntegers(13, 14));
    }

    [Fact]
    public void PassingMultiplyIntegers()
    {
        Calculator calculator = new Calculator();
        Assert.Equal(6, calculator.MultiplyIntegers(2, 3));
        Assert.Equal(28, calculator.MultiplyIntegers(7, 4));
        Assert.Equal(26, calculator.MultiplyIntegers(13, 2));
    }

    [Fact]
    public void PassingIsNumberEven()
    {
        Calculator calculator = new Calculator();
        int[] numbers = { 4, 28, 80, 1024, 10, 24 };

        foreach (int number in numbers)
        {
            Assert.True(calculator.IsNumberEven(number));
        }
    }
    
}