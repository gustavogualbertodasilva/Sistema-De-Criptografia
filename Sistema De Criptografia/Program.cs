using System;
using System.Collections.Generic;
using System.Threading;

class Usuario
{
    public string Username { get; set; }
    public string Senha { get; set; }

    public Usuario(string username, string senha)
    {
        Username = username;
        Senha = senha;
    }
}

class Program
{
    public static bool IsLog = false;
    public static bool UserExiste = false;
    public static bool RepeatCadOurLog = true;
    public static bool RepeatCad = true;
    public static bool RepeatCadSenha = true;
    public static string NewUsarname = "";
    public static string NewSenha = "";
    public static string AcesssUsername = "";
    public static string AcessSenha = "";
    public static string LogOptions = "";
    public static bool RepeatLogOptions = true;
    public static string TrocarSenhaAtual;
    public static string TrocarSenha;
    public static string CriptografiaOptions;

    static void Main()
    {
        List<Usuario> usuarios = new List<Usuario>();
        usuarios.Add(new Usuario("Admin", "Admin123"));
        Console.Clear();
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bem Vindo Ao Sistema De Criptografia De Textos");

        while (RepeatCadOurLog)
        {
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            RepeatCad = true;
            RepeatCadSenha = true;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Seu Cadastro Não Fica Salvo, Isso é Um Sistema Feito Para Pratica (SEM BANCO DE DADOS)");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Você quer Fazer Login Ou Cadastrar L/C");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string CadOurLog = Console.ReadLine();
            if (CadOurLog == "L")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Para Fazer Seu Login, Siga Os Seguintes Passos:");
                Thread.Sleep(500);
                Console.WriteLine("Digite Seu Nome De Usuario.");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                AcesssUsername = Console.ReadLine();
                foreach (var Usuar in usuarios)
                {
                    if (Usuar.Username == AcesssUsername)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Digite Sua Senha");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        AcessSenha = Console.ReadLine();
                        if (Usuar.Senha == AcessSenha)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(".");
                            Thread.Sleep(500);
                            Console.WriteLine(".");
                            Thread.Sleep(500);
                            Console.WriteLine(".");
                            Thread.Sleep(500);
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine($"Usuario {AcesssUsername} Logado Com Sucesso");
                            RepeatLogOptions = true;
                            while (RepeatLogOptions)
                            {
                                Thread.Sleep(900);
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("O Que Deseja Fazer?");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Thread.Sleep(500);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("1- Ir para Seção de ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("CRIPTOGRAFIA");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Thread.Sleep(500);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("2- Mudar ");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Senha");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Thread.Sleep(500);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("3- ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Deslogar");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                LogOptions = Console.ReadLine();
                                if (LogOptions == "1" || LogOptions == "2" || LogOptions == "3")
                                {
                                    if (LogOptions == "1")
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Que Criptografia Você Quer Usar?");
                                        Thread.Sleep(500);
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("1- Cifra de Substituição Simples.");
                                        Thread.Sleep(500);
                                        Console.WriteLine("2- Codigo Binario.");
                                        Thread.Sleep(500);
                                        Console.WriteLine("3- Codigo Morse.");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        CriptografiaOptions = Console.ReadLine();

                                        if (CriptografiaOptions == "1")
                                        {
                                            css();
                                        }
                                        else if (CriptografiaOptions == "2")
                                        {
                                            CodBin();
                                        }
                                        else if (CriptografiaOptions == "3")
                                        {
                                            CodMorse();
                                        }
                                    }
                                    else if (LogOptions == "2")
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Para Mudar Sua Senha");
                                        Thread.Sleep(400);
                                        Console.WriteLine("Digite Sua Senha Atual");
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        TrocarSenhaAtual = Console.ReadLine();

                                        foreach (var NewSenhaUser in usuarios)
                                        {
                                            if (NewSenhaUser.Username == AcesssUsername)
                                            {
                                                if (TrocarSenhaAtual == NewSenhaUser.Senha)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("Digite Sua Nova Senha 7-20 Caracteres");
                                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                                    TrocarSenha = Console.ReadLine();

                                                    if (TrocarSenha.Length >= 7 && TrocarSenha.Length <= 20)
                                                    {
                                                        if (NewSenhaUser.Senha == TrocarSenha)
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("Você Não Pode Trocar Sua Senha Para Ela Mesma...");
                                                        }
                                                        else
                                                        {
                                                            Thread.Sleep(1000);
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Senha Alterada Com Sucesso!");
                                                            NewSenhaUser.Senha = TrocarSenha;
                                                            RepeatLogOptions = true;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("A senha deve ter entre 7 e 20 caracteres!");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.Write("ERRO 001 Diz: ");
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Senha Incorreta");
                                                }
                                            }
                                        }
                                    }
                                    else if (LogOptions == "3")
                                    {
                                        Console.Write("Saindo");
                                        Thread.Sleep(500);
                                        Console.Write(".");
                                        Thread.Sleep(500);
                                        Console.Write(".");
                                        Thread.Sleep(500);
                                        Console.Write("...");
                                        Thread.Sleep(500);
                                        Console.Write("\b \b");
                                        Thread.Sleep(500);
                                        Console.Write("\b \b");
                                        Thread.Sleep(500);
                                        Console.Write("\b \b");
                                        Thread.Sleep(500);
                                        Console.WriteLine(".");
                                        Thread.Sleep(200);

                                        RepeatLogOptions = false;
                                        IsLog = false;
                                        RepeatCadOurLog = true;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Digite Um Numero Valido");
                                    Thread.Sleep(1500);
                                    RepeatLogOptions = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Esse Usuario Não Existe. Tente Novamente.");
                        Thread.Sleep(2500);
                    }
                }
            }
            else if (CadOurLog == "C")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Para Fazer Seu Cadastro, Siga Os Seguintes Passos:");

                while (RepeatCad)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\nDigite Um Nome De Usuario (4 - 15 Caracteres)");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    NewUsarname = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;

                    if (NewUsarname.Length >= 4 && NewUsarname.Length <= 15)
                    {
                        bool usuarioExiste = usuarios.Exists(u => u.Username == NewUsarname);

                        if (usuarioExiste)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Já Existe Um Usuário Com Esse Nome");
                        }
                        else
                        {
                            RepeatCad = false;
                            while (RepeatCadSenha)
                            {
                                Console.WriteLine("Digite Sua Senha (Entre 7 - 20 Caracteres)");
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                NewSenha = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Green;

                                if (NewSenha.Length >= 7 && NewSenha.Length <= 20)
                                {
                                    usuarios.Add(new Usuario(NewUsarname, NewSenha));
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("...");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("...");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("...");
                                    Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine($"Usuário {NewUsarname} cadastrado com sucesso!");
                                    RepeatCadSenha = false;
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("A senha deve ter entre 7 e 20 caracteres!");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite um nome que tenha entre 4 - 15 caracteres");
                    }
                }
            }
            else
            {
                Console.WriteLine("Digite um valor válido");
            }
        }
    }

    public static void css()
    {
        Dictionary<char, int> CodLetras = new Dictionary<char, int>();
        CodLetras.Add('A', 1);   CodLetras.Add('G', 7);   CodLetras.Add('M', 13);  CodLetras.Add('S', 19);
        CodLetras.Add('B', 2);   CodLetras.Add('H', 8);   CodLetras.Add('N', 14);  CodLetras.Add('T', 20);
        CodLetras.Add('C', 3);   CodLetras.Add('I', 9);   CodLetras.Add('O', 15);  CodLetras.Add('U', 21);
        CodLetras.Add('D', 4);   CodLetras.Add('J', 10);  CodLetras.Add('P', 16);  CodLetras.Add('V', 22);
        CodLetras.Add('E', 5);   CodLetras.Add('K', 11);  CodLetras.Add('Q', 17);  CodLetras.Add('W', 23);
        CodLetras.Add('F', 6);   CodLetras.Add('L', 12);  CodLetras.Add('R', 18);  CodLetras.Add('X', 24);
        CodLetras.Add('Y', 25);  CodLetras.Add('Z', 26);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ESSE TIPO DE CRIPTGRAFIA NÃO ACEITA ACENTUAÇÃO OU CARACTERES ESPECIAIS");
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Digite Um Texto Que Deseja Criptografar:");
        Console.ForegroundColor = ConsoleColor.Gray;
        string palavra = Console.ReadLine().ToUpper();
        char[] CodAcriptografar = palavra.ToCharArray();
        string result = "";
        foreach (var letras in CodAcriptografar)
        {
            if (CodLetras.ContainsKey(letras))
            {
                result += CodLetras[letras] + " ";
            }
            else
            {
                result += letras + " ";
            }
        }
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"Texto Criptografado: ");
        Console.Write("\u001b[38;2;0;204;0m");
        Console.WriteLine(result.Trim());
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public static void CodBin()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Digite um texto: ");
        Console.ForegroundColor = ConsoleColor.Gray;
        string texto = Console.ReadLine();

        string resultadoBinario = "";

        foreach (char c in texto)
        {
            string binario = Convert.ToString((int)c, 2).PadLeft(8, '0');
            resultadoBinario += binario + " ";
        }
        Console.Write($"Texto Criptografado: ");
        Console.Write("\u001b[38;2;0;204;0m");
        Console.WriteLine(resultadoBinario.Trim());
    }

    public static void CodMorse()
    {
        Dictionary<char, string> morseCode = new Dictionary<char, string>()
        {
            {'A', ".-"},    {'B', "-..."},  {'C', "-.-."},  {'D', "-.."},   {'E', "."},
            {'F', "..-."},  {'G', "--."},   {'H', "...."},  {'I', ".."},    {'J', ".---"},
            {'K', "-.-"},   {'L', ".-.."},  {'M', "--"},    {'N', "-."},    {'O', "---"},
            {'P', ".--."},  {'Q', "--.-"},  {'R', ".-."},   {'S', "..."},   {'T', "-"},
            {'U', "..-"},   {'V', "...-"},  {'W', ".--"},   {'X', "-..-"},  {'Y', "-.--"},
            {'Z', "--.."},  
            {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"},
            {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."},
            {' ', "/"}
        };

        Console.Write("Digite um texto: ");
        string texto = Console.ReadLine().ToUpper();

        string resultadoMorse = "";

        foreach (char c in texto)
        {
            if (morseCode.ContainsKey(c))
            {
                resultadoMorse += morseCode[c] + " ";
            }
        }

        Console.WriteLine($"Código Morse: {resultadoMorse.Trim()}");
    }
}