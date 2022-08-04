// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using Marbles;
using System.Text;




Marble marble1 = new Marble(1, "Blue" , "Bob" , 0.5);                             //Yes 
Marble marble2 = new Marble(2, "Red", "John Smith", 0.25);                        //No 
Marble marble3 = new Marble(3, "Violet", "Bob O' Bob", 0.5);                      //Yes 
Marble marble4 = new Marble(4, "Indigo", "Bob Dad-Bob", 0.75);                    //No 
Marble marble5 = new Marble(5, "Yellow", "John", 0.5);                            //No 
Marble marble6 = new Marble(6, "Orange", "Bob", 0.25);                            //Yes 
Marble marble7 = new Marble(7, "Blue", "Smith", 0.5);                             //No 
Marble marble8 = new Marble(8, "Blue", "Bob", 0.25);                              //Yes 
Marble marble9 = new Marble(9, "Green", "Bobb Ob", 0.75);                         //Yes 
Marble marble10 = new Marble(10, "Blue", "Bob", 0.5);                             //Yes 


/*Console.WriteLine("Marble - " + marble1 + ", Palindrome? " + StringHelper.IsPalindrome(marble1.Name));
Console.WriteLine("Marble - " + marble2 + ", Palindrome? " + StringHelper.IsPalindrome(marble2.Name));
Console.WriteLine("Marble - " + marble3 + ", Palindrome? " + StringHelper.IsPalindrome(marble3.Name));
Console.WriteLine("Marble - " + marble4 + ", Palindrome? " + StringHelper.IsPalindrome(marble4.Name));
Console.WriteLine("Marble - " + marble5 + ", Palindrome? " + StringHelper.IsPalindrome(marble5.Name));
Console.WriteLine("Marble - " + marble6 + ", Palindrome? " + StringHelper.IsPalindrome(marble6.Name));
Console.WriteLine("Marble - " + marble7 + ", Palindrome? " + StringHelper.IsPalindrome(marble7.Name));
Console.WriteLine("Marble - " + marble8 + ", Palindrome? " + StringHelper.IsPalindrome(marble8.Name));
Console.WriteLine("Marble - " + marble9 + ", Palindrome? " + StringHelper.IsPalindrome(marble9.Name));
Console.WriteLine("Marble - " + marble10 + ", Palindrome? " + StringHelper.IsPalindrome(marble10.Name));
*/



List<Marble> inputMarbles = new List<Marble>();                                  //Creating a List to add all the marbles to
inputMarbles.Add(marble4);
inputMarbles.Add(marble1);
inputMarbles.Add(marble2);
inputMarbles.Add(marble3);                                      
inputMarbles.Add(marble5);
inputMarbles.Add(marble6);
inputMarbles.Add(marble7);
inputMarbles.Add(marble8);
inputMarbles.Add(marble9);
inputMarbles.Add(marble10);

Console.WriteLine("Input Marbles: ");                                         //List that returns ID, Color, Name, Weight and if Palindrome is true/false.
Console.WriteLine("------------------------------------------------");
foreach (Marble marble in inputMarbles)
{
    Console.WriteLine("Marble - ID: " + marble + ", Palindrome " + StringHelper.IsPalindrome(marble.Name));
}


Console.WriteLine("");
Console.WriteLine("Sorted and Filtered Marbles");                                                   //Creating a list called "Sorted And FIltered Marbles"            
Console.WriteLine("------------------------------------------------");

List<Marble> OutputMarbles = MarbleProcessor.SortAndFilter(inputMarbles);

foreach (Marble marble in OutputMarbles)                                                 
{
    Console.WriteLine("Marble -  " + marble + ", Palindrome " + StringHelper.IsPalindrome(marble.Name));
}











/*
 * Console.WriteLine("Help Me Name The Eight Planets Of The Solar System");
Console.WriteLine();
Console.WriteLine("I'll Start :)");
Console.WriteLine();
Console.WriteLine("Mercury");
Console.WriteLine();
Console.WriteLine("It's Your Turn");
//The code above basically echos the string you typed.

Console.WriteLine();

String Userinput; //This is the variable you are working with. You need a variable. 
//Console.WriteLine("It's Your Turn");
Userinput = Console.ReadLine(); //This waits for the user's answer 
Console.WriteLine("You entered: " + Userinput); //Prints out what the user entered 



while (Userinput != "Venus")
{
    Console.WriteLine("Try again.");
    Userinput = Console.ReadLine();
    Console.WriteLine("You entered: " + Userinput);

}
//The command above is to keep the code in a loop if the user entered the wrong answer.



String ThirdPlanet;
Console.WriteLine("The third planet?");
Console.WriteLine();
ThirdPlanet = Console.ReadLine();
Console.WriteLine("You Entered: " + ThirdPlanet);


while (ThirdPlanet != "Earth")
{
    Console.WriteLine("Damn, What A Loser!");
    ThirdPlanet = Console.ReadLine();
    Console.WriteLine("You Entered: " + ThirdPlanet);
}



String FourthPlanet;
Console.WriteLine("That's Correct! " + "Can You Guess The Fourth Planet?");
Console.WriteLine();
FourthPlanet = Console.ReadLine();
Console.WriteLine("You Entered: " + FourthPlanet);

while (FourthPlanet != "Mars")
{
    Console.WriteLine("Oh come on, A 1 year old can do better than this!");
    FourthPlanet = Console.ReadLine();
    Console.WriteLine("You Entered: " + FourthPlanet);
}



String FifthPlanet;
Console.WriteLine("Ha! You made it. What about the fifth planet?");
Console.WriteLine();
FifthPlanet = Console.ReadLine();
Console.WriteLine("You Entered: " + FifthPlanet);

while (FifthPlanet != "Jupiter")
{
    Console.WriteLine("Go Back To Kindergarden.");
    FifthPlanet = Console.ReadLine();
    Console.WriteLine("You Entered: " + FifthPlanet);
}


String SixthPlanet;
Console.WriteLine("Hmmm, You've Made It This Far. What's The Sixth Planet?");
Console.WriteLine();
SixthPlanet = Console.ReadLine();
Console.WriteLine("You Entered: " + SixthPlanet);

while (SixthPlanet != "Saturn")
{
    Console.WriteLine("Kill Me.");
    SixthPlanet = Console.ReadLine();
    Console.WriteLine("You Entered: " + SixthPlanet);
   
}
Console.WriteLine("Look Who's Made It This Far?");
Console.WriteLine();


String SeventhPlanet;
Console.WriteLine("Let Me See You Guess The Seventh Planet, Can You?");
Console.WriteLine();
SeventhPlanet = Console.ReadLine();
Console.WriteLine("You Entered: " + SeventhPlanet);

while (SeventhPlanet != "Uranus")
{
    Console.WriteLine("Go Learn The Solar System And Try Again.");
    SeventhPlanet = Console.ReadLine();
    Console.WriteLine("You Entered: " + SeventhPlanet);

    
}
Console.WriteLine("Great!");


String EighthPlanet;
Console.WriteLine("Let's See If You Guess The Last Planet.");
Console.WriteLine();
EighthPlanet = Console.ReadLine();
Console.WriteLine("You Entered: " + EighthPlanet);

while (EighthPlanet != "Neptune")
{
    Console.WriteLine("I Can't Keep Doing This. Just Try Again.");
    EighthPlanet = Console.ReadLine();
    Console.WriteLine("You Entered: " + EighthPlanet);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("You're Pretty Smart.");//If the user guessed right, this message
                                          //will pop up
Console.WriteLine("Anyways");
Console.WriteLine("You've Completed The Game, You Can Go Brag About It To Your Friends Now.");
*/








