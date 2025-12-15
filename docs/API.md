# API.md

## Referencia de API Pública - SGCV

Este documento describe los métodos públicos y la interfaz de programación de las capas de negocio y datos del proyecto SGCV.

---

## CapaNegocio - Agentes de Negocio

### CN_Usuario

**Namespace:** `CapaNegocio`

#### `public static bool Login(string documento, out string mensaje)`
Autentica un usuario en el sistema.

**Parámetros:**
- `documento` (string): DNI del usuario (8 dígitos)
- `mensaje` (out string): Mensaje de error o éxito

**Retorna:** (bool)
- `true`: Autenticación exitosa
- `false`: Credenciales inválidas

**Excepciones:** Ninguna (utiliza out parameter)

**Ejemplo de uso:**
```csharp
if (CN_Usuario.Login("12345678", out string msg))
{
    // Usuario autenticado
}
else
{
    MessageBox.Show(msg);
}
```

---

#### `public static bool Crear(CE_Usuario oUsuario, out string mensaje)`
Crea un nuevo usuario en el sistema.

**Parámetros:**
- `oUsuario` (CE_Usuario): Objeto con datos del usuario
  - `documento`: DNI (8 dígitos, requerido)
  - `nombre`: Nombre (requerido)
  - `apellido`: Apellido (requerido)
  - `clave`: Contraseña en texto plano (requerido)
  - `idRol`: ID del rol (requerido)
- `mensaje` (out string): Mensaje de validación o error

**Retorna:** (bool)
- `true`: Usuario creado exitosamente
- `false`: Error en validación o creación

**Validaciones:**
- Documento debe ser 8 dígitos numéricos
- Documento debe ser único
- Nombre y apellido no vacíos
- Clave no vacía

**Ejemplo de uso:**
```csharp
CE_Usuario usuario = new CE_Usuario
{
    documento = "12345678",
    nombre = "Juan",
    apellido = "Pérez",
    clave = "miClave123",
    idRol = 2
};

if (CN_Usuario.Crear(usuario, out string msg))
{
    MessageBox.Show("Usuario creado");
}
else
{
    MessageBox.Show(msg);
}
```

---

#### `public static bool Actualizar(CE_Usuario oUsuario, out string mensaje)`
Actualiza datos de un usuario existente.

**Parámetros:**
- `oUsuario` (CE_Usuario): Objeto con datos actualizados
  - `idUsuario`: ID requerido
  - `nombre`, `apellido`, `idRol`, `estado`: Campos a actualizar
- `mensaje` (out string): Mensaje de resultado

**Retorna:** (bool) Éxito o error de actualización

---

#### `public static CE_Usuario ObtenerUsuario(int idUsuario)`
Obtiene los datos de un usuario por su ID.

**Parámetros:**
- `idUsuario` (int): ID del usuario

**Retorna:** (CE_Usuario) Objeto con datos del usuario o null

---

#### `public static DataTable Listar(out string mensaje)`
Obtiene lista de todos los usuarios.

**Parámetros:**
- `mensaje` (out string): Mensaje de resultado

**Retorna:** (DataTable) Tabla con columnas:
- `idUsuario`, `documento`, `nombre`, `apellido`, `idRol`, `estado`

---

#### `public static bool Eliminar(int idUsuario, out string mensaje)`
Elimina un usuario del sistema.

**Parámetros:**
- `idUsuario` (int): ID del usuario a eliminar
- `mensaje` (out string): Mensaje de resultado

**Retorna:** (bool) Éxito o error

---

#### `public static bool CambiarClave(int idUsuario, string claveActual, string claveNueva, out string mensaje)`
Cambia la contraseña de un usuario.

**Parámetros:**
- `idUsuario` (int): ID del usuario
- `claveActual` (string): Contraseña actual en texto plano
- `claveNueva` (string): Nueva contraseña
- `mensaje` (out string): Mensaje de validación

**Retorna:** (bool) Éxito o error

---

### CN_Producto

**Namespace:** `CapaNegocio`

#### `public static bool Crear(CE_Producto oProducto, out string mensaje)`
Crea un nuevo producto.

**Parámetros:**
- `oProducto` (CE_Producto): Objeto con datos del producto
  - `codigo`: Código único del producto (requerido)
  - `descripcion`: Descripción (requerido)
  - `precio`: Precio de venta decimal (requerido)
  - `idCategoria`: ID de categoría (requerido)
- `mensaje` (out string): Mensaje de validación

**Retorna:** (bool)

**Validaciones:**
- Código único
- Descripción no vacía
- Precio >= 0
- Categoría válida

---

#### `public static bool Actualizar(CE_Producto oProducto, out string mensaje)`
Actualiza un producto existente.

**Parámetros:**
- `oProducto` (CE_Producto): Objeto con datos actualizados (requiere `idProducto`)
- `mensaje` (out string): Mensaje de resultado

**Retorna:** (bool)

---

#### `public static DataTable Listar(out string mensaje)`
Obtiene lista de productos.

**Parámetros:**
- `mensaje` (out string): Mensaje de resultado

**Retorna:** (DataTable) Con columnas:
- `idProducto`, `codigo`, `descripcion`, `precio`, `stock`, `categoria`, `estado`

---

#### `public static CE_Producto ObtenerPorCodigo(string codigo)`
Obtiene un producto por su código.

**Parámetros:**
- `codigo` (string): Código del producto

**Retorna:** (CE_Producto) Objeto con datos o null

---

#### `public static bool Eliminar(int idProducto, out string mensaje)`
Elimina un producto.

**Parámetros:**
- `idProducto` (int): ID del producto
- `mensaje` (out string): Mensaje de resultado

**Retorna:** (bool)

---

### CN_Compra

**Namespace:** `CapaNegocio`

#### `public static bool Crear(CE_Compra oCompra, DataTable compraDetalle, out string mensaje)`
Crea una nueva compra con sus detalles.

**Parámetros:**
- `oCompra` (CE_Compra): Datos de la compra
  - `idProveedor`: ID del proveedor (requerido)
  - `fechaPedido`: Fecha de pedido (requerido)
  - `fechaEntrega`: Fecha de entrega (requerido)
  - `total`: Total de la compra
- `compraDetalle` (DataTable): Tabla con detalles
  - Columnas: `idProducto`, `cantidad`, `precioUnitario`, `subtotal`
- `mensaje` (out string): Mensaje de validación

**Retorna:** (bool)

**Validaciones:**
- Proveedor válido
- Fechas correctas (entrega >= pedido)
- Al menos un detalle
- Cantidades > 0

**Acciones secundarias:**
- Actualiza stock de productos
- Genera número de compra secuencial
- Registra usuario que crea

**Ejemplo de uso:**
```csharp
DataTable detalles = new DataTable();
detalles.Columns.Add("idProducto", typeof(int));
detalles.Columns.Add("cantidad", typeof(int));
detalles.Columns.Add("precioUnitario", typeof(decimal));
detalles.Columns.Add("subtotal", typeof(decimal));

DataRow fila = detalles.NewRow();
fila["idProducto"] = 1;
fila["cantidad"] = 5;
fila["precioUnitario"] = 100;
fila["subtotal"] = 500;
detalles.Rows.Add(fila);

CE_Compra compra = new CE_Compra
{
    idProveedor = 1,
    fechaPedido = DateTime.Now.Date,
    fechaEntrega = DateTime.Now.AddDays(7).Date,
    total = 500
};

if (CN_Compra.Crear(compra, detalles, out string msg))
{
    MessageBox.Show("Compra registrada");
}
```

---

#### `public static DataTable Listar(out string mensaje)`
Obtiene lista de compras.

**Retorna:** (DataTable) Con columnas:
- `idCompra`, `numero`, `proveedor`, `fechaPedido`, `fechaEntrega`, `total`

---

#### `public static CE_Compra ObtenerCompra(int idCompra)`
Obtiene una compra con sus detalles.

**Retorna:** (CE_Compra) Con detalles en propiedad `detalles`

---

### CN_Venta

**Namespace:** `CapaNegocio`

#### `public static bool Crear(CE_Venta oVenta, DataTable ventaDetalle, out string mensaje)`
Crea una nueva venta.

**Parámetros:**
- `oVenta` (CE_Venta): Datos de la venta
  - `idCliente`: ID del cliente o null (opcional)
  - `tipoFactura`: 'A', 'B', 'C' (requerido)
  - `subtotal`, `total`, `montoPago`, `vuelto`: Montos (requerido)
- `ventaDetalle` (DataTable): Detalles de la venta
- `mensaje` (out string): Mensaje de validación

**Retorna:** (bool)

**Validaciones:**
- Tipo de factura válido
- montoPago >= total
- Al menos un detalle
- Cantidades disponibles en stock

**Acciones secundarias:**
- Decrementa stock de productos
- Genera número de venta secuencial
- Calcula vuelto automáticamente

---

#### `public static DataTable Listar(out string mensaje)`
Obtiene lista de ventas.

**Retorna:** (DataTable) Con columnas:
- `idVenta`, `numero`, `cliente`, `fecha`, `tipoFactura`, `total`

---

#### `public static CE_Venta ObtenerVenta(int idVenta)`
Obtiene una venta con sus detalles.

**Retorna:** (CE_Venta) Con detalles completos

---

### CN_Cliente

**Namespace:** `CapaNegocio`

#### `public static bool Crear(CE_Cliente oCliente, out string mensaje)`
Crea un nuevo cliente.

**Parámetros:**
- `oCliente` (CE_Cliente): Datos del cliente
  - `documento`: DNI (8 dígitos, requerido)
  - `nombre`, `apellido`: Requeridos
  - `idResponsableIVA`: Condición ante IVA

**Retorna:** (bool)

**Validaciones:**
- Documento 8 dígitos
- Documento único
- Nombre y apellido no vacíos

---

#### `public static DataTable Listar(out string mensaje)`
Obtiene lista de clientes.

**Retorna:** (DataTable)

---

#### `public static CE_Cliente ObtenerPorDocumento(string documento)`
Obtiene cliente por DNI.

**Retorna:** (CE_Cliente) o null

---

### CN_Proveedor

**Namespace:** `CapaNegocio`

#### `public static bool Crear(CE_Proveedor oProveedor, out string mensaje)`
Crea un nuevo proveedor.

**Parámetros:**
- `oProveedor` (CE_Proveedor): Datos del proveedor
  - `razonSocial`: Razón social (requerido)

**Retorna:** (bool)

---

#### `public static DataTable Listar(out string mensaje)`
Obtiene lista de proveedores.

**Retorna:** (DataTable)

---

### CN_Comercio

**Namespace:** `CapaNegocio`

#### `public static CE_Comercio Leer()`
Obtiene datos del comercio.

**Retorna:** (CE_Comercio) Objeto con datos

```csharp
CE_Comercio comercio = CN_Comercio.Leer();
MessageBox.Show(comercio.razonSocial);
```

---

#### `public static bool Actualizar(CE_Comercio oComercio, out string mensaje)`
Actualiza datos del comercio.

**Parámetros:**
- `oComercio` (CE_Comercio): Datos a actualizar

**Retorna:** (bool)

---

## CapaDatos - Data Access Objects

### CD_Usuario

**Namespace:** `CapaDatos`

#### `public static CE_Usuario Login(string documento, string claveHasheada)`
Busca usuario por documento y valida clave.

**Retorna:** (CE_Usuario) Usuario encontrado o null

---

### CD_Producto

**Namespace:** `CapaDatos`

#### `public static DataTable Listar()`
Obtiene todos los productos.

**Retorna:** (DataTable)

---

#### `public static bool CrearProducto(CE_Producto oProducto, out string mensaje)`
Crea producto en BD.

**Retorna:** (bool)

---

### CD_Compra

**Namespace:** `CapaDatos`

#### `public static bool Crear(CE_Compra oCompra, DataTable detalles, out string mensaje)`
Crea compra en BD mediante stored procedure.

**Retorna:** (bool)

---

### CD_Venta

**Namespace:** `CapaDatos`

#### `public static bool Crear(CE_Venta oVenta, DataTable detalles, out string mensaje)`
Crea venta en BD mediante stored procedure.

**Retorna:** (bool)

---

## Utilidades

### Hash.cs

**Namespace:** `CapaNegocio.Utilidades`

#### `public static string Generar(string claveTextoPlano)`
Genera hash seguro de contraseña con PBKDF2.

**Parámetros:**
- `claveTextoPlano` (string): Contraseña en texto plano

**Retorna:** (string) Hash hasheado con salt

**Ejemplo:**
```csharp
string claveHasheada = Hash.Generar("miClave123");
// Almacenar claveHasheada en BD
```

---

#### `public static bool Verificar(string claveHasheada, string claveTextoPlano)`
Verifica si una contraseña coincide con su hash.

**Parámetros:**
- `claveHasheada` (string): Hash almacenado en BD
- `claveTextoPlano` (string): Contraseña a verificar

**Retorna:** (bool) true si coinciden

**Ejemplo:**
```csharp
if (Hash.Verificar(usuarioBD.clave, inputUsuario))
{
    // Contraseña correcta
}
```

---

### UtilidadesForm.cs

**Namespace:** `CapaPresentacion.Utilidades`

#### `public static void LimpiarControles(Control contenedor)`
Limpia todos los TextBox y ComboBox dentro de un contenedor.

---

#### `public static void HabilitarPanel(Panel pnl, bool habilitar)`
Habilita o deshabilita todos los controles de un panel.

---

### UtilidadesDGV.cs

**Namespace:** `CapaPresentacion.Utilidades`

#### `public static void ConfigurarDGV(DataGridView dgv)`
Configura estilos básicos de un DataGridView.

---

#### `public static void FiltrarDGV(DataGridView dgv, string columna, string texto)`
Filtra filas de un DataGridView por columna y texto.

---

### UtilidadesTextBox.cs

**Namespace:** `CapaPresentacion.Utilidades`

#### `public static bool EsSoloNumeros(string texto)`
Valida si una cadena contiene solo números.

---

#### `public static bool EsDocumentoValido(string documento)`
Valida que sea documento de 8 dígitos.

---

#### `public static bool EsCorreoValido(string correo)`
Valida formato de correo electrónico.

---

## Entidades (CapaEntidad)

### CE_Usuario
```csharp
public class CE_Usuario
{
    public int idUsuario { get; set; }
    public string documento { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string clave { get; set; }
    public int idRol { get; set; }
    public bool estado { get; set; }
}
```

---

### CE_Producto
```csharp
public class CE_Producto
{
    public int idProducto { get; set; }
    public string codigo { get; set; }
    public string descripcion { get; set; }
    public decimal precio { get; set; }
    public decimal precioCompra { get; set; }
    public int stock { get; set; }
    public int idCategoria { get; set; }
    public bool estado { get; set; }
}
```

---

### CE_Compra
```csharp
public class CE_Compra
{
    public int idCompra { get; set; }
    public int numero { get; set; }
    public int idProveedor { get; set; }
    public DateTime fechaPedido { get; set; }
    public DateTime fechaEntrega { get; set; }
    public decimal total { get; set; }
    public int idUsuario { get; set; }
}
```

---

### CE_Venta
```csharp
public class CE_Venta
{
    public int idVenta { get; set; }
    public int numero { get; set; }
    public int? idCliente { get; set; }
    public DateTime fechaVenta { get; set; }
    public char tipoFactura { get; set; }
    public decimal subtotal { get; set; }
    public decimal iva { get; set; }
    public decimal total { get; set; }
    public decimal montoPago { get; set; }
    public decimal vuelto { get; set; }
}
```

---

**Última actualización:** Diciembre 2024
**Versión de API:** 1.0
