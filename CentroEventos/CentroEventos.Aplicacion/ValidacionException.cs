using System;

namespace CentroEventos.Aplicacion;

public class ValidacionException : Exception
{
    public ValidacionException(string st) : base(st) { }
}

/*
Se lanza si algún dato obligtatorio está ausente, tiene formato incorrecto,
o una regla de validación simple falla
(ej: CupoMáximo <= 0, FechaHoraInicio anterior a la fecha y hora actual)
*/