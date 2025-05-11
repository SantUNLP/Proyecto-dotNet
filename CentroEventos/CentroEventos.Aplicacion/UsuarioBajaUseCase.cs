using System;

namespace CentroEventos.Aplicacion;

public class UsuarioBajaUseCase
{
    public void Ejecutar(IServicioAutorizacion ISAP /*IRepositorioUsuarios IRU (No existe)*/){
        if (ISAP.PoseeElPermiso(1,Permiso.UsuarioBaja)){
            Console.WriteLine("Usuario dado de baja!");
            // Dar de baja un usuario al sistema, usar VALIDACIONES y EXCEPCIONES
            // Consultar al repositorio si existe el usuario
        } else {
                new FalloAutorizacionException("No posee permisos!"); // Todas las excepciones se hacen en la clase UseCase
        }
    }
}
