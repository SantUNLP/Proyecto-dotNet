using System;

namespace CentroEventos.Aplicacion;

public class UsuarioAltaUseCase
{
    public void Ejecutar(IServicioAutorizacion ISAP /*IRepositorioUsuarios IRU (No existe)*/){
        if (ISAP.PoseeElPermiso(1,Permiso.UsuarioAlta)){
            Console.WriteLine("Usuario dado de alta!");
            // Dar de alta un usuario al sistema, usar VALIDACIONES y EXCEPCIONES
        } else {
                new FalloAutorizacionException("No posee permisos!"); // Todas las excepciones se hacen en la clase UseCase
        }
    }
}
