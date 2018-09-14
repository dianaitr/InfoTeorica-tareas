using System.Collections.Generic;

namespace Grafo
{

	using ExcepcionAristaImposible = Excepciones.ExcepcionAristaImposible;
	using ExcepcionNodoNoEncontrado = Excepciones.ExcepcionNodoNoEncontrado;

	public interface IGrafo <N>
	{

		void agregarNodo(N n);
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public boolean eliminarNodo(N n) throws Excepciones.ExcepcionNodoNoEncontrado;
		bool eliminarNodo(N n);
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public boolean eliminarArista(N n1,N n2) throws Excepciones.ExcepcionAristaImposible;
		bool eliminarArista(N n1, N n2);
		bool existeCamino(N n1, N n2);
		bool esConexo();
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void agregarArista(N n1, N n2, System.Nullable<int> peso) throws Excepciones.ExcepcionAristaImposible, Excepciones.ExcepcionNodoNoEncontrado;
		void agregarArista(N n1, N n2, int? peso);
		bool existeArista(N n1, N n2);
		bool existeNodo(N n);
		List<N> darAdyacentes(N n);
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public Nodo<N> buscarNodo(N n) throws Excepciones.ExcepcionNodoNoEncontrado;
		Nodo<N> buscarNodo(N n);
		void reestablecerNodos();
		List<Arista<N>> generarAristas();
		bool esDirigido();
		List<N> darValorNodos();
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public java.util.ArrayList<Arista<N>> darAristasAdyacentes(N n) throws Excepciones.ExcepcionNodoNoEncontrado;
		List<Arista<N>> darAristasAdyacentes(N n);
		Arista<N> buscarArista(N n1, N n2);
		List<Arista<N>>[][] darMatriz();


	}

}