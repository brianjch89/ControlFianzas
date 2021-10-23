using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Modelo;

namespace Controlador
{
    public class ControladorNotificaciones
    {
        ModeloNotificaciones m_Notificaciones = new ModeloNotificaciones();

        public DataTable ObtenerFianzasPorVencer(int mes, int año)
        {
            return m_Notificaciones.ObtenerFianzasPorVencer(mes, año);
        }
    }
}
