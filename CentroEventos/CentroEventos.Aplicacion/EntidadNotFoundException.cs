using System;

namespace CentroEventos.Aplicacion;

public class EntidadNotFoundException
{
    public EntidadNotFoundException(string st) => throw new Exception(st);
}

/*
Se lanza si se intenta operar con un Id que no existe
(ej: PersonaId, EventoDeportivoId o ReservaId no encontrados) (Consultar repositorios correspondientes)
*/