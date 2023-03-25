using Base_de_Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace JosueBaca
{
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();
        }

        Cliente miCliente = null;
        ClienteDB clienteDB = new ClienteDB();
        TicketsDB ticketDB = new TicketsDB();

        decimal precio = 0;
        decimal ISV = 0;
        decimal descuento = 0;
        decimal TotalPagar = 0;


        private void TicketsForm_Load(object sender, System.EventArgs e)
        {
            UsuarioTextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
            ISVTextBox.Text = "0.00";
            TotalTextBox.Text = "0.00";
            FechaDateTimePicker.Value = DateTime.Now;
        }


        private void IdentidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(IdentidadTextBox.Text))
            {
                miCliente = new Cliente();
                miCliente = clienteDB.DevolverClientePorIdentidad(IdentidadTextBox.Text);
                NombreClienteTextBox.Text = miCliente.Nombre;
            }
            else
            {
                miCliente = null;
                NombreClienteTextBox.Clear();
            }
        }

        private void BuscarClienteButton_Click(object sender, System.EventArgs e)
        {
            BuscarClienteForm form = new BuscarClienteForm();
            form.ShowDialog();
            miCliente = new Cliente();
            miCliente = form.cliente;
            IdentidadTextBox.Text = miCliente.Identidad;
            NombreClienteTextBox.Text = miCliente.Nombre;
        }


        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(PrecioTextBox.Text))
            {
                precio = Convert.ToDecimal(PrecioTextBox.Text);
                ISV = precio * 0.15M;
                TotalPagar = precio + ISV;

                ISVTextBox.Text = ISV.ToString("N2");
                TotalTextBox.Text = TotalPagar.ToString("N2");

            }
        }


        private void GuardarButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(IdentidadTextBox.Text))
            {
                errorProvider1.SetError(IdentidadTextBox, "Consulte un Cliente");
                IdentidadTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(TipoSoporteComboBox.Text))
            {
                errorProvider1.SetError(TipoSoporteComboBox, "Seleccione el tipo de soporte");
                TipoSoporteComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                errorProvider1.SetError(DescripcionTextBox, "Ingrese la descripción de la solicitud");
                DescripcionTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(RespuestaTextBox.Text))
            {
                errorProvider1.SetError(RespuestaTextBox, "Ingrese la respuesta de la solitud");
                RespuestaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(PrecioTextBox.Text))
            {
                errorProvider1.SetError(PrecioTextBox, "Ingrese el precio del soporte técnico");
                PrecioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            Tickets miTicket = new Tickets();

            miTicket.CodigoUsuario = System.Threading.Thread.CurrentPrincipal.Identity.Name;
            miTicket.IdentidadCliente = IdentidadTextBox.Text;
            miTicket.Fecha = FechaDateTimePicker.Value;
            miTicket.TipoSoporte = TipoSoporteComboBox.Text;
            miTicket.DescripcionSolicitud = DescripcionTextBox.Text;
            miTicket.RespuestaSolicitud = RespuestaTextBox.Text;
            miTicket.Precio = precio;
            miTicket.ISV = ISV;
            miTicket.Descuento = descuento;
            miTicket.Total = TotalPagar;

            bool inserto = ticketDB.GuardarTicket(miTicket);

            if (inserto)
            {
                LimpiarControles();
                DeshabilitarControles();
                TraerTickets();
                MessageBox.Show("Ticket guardado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se guardó el ticket", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DescuentoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(DescuentoTextBox.Text))
            {
                descuento = Convert.ToDecimal(DescuentoTextBox.Text);
                TotalPagar = TotalPagar - descuento;
                TotalTextBox.Text = TotalPagar.ToString("N2");
            }
        }


        private void HabilitarControles()
        {
            FechaDateTimePicker.Enabled = true;
            IdentidadTextBox.Enabled = true;
            BuscarClienteButton.Enabled = true;
            NombreClienteTextBox.Enabled = true;
            TipoSoporteComboBox.Enabled = true;
            DescripcionTextBox.Enabled = true;
            RespuestaTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;
            ISVTextBox.Enabled = true;
            DescuentoTextBox.Enabled = true;
            TotalTextBox.Enabled = true;
            GuardarButton.Enabled = true;
            CancelarButton.Enabled = true;
            NuevoButton.Enabled = false;
        }


        private void DeshabilitarControles()
        {
            FechaDateTimePicker.Enabled = false;
            IdentidadTextBox.Enabled = false;
            BuscarClienteButton.Enabled = false;
            NombreClienteTextBox.Enabled = false;
            TipoSoporteComboBox.Enabled = false;
            DescripcionTextBox.Enabled = false;
            RespuestaTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            ISVTextBox.Enabled = false;
            DescuentoTextBox.Enabled = false;
            TotalTextBox.Enabled = false;
            GuardarButton.Enabled = false;
            CancelarButton.Enabled = false;
            NuevoButton.Enabled = true;
        }


        private void LimpiarControles()
        {
            miCliente = null;
            FechaDateTimePicker.Value = DateTime.Now;
            IdentidadTextBox.Clear();
            NombreClienteTextBox.Clear();
            TipoSoporteComboBox.Text = null;
            DescripcionTextBox.Clear();
            RespuestaTextBox.Clear();
            PrecioTextBox.Clear();
            ISVTextBox.Clear();
            DescuentoTextBox.Clear();
            TotalTextBox.Clear();
            precio = 0;
            ISV = 0;
            descuento = 0;
            TotalPagar = 0;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            IdentidadTextBox.Focus();
            HabilitarControles();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }

        private void TraerTickets()
        {
            ListaTicketsDataGridView.DataSource = ticketDB.DevolverTickets();
        }
    }
}
