using Grpc.Net.Client;
using GrpcContract;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("http://localhost:5282");
var client = new Cat.CatClient(channel);
var reply = await client.SayMiauAsync(
                  new PetRequest { PetName = "Otávio" });
Console.WriteLine("Response: " + reply.PetSaid);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
