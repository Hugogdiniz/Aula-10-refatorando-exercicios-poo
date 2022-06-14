namespace aula10refatoracao_aula08
{


    public class Filmes
    {
        public String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };
       
        // 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
        public string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
        {
            string lista = "";
            for (int i = 0; i < listaDeFilmes.Length; i++)
            {
                lista += ($"{listaDeFilmes[i]}; ");
            }
            return lista;
        }

        //1.2. Apresentar quantidade de filmes da lista.
        public int quantidadeTotalDeFilmes()
        {
            return listaDeFilmes.Length;
        }

        // 1.3. Buscar o nome do filme de acordo com seu índice.

        public string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
        {
            return listaDeFilmes[indiceDoFilme];
        }

        // 1.4. Adiciona um novo filme a lista pelo seu nome.
        public String[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
        {
            listaDeFilmes[listaDeFilmes.Length - 1] = nomeDoFilme;
            return listaDeFilmes;
        }

        // 1.5. Atualiza um filme a partir do seu índice na lista.
        public string[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme, string filmeSubstituto)
        {
            listaDeFilmes[indiceDoFilme] = filmeSubstituto;
            return listaDeFilmes;
        }

        // 1.6. Listar todos os filmes com seu índice/posição na lista.
        public String listarTodosOsFilmesComSeuIndiceNaLista()
        {
            string lista = "";
            for (int i = 0; i < listaDeFilmes.Length; i++)
            {
                int posicao = i + 1;
                lista += ($"    indice:{i} - Posição:{posicao} - conteudo:{listaDeFilmes[i]}; \r\n");
            }
            return lista;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Filmes listaDeFilmes01 = new Filmes();



            Console.WriteLine($"1.1. {listaDeFilmes01.apresentaTodosOsFilmesSeparadosPorPontoVirgula()}");
            Console.WriteLine($"1.2. {listaDeFilmes01.quantidadeTotalDeFilmes()}");
            Console.WriteLine($"1.3. {listaDeFilmes01.buscarNomeDoFilmePeloIndice(2)}");
            Console.WriteLine($"1.4. {listaDeFilmes01.adicionaUmNovoFilmePeloSeuNome("Batman")}");
            Console.WriteLine($"1.5. {listaDeFilmes01.atualizarUmFilmePeloSeuIndice(1, "NovoFilme")}");
            Console.WriteLine($"1.5. {listaDeFilmes01.apresentaTodosOsFilmesSeparadosPorPontoVirgula()}");
            Console.WriteLine($"1.6.{listaDeFilmes01.listarTodosOsFilmesComSeuIndiceNaLista()}");

        }
    }
}




