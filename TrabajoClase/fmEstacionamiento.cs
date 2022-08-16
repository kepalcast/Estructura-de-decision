namespace TrabajoClase
{
    public partial class fmEstacionamiento : Form
    {
        string dia;
        public fmEstacionamiento()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Mostrando la fecha actual
            lblFecha.Text = DateTime.Now.ToShortDateString();

            //Determinar el día
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            dia = fecha.ToString("dddd");

            double costo = 0;
            switch (dia)
            {
                case "domingo": costo = 2; break;
                case "lunes":
                case "martes":
                case "miércoles":
                case "Jueves":
                    costo = 4; break;
                case "viernes":
                case "sábado":
                    costo = 7;break;
            }
            lblCosto.Text = costo.ToString("0.00");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lvlRegistro_Click(object sender, EventArgs e)
        {
            //Capturando los datos del formulario
            string placa = txtPlaca.Text;
            double costo = double.Parse(lblCosto.Text);
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            DateTime horaInicio = DateTime.Parse(txtHoraInicio.Text);
            DateTime horafin = DateTime.Parse(txtHoraSalida.Text);

            //Calcular la hora
            TimeSpan hora = horafin - horaInicio;

            //Calcular el importe
            double importe = costo * (hora.TotalHours);

            ListViewItem fila = new ListViewItem(placa);
            fila.SubItems.Add(fecha.ToString("d"));
            fila.SubItems.Add(horaInicio.ToString("t"));
            fila.SubItems.Add(horafin.ToString("t"));
            fila.SubItems.Add(hora.TotalHours.ToString());
            fila.SubItems.Add(costo.ToString("C"));
            fila.SubItems.Add(importe.ToString("C"));
            lvlRegistro.Items.Add(fila);
        }

        private void lvlSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estás seguro de salir?",
                                              "Estacionamiento",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Exclamation);
            if(r == DialogResult.Yes)
                this.Close();
        }

        private void lvlLimpiar_Click(object sender, EventArgs e)
        {
            txtPlaca.Clear();
            txtHoraInicio.Clear();
            txtHoraSalida.Clear();
            lvlRegistro.Clear();
        }
    }
}