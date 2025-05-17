using System.Collections;

namespace CentroEventos.Aplicacion;

public class ServicioAutorizacionProvisorio : IServicioAutorizacion
{
    public bool PoseeElPermiso(int IdUsuario, Permiso p)
    {
        return IdUsuario == 1;
    }
}

// Método que verifica si un usuario posee algún permiso, para todo usuario de ID = 1, retorna true, caso contrario retorna false.
