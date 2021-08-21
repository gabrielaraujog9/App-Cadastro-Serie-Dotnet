using System;

namespace POOdotnet
{
  class Program
  {
    static SerieRepositorio repositorioSerie = new SerieRepositorio();
    static FilmeRepositorio repositorioFilme = new FilmeRepositorio();
    static void Main(string[] args)
    {


      string opcaoUsuario = OpcaoSerieFilme();
      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            menuSerie(opcaoUsuario);
            break;
          case "2":
            menuFilmes(opcaoUsuario);
            break;
          case "C":
            Console.Clear();
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }
        opcaoUsuario = OpcaoSerieFilme();
      }
    }

    private static void menuSerie(string opcaoUsuario)
    {
      opcaoUsuario = ObterOpcaoUsuarioSerie();

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            ListarSF(opcaoUsuario);
            break;
          case "2":
            InserirSF(opcaoUsuario);
            break;
          case "3":
            AtualizarSF(opcaoUsuario);
            break;
          case "4":
            ExcluirSF(opcaoUsuario);
            break;
          case "5":
            VisualizarSF(opcaoUsuario);
            break;
          case "C":
            Console.Clear();
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }
        opcaoUsuario = ObterOpcaoUsuarioSerie();
      }
    }
    private static void menuFilmes(string opcaoUsuario)
    {
      opcaoUsuario = ObterOpcaoUsuarioFilme();

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            ListarSF(opcaoUsuario);
            break;
          case "2":
            InserirSF(opcaoUsuario);
            break;
          case "3":
            AtualizarSF(opcaoUsuario);
            break;
          case "4":
            ExcluirSF(opcaoUsuario);
            break;
          case "5":
            VisualizarSF(opcaoUsuario);
            break;
          case "C":
            Console.Clear();
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }
        opcaoUsuario = ObterOpcaoUsuarioFilme();
      }
    }
    private static void VisualizarSF(string opcaoUsuario)
    {
      if (opcaoUsuario == "1")
      {

        Console.Write("Digite o id da série: ");
        int indiceSerie = int.Parse(Console.ReadLine());

        var serie = repositorioSerie.RetornaPorId(indiceSerie);

        Console.WriteLine(serie);
      }
      else
      {
        Console.Write("Digite o id do filme: ");
        int indiceFilme = int.Parse(Console.ReadLine());

        var filme = repositorioFilme.RetornaPorId(indiceFilme);

        Console.WriteLine(filme);
      }
    }
    private static void ExcluirSF(string opcaoUsuario)
    {
      if (opcaoUsuario == "1")
      {

        Console.Write("Digite o id da série que quer excluir: ");
        int indiceSerie = int.Parse(Console.ReadLine());

        repositorioSerie.Exclui(indiceSerie);
      }
      else
      {
        Console.Write("Digite o id do filme que quer excluir: ");
        int indiceFilme = int.Parse(Console.ReadLine());
        repositorioFilme.Exclui(indiceFilme);

      }

    }
    private static void AtualizarSF(string opcaoUsuario)
    {
      if (opcaoUsuario == "1")
      {
        Console.Write("Digite o id da série: ");
        int indiceSerie = int.Parse(Console.ReadLine());

        foreach (int i in Enum.GetValues(typeof(Genero)))
        {
          Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
        }
        Console.Write("Digite o gênero entre as opções acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.Write("Digite o título da série: ");
        string entradaTitulo = Console.ReadLine();

        Console.Write("Digite o ano de ínicio da série: ");
        int entradaAno = int.Parse(Console.ReadLine());

        Console.Write("Digite descrição da série: ");
        string entradaDescricao = Console.ReadLine();

        foreach (int i in Enum.GetValues(typeof(Classificacao)))
        {
          Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Classificacao), i));
        }
        Console.Write("Digite classificação etária da série: ");
        int entradaClassificacao = int.Parse(Console.ReadLine());

        Serie atualizaSerie = new Serie(id: indiceSerie,
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    descricao: entradaDescricao,
                                    ano: entradaAno,
                                    classificacao: (Classificacao)entradaClassificacao);

        repositorioSerie.Atualiza(indiceSerie, atualizaSerie);

      }
      else
      {
        Console.Write("Digite o id do filme: ");
        int indiceFilme = int.Parse(Console.ReadLine());

        foreach (int i in Enum.GetValues(typeof(Genero)))
        {
          Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
        }
        Console.Write("Digite o gênero entre as opções acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.Write("Digite o título do filme: ");
        string entradaTitulo = Console.ReadLine();

        Console.Write("Digite o ano de ínicio do filme: ");
        int entradaAno = int.Parse(Console.ReadLine());

        Console.Write("Digite descrição do filme: ");
        string entradaDescricao = Console.ReadLine();

        foreach (int i in Enum.GetValues(typeof(Classificacao)))
        {
          Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Classificacao), i));
        }
        Console.Write("Digite classificação etária do filme: ");
        int entradaClassificacao = int.Parse(Console.ReadLine());

        Filme atualizaFilme = new Filme(id: indiceFilme,
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    descricao: entradaDescricao,
                                    ano: entradaAno,
                                    classificacao: (Classificacao)entradaClassificacao);

        repositorioFilme.Atualiza(indiceFilme, atualizaFilme);

      }
    }
    private static void InserirSF(string opcaoUsuario)
    {
      if (opcaoUsuario == "1")
      {
        Console.WriteLine("Inserir nova série");

        foreach (int i in Enum.GetValues(typeof(Genero)))
        {
          Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
        }
        Console.Write("Digite o gênero entre as opções acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.Write("Digite o título da série: ");
        string entradaTitulo = Console.ReadLine();

        Console.Write("Digite o ano de ínicio da série: ");
        int entradaAno = int.Parse(Console.ReadLine());

        Console.Write("Digite descrição da série: ");
        string entradaDescricao = Console.ReadLine();

        foreach (int i in Enum.GetValues(typeof(Classificacao)))
        {
          Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Classificacao), i));
        }
        Console.Write("Digite classificação etária da série: ");
        int entradaClassificacao = int.Parse(Console.ReadLine());

        Serie novaSerie = new Serie(id: repositorioSerie.ProximoId(),
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    descricao: entradaDescricao,
                                    ano: entradaAno,
                                    classificacao: (Classificacao)entradaClassificacao);
        repositorioSerie.Insere(novaSerie);

      }
      else if (opcaoUsuario == "2")
      {
        Console.WriteLine("Inserir novo filme");

        foreach (int i in Enum.GetValues(typeof(Genero)))
        {
          Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
        }
        Console.Write("Digite o gênero entre as opções acima: ");
        int entradaGenero = int.Parse(Console.ReadLine());

        Console.Write("Digite o título do filme: ");
        string entradaTitulo = Console.ReadLine();

        Console.Write("Digite o ano de ínicio do filme: ");
        int entradaAno = int.Parse(Console.ReadLine());

        Console.Write("Digite descrição do filme: ");
        string entradaDescricao = Console.ReadLine();

        foreach (int i in Enum.GetValues(typeof(Classificacao)))
        {
          Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Classificacao), i));
        }
        Console.Write("Digite classificação etária do filme: ");
        int entradaClassificacao = int.Parse(Console.ReadLine());

        Filme novoFilme = new Filme(id: repositorioFilme.ProximoId(),
                                    genero: (Genero)entradaGenero,
                                    titulo: entradaTitulo,
                                    descricao: entradaDescricao,
                                    ano: entradaAno,
                                    classificacao: (Classificacao)entradaClassificacao);
        repositorioFilme.Insere(novoFilme);
      }
    }
    private static void ListarSF(string opcaoUsuario)
    {
      if (opcaoUsuario == "1")
      {

        Console.WriteLine("Listar série");

        var lista = repositorioSerie.Lista();

        if (lista.Count == 0)
        {
          Console.WriteLine("Nenhuma série cadastrada.");
          return;
        }

        foreach (var serie in lista)
        {
          Console.WriteLine("#ID {0}: - {1}", serie.retornaID(), serie.retornaTitulo());
        }
      }
      else
      {
        Console.WriteLine("Listar filmes");

        var lista = repositorioFilme.Lista();

        if (lista.Count == 0)
        {
          Console.WriteLine("Nenhum filme cadastrado.");
          return;
        }

        foreach (var filme in lista)
        {
          Console.WriteLine("#ID {0}: - {1}", filme.retornaID(), filme.retornaTitulo());
        }
      }
    }
    private static string OpcaoSerieFilme()
    {
      Console.WriteLine();
      Console.WriteLine("NET Séries :D !!!");
      Console.WriteLine("Informe a opção desejada:");

      Console.WriteLine("1- Opções para séries");
      Console.WriteLine("2- Opções para filmes");
      Console.WriteLine("C- Limpar Tela");

      Console.WriteLine("X- Sair");

      string opcaoUsuario = Console.ReadLine().ToUpper();
      Console.WriteLine();
      return opcaoUsuario;

    }
    private static string ObterOpcaoUsuarioFilme()
    {
      Console.WriteLine();
      Console.WriteLine("NET Séries :D !!!");
      Console.WriteLine("Informe a opção desejada:");

      Console.WriteLine("1- Listar filmes");
      Console.WriteLine("2- Inserir nova filme");
      Console.WriteLine("3- Atualizar filme");
      Console.WriteLine("4- Excluir filme");
      Console.WriteLine("5- Visualizar filme");
      Console.WriteLine("C- Limpar Tela");
      Console.WriteLine("X- Voltar");
      Console.WriteLine();

      string opcaoUsuario = Console.ReadLine().ToUpper();
      Console.WriteLine();
      return opcaoUsuario;
    }
    private static string ObterOpcaoUsuarioSerie()
    {
      Console.WriteLine();
      Console.WriteLine("NET Séries :D !!!");
      Console.WriteLine("Informe a opção desejada:");

      Console.WriteLine("1- Listar séries");
      Console.WriteLine("2- Inserir nova série");
      Console.WriteLine("3- Atualizar série");
      Console.WriteLine("4- Excluir série");
      Console.WriteLine("5- Visualizar série");
      Console.WriteLine("C- Limpar Tela");
      Console.WriteLine("X- Voltar");
      Console.WriteLine();

      string opcaoUsuario = Console.ReadLine().ToUpper();
      Console.WriteLine();
      return opcaoUsuario;
    }
  }
}
