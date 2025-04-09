using Grpc.Net.Client;
using grpcclient;

using var channel = GrpcChannel.ForAddress("https://localhost:7011");
var client = new Health.HealthClient(channel);
var reply = await client.CheckAsync(new CheckRequest { });
Console.WriteLine("Check Service: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
