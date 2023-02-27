namespace Magellan.Utilities.Calculator.Tests.Unit; 

public sealed class BasicCalculatorTests: IDisposable {
  private readonly BasicCalculator _sut;
  private readonly ITestOutputHelper _outputHelper;

  public BasicCalculatorTests(ITestOutputHelper outputHelper) {
    _outputHelper = outputHelper;
    _sut = new BasicCalculator();
    
    _outputHelper.WriteLine("Initialize Calculator Test");
  }

  [Fact]
  public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers() {
    // Arrange
    const int firstNumber = 5;
    const int secondNumber = 8;
    const int sumOfFirstAnsSecondNumber = firstNumber + secondNumber;
    
    // Act
    var result = _sut.Add(firstNumber, secondNumber);

    // Assert
    result.Should().Be(sumOfFirstAnsSecondNumber);
    
    _outputHelper.WriteLine("Sum Test Executed");
  }
  
  [Theory]
  [InlineData(10, 2, 8)]
  [InlineData(17, 8, 9)]
  public void Subtract_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers(int firstNumber, int secondNumber, int differenceOfFirstAnsSecondNumber) {
    // Act
    var result = _sut.Subtract(firstNumber, secondNumber);

    // Assert
    result.Should().Be(differenceOfFirstAnsSecondNumber);
    
    _outputHelper.WriteLine("Subtract Test Executed");
  }
  
  [Fact(Skip = "Not implemented yet")]
  public void Multiply_ShouldMultiplyTwoNumbers_WhenTwoNumbersAreIntegers() {
    // Arrange
    const int firstNumber = 5;
    const int secondNumber = 8;
    const int productOfFirstAnsSecondNumber = firstNumber + secondNumber;
    
    // Act
    var result = _sut.Multiply(firstNumber, secondNumber);

    // Assert
    result.Should().Be(productOfFirstAnsSecondNumber);
  }
  
  [Theory(Skip = "Breaks integration")]
  [InlineData(10, 2, 8, Skip = "Breaks Integration")]
  [InlineData(17, 8, 9)]
  public void Divide_ShouldDivideTwoNumbers_WhenTwoNumbersAreIntegers(int firstNumber, int secondNumber, int quotientOfFirstAnsSecondNumber) {
    // Act
    var result = _sut.Subtract(firstNumber, secondNumber);

    // Assert
    result.Should().Be(quotientOfFirstAnsSecondNumber);
    
    _outputHelper.WriteLine("Subtract Test Executed");
  }

  public void Dispose() =>
    _outputHelper.WriteLine("Cleanup Calculator Test");
}