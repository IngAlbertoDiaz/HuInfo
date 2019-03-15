using System;
using System.Windows.Forms;
using System.Net;
using System.Data;

namespace HuInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string IP()
        {
            string hostName = Dns.GetHostName();
            string IP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            return IP;
        }

        public void ConsultarHU(string hu)
        {
            try
            {

                if (txtHU.Text == "" || String.IsNullOrEmpty(txtHU.Text) || String.IsNullOrWhiteSpace(txtHU.Text))
                {
                    MessageBox.Show("Ingresa un HU valido");
                }

                Metodos metodo = new Metodos();
                DataTable dtResultado = metodo.GetHU(hu);
                if (dtResultado != null)
                {
                    if (dtResultado.Rows.Count > 0)
                    {
                        //dgvInfo.DataSource = dtResultado;
                        dgvInfo.Rows.Add(dtResultado.Rows[0][0].ToString(), dtResultado.Rows[0][1].ToString(),dtResultado.Rows[0][2].ToString(), dtResultado.Rows[0][3].ToString());
                        txtHU.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El HU no existe, o es incorrecto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void txtHU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsultarHU(txtHU.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblIPaddress.Text = "Server: " + IP();
        }

        private void recargarIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblIPaddress.Text = "Server: " + IP();
        }
    }
}
