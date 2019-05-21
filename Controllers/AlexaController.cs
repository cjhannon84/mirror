using System;
using magicmirror.Controllers;
using magicmirror.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

public class AlexaController : Controller 
{
    private readonly IHubContext<MessagingHub> messagingHubContext;

    public AlexaController(IHubContext<MessagingHub> messagingHubContext)
    {
        this.messagingHubContext = messagingHubContext;
    }

    public dynamic SendMessage(dynamic request)
    {
        messagingHubContext.Clients.All.SendAsync("ReceiveMessage", "Hello");
        return new {
            Version="1.0",
            sessionAttributes=new{},
            response=new {
                outputSpeech=new {
                    type="PlainText",
                    text="Hello World"
                },
                card = new {
                    type="Simple",
                    title="Smart Mirror",
                    content = "Hello"
                },
                shouldEndSession=false
            }
        };
    }
}