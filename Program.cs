string[] Massive = new string[10];
int count = 0;

void StringMassive()
{
    for (int i = 0; i < Massive.Length; i++)
    {
        Massive[i] = Console.ReadLine();
    }

    for (int i = 0; i < Massive.Length; i++)
    {
        if (Massive[i].Length <= 3)
        {
            count++;
        }
    }

    string[] ThreeSymbolMassive = new string[count];
    int elementthreesymbolmassive = 0;

    for (int i = 0; i < Massive.Length; i++)
    {
        if (Massive[i].Length <= 3)
        {
            ThreeSymbolMassive[elementthreesymbolmassive] = Massive[i];
            elementthreesymbolmassive++;
        }
    }

    for (int i = 0; i < Massive.Length; i++)
    {
        Console.Write(Massive[i] + "\t");
    }
    Console.WriteLine();

    for (int i = 0; i < ThreeSymbolMassive.Length; i++)
    {
        Console.Write(ThreeSymbolMassive[i] + "\t");
    }
    Console.WriteLine();
}

StringMassive();