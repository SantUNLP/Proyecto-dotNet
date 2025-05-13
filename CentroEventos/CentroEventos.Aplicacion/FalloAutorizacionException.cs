using System;

namespace CentroEventos.Aplicacion;

public class FalloAutorizacionException
{
    public FalloAutorizacionException(string st) => throw new Exception(st);
}

/*
Se lanza cuando se intenta realizar una operación para la cual el usuario del sistema no tiene permiso
(No se puede consultar el repositorio ya que no existe)
(Todos los usuarios de ID = 1 tienen TODOS los permisos)
*/