//Zionn Showers
//9-15-2026
//Mini Challenge # 8 - Add 2 Numbers & Greater Than Or Less Than Validation
/*I basically just copied and pasted most of the code from mini challenge 2 and 4, but edited the parts where it converted strings into integers using TryParse
 statements instead to make sure the user has actually inputted a number rather than anything else. I also added a try again option for each part by asking the
 user if they want to play the game again or if they want to move on.*/
//Peer Review:
/*Review: */

Console.Clear();

string playAgain;
do
{

int actualNum1;
int actualNum2;

Console.Write("Please input a number: ");
string num1 = Console.ReadLine();
Console.Write("Now input another number: ");
string num2 = Console.ReadLine();
bool isConverted1 = int.TryParse(num1, out actualNum1);
bool isConverted2 = int.TryParse(num2, out actualNum2);

while (isConverted1 == false || isConverted2 == false)
{
    Console.Write("Error: ");
    Console.Write("Please input a number: ");
    num1 = Console.ReadLine();
    Console.Write("Now input another number: ");
    num2 = Console.ReadLine();
    isConverted1 = int.TryParse(num1, out actualNum1);
    isConverted2 = int.TryParse(num2, out actualNum2);
}
Console.WriteLine($"Those numbers added together equal {actualNum1 + actualNum2}!");

//play again?
Console.WriteLine ("Would you like to play again? y/n");
playAgain = Console.ReadLine().ToLower();

while(playAgain != "y" && playAgain != "n")
{
    Console.WriteLine("Error! Try Again!");
    playAgain = Console.ReadLine().ToLower();
}


}while(playAgain == "y");

//-----------------------------------------------------------------------------------//

string playAgain2;
do
{

int actualNum3;
int actualNum4;

Console.WriteLine("Enter a number:"); //Number setups
string num3 = Console.ReadLine();
Console.WriteLine("Enter another number:");
string num4 = Console.ReadLine();
bool isConverted3 = int.TryParse(num3, out actualNum3);
bool isConverted4 = int.TryParse(num4, out actualNum4);

while (isConverted3 == false || isConverted4 == false)
{
    Console.Write("Error: ");
    Console.WriteLine("Enter a number:"); //Number setups
     num3 = Console.ReadLine();
    Console.WriteLine("Enter another number:");
    num4 = Console.ReadLine();
    isConverted3 = int.TryParse(num3, out actualNum3);
    isConverted4 = int.TryParse(num4, out actualNum4);
}

if(actualNum3 > actualNum4)// 1st Number Output
{
    Console.WriteLine($"{actualNum3} is greater than {actualNum4}!");
}
else if(actualNum3 < actualNum4)
{
    Console.WriteLine($"{actualNum3} is lesser than {actualNum4}!");
}
else
{
    Console.WriteLine($"{actualNum3} is equal to {actualNum4}!");
}

if(actualNum4 > actualNum3)// 2nd Number Output
{
    Console.WriteLine($"{actualNum4} is greater than {actualNum3}!");
}
else if(actualNum4 < actualNum3)
{
    Console.WriteLine($"{actualNum4} is lesser than {actualNum3}!");
}
else
{
    Console.WriteLine($"{actualNum4} is equal to {actualNum3}!");
}

//play again?
Console.WriteLine ("Would you like to play again? y/n");
playAgain2 = Console.ReadLine().ToLower();

while(playAgain2 != "y" && playAgain2 != "n")
{
    Console.WriteLine("Error! Try Again!");
    playAgain = Console.ReadLine().ToLower();
}


}while(playAgain2 == "y");