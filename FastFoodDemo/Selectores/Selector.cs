using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using RecursoHumano.Models;

namespace FastFoodDemo
{
    public partial class Selector : MetroFramework.Forms.MetroForm
    {
        private FirstCustomControl frm1;
        List<Empleado> empleados = new List<Empleado>();//Dapper
        public Selector(FirstCustomControl frst)
        {
            InitializeComponent();
            frm1 = frst;
        }

        private void Selector_Load(object sender, EventArgs e)
        {
            

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Conexion.CnnVal()))
            {
                empleados = connection.Query<Empleado>("SELECT * FROM [Empleado] where TipoEmpleado = 1 order by Nombre").ToList<Empleado>();
                var x = empleados
                    .Select(y => Tuple.Create(y.Nombre))
                    .ToList();
                gridSel.DataSource = x;
            }

            DataGridViewColumn column = gridSel.Columns[0];
            column.Width = 175;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(gridSel.CurrentRow.Cells[0].Value.ToString());
            
            frm1.docCmb.Text = gridSel.CurrentRow.Cells[0].Value.ToString();

            this.Close();
        }
    }
}
