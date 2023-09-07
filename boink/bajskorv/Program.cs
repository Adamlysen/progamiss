using System;

namespace bajskorv{

class program{

public static void Main(string[] args) {

Console.WriteLine("Vill du gå åt höger eller vänster?");
string direction1 = Console.ReadLine();

if (direction1 == "höger")
{

Extra1();

}
else if (direction1 == "vänster") {

Console.WriteLine("Bra, du dog inte");
Console.WriteLine("Tryck på enter för att fortsätta");
Console.ReadLine();
Extra2();


}
else {

Console.WriteLine("HORUNGE SKRIV RÄTT ISTÄLLET");
}



}

private static void Extra1()
{

Console.WriteLine("Du hamnar i en skog full av ropenisar och dör");
Console.WriteLine("GAME OVER HORUNGE");
Console.WriteLine("Tryck enter för att avsluta");
Console.ReadLine();
return;


}

private static void Extra2()
{

Console.WriteLine("Du kommer till en gångväg full med ortengrabbar");
Console.WriteLine("Ska du slå alla med din lilla boing boing eller backa framåt?");
string direction2 = Console.ReadLine();

if (direction2 == "Slå alla"){

Console.WriteLine("De äter upp din boing boing och du dör av NAM NAM NAM");
Console.WriteLine("GAME OVER");
Console.WriteLine("Tryck på enter för att avsluta");
Console.ReadLine();
}
else if (direction2 == "backa framåt")
{

Console.WriteLine("HORUNGE!!!!  HUR BACKAR MAN FRAMÅT IDIOT!!!!");
Console.WriteLine("Men ändå bra, du överlevde ändå");
Console.WriteLine("Tryck på enter för att fortsätta");
Extra3();

}

else {
Console.WriteLine("HORUNGE SKRIV RÄTT ISTÄLLET DÅ");
Console.ReadLine();
}
}

private static void Extra3() 
{

Console.WriteLine("Du hittar glass på marken med I NEED MORE BOULESSSS smak");
Console.WriteLine("Ska du gå hem?");
string direction3 = Console.ReadLine();

if (direction3 == "ja") {

Console.WriteLine("Bra, du vann hela skiten");
Console.WriteLine("Tryck på enter för att avsluta");
Console.ReadLine();
return;



}
else {

Console.WriteLine("BROR E DU DUM ELLER???");
Console.WriteLine("Tryck enter för att avsluta");
return;



}






}


}


}







