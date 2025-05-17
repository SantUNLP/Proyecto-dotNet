using System;

namespace CentroEventos.Aplicacion;

public class UsuarioAltaUseCase (IServicioAutorizacion ISAP, IRepositorioUsuario IRU)
// Inyección de dependencias, aunque no existe el repositorio de Usuarios!
{
    public void Ejecutar(Usuario usuario){
        if (ISAP.PoseeElPermiso(1, Permiso.UsuarioAlta))
        // SE ASUME QUE SIEMPRE LE MANDAMOS EL ID = 1, CASO CONTRARIO ENTENDEMOS QUE SE TIRA UNA EXCEPCIÓN
        {
            IRU.agregarUsuario(usuario);
            // Dar de alta un usuario al sistema, usar VALIDACIONES y EXCEPCIONES
            // Consultar al repositorio si se repite el usuario
        }
        else
        {
            throw new FalloAutorizacionException("No posee permisos para dar de Alta!"); // Todas las excepciones se hacen en la clase UseCase
        }
    }
}
