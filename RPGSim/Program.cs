Dictionary<string, int> slovnik = new Dictionary<string, int>();
slovnik.Add("STR", 10);
slovnik.Add("DEX", 10);
slovnik.Add("INT", 10);      //slovník založen-Kubík//

Console.WriteLine("jak chcete aby se vaše postava jmenovala?");
string jmenoPostavy = Console.ReadLine(); // Zadání jména postavy okej // petko
string[] poleAtr = { "STR", "DEX", "INT" };

int Spánek = 0; 



while (true)
{
    Console.WriteLine($"Jsi unavená na {Spánek}%");
    Console.WriteLine("chceš jít na quest nebo jít spát? Q/V");
    string input=Console.ReadLine();

    if (input == "Q") 
    {
        Console.WriteLine("Vydáváš se splnit quest na INT, vrať se za 10 sec");
        break;
    }
    



}




