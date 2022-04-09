string senhaDigitada;

// Espacamento
Console.WriteLine();

// Solicitando e armazenando uma senha digitada pelo usuário
Console.Write("Olá usuário. Digite sua senha: ");
senhaDigitada = Console.ReadLine()!;

// Testando se a senha é igual a correta (1234abcd)
if (senhaDigitada == "1234abcd")
{
    // Mensagem de sucesso, em cor verde.
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Acesso autorizado");
}
else
{
    // Mensagem de erro, em cor vermelha, com som
    Console.Beep();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Acesso negado");
}

// Resetando a cor
Console.ResetColor();

// Espacamento
Console.WriteLine();