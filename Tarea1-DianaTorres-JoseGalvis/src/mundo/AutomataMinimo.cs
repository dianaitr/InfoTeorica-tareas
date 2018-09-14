using System.Collections.Generic;

namespace mundo
{

	using ExcepcionNodoNoEncontrado = Excepciones.ExcepcionNodoNoEncontrado;
	using AlgoritmosG = Grafo.AlgoritmosG;
	using GrafoL = Grafo.GrafoL;
	using IGrafo = Grafo.IGrafo;
	using Nodo = Grafo.Nodo;

	public class AutomataMinimo
	{

		public const string MEALY = "Mealy";
		public const string MOORE = "Moore";

		private IGrafo<string> automata;

		private List<string> estimulos, respuestas;
		private Nodo<string> estadoInicial;
		private string tipo;
		private Dictionary<string, string> respuestasMoore;


		//inicializar el grafo
		public AutomataMinimo(string valorInicial, string elTipo)
		{

			automata = new GrafoL<string>(true, true);
			estadoInicial = new Nodo<string>(valorInicial);
			automata.agregarNodo(valorInicial);
			tipo = elTipo;


		}


		public virtual void agregarEstado(string valor, string respuesta)
		{

			respuestasMoore[valor] = respuesta;
			automata.agregarNodo(valor);

		}

		/// <summary>
		/// usando el algoritmo BFS, encontramos los estados accesibles desde el estado de origen.
		/// el algoritmo siguiente eliminar� aquellos estados que no se encuentran en la lista encontrada anteriormente. </summary>
		/// <exception cref="ExcepcionNodoNoEncontrado">  </exception>

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void eliminarEstadosNoAccesibles(java.util.ArrayList<String> estadosAcc) throws Excepciones.ExcepcionNodoNoEncontrado
		public virtual void eliminarEstadosNoAccesibles(List<string> estadosAcc)
		{



			for (int i = 0; i < automata.darValorNodos().Count; i++)
			{

				bool aparece = false;

				for (int j = 0;j < estadosAcc.Count && !aparece;j++)
				{

					if (estadosAcc[j].Equals(automata.darValorNodos()[i]))
					{
						aparece = true;
					}

				}

				if (!aparece)
				{
					automata.eliminarNodo(automata.darValorNodos()[i]);
				}
			}



		}


		/// <summary>
		/// Paso1.
		/// </summary>
	//	
	//	public void automataConexoEquivalente() {
	//		AlgoritmosG<String> aG = new AlgoritmosG<String>();
	//		ArrayList<String> lista = aG.BFS(automata, )
	//		eliminarEstadosNoAccesibles();
	//	}


		public virtual void particionamientoMoore()
		{

			Dictionary<string, string> p1 = new Dictionary<string, string>();

		}



	}

}