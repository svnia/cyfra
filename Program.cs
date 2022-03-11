// See https://aka.ms/new-console-template for more information

//Gierka zgadnij cyfrę

Random r = new Random();
int cyfra = r.Next(0, 1);

Console.WriteLine("Wylosowałem cyfrę" + cyfra.ToString());
Console.WriteLine("Właśnie wylosowałem pewną cyfrę...");
Console.WriteLine("Odgadnij ją, w przedziale 1-10!");
char wybor = Console.ReadKey().KeyChar;

switch (wybor)
{
    case '1':
        if (cyfra > 1)
            Console.WriteLine("Cyfra jest wyższa niż wybrana!");
        if (cyfra < 1)
            Console.WriteLine("Cyfra jest niższa niż wybrana!");
        if (cyfra == 1)
            Console.WriteLine("Gratulacje, zgadłeś!");
        else
            Console.WriteLine("Niestety, spróbuj jeszcze raz!");
        break;

    case '2':
        if (cyfra > 2)
            Console.WriteLine("Cyfra jest wyższa niż wybrana!");
        if (cyfra < 2)
            Console.WriteLine("Cyfra jest niższa niż wybrana!");
        if (cyfra == 2)
            Console.WriteLine("Gratulacje, zgadłeś!");
        else
            Console.WriteLine("Niestety, spróbuj jeszcze raz!");

        break;

    case '3':
        if (cyfra > 3)
            Console.WriteLine("Cyfra jest wyższa niż wybrana!");
        if (cyfra < 3)
            Console.WriteLine("Cyfra jest niższa niż wybrana!");
        if (cyfra == 3)
            Console.WriteLine("Gratulacje, zgadłeś!");
        else
            Console.WriteLine("Niestety, spróbuj jeszcze raz!");

        break;

    case '4':
        if (cyfra > 4)
            Console.WriteLine("Cyfra jest wyższa niż wybrana!");
        if (cyfra < 4)
            Console.WriteLine("Cyfra jest niższa niż wybrana!");
        if (cyfra == 4)
            Console.WriteLine("Gratulacje, zgadłeś!");
        else
            Console.WriteLine("Niestety, spróbuj jeszcze raz!");

        break;

    case '5':
        if (cyfra > 5)
            Console.WriteLine("Cyfra jest wyższa niż wybrana!");
        if (cyfra < 5)
            Console.WriteLine("Cyfra jest niższa niż wybrana!");
        if (cyfra == 5)
            Console.WriteLine("Gratulacje, zgadłeś!");
        else
            Console.WriteLine("Niestety, spróbuj jeszcze raz!");

        break;

    case '6':
        if (cyfra > 6)
            Console.WriteLine("Cyfra jest wyższa niż wybrana!");
        if (cyfra < 6)
            Console.WriteLine("Cyfra jest niższa niż wybrana!");
        if (cyfra == 6)
            Console.WriteLine("Gratulacje, zgadłeś!");
        else
            Console.WriteLine("Niestety, spróbuj jeszcze raz!");

        break;

    case '7':
        if (cyfra > 7)
            Console.WriteLine("Cyfra jest wyższa niż wybrana!");
        if (cyfra < 7)
            Console.WriteLine("Cyfra jest niższa niż wybrana!");
        if (cyfra == 7)
            Console.WriteLine("Gratulacje, zgadłeś!");
        else
            Console.WriteLine("Niestety, spróbuj jeszcze raz!");

        break;

    case '8':
        if (cyfra > 8)
            Console.WriteLine("Cyfra jest wyższa niż wybrana!");
        if (cyfra < 8)
            Console.WriteLine("Cyfra jest niższa niż wybrana!");
        if (cyfra == 8)
            Console.WriteLine("Gratulacje, zgadłeś!");
        else
            Console.WriteLine("Niestety, spróbuj jeszcze raz!");

        break;

    case '9':
        if (cyfra > 9)
            Console.WriteLine("Cyfra jest wyższa niż wybrana!");
        if (cyfra < 9)
            Console.WriteLine("Cyfra jest niższa niż wybrana!");
        if (cyfra == 9)
            Console.WriteLine("Gratulacje, zgadłeś!");
        else
            Console.WriteLine("Niestety, spróbuj jeszcze raz!");

        break;

    case '0':
        if (cyfra > 0)
            Console.WriteLine("Cyfra jest wyższa niż wybrana!");
        if (cyfra < 0)
            Console.WriteLine("Cyfra jest niższa niż wybrana!");
        if (cyfra == 0)
            Console.WriteLine("Gratulacje, zgadłeś!");
        else
            Console.WriteLine("Niestety, spróbuj jeszcze raz!");

        break;

 


}
