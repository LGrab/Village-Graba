// See https://aka.ms/new-console-template for more information



HttpClient gameServerClient = new HttpClient();
gameServerClient.BaseAddress = new Uri("http://localhost:5555");
string response = await gameServerClient.GetStringAsync("/");
Console.WriteLine(response);
    
    
    
