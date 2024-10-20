while (true)

{
    string[] tautograma = Console.ReadLine().Split();
    if (tautograma[0] == "*")
    {
        break;
    }

    bool validacao = true;
    char letra = char.ToUpper(tautograma[0][0]);

    foreach (string palavra in tautograma)
    {
        if (letra != char.ToUpper(palavra[0]))
        {
            validacao = false;
            break;
        }
    }
    if (validacao == true)
    {
        Console.WriteLine("Y");
    }
    else
    {
        Console.WriteLine("N");
    }
}

