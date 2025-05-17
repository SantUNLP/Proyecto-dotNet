using System;

namespace CentroEventos.Aplicacion;

public class FalloAutorizacionException : Exception
{
    public FalloAutorizacionException(string st) : base(st) { }
}

/*
Se lanza cuando se intenta realizar una operación para la cual el usuario del sistema no tiene permiso
(No se puede consultar el repositorio ya que no existe)
(Todos los usuarios de ID = 1 tienen TODOS los permisos)
*/