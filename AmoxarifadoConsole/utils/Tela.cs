using System.ComponentModel;
using System.Security.Cryptography;
using Org.BouncyCastle.Pqc.Crypto.Ntru;

public class Tela
{
    private int largura;
    private int altura;
    private int colunaInicial;
    private int linhaInicial;

    public Tela(int largura, int altura)
    {
        this.largura = largura;
        this.altura = altura;
        this.colunaInicial = 0;
        this.linhaInicial = 0;
    }

    public Tela(int largura, int altura, int coluna, int linha)
    {
        this.largura = largura;
        this.altura = altura;
        this.colunaInicial = coluna;
        this.linhaInicial = linha;
    }

    public void MontarMolduraCentralizada(string titulo = "")
    {
        int larguraConsole = Console.WindowWidth;
        int alturaConsole = Console.WindowHeight;

        int larguraMoldura = this.largura;
        int alturaMoldura = this.altura;

        int ci = (larguraConsole - larguraMoldura) / 2;
        int li = (alturaConsole - alturaMoldura) / 2;
        int cf = ci + larguraMoldura;
        int lf = li + alturaMoldura;


        for (int col = ci; col < cf; col++)
        {
            Console.SetCursorPosition(col, li);
            Console.Write("═");
            Console.SetCursorPosition(col, lf);
            Console.Write("═");
        }

        for (int lin = li; lin < lf; lin++)
        {
            Console.SetCursorPosition(ci, lin);
            Console.Write("║");
            Console.SetCursorPosition(cf, lin);
            Console.Write("║");
        }

        Console.SetCursorPosition(ci, li); Console.Write("╔");
        Console.SetCursorPosition(cf, li); Console.Write("╗");
        Console.SetCursorPosition(ci, lf); Console.Write("╚");
        Console.SetCursorPosition(cf, lf); Console.Write("╝");

        if (!string.IsNullOrEmpty(titulo))
        {
            int colTitulo = ci + (larguraMoldura - titulo.Length) / 2;
            Console.SetCursorPosition(colTitulo, li + 1);
            Console.Write(titulo);
        }
    }
}