using System;
using Microsoft.AspNetCore.Mvc;

public class AlexaController : Controller 
{
    public dynamic SendMessage(dynamic request)
    {
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