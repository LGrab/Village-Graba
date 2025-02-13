using Interfaces;

namespace Domain;

public class Test : ITest
{
    public string GetTestMessage()
    {
        return "Test......";
    }
}