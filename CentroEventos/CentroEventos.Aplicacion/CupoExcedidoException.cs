using System;

namespace CentroEventos.Aplicacion;

public class CupoExcedidoException : Exception
{
    public CupoExcedidoException(string st) : base(st) { }
}

/*
Se lanza al intentar registrar una Reserva para un EventoDeportivo sin cupo
(Consultar repositorio EventoDeportivo)
*/
