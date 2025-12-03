using System.Reactive.Linq;

IEnumerable<int> numbers = [1, 2, 3, 4, 5];
IObservable<int> numbersObservable = numbers.ToObservable();

IObservable<int> observable = Observable.Range(1, 5);
IObservable<Customer> observableagain = Observable.Create<Customer>(observer =>
{
    observer.OnNext(new Customer { Id = 1, Name = "John Doe" });
    observer.OnNext(new Customer { Id = 2, Name = "Jane Smith" });
    observer.OnCompleted();
    return System.Reactive.Disposables.Disposable.Empty;
});

observableagain.Subscribe(
    onNext: value => Console.WriteLine($"Received value: {value.Name}"),
    onError: error => Console.WriteLine($"Error occurred: {error.Message}"),
    onCompleted: () => Console.WriteLine("Sequence completed.")
);

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.ReadLine();

internal class Customer
{
    public int Id { get; internal set; }
    public required string Name { get; internal set; }
}
