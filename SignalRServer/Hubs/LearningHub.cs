using Microsoft.AspNetCore.SignalR;

namespace SignalRServer.Hubs;

public class LearningHub: Hub<ILearningHubClient>
{
    public async Task BroadcastMessage(string message)
    {
        await Clients.All.ReceiveMessage(message);
    }
    
    public override async Task OnConnectedAsync()
    {
        Console.WriteLine($"Client connected: {Context.ConnectionId}");
        await base.OnConnectedAsync();
    }
    
    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        await base.OnDisconnectedAsync(exception);
    }
}