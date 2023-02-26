namespace Magellan.Utilities.Calculator;

public sealed class AsyncCalculator {
  public Task InitAsync() => Task.CompletedTask;
  public Task CleanupAsync() => Task.CompletedTask;
  
  public Task<int> AddAsync(int a, int b) => Task.FromResult(a + b);

  public Task<int> Subtract(int a, int b) => Task.FromResult(a - b);
}