namespace EstanciaCaballos.App.Frontend.Pages
{
    public class Equipo
    {
        public Equipo(string nombre,string rol,List<string> descripcionRol)
        {
            Nombre = nombre;
            Rol = rol;
            DescripcionRol = descripcionRol;
        }
        public string Nombre {get; set;}
        public string Rol {get; set;}
        public List<string> DescripcionRol {get;set;}

    }
}