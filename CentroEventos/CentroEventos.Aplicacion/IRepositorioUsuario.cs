using System;

namespace CentroEventos.Aplicacion;

public interface IRepositorioUsuario
{
    void agregarUsuario(Usuario usuario);
    bool darDeBaja(int id);
    void modificarUsuario(/* que va aca? */);
    List<Usuario> mostrarUsuarios();
}

// NO IMPLEMENTAMOS UN REPOSITORIO DE USUARIOS!
