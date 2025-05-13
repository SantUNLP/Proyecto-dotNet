using System;

namespace CentroEventos.Aplicacion;

public class ValidacionException
{
    public ValidacionException(string st) => throw new Exception(st);
}

/*
Se lanza si algún dato obligtatorio está ausente, tiene formato incorrecto,
o una regla de validación simple falla
(ej: CupoMáximo <= 0, FechaHoraInicio anterior a la fecha y hora actual)
(???)
*/