namespace Entidades
{
    public class Login
    {
        //PROPIEDADES
        public string CodigoUsuario { get; set; }
        public string Contraseña { get; set; }


        //CONSTRUCTORES
        public Login()
        {
        }

        public Login(string codigoUsuario, string contraseña)
        {
            CodigoUsuario = codigoUsuario;
            Contraseña = contraseña;
        }
    }
}
