namespace Grafo
{
	public class Nodo <N>
	{

		private N valor;
		private bool estaVisitado;

		public Nodo(N n)
		{
			valor = n;
		}


		public virtual N Valor
		{
			get
			{
				return valor;
			}
			set
			{
				valor = value;
			}
		}



		public virtual bool EstaVisitado
		{
			get
			{
				return estaVisitado;
			}
			set
			{
				this.estaVisitado = value;
			}
		}






	}

}