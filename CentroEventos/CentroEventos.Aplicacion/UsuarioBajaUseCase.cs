using System;

namespace CentroEventos.Aplicacion;

public class UsuarioBajaUseCase(IServicioAutorizacion ISAP, IRepositorioUsuario IRU)
// Inyección de dependencias, aunque no existe el repositorio de Usuarios!
{
    public void Ejecutar(int id){
        if (ISAP.PoseeElPermiso(1, Permiso.UsuarioBaja))
        // SE ASUME QUE SIEMPRE LE MANDAMOS EL ID = 1, CASO CONTRARIO ENTENDEMOS QUE SE TIRA UNA EXCEPCIÓN
        {
            IRU.darDeBaja(id);
            // Dar de baja un usuario al sistema, usar VALIDACIONES y EXCEPCIONES
            // Consultar al repositorio si existe el usuario
        }
        else
        {
            throw new FalloAutorizacionException("No posee permisos para dar de baja!"); // Todas las excepciones se hacen en la clase UseCase
        }
    }
}
