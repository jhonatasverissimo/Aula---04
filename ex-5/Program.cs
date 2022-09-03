// See https://aka.ms/new-console-template for more information
string nm_completo, nome, sobrenome, email= "";

Console.Write("Informe o seu nome completo: ");
nm_completo = Console.ReadLine();
nm_completo = nm_completo.Trim();

nome = nm_completo.Substring(0,nm_completo.IndexOf(" "));

sobrenome = nm_completo.Substring(nm_completo.LastIndexOf(" "));

email = nome+"."+sobrenome+"@fatec.sp.gov.br";

email = email.Replace(" ","").ToLower();

Console.WriteLine("E-mail:"+email);

