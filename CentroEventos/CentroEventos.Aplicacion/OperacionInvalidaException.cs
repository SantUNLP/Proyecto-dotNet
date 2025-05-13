using System;

namespace CentroEventos.Aplicacion;

public class OperacionInvalidaException
{
    public OperacionInvalidaException(string st) => throw new Exception(st);
}

/*
Se lanza al intentar realizar una operación no permitida por las reglas de negocio
(ej: eliminar entidad con dependencias) (Consultar repositorios correspondientes)
*/