string senha, correct;

Console.WriteLine("Olá, usuário. Por favor, digite sua senha:");
senha = Console.ReadLine()!;

correct = "1234abcd";
if (senha == correct)
{
    Console.WriteLine("Acesso permitido");
}
else
{
    Console.WriteLine("Acesso negado");
}
