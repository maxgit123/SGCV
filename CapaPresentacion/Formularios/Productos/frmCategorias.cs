using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//Lo que agregue:
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Productos
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }
        private void frmCategorias_Load(object sender, EventArgs e)
        {
            List<CE_AlicuotaIVA> listaAlicuotaIVA = new CN_AlicuotaIVA().Listar();

            foreach (CE_AlicuotaIVA item in listaAlicuotaIVA)
            {
                cbAlicuotaIVA.Items.Add(new OpcionCombo() { Valor = item.IdAlicuotaIVA, Texto = Convert.ToString(item.PorcentajeIVA) });
                cbAlicuotaIVA.DisplayMember = "Texto";
                cbAlicuotaIVA.ValueMember = "Valor";
                cbAlicuotaIVA.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn columna in dgvCategorias.Columns)
            { //Se agrega al combobox de busqueda los encabezados visibles en el dgv. 
                if (columna.Visible == true && columna.HeaderText != "")
                {
                    cbBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbBuscar.DisplayMember = "Texto";
            cbBuscar.ValueMember = "Valor";
            cbBuscar.SelectedIndex = 0;

            //Muestra los Categorias de la base de datos en el dgv
            List<CE_Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (CE_Categoria item in listaCategoria)
            {
                dgvCategorias.Rows.Add(new object[] { //Acordate de poner los TODOS los items EN ORDEN
                    item.IdCategoria,
                    item.NomCategoria,
                    item.oAlicuotaIVA.IdAlicuotaIVA,
                    item.oAlicuotaIVA.PorcentajeIVA,
                    "","" //Boton editar y eliminar.
                });
            }
        }
        private void dgvCategorias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 4) //Pinta el icono de editar
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.edit16.Width;
                var h = Properties.Resources.edit16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.edit16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 5) //Pinta el icono de eliminar
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete16.Width;
                var h = Properties.Resources.delete16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice >= 0)
            {
                if (dgvCategorias.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    //Labels de ayuda para ver el indice del DGV y el ID del Categoria.
                    lblIndice.Text = indice.ToString();
                    lblID_Categoria.Text = dgvCategorias.Rows[indice].Cells["ID_Categoria"].Value.ToString();

                    txtNomCategoria.Text = dgvCategorias.Rows[indice].Cells["NomCategoria"].Value.ToString();
                    foreach (OpcionCombo oc in cbAlicuotaIVA.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvCategorias.Rows[indice].Cells["ID_AlicuotaIVA"].Value))
                        {
                            int indice_combo = cbAlicuotaIVA.Items.IndexOf(oc);
                            cbAlicuotaIVA.SelectedIndex = indice_combo; //Se selecciona el que encontro.
                            break; //Cuando la relacion sea correcta se corta el foreach.
                        }
                    }
                }
                else if (dgvCategorias.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    if (MessageBox.Show("¿Desea eliminar la categoría " + dgvCategorias.Rows[indice].Cells["NomCategoria"].Value.ToString() + "?", "Eliminar Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;

                        CE_Categoria oCategoria = new CE_Categoria() //Se crea un nueva instancia
                        { //de la que solo se necesita el ID de la Categoria.
                            IdCategoria = int.Parse(dgvCategorias.Rows[indice].Cells["ID_Categoria"].Value.ToString())
                        };

                        bool respuesta = new CN_Categoria().Eliminar(oCategoria, out mensaje);

                        if (respuesta) //Si se elimino correctamente (Eliminar retorna respuesta bool):
                            dgvCategorias.Rows.RemoveAt(Convert.ToInt32(indice)); //se elimina la fila del DGV.
                        else
                            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Categoria oCategoria = new CE_Categoria() //Se crea un obj de la clase Categoria
            { //y se le asignan los valores del formulario.
                IdCategoria = Convert.ToInt32(lblID_Categoria.Text),
                NomCategoria = txtNomCategoria.Text.Trim(),
                oAlicuotaIVA = new CE_AlicuotaIVA() { IdAlicuotaIVA = Convert.ToInt32(((OpcionCombo)cbAlicuotaIVA.SelectedItem).Valor) },
            };

            if (oCategoria.IdCategoria == 0) //Si es una categoria nueva:
            {
                //Se ejecuta el metodo Crear que retorna el ID de la categoria creada que se genera desde la BD.
                int idCategoriaCreada = new CN_Categoria().Crear(oCategoria, out mensaje);

                if (idCategoriaCreada != 0) //Si se agrego correctamente
                { //Se agregan los datos al DGV.
                    dgvCategorias.Rows.Add(new object[] { //Nota: el orden es importante.
                        idCategoriaCreada,
                        txtNomCategoria.Text.Trim(),
                        ((OpcionCombo)cbAlicuotaIVA.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cbAlicuotaIVA.SelectedItem).Texto.ToString() + " %",
                        "","" //Lo dos botones (Editar y Eliminar)
                    });

                    LimpiarForm(); //Limpia los campos del formulario.
                }
                else //MessageBox que muestra un error sqlite.
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //Si su ID no es 0, se ejecuta el metodo Actualizar.
            {
                bool resultado = new CN_Categoria().Actualizar(oCategoria, out mensaje);

                if (resultado) //Si se agrego correctamente, se agregan los datos a la lista.
                {
                    DataGridViewRow row = dgvCategorias.Rows[Convert.ToInt32(lblIndice.Text)];
                    row.Cells["ID_Categoria"].Value = lblID_Categoria.Text;
                    row.Cells["NomCategoria"].Value = txtNomCategoria.Text.Trim();
                    row.Cells["ID_AlicuotaIVA"].Value = ((OpcionCombo)cbAlicuotaIVA.SelectedItem).Valor.ToString();
                    row.Cells["PorcentajeIVA"].Value = ((OpcionCombo)cbAlicuotaIVA.SelectedItem).Texto.ToString();

                    LimpiarForm(); //Limpia los campos del formulario.
                }
                else //MessageBox que muestra un error sqlite.
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
        private void LimpiarForm() //Limpia los textbox y combobox.
        {
            lblIndice.Text = "-1"; //Se setea en -1 xq el indice empieza en 0.
            lblID_Categoria.Text = "0"; //Se setea en 0 para que el boton guardar sepa si debe crear o actualizar.
            //Se limpian los campos:
            txtNomCategoria.Text = "";
            cbAlicuotaIVA.SelectedIndex = 0;
            //Y se vuelve a dejar seleccionado el primer textbox.
            txtNomCategoria.Select();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBuscar.SelectedItem).Valor.ToString();
            if (dgvCategorias.Rows.Count > 0) //Si no hay elementos en la tabla no tiene sentido hacer la busqueda.
            {
                foreach (DataGridViewRow row in dgvCategorias.Rows) //Recorre cada fila que encuentre en dgvUsuarios.
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        //Se hace el filtro por la columnaFiltro si contiene lo que se encuentra en txtBuscar.
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }
        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        { //Limpia el textbox de busqueda y se elimina el filtro.
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgvCategorias.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
