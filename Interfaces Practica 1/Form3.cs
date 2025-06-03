using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_Practica_1
{
    public partial class Form3 : Form
    {
        private readonly RepositorioProyectos repo;
        private readonly bool esEdicion;

        public Form3(RepositorioProyectos repositorio, Proyecto proyectoExistente = null)
        {
            InitializeComponent();
            repo = repositorio;

            if (proyectoExistente != null)
            {
                txtNombre.Text = proyectoExistente.Nombre;
                dtpFechaFin.Value = proyectoExistente.FechaFin;
                txtNombre.Enabled = false; // No se modifica el nombre
                esEdicion = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            DateTime fechaFin = dtpFechaFin.Value;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese un nombre de proyecto válido.");
                return;
            }
            else
            {
                var nuevo = new Proyecto { Nombre = nombre, FechaFin = fechaFin };
                string mensaje = repo.Agregar(nuevo);
                MessageBox.Show(mensaje);
                if (mensaje.Contains("correctamente"))
                    this.DialogResult = DialogResult.OK;
            }

            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            DateTime fechaFin = dtpFechaFin.Value;

            var proyecto = repo.Listar().FirstOrDefault(p => p.Nombre == nombre);
            if (proyecto != null)
            {
                proyecto.FechaFin = fechaFin;
                MessageBox.Show("Proyecto modificado.");
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
