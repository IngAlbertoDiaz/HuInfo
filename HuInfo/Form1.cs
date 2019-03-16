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
                Metodos metodo = new Metodos();

                if (txtHU.Text == "" || String.IsNullOrEmpty(txtHU.Text) || String.IsNullOrWhiteSpace(txtHU.Text))
                {
                    MessageBox.Show("Ingresa un HU valido");
                }
                
                if (rbCMES.Checked == true)
                {
                    DataTable dtResultado = metodo.CmesHU(hu);
                    if (dtResultado != null)
                    {
                        if (dtResultado.Rows.Count > 0)
                        {
                            //dgvInfo.DataSource = dtResultado;
                            dgvInfo.Rows.Add(dtResultado.Rows[0][0].ToString(), dtResultado.Rows[0][1].ToString(), dtResultado.Rows[0][2].ToString(), dtResultado.Rows[0][3].ToString());
                            txtHU.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("El HU no se encuentra en CMES, o es incorrecto.");
                        }
                    }
                }
                if (rbINFOR.Checked == true)
                {
                    string company = "";
                    if (rbDurango.Checked == true)
                    {
                        company = "630";
                    }
                    if (rbLeon.Checked == true)
                    {
                        company = "640";
                    }
                    DataTable dtResultado = metodo.InforHU(hu, company);
                    if (dtResultado != null)
                    {
                        if (dtResultado.Rows.Count > 0)
                        {
                            //dgvInfo.DataSource = dtResultado;
                            dgvInfo.Rows.Add(dtResultado.Rows[0][0].ToString(), dtResultado.Rows[0][1].ToString(), dtResultado.Rows[0][2].ToString(), dtResultado.Rows[0][3].ToString());
                            txtHU.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("El HU no se encuentra en InforLN, o es incorrecto.");
                        }
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
                txtHU.Focus();
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

        private void rbINFOR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbINFOR.Checked == true)
            {
                groupBox1.Enabled = true;
                txtHU.Focus();
            }
            if (rbINFOR.Checked == false)
            {
                groupBox1.Enabled = false;
                txtHU.Focus();
            }
        }
    }
}
