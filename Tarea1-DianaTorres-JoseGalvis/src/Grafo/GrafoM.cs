//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System;
using System.Collections;
using System.Collections.Generic;

namespace Grafo
{
	using ExcepcionAristaImposible = Excepciones.ExcepcionAristaImposible;
	using ExcepcionNodoNoEncontrado = Excepciones.ExcepcionNodoNoEncontrado;

	public class GrafoM<N> : IGrafo<N>
	{

		public static int MAX_VERTICES;

//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private bool esDirigido_Renamed;
		private bool esPonderado;
		private List<Arista<N>>[][] matrizNodos;
		private List<Nodo<N>> nodos;
		private Dictionary<N, int> mapaNodos;
		private int tamanoGrafo;
		private List<Arista<N>> aristas;

		public GrafoM(bool pEsDirigido, int pnNodos, bool pPonderado)
		{

			MAX_VERTICES = pnNodos;
			esDirigido_Renamed = pEsDirigido;
			esPonderado = pPonderado;
			nodos = new List<Nodo<N>>();
//JAVA TO C# CONVERTER NOTE: The following call to the 'RectangularArrays' helper class reproduces the rectangular array initialization that is automatic in Java:
//ORIGINAL LINE: matrizNodos = new ArrayList[MAX_VERTICES][MAX_VERTICES];
			matrizNodos = RectangularArrays.ReturnRectangularArrayListArray(MAX_VERTICES, MAX_VERTICES);
			mapaNodos = new Dictionary<>();
			tamanoGrafo = 0;

		}

		public GrafoM(bool pEsDirigido, bool pPonderado)
		{

			MAX_VERTICES = 30;
			esDirigido_Renamed = pEsDirigido;
			esPonderado = pPonderado;
			nodos = new List<Nodo<N>>();
//JAVA TO C# CONVERTER NOTE: The following call to the 'RectangularArrays' helper class reproduces the rectangular array initialization that is automatic in Java:
//ORIGINAL LINE: matrizNodos = new ArrayList[MAX_VERTICES][MAX_VERTICES];
			matrizNodos = RectangularArrays.ReturnRectangularArrayListArray(MAX_VERTICES, MAX_VERTICES);
			mapaNodos = new Dictionary<>();
			tamanoGrafo = 0;

			aristas = new List<Arista<N>>();

		}

		public virtual int TamanoGrafo
		{
			get
			{
				return tamanoGrafo;
			}
			set
			{
				this.tamanoGrafo = value;
			}
		}


		public virtual bool EsPonderado
		{
			get
			{
				return esPonderado;
			}
			set
			{
				this.esPonderado = value;
			}
		}


		public virtual bool EsDirigido
		{
			get
			{
				return esDirigido_Renamed;
			}
			set
			{
				this.esDirigido_Renamed = value;
			}
		}


		public virtual List<Arista<N>>[][] MatrizNodos
		{
			get
			{
				return matrizNodos;
			}
			set
			{
				this.matrizNodos = value;
			}
		}


		public virtual List<Nodo<N>> Nodos
		{
			get
			{
				return nodos;
			}
			set
			{
				this.nodos = value;
			}
		}


		public virtual Dictionary<N, int> MapaNodos
		{
			get
			{
				return mapaNodos;
			}
			set
			{
				this.mapaNodos = value;
			}
		}


		public virtual void agregarNodo(N n)
		{

			if (!mapaNodos.ContainsKey(n))
			{
				Nodo<N> agregar = new Nodo<N>(n);
				mapaNodos[n] = nodos.Count;
				agregarNodo(agregar);
			}

		}

		private void agregarNodo(Nodo<N> nuevoNodo)
		{
			nodos.Add(nuevoNodo);
			tamanoGrafo = nodos.Count;

		}

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: @Override public boolean eliminarNodo(N n) throws Excepciones.ExcepcionNodoNoEncontrado
		public virtual bool eliminarNodo(N n)
		{

			bool seElimino = false;

			if (buscarNodo(n) != null)
			{
				Nodo<N> aEliminar = buscarNodo(n);
				eliminarNodo(aEliminar);
				seElimino = true;
			}
			return seElimino;
		}

		private void eliminarNodo(Nodo<N> nodoEliminar)
		{
			nodos.Remove(nodoEliminar);
			tamanoGrafo = nodos.Count;
		}


		public virtual bool existeCamino(N n1, N n2)
		{

			return false;
		}

		public virtual bool esConexo()
		{

			return false;
		}


		public virtual bool eliminarArista(N n1, N n2)
		{
			int v1 = nodos.IndexOf(n1);
			int v2 = nodos.IndexOf(n2);
			matrizNodos[v1][v2] = null;
			return false;
		}

		public virtual bool existeArista(N n1, N n2)
		{

			bool ahiEsta = false;
			int v1 = mapaNodos[n1];
			int v2 = mapaNodos[n2];

			if (existeNodo(n1) && existeNodo(n2))
			{

//====================================================================================================
//End of the allowed output for the Free Edition of Java to C# Converter.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================
