//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System.Collections.Generic;

namespace Grafo
{

	using ExcepcionAristaImposible = Excepciones.ExcepcionAristaImposible;
	using ExcepcionNodoNoEncontrado = Excepciones.ExcepcionNodoNoEncontrado;

	public class AlgoritmosG<N>
	{

		public AlgoritmosG()
		{

		}

		//PASO 1. Falta eliminar los estados 
		//nodo inicial
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public java.util.ArrayList<N> BFS(IGrafo<N> grafo, N n) throws Excepciones.ExcepcionNodoNoEncontrado
		public virtual List<N> BFS(IGrafo<N> grafo, N n)
		{

			grafo.reestablecerNodos();

			if (grafo.existeNodo(n))
			{

				LinkedList<N> cola = new LinkedList<N>();
				cola.AddLast(n);
				grafo.buscarNodo(n).EstaVisitado = true;
				List<N> array = new List<N>();
				while (cola.Count > 0)
				{
					N actual = cola.RemoveFirst();
					array.Add(actual);
					List<N> aux = grafo.darAdyacentes(actual);
					for (int i = 0; i < aux.Count; i++)
					{
						N sig = aux[i];
						if (grafo.buscarNodo(sig).EstaVisitado == false)
						{
							grafo.buscarNodo(sig).EstaVisitado = true;
							cola.AddLast(sig);
						}
					}

				}

				return array;
			}
			else
			{
				return null;
			}
		}

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public java.util.ArrayList<N> DFS(IGrafo<N> grafo, N n) throws Excepciones.ExcepcionNodoNoEncontrado
		public virtual List<N> DFS(IGrafo<N> grafo, N n)
		{

			if (grafo.existeNodo(n))
			{

				List<N> array = new List<N>();
				grafo.buscarNodo(n).EstaVisitado = true;
				array.Add(n);
				List<N> aux = grafo.darAdyacentes(n);
				for (int i = 0; i < aux.Count; i++)
				{
					N sig = aux[i];
					if (grafo.buscarNodo(sig).EstaVisitado == false)
					{
						List<N> array2 = DFS(grafo, sig);
						for (int j = 0; j < array2.Count; j++)
						{
							array.Add(array2[j]);
						}
					}
				}

				return array;

			}
			else
			{
				return null;
			}
		}

		// el parametro cond identifica con que tipo de grafo se esta trabajando, si
		// es
		// con listas entonces entra cond igual a true, si es con una matriz
		// entonces
		// cond es false
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public IGrafo<N> Kruskal(IGrafo<N> grafo, boolean cond) throws Excepciones.ExcepcionAristaImposible, Excepciones.ExcepcionNodoNoEncontrado
		public virtual IGrafo<N> Kruskal(IGrafo<N> grafo, bool cond)
		{
			if (cond)
			{
				return KruskalGrafoLista(grafo);
			}
			else
			{
				return KruskalGrafoMatriz(grafo);
			}

		}

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GrafoL<N> KruskalGrafoLista(IGrafo<N> grafo) throws Excepciones.ExcepcionAristaImposible
		public virtual GrafoL<N> KruskalGrafoLista(IGrafo<N> grafo)
		{

			GrafoL<N> graph = null;

			if (grafo.esDirigido())
			{
				graph = new GrafoL<N>(true, true);
			}
			else
			{
				graph = new GrafoL<N>(false, true);
			}

			List<Arista<N>> aristas = grafo.generarAristas();

			aristas.sort(null);

			List<N> nodos = grafo.darValorNodos();

			for (int i = 0; i < nodos.Count; i++)
			{
				graph.agregarNodo(nodos[i]);
			}

			List<Conjunto<N>> conjuntos = new List<Conjunto<N>>();

			for (int i = 0; i < nodos.Count; i++)
			{
				conjuntos.Add(new Conjunto<N>(nodos[i]));
			}

			for (int i = 0; i < aristas.Count && conjuntos.Count > 1; i++)
			{
				int n = conjuntos.Count;
				Arista<N> arista = aristas[i];
				N nodo1 = arista.NodoInicial.Valor;
				N nodo2 = arista.NodoFinal.Valor;
				for (int j = 0; j < conjuntos.Count; j++)
				{
					if (conjuntos[j].existeNodoEnElConjunto(nodo1) && !conjuntos[j].existeNodoEnElConjunto(nodo2))
					{
						Conjunto<N> c1 = conjuntos[j];
						Conjunto<N> c2 = null;
						int l = -1;
						for (int h = 0; c2 == null && h < conjuntos.Count; h++)
						{
							if (conjuntos[h].existeNodoEnElConjunto(nodo2))
							{
								c2 = conjuntos[h];
								l = h;
							}
						}
						if (c2 != null)
						{
							c1.unirConjuntos(c2);
							conjuntos.RemoveAt(l);
						}
					}
				}
				if (n > conjuntos.Count)
				{
					graph.agregarArista(nodo1, nodo2, arista.Peso);
				}
			}

			return graph;

		}

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GrafoM<N> KruskalGrafoMatriz(IGrafo<N> grafo) throws Excepciones.ExcepcionAristaImposible, Excepciones.ExcepcionNodoNoEncontrado
		public virtual GrafoM<N> KruskalGrafoMatriz(IGrafo<N> grafo)
		{
			GrafoM<N> graph = null;

			if (grafo.esDirigido())
			{
				graph = new GrafoM<N>(true, true);
			}
			else
			{
				graph = new GrafoM<N>(false, true);
			}

			List<Arista<N>> aristas = grafo.generarAristas();

			aristas.sort(null);

			List<N> nodos = grafo.darValorNodos();

			for (int i = 0; i < nodos.Count; i++)
			{
				graph.agregarNodo(nodos[i]);
			}

			List<Conjunto<N>> conjuntos = new List<Conjunto<N>>();

			for (int i = 0; i < nodos.Count; i++)
			{
				conjuntos.Add(new Conjunto<N>(nodos[i]));
			}

			for (int i = 0; i < aristas.Count && conjuntos.Count > 1; i++)
			{
				int n = conjuntos.Count;
				Arista<N> arista = aristas[i];
				N nodo1 = arista.NodoInicial.Valor;
				N nodo2 = arista.NodoFinal.Valor;
				for (int j = 0; j < conjuntos.Count; j++)
				{
					if (conjuntos[j].existeNodoEnElConjunto(nodo1) && !conjuntos[j].existeNodoEnElConjunto(nodo2))
					{

//====================================================================================================
//End of the allowed output for the Free Edition of Java to C# Converter.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================
