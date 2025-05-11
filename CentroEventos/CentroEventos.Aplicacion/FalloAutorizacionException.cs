using System;

namespace CentroEventos.Aplicacion;

public class FalloAutorizacionException
{
    public FalloAutorizacionException(string st) => throw new Exception(st);
}
