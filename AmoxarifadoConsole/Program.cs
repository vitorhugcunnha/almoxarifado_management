Tela tela = new Tela(50, 10);
autenticacaoUsuario autenticacao = new autenticacaoUsuario();

while (true)
{
    string opcao = tela.MolduraMenu();

    switch (opcao)
    {
        case "1":
            bool autenticado = false;
            while (!autenticado)
            {
                string usuario, senha;
                tela.TelaLogin(out usuario, out senha);
                autenticado = autenticacao.Autenticar(usuario, senha);

                if (!autenticado)
                {
                    Console.Clear();
                    tela.MontarMolduraCentralizada("Usuario ou senha incorretos!");
                    Thread.Sleep(2000);
                    Console.ReadKey();
                }
            }

            Console.Clear();
            tela.MontarMolduraCentralizada("Login realizado com sucesso!");
            Console.ReadKey();
            break;

        case "2":
            Console.Clear();
            tela.MontarMolduraCentralizada("Encerrando o programa...");
            Thread.Sleep(1500);
            Console.Clear();
            return;

        default:
            Console.Clear();
            tela.MontarMolduraCentralizada("Opcao invalida, tente novamente!");
            Console.ReadKey();
            break;
    }
}
