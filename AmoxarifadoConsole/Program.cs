Tela tela = new Tela(50, 10);
autenticacaoUsuario autenticacao = new autenticacaoUsuario();

List<string> opcoes = new List<string>();
opcoes.Add("1 - Login");
opcoes.Add("2 - Sair");

    bool autenticado = false;
    while (!autenticado)
    {
        string usuario, senha;
        tela.TelaLogin(out usuario, out senha);
        autenticado = autenticacao.Autenticar(usuario, senha);
        if (!autenticado)
        {
            Console.Clear();
            tela.MontarMolduraCentralizada("Usuário ou senha incorretos!");
            Console.ReadKey();
        }
    }
Console.Clear();
tela.MontarMolduraCentralizada("Login realizado com sucesso!");
Console.ReadKey();