using System;

namespace POOdotnet
{
  public class Filme : EntidadeBase
  {
    private Genero Genero { get; set; }
    private string Titulo { get; set; }

    private string Descricao { get; set; }
    private int Ano { get; set; }

    private bool Excluido { get; set; }
    private Classificacao Classificacao { get; set; }
    public Filme(int id, Genero genero, string titulo, string descricao, int ano, Classificacao classificacao)
    {
      this.Id = id;
      this.Genero = genero;
      this.Titulo = titulo;
      this.Descricao = descricao;
      this.Ano = ano;
      this.Classificacao = classificacao;
      this.Excluido = false;
    }
    public override string ToString()
    {
      string retorno = "";
      retorno += "Gênero: " + this.Genero + Environment.NewLine;
      retorno += "Título: " + this.Titulo + Environment.NewLine;
      retorno += "Descrição: " + this.Descricao + Environment.NewLine;
      retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
      retorno += "Classificação: " + this.Classificacao + Environment.NewLine;
      retorno += "Excluido: " + this.Excluido;
      return retorno;

    }
    public string retornaTitulo()
    {
      return this.Titulo;
    }
    public int retornaID()
    {
      return this.Id;
    }
    public void Exclui()
    {
      this.Excluido = true;
    }
  }
}