Tela tela = new Tela(80, 25);

string opc = "";
List<string> opcoes = new List<string>();
opcoes.Add("1 - Login");
opcoes.Add("2 - Sair");

while (true)
{
    Console.Clear();
    tela.MontarMolduraCentralizada("Login");
    Console.ReadKey();
    switch (opc)
    {
        case "1":
            break;
        case "2":
            break;
    }
    if (opc == "2")
    {
        return;
    }
}