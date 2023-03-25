using System;

namespace Entidades
{
    public class Tickets
    {

        //PROPIEDADES
        public string Id { get; set; }
        public string CodigoUsuario { get; set; }
        public string IdentidadCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoSoporte { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string RespuestaSolicitud { get; set; }
        public decimal Precio { get; set; }
        public decimal ISV { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }


        //CONSTRUCTORES
        public Tickets()
        {
        }

        public Tickets(string id, string codigoUsuario, string identidadCliente, DateTime fecha, string tipoSoporte, string descripcionSolicitud, string respuestaSolicitud, decimal precio, decimal iSV, decimal descuento, decimal total)
        {
            Id = id;
            CodigoUsuario = codigoUsuario;
            IdentidadCliente = identidadCliente;
            Fecha = fecha;
            TipoSoporte = tipoSoporte;
            DescripcionSolicitud = descripcionSolicitud;
            RespuestaSolicitud = respuestaSolicitud;
            Precio = precio;
            ISV = iSV;
            Descuento = descuento;
            Total = total;
        }
    }
}
