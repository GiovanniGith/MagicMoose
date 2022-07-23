// See https://aka.ms/new-console-template for more information


// Write a console app for a fortune telling moose
Console.WriteLine("I am the Magic Moooooose!");

Console.WriteLine();
Console.WriteLine("Ask me ANY Question you'd like");

string questionAsked = Console.ReadLine();



string[] responses = {"As I see it, yes.","Ask Again later.","Better not tell you now.","Cannot predict now.","Concentrate and ask again.",
    "Don't count on it.","It is certain","It is decidedly so.","Most Likely",
    "My Reply is No","My sources say no","Outlook not so good","Outlook Good",
    "Reply hazy, try again","Signs point to yes","Very doubtful","Without a doubt",
    "yes","yes-definitely","You may rely on it"};

List<string> answers = new List<string>(responses);

foreach (string response in answers)
{

    Console.WriteLine(response);
}






Console.ReadLine();
