using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Negocio;
namespace Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "UserService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione UserService.svc o UserService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class UserService : IServices
    {
        /// <summary>
        /// para usuarios
        /// </summary>

        bool IServices.BorrarUserService(int id)
        {
            return UserNegocio.BorrarUserNegocio(id);
        }

        UserEntidad IServices.BuscarUserService(int id)
        {
            return UserNegocio.BuscarUserNegocio(id);
        }

        UserEntidad IServices.CrearUserService(UserEntidad user)
        {
            return UserNegocio.CrearUserNegocio(user);
        }

        UserEntidad IServices.EditarUserService(UserEntidad user)
        {
            return UserNegocio.EditarUserNegocio(user);
        }

        List<UserEntidad> IServices.ListarUserService()
        {
            return UserNegocio.ListarUserNegocio();
        }

        UserEntidad IServices.VerificarUserService(string user, string pass)
        {
            return UserNegocio.VerificarUserNegocio(user, pass);
        }

        /// <summary>
        /// para sucursales
        /// </summary>
        public bool BorrarOfficeService(int id)
        {
            return OfficeNegocio.BorrarOfficeNegocio(id);
        }

        public OfficeEntidad BuscarOfficeService(int id)
        {
            return OfficeNegocio.BuscarOfficeNegocio(id);
        }

        public OfficeEntidad CrearOfficeService(OfficeEntidad office)
        {
            return OfficeNegocio.CrearOfficeNegocio(office);
        }

        public OfficeEntidad EditarOfficeService(OfficeEntidad office)
        {
            return OfficeNegocio.EditarOfficeNegocio(office);
        }

        public List<OfficeEntidad> ListarOfficeService()
        {
            return OfficeNegocio.ListarOfficeNegocio();
        }


        /// <summary>
        /// para notificaciones
        /// </summary>
        public DetailEntidad CrearDetailService(DetailEntidad detail)
        {
            return DetailNegocio.CrearDetailNegocio(detail);
        }

        public DetailEntidad EditarDetailService(DetailEntidad detail)
        {
            return DetailNegocio.EditarDetailNegocio(detail);
        }

        public List<DetailEntidad> ListarDetailService()
        {
            return DetailNegocio.ListarDetailNegocio();
        }

        public bool BorrarDetailService(int id)
        {
            return DetailNegocio.BorrarDetailNegocio(id);
        }

        public DetailEntidad BuscarDetailService(int id)
        {
            return DetailNegocio.BuscarDetailNegocio(id);
        }
    }
}
