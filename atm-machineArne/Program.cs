

//bekijken om klasse/List van te maken.
#region Hardcode
Console.WriteLine("what amount do you like to withdraw?");
int input = Convert.ToInt32(Console.ReadLine());
int rest = input;
int counter = 0;
int bill500 = 0;
int bill200 = 0;
int bill100 = 0;
int bill50 = 0;
int bill20 = 0;
int bill10 = 0;
int bill5 = 0;
int coin2 = 0;
int coin1 = 0;

int abill500 = 2;
int abill200 = 3;
int abill100 = 5;
int abill50 = 12;
int abill20 = 20;
int abill10 = 50;
int abill5 = 100;
int acoin2 = 250;
int acoin1 = 500;

int totalAmount = 5100;

#endregion


#region Berekening 
//bekijken om in methode te steken.
while (rest != 0 && input < totalAmount)
{
    if (rest / 500 >= 1)

    {
        while (abill500 > 0 && rest != 0 && rest >= 500)   //kijken voor between te gebruiken.
        {

            rest = rest - 500;
            abill500--;
            counter++;
            bill500 = counter;
        }
    }
    counter = 0;

    if (rest / 200 >= 1)
    {
        while (abill200 > 0 && rest != 0 && rest >= 200)
        {
            rest = rest - 200;
            abill200--;
            counter++;
            bill200 = counter;
        }
    }
    counter = 0;

    if (rest / 100 >= 1)
    {
        while (abill100 > 0 && rest != 0 && rest >= 100)
        {
            rest = rest - 100;
            abill100--;
            counter++;
            bill100 = counter;
        }
    }
    counter = 0;

    if (rest / 50 >= 1)
    {
        while (abill50 > 0 && rest != 0 && rest >= 50)
        {
            rest = rest - 50;
            abill50--;
            counter++;
            bill50 = counter;
        }
    }
    counter = 0;

    if (rest / 20 >= 1)
    {
        while (abill20 > 0 && rest != 0 && rest >= 20)
        {
            rest = rest - 20;
            abill20--;
            counter++;
            bill20 = counter;
        }
    }
    counter = 0;

    if (rest / 10 >= 1)
    {
        while (abill10 > 0 && rest != 0 && rest >= 10)
        {
            rest = rest - 10;
            abill10--;
            counter++;
            bill10 = counter;
        }

    }
    counter = 0;

    if (rest / 5 >= 1)
    {
        while (abill10 > 0 && rest != 0 && rest >= 5)
        {
            rest = rest - 5;
            abill5--;
            counter++;
            bill5 = counter;
        }
    }
    counter = 0;

    if (rest / 2 >= 1)
    {
        while (coin2 > 0 && rest != 0 && rest >= 2)
        {
            rest = rest - 2;
            acoin2--;
            counter++;
            coin2 = counter;
        }
    }

    counter = 0;
    while (rest != 0)
    {
        rest = rest - 1;
        acoin1--;
        counter++;
        coin1 = counter;
    }
}
#endregion


#region output
Console.WriteLine("withdrawn bills from ATM:");
Console.WriteLine();
Console.WriteLine("500: " + bill500);
Console.WriteLine("200: " + bill200);
Console.WriteLine("100: " + bill100);
Console.WriteLine("50: " + bill50);
Console.WriteLine("20: " + bill20);
Console.WriteLine("10: " + bill10);
Console.WriteLine("5: " + bill5);
Console.WriteLine("2: " + coin2);
Console.WriteLine("1: " + coin1);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("bills still in the ATM:");
Console.WriteLine();
Console.WriteLine("500: " + abill500);
Console.WriteLine("200: " + abill200);
Console.WriteLine("100: " + abill100);
Console.WriteLine("50: " + abill50);
Console.WriteLine("20: " + abill20);
Console.WriteLine("10: " + abill10);
Console.WriteLine("5: " + abill5);
Console.WriteLine("2: " + acoin2);
Console.WriteLine("1: " + acoin1);
Console.WriteLine();
Console.WriteLine();
if (input > totalAmount)
{
    Console.WriteLine("het gevraagde bedrag is te groot.");
}
else
{
    totalAmount -= input;
}
Console.WriteLine($"Het bedrag in de ATM is nog {totalAmount}");


//Console.WriteLine("do you wish to witdraw more money?");
//string awns = Console.ReadLine();
//awns.ToLower();
//if (awns == "y")
//{
//    Console.WriteLine("how much do you wish to withdraw?");
//    //methode laten lopen.
//}
//else
//{
//    Console.WriteLine("thank you!");
//    Console.WriteLine("come again.");
//}
#endregion






