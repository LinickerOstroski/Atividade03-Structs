using System;
using System.Linq.Expressions;

class Programa
{

    struct livro
    {
        public string titulo;
        public string autor;
        public int ano;
        public int patreleira;

    }

    static void cadastraLivro(List<livro> lista)
    {
        livro novoLivro = new livro();

        Console.Write("Digite o Título do livro:");
        novoLivro.titulo = Console.ReadLine();
        Console.Write("Digite o Autor do livro:");
        novoLivro.autor = Console.ReadLine();
        Console.Write("Digite o ano do livro:");
        novoLivro.ano = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a prateleira:");
        novoLivro.patreleira = Convert.ToInt32(Console.ReadLine());

        lista.Add(novoLivro);

    }

    static void procurarLivro(List<livro> lista, string tituloBusca)
    {
        int index = lista.Count();
        
        for(int i =0;i< index; i++)
        {
            if (lista[i].titulo.ToUpper().Contains(tituloBusca.ToUpper()))
            {
                Console.WriteLine($"{lista[i].titulo}");
                Console.WriteLine("Prateleira" + lista[i].patreleira);
            }
        }

    }
    static void listarLivros(List<livro> lista)
    {
        foreach(livro l in lista)
        {
            Console.WriteLine("Nome:" + l.titulo);
            Console.WriteLine("Autor:" + l.autor);
            Console.WriteLine("Ano:" + l.ano);
            Console.WriteLine("Prateleira" + l.patreleira);
        }
    }
    static int menu()
    {
        int num;

        Console.WriteLine("*** Biblioteca ***");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("1 - Cadastrar Livros");
        Console.WriteLine("2 - Procurar por um livro"); // pedir para digitar o título
        Console.WriteLine("3 - Listar os livros cadastrados");
        Console.WriteLine("4 - Ler um ano"); // apresentar todos os livros mais novos que o ano lido.

        num = Convert.ToInt32(Console.ReadLine());

        return num;
    }
    static void Main()
    {
        List<livro> lista = new List<livro>();
        int operador;
        bool program = true;


        do
        {
            operador = menu();
            switch (operador)
            {
                case 0:
                    program = false;
                    Console.WriteLine("Saindo...");
                    break;
                case 1:
                    Console.WriteLine("Cadastrar livro:");
                    cadastraLivro(lista);
                    break;
            }
        } while (program);

    }



}