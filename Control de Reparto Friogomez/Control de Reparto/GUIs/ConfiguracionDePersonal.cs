using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_de_Reparto.Modelos;
using Control_de_Reparto.DAL;

namespace Control_de_Reparto.GUIs
{
    public partial class ConfiguracionDePersonal : Form
    {
        public ConfiguracionDePersonal()
        {
            InitializeComponent();
        }

        private void ConfiguracionDePersonal_Load(object sender, EventArgs e)
        {
            LlenarComboTipos();
        }

        private void LlenarComboTipos()
        {
            cbTipos.Items.Add(new Tipos('N', "-----------"));
            cbTipos.Items.Add(new Tipos('R', "Responsable"));
            cbTipos.Items.Add(new Tipos('C', "Chofer"));

            cbTipos.DisplayMember = "Nombre";
            cbTipos.ValueMember = "Id";
            cbTipos.SelectedIndex = 0;
        }

        private void validarBotones()
        {
            List<Personal> lstPersonal = (List<Personal>)gridPersonal.DataSource;
            if (lstPersonal == null)
            {
                btnAgregar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                if (lstPersonal.Count == 0)
                {
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
            }
        }

        private void ConfiguracionDePersonal_Shown(object sender, EventArgs e)
        {
            LlenarGrid();
            validarBotones();
        }

        private void LlenarGrid()
        {
            SqliteDAL sqlite = new SqliteDAL("ControlDeCobranza.db3");
            gridPersonal.DataSource = sqlite.ObtenerPersonal();
            gvPersonal.BestFitColumns();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txbNombre.Text.Trim().Length > 3)
            {
                try
                {
                    AgregarPersona();
                    LlenarGrid();
                    validarBotones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El nombre es demasiado corto...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AgregarPersona()
        {
            SqliteDAL sqlite = new SqliteDAL("ControlDeCobranza.db3");
            string Nombre = txbNombre.Text;
            char Tipo = ((Tipos)cbTipos.SelectedItem).Id;
            if (Tipo != 'N')
            {
                sqlite.AgregarPersona(Nombre, Tipo);
            }
            else
            {
                MessageBox.Show("Seleccione un tipo valido...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
        private void Modificar()
        {
            try
            {
                int[] iFilaSeleccionada = gvPersonal.GetSelectedRows();
                Personal persona = (Personal)gvPersonal.GetRow(iFilaSeleccionada[0]);

                StringBuilder Mensaje = new StringBuilder();
                Mensaje.AppendLine(string.Format("Desea Modificar al empleado <<{0}>> con los siguientes datos:", persona.Nombre));
                Mensaje.AppendLine("Nombre: " + txbNombre.Text);
                Mensaje.AppendLine("Tipo: " + ((Tipos)cbTipos.SelectedItem).Nombre);
                DialogResult dr = MessageBox.Show(Mensaje.ToString(), "Modificar", 
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    string sTipo = ((Tipos)cbTipos.SelectedItem).Id.ToString();
                    if (sTipo != "N")
                    {

                        SqliteDAL sqlite = new SqliteDAL("ControlDeCobranza.db3");
                        Personal personaModificada = new Personal();
                        personaModificada.ID_Personal = persona.ID_Personal;
                        personaModificada.Nombre = txbNombre.Text;
                        personaModificada.Tipo = ((Tipos)cbTipos.SelectedItem).Id.ToString();
                        sqlite.ModificarPersonal(personaModificada);

                        MessageBox.Show("¡¡¡Modificación exitosa!!!");
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un tipo valido...", "Error", 
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void Eliminar()
        {
            try
            {
                int[] iFilaSeleccionada = gvPersonal.GetSelectedRows();
                Personal persona = (Personal)gvPersonal.GetRow(iFilaSeleccionada[0]);

                StringBuilder Mensaje = new StringBuilder();
                Mensaje.AppendLine(string.Format("¿Desea Eliminar al empleado <<{0}>>?", persona.Nombre));
                DialogResult dr = MessageBox.Show(Mensaje.ToString(), "Eliminar",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    SqliteDAL sqlite = new SqliteDAL("ControlDeCobranza.db3");
                    sqlite.EliminarPersonal(persona);

                    MessageBox.Show("¡¡¡Empleado eliminado exitosamente!!!");
                    LlenarGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvPersonal_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            
        }

        private void gvPersonal_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Personal personaSeleccionada = (Personal)gvPersonal.GetRow(gvPersonal.GetSelectedRows()[0]);
            txbId.Text = personaSeleccionada.ID_Personal.ToString();
            txbNombre.Text = personaSeleccionada.Nombre;
            cbTipos.SelectedValue = personaSeleccionada.Tipo;
        }
    }
}
