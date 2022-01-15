bool izlaz = false;
do
{
    Console.WriteLine("*********************");
    Console.WriteLine("~~1. Sabiranje~~");
    Console.WriteLine("~~2. Oduzimanje~~");
    Console.WriteLine("~~3. Izlaz~~");
    Console.WriteLine("*********************");
    Console.Write("Izbor? ");
    string izb = Console.ReadLine();

    switch (izb)
    {
        case "1":
            Console.Write("Unesi prvi broj: ");
            int broj1 = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi broj: ");
            int broj2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Rezultat je: " + (broj1 + broj2));
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