namespace JosueBaca
{
    partial class TicketsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.IdentidadTextBox = new System.Windows.Forms.TextBox();
            this.BuscarClienteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RespuestaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TipoSoporteComboBox = new System.Windows.Forms.ComboBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ListaTicketsDataGridView = new System.Windows.Forms.DataGridView();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ISVTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaTicketsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(394, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "TECH RELIEF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.NombreClienteTextBox);
            this.groupBox2.Controls.Add(this.IdentidadTextBox);
            this.groupBox2.Controls.Add(this.BuscarClienteButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(973, 65);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre:";
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NombreClienteTextBox.Enabled = false;
            this.NombreClienteTextBox.Location = new System.Drawing.Point(436, 28);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.ReadOnly = true;
            this.NombreClienteTextBox.Size = new System.Drawing.Size(531, 23);
            this.NombreClienteTextBox.TabIndex = 8;
            // 
            // IdentidadTextBox
            // 
            this.IdentidadTextBox.Enabled = false;
            this.IdentidadTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdentidadTextBox.Location = new System.Drawing.Point(109, 27);
            this.IdentidadTextBox.Name = "IdentidadTextBox";
            this.IdentidadTextBox.Size = new System.Drawing.Size(200, 23);
            this.IdentidadTextBox.TabIndex = 4;
            this.IdentidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentidadTextBox_KeyPress);
            // 
            // BuscarClienteButton
            // 
            this.BuscarClienteButton.Enabled = false;
            this.BuscarClienteButton.Location = new System.Drawing.Point(315, 26);
            this.BuscarClienteButton.Name = "BuscarClienteButton";
            this.BuscarClienteButton.Size = new System.Drawing.Size(32, 25);
            this.BuscarClienteButton.TabIndex = 7;
            this.BuscarClienteButton.Text = "...";
            this.BuscarClienteButton.UseVisualStyleBackColor = true;
            this.BuscarClienteButton.Click += new System.EventHandler(this.BuscarClienteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. Identidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaDateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UsuarioTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Enabled = false;
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(795, 19);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(172, 23);
            this.FechaDateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(742, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UsuarioTextBox.Location = new System.Drawing.Point(72, 19);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(200, 23);
            this.UsuarioTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RespuestaTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TipoSoporteComboBox);
            this.groupBox3.Controls.Add(this.DescripcionTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(973, 115);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la Gestión";
            // 
            // RespuestaTextBox
            // 
            this.RespuestaTextBox.Enabled = false;
            this.RespuestaTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RespuestaTextBox.Location = new System.Drawing.Point(547, 71);
            this.RespuestaTextBox.Name = "RespuestaTextBox";
            this.RespuestaTextBox.Size = new System.Drawing.Size(420, 23);
            this.RespuestaTextBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Respuesta:";
            // 
            // TipoSoporteComboBox
            // 
            this.TipoSoporteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoSoporteComboBox.Enabled = false;
            this.TipoSoporteComboBox.FormattingEnabled = true;
            this.TipoSoporteComboBox.Items.AddRange(new object[] {
            "Dispositivo Móvil ",
            "Equipo de Cómputo"});
            this.TipoSoporteComboBox.Location = new System.Drawing.Point(122, 31);
            this.TipoSoporteComboBox.Name = "TipoSoporteComboBox";
            this.TipoSoporteComboBox.Size = new System.Drawing.Size(225, 26);
            this.TipoSoporteComboBox.TabIndex = 11;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Enabled = false;
            this.DescripcionTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(547, 33);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(420, 23);
            this.DescripcionTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descripción de la solictud:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tipo de Soporte:";
            // 
            // ListaTicketsDataGridView
            // 
            this.ListaTicketsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaTicketsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaTicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaTicketsDataGridView.Location = new System.Drawing.Point(12, 377);
            this.ListaTicketsDataGridView.Name = "ListaTicketsDataGridView";
            this.ListaTicketsDataGridView.Size = new System.Drawing.Size(973, 202);
            this.ListaTicketsDataGridView.TabIndex = 11;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Enabled = false;
            this.TotalTextBox.Location = new System.Drawing.Point(837, 690);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(148, 23);
            this.TotalTextBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(738, 692);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "Total a Pagar:";
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Enabled = false;
            this.DescuentoTextBox.Location = new System.Drawing.Point(837, 661);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(148, 23);
            this.DescuentoTextBox.TabIndex = 25;
            this.DescuentoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescuentoTextBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(753, 663);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Descuento:";
            // 
            // ISVTextBox
            // 
            this.ISVTextBox.Enabled = false;
            this.ISVTextBox.Location = new System.Drawing.Point(837, 632);
            this.ISVTextBox.Name = "ISVTextBox";
            this.ISVTextBox.ReadOnly = true;
            this.ISVTextBox.Size = new System.Drawing.Size(148, 23);
            this.ISVTextBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(727, 634);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Impuesto (ISV):";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Enabled = false;
            this.PrecioTextBox.Location = new System.Drawing.Point(837, 603);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(148, 23);
            this.PrecioTextBox.TabIndex = 21;
            this.PrecioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTextBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(777, 605);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Precio:";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = global::JosueBaca.Properties.Resources.cancelar_ticket;
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.Location = new System.Drawing.Point(302, 632);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(109, 49);
            this.CancelarButton.TabIndex = 30;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = global::JosueBaca.Properties.Resources.guardar_datos;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(165, 632);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(119, 49);
            this.GuardarButton.TabIndex = 29;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = global::JosueBaca.Properties.Resources.ticket_de_soporte;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(12, 632);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(134, 49);
            this.NuevoButton.TabIndex = 28;
            this.NuevoButton.Text = "Nuevo Ticket";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JosueBaca.Properties.Resources.soporte_tecnico;
            this.pictureBox1.Location = new System.Drawing.Point(327, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 736);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ISVTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ListaTicketsDataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketsForm";
            this.Text = "TicketsForm";
            this.Load += new System.EventHandler(this.TicketsForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaTicketsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IdentidadTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.Button BuscarClienteButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox RespuestaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox TipoSoporteComboBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView ListaTicketsDataGridView;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ISVTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}