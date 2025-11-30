using System.Reactive.Linq;

IObservable<int> observable = Observable.Range(1, 5);

observable.Subscribe(
    onNext: value => Console.WriteLine($"Received value: {value}"),
    onError: error => Console.WriteLine($"Error occurred: {error.Message}"),
    onCompleted: () => Console.WriteLine("Sequence completed.")
);

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.ReadLine();
