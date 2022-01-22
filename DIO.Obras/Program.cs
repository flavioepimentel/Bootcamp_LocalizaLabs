using System;
using System.Threading;


namespace DIO.Obras
{
    class Program
    {

		static ObrasRepositorio repositorio = new ObrasRepositorio();

        static void Main(string[] args)
        {
			
		inicio:

			string opcaoUsuario = ObterOpcaoUsuario();
			
			do {
				switch (opcaoUsuario.ToUpper())
                {
					case "1":
						ListarObras();
						goto inicio;
					case "2": 
						InserirObra();
						goto inicio;
					case "3": 
						AtualizarObras();
						goto inicio;
					case "4": 
						ExcluirObra();
						goto inicio;
					case "5": 
						VisualizarObras();
						goto inicio;
					case "X":
					case "x" :
					break;
					
					default:
					goto inicio;
                }
			} while (opcaoUsuario.ToUpper() != "X");
            


			static void ExcluirObra()
            {
				Console.Write("Informe o ID: ");
				int indicieObra = int.Parse(Console.ReadLine());
				repositorio.Exclui(indicieObra);
				Console.Clear();
				Console.WriteLine("Registro Excluido com Sucesso.");
				Console.WriteLine();
				Thread.Sleep(1500);
				Console.Clear();


            }

			static void VisualizarObras()
            {
				Console.Clear();
				Console.Write("Informe o ID do Titulo: ");
				int indiceObra = int.Parse(Console.ReadLine());
				var obras = repositorio.RetornaPorId(indiceObra);

				Console.WriteLine();
				Console.WriteLine(obras);
				
				Console.WriteLine();
				Console.WriteLine("Pressione qualquer tecla e retorne ao menu");

				

				// Essa opção cria um modo de vizualização para o usuario aguardando ele clicar em qualquer tecla.
				var novaOpcao = Console.ReadLine();
				while (novaOpcao == null){
					Thread.Sleep(500);
				}
				Console.Clear();


            }

			static void AtualizarObras()
		{
			Console.Write("Digite o id da série: ");
			int indiceObra = int.Parse(Console.ReadLine());

			// Listando opções de Genero disponíveis no arquivo "./Enum/Genero.cs"
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				// Acrescentando um número para as opções
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			};
			
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Titulo: ");
			int entradaAno = int.Parse(Console.ReadLine());

			// Listando opções de Categoria disponíveis no arquivo "./Enum/Categoria.cs"
			foreach (int i in Enum.GetValues(typeof(Categoria)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Categoria), i));
			}

			Console.Write("Digite a categoria: ");
			int entradaCategoria = int.Parse(Console.ReadLine());


			Console.Write($"Digite os nome dos integrantes do Elenco: ");
			var entradaElenco = Console.ReadLine();
			


			Console.Write("Digite a Descrição: ");
			string entradaDescricao = Console.ReadLine();

			Obras atualizarObra = new Obras(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										categoria:(Categoria)entradaCategoria,
										elenco: entradaElenco,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceObra, atualizarObra);
			Console.WriteLine("Registro atulizado com sucesso!");
			Thread.Sleep(1500);
			Console.Clear();

		}
        static void ListarObras()
		{
			Console.WriteLine("Listar titulos");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.Clear();
				Console.WriteLine("Nenhuma titulo cadastrada.");
				Console.WriteLine();
				Thread.Sleep(1500);
				Console.Clear();


			} else {

				foreach (var obras in lista)
				{
                var excluido = obras.retornaExcluido();
				Console.Clear();
				Console.WriteLine("# ID {0}: - {1} {2}", obras.retornaId(), obras.retornaTitulo(), (excluido ? "*Excluído*" : ""));
				Console.WriteLine();
				Console.WriteLine("[Enter] Retorna ao menu");

				var novaOpcao = Console.ReadLine();
				while (novaOpcao == null){
					Thread.Sleep(500);
				}
				Console.Clear();
				}
			}
		}

    	static void InserirObra()
		{
			Console.WriteLine();
			Console.WriteLine();
			
			Console.WriteLine("Inserir novo titulo");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			

			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Obra: ");
			string entradaTitulo = Console.ReadLine();

			foreach (int i in Enum.GetValues(typeof(Categoria)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Categoria), i));
			}

			Console.Write("Digite a categoria da Obra: ");
			int entradaCategoria = int.Parse(Console.ReadLine());


			Console.Write("Digite o Ano de Início da Obra: ");
			int entradaAno = int.Parse(Console.ReadLine());

			
			Console.Write($"Digite os nomes do elenco: ");
			var entradaElenco = Console.ReadLine();

			Console.Write("Digite a Descrição da Obra: ");
			string entradaDescricao = Console.ReadLine();


			Obras novaObra = new Obras(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										categoria:(Categoria)entradaCategoria,
										elenco: entradaElenco,
										descricao: entradaDescricao);

			repositorio.Insere(novaObra);
			Console.Clear();
			Console.WriteLine("Nova obra inserida com sucesso.");
			Thread.Sleep(2000);
			Console.Clear();
		}

        static string ObterOpcaoUsuario()
		{			
			Console.Clear();
			Console.WriteLine("Stream DIO");
			Console.WriteLine("===================");
			Console.WriteLine("1 - Listar titulos");
			Console.WriteLine("2 - Inserir novos titulos");
			Console.WriteLine("3 - Atualizar titulo");
			Console.WriteLine("4 - Excluir titulo");
			Console.WriteLine("5 - Visualizar titulos disponíveis");
			Console.WriteLine("X - Sair");
			Console.WriteLine();
			Console.WriteLine(" ");
			string opcaoUsuario = Console.ReadLine().ToUpper();
			return opcaoUsuario;
			}
        }
    }
}
