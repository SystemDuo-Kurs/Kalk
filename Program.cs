bool izlaz = false;
do
{
    StampajMeni();
    Console.Write("Izbor? ");
    string izb = Console.ReadLine();
    switch (izb)
    {
        case "1":
            Console.Write("Unesi prvi broj: ");
            int broj1 = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi broj: ");
            int broj2 = int.Parse(Console.ReadLine());
            int zbir = Sabiranje(broj1, broj2);
            Console.WriteLine("Rezultat je: " + zbir);
            break;

        case "2":
            Console.Write("Unesi prvi broj: ");
            broj1 = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi broj: ");
            broj2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Rezultat je: " + (broj1 - broj2));
            break;

        case "3":
            Console.WriteLine("Vozdra");
            izlaz = true;
            break;

        default:
            Console.WriteLine("Jok :/");
            break;
    }
    Console.ReadKey();
    Console.Clear();
} while (!izlaz);

int Sabiranje(int x, int y)
{
    return x + y;
}

//povratni tip          naziv                  ulazni parametri
void StampajMeni()
{
    StampajRed("*********************");
    StampajRed("~~1. Sabiranje~~");
    StampajRed("~~2. Oduzimanje~~");
    Console.WriteLine("~~3. Izlaz~~");
    Console.WriteLine("*********************");
}

void StampajRed(string red)
{
    Console.WriteLine(red);
}