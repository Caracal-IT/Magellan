namespace Magellan.Utilities.Calculator;

public sealed class BasicCalculator {
  public int Add(int a, int b) => a + b;

  public int Subtract(int a, int b) => a - b;

  public int Multiply(int a, int b) => throw new NotImplementedException();
  
  public int Divide(int a, int b) => throw new NotImplementedException();
}