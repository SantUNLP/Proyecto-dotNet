using System;

namespace CentroEventos.Aplicacion;

public class UsuarioModificacionUseCase(IServicioAutorizacion ISAP, IRepositorioUsuario IRU)
// Inyección de dependencias, aunque no existe el repositorio de Usuarios!
{
    public void Ejecutar(){
        if (ISAP.PoseeElPermiso(1, Permiso.UsuarioModificacion))
        // SE ASUME QUE SIEMPRE LE MANDAMOS EL ID = 1, CASO CONTRARIO ENTENDEMOS QUE SE TIRA UNA EXCEPCIÓN 
        {
            IRU.modificarUsuario();
            // ¿Qué se modifica?
            // Modificar los datos de un usuario al sistema, usar VALIDACIONES y EXCEPCIONES
            // Consultar al repositorio si existe el usuario
        }
        else
        {
            new FalloAutorizacionException("No posee permisos para modificar!"); // Todas las excepciones se hacen en la clase UseCase
        }
    }
}
