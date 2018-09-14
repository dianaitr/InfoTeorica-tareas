//====================================================================================================
//The Free Edition of Java to C# Converter limits conversion output to 100 lines per file.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================

using System.Collections.Generic;

namespace Grafo
{

	using ExcepcionAristaImposible = Excepciones.ExcepcionAristaImposible;

	public class GrafoL<N> : IGrafo<N>
	{

//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
		private bool esDirigido_Renamed;

		private List<Arista<N>> aristas;

		private bool tienePeso;

		private List<LinkedList<Nodo<N>>> nodos;

		private Dictionary<N, Dictionary<N, int>> pesos;

		public virtual Dictionary<N, Dictionary<N, int>> Pesos
		{
			get
			{
				return pesos;
			}
		}

		//esDirigido, tienePeso
		public GrafoL(bool esD, bool tieneP)
		{

			Aristas = new List<Arista<N>>();

			tienePeso = tieneP;
			esDirigido_Renamed = esD;

			if (tienePeso)
			{
				pesos = new Dictionary<N, Dictionary<N, int>>();
			}
			nodos = new List<LinkedList<Nodo<N>>>();
		}

		public virtual void agregarNodo(N n)
		{
			bool cond = false;
			for (int i = 0; i < nodos.Count && !cond; i++)
			{
				if (nodos[i].Count > 0)
				{
					if (nodos[i].get(0).Equals(n))
					{
						cond = true;
					}
				}
			}

			if (!cond)
			{
				LinkedList<Nodo<N>> l = new LinkedList<Nodo<N>>();
				Nodo<N> nodo = new Nodo<N>(n);
				l.AddLast(nodo);
				nodos.Add(l);
			}

			if (tienePeso)
			{
				if (pesos[n] == null)
				{
					pesos[n] = new Dictionary<N, int>();
				}
			}

		}

		public virtual bool eliminarNodo(N n)
		{

			List<Arista<N>> ari = generarAristas();
			List<Arista<N>> ariNuevo = new List<Arista<N>>();

			if (ari.Count != 0)
			{
				int tamano = ari.Count;
				for (int i = 0; i < ari.Count; i++)
				{

					N actualInicial = ari[i].NodoInicial.Valor;
					N actualFinal = ari[i].NodoFinal.Valor;

					if (actualInicial.Equals(n))
					{

					}
					else if (actualFinal.Equals(n))
					{

					}
					else
					{
						ariNuevo.Add(aristas[i]);
					}
				}
				aristas = new List<Arista<N>>();
				for (int i = 0; i < ariNuevo.Count; i++)
				{
					aristas.Add(ariNuevo[i]);
				}
			}

			bool seEncontro = false;

			for (int i = 0; i < nodos.Count; i++)
			{
				if (!seEncontro)
				{

					for (int j = 0; j < nodos[i].Count; j++)
					{
						if (nodos[i].get(j).Valor.Equals(n))
						{
//JAVA TO C# CONVERTER TODO TASK: There is no .NET LinkedList equivalent to the Java 'remove' method:
							if (nodos[i].remove(j) != null)
							{
								seEncontro = true;
							}
						}
					}

				}
				else
				{

					for (int j = 0; j < nodos[i].Count; j++)
					{
						if (nodos[i].get(j).Valor.Equals(n))
						{
//JAVA TO C# CONVERTER TODO TASK: There is no .NET LinkedList equivalent to the Java 'remove' method:
							nodos[i].remove(j);

						}
					}

				}

			}

			if (tienePeso)
			{
				pesos.Remove(n);
				for (int i = 0; i < nodos.Count; i++)
				{
					if (nodos[i].Count > 0)
					{
						if (pesos[nodos[i].get(0).Valor][n] != null)
						{
							pesos[nodos[i].get(0).Valor].Remove(n);
						}
					}
				}
			}

			return seEncontro;

		}

		public virtual bool existeCamino(N n1, N n2)
		{

			return false;
		}

		public virtual bool esConexo()
		{

			return false;
		}

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: @Override public void agregarArista(N n1, N n2, System.Nullable<int> peso) throws Excepciones.ExcepcionAristaImposible
		public virtual void agregarArista(N n1, N n2, int? peso)
		{

			if (existeNodo(n1) && existeNodo(n2))
			{

				if (esDirigido_Renamed)
				{

					bool c = false;
					for (int i = 0; i < nodos.Count && !c; i++)
					{
						if (nodos[i].Count > 0)
						{
							if (nodos[i].get(0).Valor.Equals(n1))
							{
								c = true;
								bool c1 = false;
								for (int j = 0; j < nodos[i].Count && !c1; j++)
								{
									if (nodos[i].get(j).Valor.Equals(n2))
									{
										c1 = true;
									}
								}
								if (!c1)
								{
									nodos[i].AddLast(new Nodo<N>(n2));
									Arista<N> arista = new Arista<N>(new Nodo<N>(n1), new Nodo<N>(n2), peso.Value);
									aristas.Add(arista);
								}
							}
						}

					}

				}
				else
				{

					int n = 0;

					while (n < 2)
					{

						if (n == 1)
						{
							N n3 = n1;
							n1 = n2;
							n2 = n3;
						}

						bool c = false;
						for (int i = 0; i < nodos.Count && !c; i++)
						{
							if (nodos[i].get(0).Valor.Equals(n1))
							{
								c = true;
								bool c1 = false;
								for (int j = 0; j < nodos[i].Count && !c1; j++)
								{

//====================================================================================================
//End of the allowed output for the Free Edition of Java to C# Converter.

//To purchase the Premium Edition, visit our website:
//https://www.tangiblesoftwaresolutions.com/order/order-java-to-csharp.html
//====================================================================================================
