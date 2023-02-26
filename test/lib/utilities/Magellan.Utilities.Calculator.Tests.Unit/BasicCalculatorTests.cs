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
  
  [Fact]
  public void Subtract_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers() {
    // Arrange
    const int firstNumber = 10;
    const int secondNumber = 2;
    const int differenceOfFirstAnsSecondNumber = firstNumber - secondNumber;
    
    // Act
    var result = _sut.Subtract(firstNumber, secondNumber);

    // Assert
    result.Should().Be(differenceOfFirstAnsSecondNumber);
    
    _outputHelper.WriteLine("Subtract Test Executed");
  }

  public void Dispose() =>
    _outputHelper.WriteLine("Cleanup Calculator Test");
}