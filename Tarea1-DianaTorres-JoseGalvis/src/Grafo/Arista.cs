using System;

namespace Grafo
{
	public class Arista<N> : IComparable
	{


		private Nodo<N> nodoInicial;
		private Nodo<N> nodoFinal;
		private int peso;
		private bool visitado;
		private bool seleccionado;


		public Arista(Nodo<N> nodoI, Nodo<N> nodoF, int p)
		{
			nodoFinal = nodoF;
			nodoInicial = nodoI;
			peso = p;
		}


		public virtual Nodo<N> NodoInicial
		{
			get
			{
				return nodoInicial;
			}
			set
			{
				this.nodoInicial = value;
			}
		}




		public virtual Nodo<N> NodoFinal
		{
			get
			{
				return nodoFinal;
			}
			set
			{
				this.nodoFinal = value;
			}
		}




		public virtual int Peso
		{
			get
			{
				return peso;
			}
			set
			{
				this.peso = value;
			}
		}




		public virtual int CompareTo(object arg0)
		{

			Arista<N> arista = (Arista<N>) arg0;

			if (arista.Peso > peso)
			{
				return -1;
			}
			else if (arista.Peso < peso)
			{
				return 1;
			}
			else
			{
				return 0;
			}


		}


		public virtual bool Visitado
		{
			get
			{
				return visitado;
			}
			set
			{
				this.visitado = value;
			}
		}




		public virtual bool Seleccionado
		{
			get
			{
				return seleccionado;
			}
			set
			{
				this.seleccionado = value;
			}
		}



	}

}