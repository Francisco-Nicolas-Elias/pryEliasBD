using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace pryEliasBD
{
    public partial class frmMain : Form
    {
        //declaro objeto conexionBD de la clase OleDBConecction
        OleDbConnection conexionBD;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //https://www.connectionstrings.com/ aca se explica como conectar a una base de datos
            // https://www.connectionstrings.com/access-2010/ para acces 2010
            //Va a ser una ruta fija la de esta base de datos "E:\Escritorio\pryEliasBD\Base de datos"
            conexionBD = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Escritorio\\pryEliasBD\\Base de datos\\EL_CLUB.accdb");
            conexionBD.Open();
            lblResultado.Text = "Conectado a la base";
            lblResultado.BackColor = Color.Green;
        }
    }
}
