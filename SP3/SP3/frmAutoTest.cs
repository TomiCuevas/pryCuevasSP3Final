using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP3
{
    public partial class frmAutoTest : Form
    {
        public struct TURNO
        {
            public int NumeroTurno;
            public string Dominio;
            public int AnioFabricacion;
            public string Titular;
        };
        const int MAX = 50;
        public TURNO[] turnos;
        public int Cantidad = 0;


        public frmAutoTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            turnos = new TURNO[MAX];
            Cantidad = 0;
            LimpiarInterfaz();
        }
        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar) == true) 
            {
                e.KeyChar = Char.ToUpper(e.KeyChar); 
            }
            if (Char.IsLetterOrDigit(e.KeyChar) == false && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }


        private void txtNroTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == true)
            {
                int nro = int.Parse(txtNroTurno.Text);
                turnos[Cantidad].NumeroTurno = nro;
                turnos[Cantidad].Dominio = txtDominio.Text;
                turnos[Cantidad].AnioFabricacion =
                int.Parse(numAnioFabricacion.Value.ToString());
                turnos[Cantidad].Titular = txtTitular.Text;
                Cantidad++;
                LimpiarInterfaz();
            }
        }

       
        private bool ValidarDatos()
        {
            bool resultado = false; 

            if (Cantidad < MAX)
            {
                if (txtNroTurno.Text != "" && txtDominio.Text.Length >= 6 && txtTitular.Text.Length >= 2) 
                {
                    int nro = int.Parse(txtNroTurno.Text); 
                    if (BuscarTurno(nro) == false) 
                    {
                        resultado = true;
                    }
                    else
                    {
                        MessageBox.Show("El número de turno ya está registrado", "ERROR",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar los datos faltantes", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay espacio disponible para registrar más turnos", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }
        private bool BuscarTurno(int nro)
        {
            int i = 0;
            bool resultado = false;
            for (i = 0; i < Cantidad; i++)
            {
                if (nro == turnos[i].NumeroTurno)
                {
                    resultado = true;
                    break; 
                }
            }
            return resultado;
        }

        private void LimpiarInterfaz()
        {
            txtNroTurno.Text = "";
            txtDominio.Text = "";
            txtTitular.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            txtCantidadTurnos.Text = Cantidad.ToString();

            int menor = int.Parse(numAnioFabricacion.Maximum.ToString()); 
            int i = 0;
            for (i = 0; i < Cantidad; i++) 
            {
                if (turnos[i].AnioFabricacion < menor)
                {
                    menor = turnos[i].AnioFabricacion;
                }
            }

            txtAnioMasAntiguo.Text = menor.ToString();
            int contador = 0;

            for (i = 0; i < Cantidad; i++)
            {
                if (turnos[i].Dominio.Length == 6) 
                {
                    contador++;
                }
            }
            txtDominio6Caracteres.Text = contador.ToString();
        }

        private void txtNroTurno_TextChanged(object sender, EventArgs e)
        {
            if (txtNroTurno.Text == "")
            {
                txtDominio.Enabled = false;
            }
            else
            {
              txtDominio.Enabled = true;
            }
        }

        private void txtDominio_TextChanged(object sender, EventArgs e)
        {
            if (txtDominio.Text == "")
            {
                numAnioFabricacion.Enabled = false;
                txtTitular.Enabled = false;

            }
            else
            {
                numAnioFabricacion.Enabled = true;
                txtTitular.Enabled = true;
            }
        }

        private void txtTitular_TextChanged(object sender, EventArgs e)
        {
            if (txtTitular.Text == "")
            {
                btnRegistrar.Enabled = false;
            }
            else
            {
                btnRegistrar.Enabled = true;
            }
        }
    }
}

