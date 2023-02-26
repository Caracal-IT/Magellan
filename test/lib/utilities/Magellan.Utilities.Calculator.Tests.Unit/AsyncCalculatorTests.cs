namespace Magellan.Utilities.Calculator.Tests.Unit; 

public class AsyncCalculatorTests: IDisposable, IAsyncLifetime {
  private readonly AsyncCalculator _sut;
  private readonly ITestOutputHelper _outputHelper;

  public AsyncCalculatorTests(ITestOutputHelper outputHelper) {
    _outputHelper = outputHelper;
    _sut = new AsyncCalculator();
    
    _outputHelper.WriteLine("Initialize Calculator Test");
  }

  public async Task InitializeAsync() {
    await _sut.InitAsync();
    
    _outputHelper.WriteLine("Initialize Async Calculator Test");
  }
  
  [Fact]
  public async Task AddAsync_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers() {
    // Arrange
    const int firstNumber = 5;
    const int secondNumber = 8;
    const int sumOfFirstAnsSecondNumber = firstNumber + secondNumber;
    
    // Act
    var result = await _sut.AddAsync(firstNumber, secondNumber);

    // Assert
    result.Should().Be(sumOfFirstAnsSecondNumber);
    
    _outputHelper.WriteLine("Sum Async Test Executed");
  }
  
  [Fact]
  public async Task SubtractAsync_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers() {
    // Arrange
    const int firstNumber = 10;
    const int secondNumber = 2;
    const int differenceOfFirstAnsSecondNumber = firstNumber - secondNumber;
    
    // Act
    var result = await _sut.Subtract(firstNumber, secondNumber);

    // Assert
    result.Should().Be(differenceOfFirstAnsSecondNumber);
    
    _outputHelper.WriteLine("Subtract Async Test Executed");
  }

  public async Task DisposeAsync() {
    await _sut.CleanupAsync();
    _outputHelper.WriteLine("Cleanup Async Calculator Test");
  }
  
  public void Dispose() =>
    _outputHelper.WriteLine("Cleanup Calculator Test");
}