// See https://aka.ms/new-console-template for more information
string nome,email; 

Console.Write("Informe o seu nome: ");
nome = Console.ReadLine();

email = nome.ToLower().Replace(" ","")+"@fatec.sp.gov.br";

Console.WriteLine("Seu email é: " + email);