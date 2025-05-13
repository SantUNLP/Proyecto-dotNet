using System;

namespace CentroEventos.Aplicacion;

public class DuplicadoException
{
    public DuplicadoException(string st) => throw new Exception(st);
}

/*
Se lanza cuando se intenta crear una Persona con DNI/Email ya existente, (Consultar repositorio)
o una Reserva duplicada para la misma persona/actividad. (Consultar repositorio)
*/
