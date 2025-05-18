decimal salarioHora;
decimal hora;
decimal horaExtra;
decimal salario;
decimal salarioHoraExtra;
decimal salarioHoraExtraTotal;
decimal salarioTotal;

Console.Clear();

Console.WriteLine("Digite seu salário-hora base:");
salarioHora = Convert.ToDecimal(Console.ReadLine()!);

Console.WriteLine("Digite seu total de horas trabalhadas:");
hora = Convert.ToDecimal(Console.ReadLine()!);

Console.WriteLine("Digite sua quantidade de horas-extras trabalhadas:");
horaExtra = Convert.ToDecimal(Console.ReadLine()!);

calculaSalario(salarioHora, hora, horaExtra);

Console.Clear();

Console.WriteLine("--- Salário ---");

Console.WriteLine("");

Console.Write("Salário-hora: ");
corVerde();
Console.WriteLine($"{salarioHora:C2}");
Console.ResetColor();

Console.Write("Horas trabalhadas: ");
corVerde();
Console.WriteLine($"{hora}h");
Console.ResetColor();

Console.Write("Bônus por horas-extras: ");
corVerde();
Console.WriteLine($"{salarioHoraExtra:C2}");
Console.ResetColor();

Console.Write("Total de horas-extras: ");
corVerde();
Console.WriteLine($"{horaExtra}h");
Console.ResetColor();

Console.WriteLine("");

Console.Write("Salário final: ");
corVerde();
Console.WriteLine($"{salarioTotal:C2}");
Console.ResetColor();

void corVerde()
{
    Console.ForegroundColor = ConsoleColor.Green;
}

decimal calculaSalario(decimal salarioHora, decimal hora, decimal horaExtra)
{
    salario = salarioHora * hora;

    salarioHoraExtra = salarioHora * 0.40m;

    salarioHoraExtraTotal = salarioHoraExtra * horaExtra;

    salarioTotal = salario + salarioHoraExtraTotal;

    return salarioTotal;
}

