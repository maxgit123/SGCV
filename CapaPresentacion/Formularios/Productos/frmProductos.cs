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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        private void frmProductos_Load(object sender, EventArgs e)
        {
            List<CE_Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (CE_Categoria item in listaCategoria)
            {
                cbCategoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.NomCategoria });
                cbCategoria.DisplayMember = "Texto";
                cbCategoria.ValueMember = "Valor";
                cbCategoria.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            { //Se agrega al combobox de busqueda los encabezados visibles en el dgv. 
                if (columna.Visible == true && columna.HeaderText != "")
                {
                    cbBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbBuscar.DisplayMember = "Texto";
            cbBuscar.ValueMember = "Valor";
            cbBuscar.SelectedIndex = 0;

            //Muestra los Productos de la base de datos en el dgv
            List<CE_Producto> listaProducto = new CN_Producto().Listar();

            foreach (CE_Producto item in listaProducto)
            {
                dgvProductos.Rows.Add(new object[] { //Acordate de poner los TODOS los items EN ORDEN
                    item.IdProducto,
                    item.Descripcion,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Stock,
                    item.QuiebreStock,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.NomCategoria,
                    "",""
                });
            }
        }
        private void dgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 8) //Pinta el icono de editar
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.edit16.Width;
                var h = Properties.Resources.edit16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.edit16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 9) //Pinta el icono de eliminar
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
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice >= 0)
            {
                if (dgvProductos.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    //Labels de ayuda para ver el indice del DGV y el ID del Producto.
                    lblIndice.Text = indice.ToString();
                    lblID_Producto.Text = dgvProductos.Rows[indice].Cells["ID_Producto"].Value.ToString();

                    txtDescripcion.Text = dgvProductos.Rows[indice].Cells["Descripcion"].Value.ToString();
                    txtQuiebreStock.Text = dgvProductos.Rows[indice].Cells["QuiebreStock"].Value.ToString();
                    foreach (OpcionCombo oc in cbCategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvProductos.Rows[indice].Cells["ID_Categoria"].Value))
                        {
                            int indice_combo = cbCategoria.Items.IndexOf(oc);
                            cbCategoria.SelectedIndex = indice_combo; //Se selecciona el que encontro.
                            break; //Cuando la relacion sea correcta se corta el foreach.
                        }
                    }
                }
                else if (dgvProductos.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    if (MessageBox.Show("¿Desea eliminar el producto " + dgvProductos.Rows[indice].Cells["Descripcion"].Value.ToString() + "?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;

                        CE_Producto oProducto = new CE_Producto() //Se crea un nueva instancia
                        { //de la que solo se necesita el ID del Producto.
                            IdProducto = int.Parse(dgvProductos.Rows[indice].Cells["ID_Producto"].Value.ToString())
                        };

                        bool respuesta = new CN_Producto().Eliminar(oProducto, out mensaje);

                        if (respuesta) //Si se elimino correctamente (Eliminar retorna respuesta bool):
                            dgvProductos.Rows.RemoveAt(Convert.ToInt32(indice)); //se elimina la fila del DGV.
                        else
                            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (txtQuiebreStock.Text != "")
            {
                CE_Producto oProducto = new CE_Producto() //Se crea un obj de la clase Producto
                { //y se le asignan los valores del formulario.
                    IdProducto = Convert.ToInt32(lblID_Producto.Text),
                    Descripcion = txtDescripcion.Text.Trim(),
                    QuiebreStock = Convert.ToInt32(txtQuiebreStock.Text.Trim()),
                    oCategoria = new CE_Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbCategoria.SelectedItem).Valor) },
                };

                if (oProducto.IdProducto == 0) //Si es un producto nuevo:
                {
                    //Se ejecuta el metodo Crear que retorna el ID de la categoria creada que se genera desde la BD.
                    int idProductoCreado = new CN_Producto().Crear(oProducto, out mensaje);

                    if (idProductoCreado != 0) //Si se agrego correctamente
                    { //Se agregan los datos al DGV.
                        dgvProductos.Rows.Add(new object[] { //Nota: el orden es importante.
                        idProductoCreado,
                        txtDescripcion.Text.Trim(),
                        "0.00", //Precio de compra.
                        "0.00", //Precio de venta.
                        "0", //Stock.
                        txtQuiebreStock.Text.Trim(),
                        ((OpcionCombo)cbCategoria.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cbCategoria.SelectedItem).Texto.ToString(),
                        "","" //Lo dos botones (Editar y Eliminar)
                    });

                        LimpiarForm(); //Limpia los campos del formulario.
                    }
                    else //MessageBox que muestra un error sqlite.
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else //Si su ID no es 0, se ejecuta el metodo Actualizar.
                {
                    bool resultado = new CN_Producto().Actualizar(oProducto, out mensaje);

                    if (resultado) //Si se agrego correctamente, se agregan los datos a la lista.
                    {
                        DataGridViewRow row = dgvProductos.Rows[Convert.ToInt32(lblIndice.Text)];
                        row.Cells["ID_Producto"].Value = lblID_Producto.Text;
                        row.Cells["Descripcion"].Value = txtDescripcion.Text.Trim();
                        row.Cells["QuiebreStock"].Value = txtQuiebreStock.Text.Trim();
                        row.Cells["ID_Categoria"].Value = ((OpcionCombo)cbCategoria.SelectedItem).Valor.ToString();
                        row.Cells["Categoria"].Value = ((OpcionCombo)cbCategoria.SelectedItem).Texto.ToString();

                        LimpiarForm(); //Limpia los campos del formulario.
                    }
                    else //MessageBox que muestra un error sqlite.
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } 
            }
            else
                MessageBox.Show("Ingrese el numero de quiebre de stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
        private void LimpiarForm() //Limpia los textbox y combobox.
        {
            lblIndice.Text = "-1"; //Se setea en -1 xq el indice empieza en 0.
            lblID_Producto.Text = "0"; //Se setea en 0 para que el boton guardar sepa si debe crear o actualizar.
            //Se limpian los campos:
            txtDescripcion.Text = "";
            txtQuiebreStock.Text = "";
            cbCategoria.SelectedIndex = 0;
            //Y se vuelve a dejar seleccionado el primer textbox.
            txtDescripcion.Select();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBuscar.SelectedItem).Valor.ToString();
            if (dgvProductos.Rows.Count > 0) //Si no hay elementos en la tabla no tiene sentido hacer la busqueda.
            {
                foreach (DataGridViewRow row in dgvProductos.Rows) //Recorre cada fila que encuentre en dgvUsuarios.
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
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
