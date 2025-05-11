using CentroEventos.Aplicacion;

IServicioAutorizacion SAP = new ServicioAutorizacionProvisorio();

UsuarioAltaUseCase Alta = new UsuarioAltaUseCase();
UsuarioModificacionUseCase Modificacion = new UsuarioModificacionUseCase();
UsuarioBajaUseCase Baja = new UsuarioBajaUseCase();

Alta.Ejecutar(SAP);
Modificacion.Ejecutar(SAP);
Baja.Ejecutar(SAP);