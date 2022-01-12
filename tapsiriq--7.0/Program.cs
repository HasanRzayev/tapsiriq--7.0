

using tapsiriq__7._0;

Dict Luget = new();


Luget["public"]="ictimai";
Luget["human"] =  "insan";
Luget["product"]=  "mehsul";
Luget["prohibit "]= "qadaga etmek";
Luget["sacred" ]  = "muqeddes";
Luget["roof"  ]  = "dam";
Luget["skin" ] ="deri";
Luget["truck"]= "yuk masini";
Luget["poet"]= "sair";
Luget["prison"]= "zindan";
Luget["private"]= "ozel";
Luget["trip"]="seyahet";
Luget["root"]= "kok";
Luget["who"]= "kim";
Luget["where"]= "hara";
Luget["weight"]= "ceki";
Luget["weekend"]= "heftesonu";
Luget["wallet"]= "pulqabi";
Luget["wood"]= "taxta";
Luget["wrong"]= "sehv";
Luget["witness"]= "sahid";
Luget["wool"]= "yun";
Luget["windly"]= "kulekli";
Luget["wing"]= "qanad";
Luget["wind"]= "kulek";
Luget["year"]= "il";
Luget["young"]= "gənc";
Luget["zone"]= "zona";


string? word;
while (true)
{
    Console.Clear();
    Luget.Print();
    Console.WriteLine("Hansi sozun menasini isteyirsenizse daxil edin .....");
    word = Console.ReadLine();
    if (Luget.Mean(word) == "0000")
    {
        Console.WriteLine("Bu sozun qarsiligi lugetde yoxdur");
        Thread.Sleep(1000);
        continue;
    }
    else
    {
        Console.WriteLine("Daxil etdiyiniz sozzun menasi ----" + Luget.Mean(word));
        Thread.Sleep(1000);
    }
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////

//Country Lasvegas = new("Amerika", "Las vegas", 667501);
//Country Tokyo = new("Japoniya", "Tokyo", 37339804);
//Country London = new("United Kingdom", "London", 9425622);
//Country NewYorkCity = new("Amerika", "New York City", 8230290);
//Country LosAngeles  = new("Amerika", "Los Angeles", 3983540);
//Country Chicago = new("Amerika", "Chicago", 2679080);
////////////////////////////////////////////////////////////////////////////
//CountryArray array = new();
//array.Add(Lasvegas);
//array.Add(Tokyo);
//array.Add(London);
//array.Add(NewYorkCity);
//array.Add(LosAngeles);
//array.Add(Chicago);

//var choose = 0;
//var choose1 = 0;
//while (true)
//{
//    Console.Clear();
//    array.Show();
//    Console.WriteLine("Muqaise ucun birinci olkeni secin");
//    choose=Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Muqaise ucun ikinci olkeni secin");
//    choose1 = Convert.ToInt32(Console.ReadLine());
//    if(choose1 == 0 || choose==0 || choose1>array.countries.Length || choose > array.countries.Length)
//    {
//        Console.WriteLine("Duzgun daxil edin");
//        Thread.Sleep(1000);
//        continue;
//    }   
//    if(array[choose-1]< array[choose-1] == true)
//    {
//        Console.WriteLine("Ikinci olkenin ehalisi birinciden boyukdur");
//    }
//    else if(array[choose-1] < array[choose-1] == false)
//    {
//        Console.WriteLine("Birinci olkenin ehalisi ikinciden boyukdur");
//    }
//    else
//    {
//        Console.WriteLine("Iki olkenin ehalisi beraberdir");
//    }
//    Thread.Sleep(2000);
//}