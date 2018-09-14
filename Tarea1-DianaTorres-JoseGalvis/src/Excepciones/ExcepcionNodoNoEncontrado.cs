namespace Excepciones
{
	public class ExcepcionNodoNoEncontrado : Exception
	{

		public ExcepcionNodoNoEncontrado<N>(N nodo) : base("El vertices buscado (" + nodo + ") no se encuentra en la matriz")
		{
		}

	}

}