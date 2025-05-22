namespace Naitv1.Models
{
    public class ActividadUsuario
    {
        public int ActividadId { get; set; }
        public Actividad? Actividad { get; set; }

        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
