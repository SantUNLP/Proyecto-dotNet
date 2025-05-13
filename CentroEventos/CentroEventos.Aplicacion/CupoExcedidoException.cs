using System;

namespace CentroEventos.Aplicacion;

public class CupoExcedidoException
{
    public CupoExcedidoException(string st) => throw new Exception(st);
}

/*
Se lanza al intentar registrar una Reserva para un EventoDeportivo sin cupo
(Consultar repositorio EventoDeportivo)
*/
