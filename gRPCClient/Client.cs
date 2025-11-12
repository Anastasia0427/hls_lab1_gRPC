using Grpc.Net.Client;
using lab1_grpc;
using System;
using System.Threading.Tasks;


class Program
{
    static async Task Main(string[] args)
    {
        using var channel = GrpcChannel.ForAddress("http://localhost:5001");
        var client = new Greeter.GreeterClient(channel);

        var reply = await client.SayHelloAsync(new HelloRequest { Name = "World" });

        Console.WriteLine("Greeting: " + reply.Msg);
        Console.WriteLine("Press any key to exit" +
            "...");
        Console.ReadKey();
    }
}