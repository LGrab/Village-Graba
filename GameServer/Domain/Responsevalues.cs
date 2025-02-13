using Interfaces;

namespace Domain;

public class Responsevalues: IResponseValues
{
    public string GetGreetingMessage()
    {
        return "Hello World!";
    }
}

