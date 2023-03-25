using Entidades;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace Base_de_Datos
{
    public class TicketsDB
    {
        string cadena = "server=localhost; user=root; database=tickets; password=123456;";

        public bool GuardarTicket(Tickets ticket)
        {
            bool inserto = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO ticket (Fecha, CodigoUsuario, IdentidadCliente, TipoSoporte, DescripcionSolicitud, RespuestaSolicitud, Precio, ISV, Descuento, Total) VALUES (@Fecha, @CodigoUsuario, @IdentidadCliente, @TipoSoporte, @DescripcionSolicitud, @RespuestaSolicitud, @Precio, @ISV, @Descuento, @Total);");
                sql.Append("SELECT LAST_INSERT_ID();");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = ticket.Fecha;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = ticket.CodigoUsuario;
                        comando.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 25).Value = ticket.IdentidadCliente;
                        comando.Parameters.Add("@TipoSoporte", MySqlDbType.VarChar, 30).Value = ticket.TipoSoporte;
                        comando.Parameters.Add("@DescripcionSolicitud", MySqlDbType.VarChar, 200).Value = ticket.DescripcionSolicitud;
                        comando.Parameters.Add("@RespuestaSolicitud", MySqlDbType.VarChar, 200).Value = ticket.RespuestaSolicitud;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = ticket.Precio;
                        comando.Parameters.Add("@ISV", MySqlDbType.Decimal).Value = ticket.ISV;
                        comando.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = ticket.Descuento;
                        comando.Parameters.Add("@Total", MySqlDbType.Decimal).Value = ticket.Total;
                        comando.ExecuteNonQuery();
                        inserto = true;
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            return inserto;
        }

        public DataTable DevolverTickets()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM ticket ");
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            return dt;
        }
    }


}

