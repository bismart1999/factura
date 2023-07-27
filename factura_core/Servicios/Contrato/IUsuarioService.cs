using Microsoft.EntityFrameworkCore;
using factura_core.Models;

namespace factura_core.Servicios.Contrato
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuarios(string correo, string clave);
        Task<Usuario>SaveUsuario(Usuario modelo);
    }
}
