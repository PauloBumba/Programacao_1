using System;
using System.Collections.Generic;

// Definição da classe que representa o modelo de dados
public class Post
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Conteudo { get; set; }
}

// Definição da classe que simula um repositório de dados
public class Repositorio
{
    private readonly List<Post> _posts;

    public Repositorio()
    {
        // Inicializa a lista de posts
        _posts = new List<Post>();
    }

    // Método para simular um POST (criação de um novo item)
    public void AdicionarPost(Post novoPost)
    {
        if (novoPost == null)
        {
            throw new ArgumentNullException(nameof(novoPost));
        }

        // Simula a geração de um ID único para o novo post
        novoPost.Id = _posts.Count + 1;
        _posts.Add(novoPost);
    }

    // Método para listar todos os posts
    public IEnumerable<Post> ListarPosts()
    {
        return _posts;
    }
}

// Exemplo de uso
class Program
{
    static void Main()
    {
        var repositorio = new Repositorio();

        // Criando e adicionando um novo post
        var novoPost = new Post
        {
            Titulo = "Título do Post",
            Conteudo = "Conteúdo do Post"
        };

        repositorio.AdicionarPost(novoPost);

        // Listando todos os posts
        foreach (var post in repositorio.ListarPosts())
        {
            Console.WriteLine($"ID: {post.Id}, Título: {post.Titulo}, Conteúdo: {post.Conteudo}");
        }
    }
}
