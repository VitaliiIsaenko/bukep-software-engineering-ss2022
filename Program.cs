// See https://aka.ms/new-console-template for more information
Console.WriteLine("Хотите ли вы жить у моря?") ;
string? answer = Console.ReadLine() ; 
bool LiveBySea ;
if (answer == "да")
{
    LiveBySea = true;
}
else
{
    LiveBySea = false;
}
Console.WriteLine(LiveBySea) ;