using CentroEventos.Aplicacion;
using CentroEventos.Repositorios;

IServicioAutorizacion SerivicioAutorizacion = new ServicioAutorizacionProvisorio();
IRepositorioUsuario Repositorio = new RepositorioUsuarios();
var darAlta = new UsuarioAltaUseCase(SerivicioAutorizacion, Repositorio);
var listarUsuarios = new UsuariosListarUseCase(Repositorio);

Usuario user1 = new Usuario("santiago@gmail.com","1234","Santiago");

darAlta.Ejecutar(user1);

List <Usuario> lista = listarUsuarios.Ejecutar();

foreach (Usuario user in lista)
{
    Console.WriteLine(user.ToString());
}

