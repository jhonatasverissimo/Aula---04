// See https://aka.ms/new-console-template for more information
string nome, replace, p_nome, sobrenome, corte;

Console.Write("Informe o seu nome: ");
nome = Console.ReadLine();
replace = nome.Replace("a","o");
p_nome = nome.Substring(0,nome.IndexOf(" "));
sobrenome = nome.Substring(nome.IndexOf(" "));
corte = nome.Substring(5,5);

Console.WriteLine("Seu nome é: " + nome);
Console.WriteLine("Seu nome trocando A por O: " + replace);
Console.WriteLine("Primeiro nome: " + p_nome.Trim());
Console.WriteLine("Sobrenome: " + sobrenome.Trim());
Console.WriteLine("Nome cortado: " + corte);





