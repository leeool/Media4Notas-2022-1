double n1, n2, n3, n4;

Console.Write("\nDigite a nota 1: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota 2: ");
n2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota 3: ");
n3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota 4: ");
n4 = Convert.ToDouble(Console.ReadLine());

bool aprovado = (n1 + n2 + n3 + n4) / 4 > 6;
bool reprovado = (n1 + n2 + n3 + n4) / 4 < 5;

if (aprovado)
{
    Console.WriteLine($"\nNota final: {(n1 + n2 + n3 + n4) / 4:N2}");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Você foi aprovado!\n");
    Console.ResetColor();
}

else if (reprovado)
{
    Console.WriteLine($"\nNota final: {(n1 + n2 + n3 + n4) / 4:N2}");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Você foi reprovado.\n");
    Console.ResetColor();

}

else {
    Console.WriteLine($"\nNota final: {(n1 + n2 + n3 + n4) / 4:N2}");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Você está de recuperação.\n");
    Console.ResetColor();
}

