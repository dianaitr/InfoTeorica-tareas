using System;
using System.Collections;

namespace interfaz
{

	using ExcepcionAristaImposible = Excepciones.ExcepcionAristaImposible;
	using ExcepcionNodoNoEncontrado = Excepciones.ExcepcionNodoNoEncontrado;
	using AlgoritmosG = Grafo.AlgoritmosG;
	using GrafoL = Grafo.GrafoL;
	using IGrafo = Grafo.IGrafo;

	public class InterfazPrincipal
	{


//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static void main(String[] args) throws Excepciones.ExcepcionAristaImposible, Excepciones.ExcepcionNodoNoEncontrado
		public static void Main(string[] args)
		{
			IGrafo<string> grafito = new GrafoL<string>(true, true);

			string a = "A";
			string b = "B";
			string c = "C";
			string d = "D";

			grafito.agregarNodo(a);
			grafito.agregarNodo(b);
			grafito.agregarNodo(c);
			grafito.agregarNodo(d);

			////

			grafito.agregarArista(a, a, 1);
			grafito.agregarArista(a, b, 0);
			grafito.agregarArista(b, a, 0);
			grafito.agregarArista(b, c, 1);
			grafito.agregarArista(c, b, 1);
			grafito.agregarArista(c, c, 0);

			grafito.agregarArista(d,c,1);

			AlgoritmosG algo = new AlgoritmosG<>();

			ArrayList lista = algo.BFS(grafito,a);
			for (int i = 0; i < lista.Count; i++)
			{
				Console.WriteLine(lista[i]);
			}
			//para paso 1. eliminar nodos que no est�n en la lista




		}

	}

}