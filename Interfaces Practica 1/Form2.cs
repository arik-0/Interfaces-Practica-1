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
    public partial class Form2 : Form
    {
        public Form2(Usuario usuario)
        {
            InitializeComponent();
        }

        private TextBox textBox1;
        private Button modificarbtn;
        private Button eliminarbtn;
        private Button agregarbtn;
        private Button button1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button3;
        private Button btnBorrar;
        private DataGridView dataGridView2;
        public Form2()
        {
            InitializeComponent();
            InicializarDatos();
            CargarProyectos();
        }
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnBorrar = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            ((ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(309, 301);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(17, -4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 413);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(213, 362);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(294, 355);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Refrescar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(19, 362);
            button2.Name = "button2";
            button2.Size = new Size(173, 23);
            button2.TabIndex = 1;
            button2.Text = "Agregar Modificar proyecto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(465, 18);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(309, 301);
            dataGridView2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(432, -4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(382, 413);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // Form2
            // 
            ClientSize = new Size(826, 421);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form2";
            Load += Form2_Load;
            ((ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarProyectos();
        }


        private IRepositorios<Proyecto> repoProyectos = new RepositorioProyectos();



        private void InicializarDatos()
        {


            /* var tarea1 = new Tarea
             {
                 Descripcion = "Diseñar base de datos",
                 Estado = Estado.Iniciado,
                 Prioridad = Prioridad.Alta
             };

             var tarea2 = new Tarea
             {
                 Descripcion = "Diseñar interfaz de usuario",
                 Estado = Estado.Iniciado,
                 Prioridad = Prioridad.Media
             };

             proyecto.AgregarTarea(tarea1);
             proyecto.AgregarTarea(tarea2);*/

            //repoProyectos.Agregar(proyecto);
        }


        private bool actualizando = false;

        private void CargarProyectos()
        {
            actualizando = true;

            // Crear una lista segura y totalmente desconectada de referencias internas
            var proyectosParaMostrar = repoProyectos.Listar()
                .Select(p => new ProyectoViewModel
                {
                    Nombre = p.Nombre,
                    FechaInicio = p.FechaInicio.ToShortDateString(),
                    FechaFin = p.FechaFin.ToShortDateString()
                }).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = proyectosParaMostrar;

            actualizando = false;
        }



        /* private void CargarTareas(string nombreProyecto)
         {
             var proyecto = repoProyectos.Listar().FirstOrDefault(p => p.Nombre == nombreProyecto);
             if (proyecto != null)
             {
                 dataGridView2.DataSource = null;
                 dataGridView2.DataSource = proyecto.ListaTareas
                     .Select(t => new
                     {
                         t.Descripcion,
                         Estado = t.Estado.ToString(),
                         Prioridad = t.Prioridad.ToString()
                     }).ToList();
             }
         }*/

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(repoProyectos);
            f3.ShowDialog();
            CargarProyectos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarProyectos();
        }
        /* private void dataGridView1_SelectionChanged(object sender, EventArgs e)
{
    if (actualizando) return;

    if (dataGridView1.SelectedRows.Count > 0)
    {
        string nombreProyecto = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        CargarTareas(nombreProyecto);
    }
}*/
        public class ProyectoViewModel
        {
            public string Nombre { get; set; }
            public string FechaInicio { get; set; }
            public string FechaFin { get; set; }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el nombre del proyecto desde la fila seleccionada
                string nombreProyecto = dataGridView1.SelectedRows[0].Cells["Nombre"].Value?.ToString();

                if (!string.IsNullOrEmpty(nombreProyecto))
                {
                    // Buscar el proyecto en la lista
                    Proyecto proyectoAEliminar = repoProyectos.Listar().FirstOrDefault(p => p.Nombre == nombreProyecto);

                    if (proyectoAEliminar != null)
                    {
                        var confirmar = MessageBox.Show(
                            $"¿Seguro que quieres eliminar el proyecto \"{proyectoAEliminar.Nombre}\"?",
                            "Confirmar eliminación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (confirmar == DialogResult.Yes)
                        {
                            // Eliminar de la lista
                            repoProyectos.Eliminar(proyectoAEliminar);

                            // Refrescar el DataGridView
                            CargarProyectos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el proyecto en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
