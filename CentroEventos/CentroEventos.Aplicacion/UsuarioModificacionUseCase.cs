using System;

namespace CentroEventos.Aplicacion;

public class UsuarioModificacionUseCase
{
    public void Ejecutar(IServicioAutorizacion ISAP /*IRepositorioUsuarios IRU (No existe)*/){
            if (ISAP.PoseeElPermiso(1,Permiso.UsuarioModificacion)){
            Console.WriteLine("Usuario modificado!");
            // Modificar los datos de un usuario al sistema, usar VALIDACIONES y EXCEPCIONES
            // Consultar al repositorio si existe el usuario
            } else {
                new FalloAutorizacionException("No posee permisos!"); // Todas las excepciones se hacen en la clase UseCase
            }
    }
}
