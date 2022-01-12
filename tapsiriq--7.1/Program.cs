
using tapsiriq__7._1;

Unit warrior = new Warrior("Warrior", 50, 30, 100); 
Unit gladiator = new Gladiator("Gladiator", 50, 45, 100); 
Unit viking = new Viking("Viking", 50, 35, 100);
Unit anchor = new Anchor("Anchor", 50, 40, 100);
UnitArray array = new();
array.Add(warrior); 
array.Add(gladiator); 
array.Add(viking); 
array.Add(anchor);

var choose = 0;
var choose1 = 0;
while (true)
{
    Console.Clear();    
    array.Show();
    Console.WriteLine("Doyus ucun birinci doyuscunu secin");
    choose = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Doyus ucun ikinci doyuscunu secin");
    choose1 = Convert.ToInt32(Console.ReadLine());
    if (choose1 == 0 || choose == 0 || choose1 > array.units.Length || choose > array.units.Length)
    {
        Console.WriteLine("Duzgun daxil edin");
        Thread.Sleep(1000);
        continue;
    }
    while (true)
    {

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Yellow;
        array[choose - 1].LetsAttack();
        Thread.Sleep(1000);
       
        if (array[choose1 - 1].defense < 0 || array[choose1 - 1].defense == 0)
        {
            array[choose1 - 1].health -= array[choose - 1].attack;
        }
        else
        {
            array[choose1 - 1].defense -= array[choose - 1].attack;
        }
           

        Console.WriteLine(array[choose1 - 1].name+"    "+ array[choose - 1].attack+"   zede aldi");
        Console.WriteLine("----------------------------------");
        Thread.Sleep(1000);
        array[choose - 1].Show();
        Console.WriteLine("----------------------------------");
        Thread.Sleep(1000);

        array[choose1 - 1].Show();
        Console.WriteLine("----------------------------------");
        Thread.Sleep(1000);

        if (array[choose1 - 1].health < 0 || array[choose1 - 1].health == 0)
        {
            Console.Clear();
            array[choose1 - 1].LetsDie();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
         
            Console.WriteLine(array[choose - 1].name + "   qazandi");
            Thread.Sleep(2000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            break;

        }
        array[choose1 - 1].LetsAttack();
        Thread.Sleep(1000);
        
        if (array[choose - 1].defense < 0 || array[choose - 1].defense == 0)
        {
            array[choose - 1].health -= array[choose1 - 1].attack;
        }
        else
        {
            array[choose - 1].defense -= array[choose1 - 1].attack;

        }
        Console.WriteLine(array[choose - 1].name + "    " + array[choose1 - 1].attack + "   zede aldi");
        Thread.Sleep(1000);

        Console.WriteLine("----------------------------------");
        array[choose - 1].Show();
        Console.WriteLine("----------------------------------");
        Thread.Sleep(1000);

        array[choose1 - 1].Show();
        Console.WriteLine("----------------------------------");
        Thread.Sleep(1000);

        if (array[choose-1].health<0 || array[choose - 1].health == 0)
        {
            Console.Clear();
            array[choose - 1].LetsDie();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(array[choose1 - 1].name+"   qazandi");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            break;

        }
       




    }
}