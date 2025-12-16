# AGENTS.md

## Overview
Este documento describe los agentes y componentes de lógica de negocio del sistema SGCV (Sistema de Gestión Comercial y Ventas). El proyecto utiliza una arquitectura de tres capas con agentes de negocio que orquestan las operaciones entre la capa de datos y presentación.

## Arquitectura de Agentes

### Capa de Negocio (CapaNegocio)
Los agentes de negocio actúan como intermediarios entre la presentación y datos, aplicando validaciones y reglas de negocio.

#### Agent: CN_Usuario
**Responsabilidades:**
- Validación de número de DNI (8 dígitos numéricos)
- Validación de campos de usuario (nombre, apellido, rol)
- Gestión de autenticación y cambio de contraseña
- Encriptación de claves mediante hash PBKDF2

**Métodos principales:**
- `Login(string documento, out string mensaje)` - Autenticación del usuario
- `Crear(CE_Usuario oUsuario, out string mensaje)` - Crear nuevo usuario
- `Actualizar(CE_Usuario oUsuario, out string mensaje)` - Actualizar datos de usuario
- `CambiarClave(int idUsuario, string claveActual, string claveNueva)` - Cambio de contraseña

**Referencia:** [CN_Usuario](CapaNegocio/CN_Usuario.cs)

#### Agent: CN_Producto
**Responsabilidades:**
- Validación de productos (código, descripción, precio, quiebre de stock, categoría)

**Métodos principales:**
- `Crear(CE_Producto oProducto, out string mensaje)` - Crear producto
- `Actualizar(CE_Producto oProducto, out string mensaje)` - Actualizar producto
- `Listar(out string mensaje)` - Listar todos los productos
- `Eliminar(int idProducto, out string mensaje)` - Eliminar producto

**Referencia:** [CN_Producto](CapaNegocio/CN_Producto.cs)

#### Agent: CN_Compra
**Responsabilidades:**

**Métodos principales:**
- `Crear(CE_Compra oCompra, DataTable compraDetalle, out string mensaje)` - Crear compra
- `ObtenerCompra(int idCompra)` - Obtener compra con detalle
- `Listar(out string mensaje)` - Listar todas las compras

**Referencia:** [CN_Compra](CapaNegocio/CN_Compra.cs)

#### Agent: CN_Venta
**Responsabilidades:**

**Métodos principales:**
- `Crear(CE_Venta oVenta, DataTable ventaDetalle, out string mensaje)` - Crear venta
- `ObtenerVenta(int idVenta)` - Obtener venta con detalle
- `Listar(out string mensaje)` - Listar todas las ventas

**Referencia:** [CN_Venta](CapaNegocio/CN_Venta.cs)

#### Agent: CN_Cliente
**Responsabilidades:**
- Validación de clientes (número de DNI de 8 dígitos, nombre, apellido, teléfono, correo)
- Validaciones de contacto (teléfono y correo opcionales)

**Métodos principales:**
- `Crear(CE_Cliente oCliente, out string mensaje)` - Crear cliente
- `Actualizar(CE_Cliente oCliente, out string mensaje)` - Actualizar cliente
- `Listar(out string mensaje)` - Listar clientes
- `Eliminar(int idCliente, out string mensaje)` - Eliminar cliente

**Referencia:** [CN_Cliente](CapaNegocio/CN_Cliente.cs)

#### Agent: CN_Proveedor
**Responsabilidades:**
- Validación de proveedores (razón social requerida)
- Gestión de contacto de proveedores (teléfono, correo opcionales)

**Métodos principales:**
- `Crear(CE_Proveedor oProveedor, out string mensaje)` - Crear proveedor
- `Actualizar(CE_Proveedor oProveedor, out string mensaje)` - Actualizar proveedor
- `Listar(out string mensaje)` - Listar proveedores
- `Eliminar(int idProveedor, out string mensaje)` - Eliminar proveedor

**Referencia:** [CN_Proveedor](CapaNegocio/CN_Proveedor.cs)

#### Agent: CN_Comercio
**Responsabilidades:**
- Gestión de datos del comercio (razón social, CUIT, ingresos brutos, inicio de actividad, punto de venta, dirección, Condición ante IVA)
- Gestión de logo del comercio

**Métodos principales:**
- `Leer()` - Obtener datos del comercio
- `Actualizar(CE_Comercio oComercio, out string mensaje)` - Actualizar datos comerciales

**Referencia:** [CN_Comercio](CapaNegocio/CN_Comercio.cs)

#### Agent: CN_Conexion
**Responsabilidades:**
- Verificación de conexión a base de datos

**Métodos principales:**
- `VerificarConexion(out string mensaje)` - Test de conexión a BD

**Referencia:** [CN_Conexion](CapaNegocio/CN_Conexion.cs)

#### Agent: CN_Categoria
**Responsabilidades:**
- Validación de categorías de productos (nombre, descripción, alicuota iva)
- Gestión del catálogo de categorías

**Métodos principales:**
- `Crear(CE_Categoria oCategoria, out string mensaje)` - Crear categoría
- `Actualizar(CE_Categoria oCategoria, out string mensaje)` - Actualizar categoría
- `Listar(out string mensaje)` - Listar categorías
- `Eliminar(int idCategoria, out string mensaje)` - Eliminar categoría

**Referencia:** [CN_Categoria](CapaNegocio/CN_Categoria.cs)

#### Agent: CN_ResponsableIVA
**Responsabilidades:**
- Gestión de condiciones ante IVA (monotributista, resp. inscripto, etc.)

**Métodos principales:**
- `Listar(out string mensaje)` - Listar responsables IVA

**Referencia:** [CN_ResponsableIVA](CapaNegocio/CN_ResponsableIVA.cs)

#### Agent: CN_Rol
**Responsabilidades:**
- Gestión de roles de usuario del sistema
- Validación de permisos y acceso

**Métodos principales:**
- `Listar(out string mensaje)` - Listar roles disponibles

**Referencia:** [CN_Rol](CapaNegocio/CN_Rol.cs)

#### Agent: CN_Modulo
**Responsabilidades:**
- Gestión de módulos del sistema
- Control de acceso a funcionalidades

**Métodos principales:**
- `Listar(out string mensaje)` - Listar módulos

**Referencia:** [CN_Modulo](CapaNegocio/CN_Modulo.cs)

#### Agent: CN_Provincia
**Responsabilidades:**
- Devolucion de listado de provincias

**Métodos principales:**
- `Listar(out string mensaje)` - Listar provincias

**Referencia:** [CN_Provincia](CapaNegocio/CN_Provincia.cs)

#### Utilitarios de Negocio

##### Hash.cs
**Responsabilidades:**
- Generación de hash seguro para contraseñas (PBKDF2)
- Verificación de contraseñas hasheadas
- Implementación de salt aleatorio y múltiples iteraciones

**Métodos principales:**
- `Generar(string claveTextoPlano)` - Genera hash con salt
- `Verificar(string claveHasheada, string claveTextoPlano)` - Verifica contraseña

**Referencia:** [Hash.cs](CapaNegocio/Utilidades/Hash.cs)

### Capa de Datos (CapaDatos)

#### Data Access Objects (DAO)
Los DAOs implementan la lógica de acceso a datos mediante SQL Server con stored procedures.

##### CD_Usuario
- Manejo de autenticación en BD
- CRUD y cambio de clave de usuarios
- Ejecución de `usp_loginUsuario`, `usp_crearUsuario`, `usp_actualizarUsuario`, `usp_eliminarUsuario` y `usp_cambiarClaveUsuario`

**Referencia:** [CD_Usuario.cs](CapaDatos/CD_Usuario.cs)

##### CD_Producto
- CRUD de productos
- Ejecución de `usp_crearProducto`
- Manejo de relación con categorías

**Referencia:** [CD_Producto.cs](CapaDatos/CD_Producto.cs)

##### CD_Compra
- Listar, obtener compra y detalle por id y crear compras
- Ejecución de `usp_crearCompra` con tabla de detalles

**Referencia:** [CD_Compra.cs](CapaDatos/CD_Compra.cs)

##### CD_Venta
- Listar, obtener venta y detalle por id y crear ventas
- Ejecución de `usp_crearVenta` con tabla de detalles

**Referencia:** [CD_Venta.cs](CapaDatos/CD_Venta.cs)

##### CD_Cliente
- CRUD de clientes
- Ejecución de `usp_crearCliente`, `usp_actualizarCliente` y `usp_eliminarCliente`

**Referencia:** [CD_Cliente.cs](CapaDatos/CD_Cliente.cs)

##### CD_Proveedor
- CRUD de proveedores
- Ejecución de `usp_crearProveedor`, `usp_actualizarProveedor` y `usp_eliminarProveedor`

**Referencia:** [CD_Proveedor.cs](CapaDatos/CD_Proveedor.cs)

##### CD_Comercio
- Lectura y actualización de datos comerciales
- Joins con Direccion, Localidad, cProvincia y cResponsableIVA
- Gestión de logo

**Referencia:** [CD_Comercio.cs](CapaDatos/CD_Comercio.cs)

**Referencia Base:** [CapaDatos](CapaDatos/)

### Capa de Presentación (CapaPresentacion)

#### Forms Principales

##### frmInicio
**Responsabilidades:**
- Dashboard principal y menú de navegación
- Gestión de sesión de usuario
- Apertura de formularios principales

**Referencia:** [frmInicio](CapaPresentacion/Formularios/frmInicio.cs)

##### frmProducto
**Responsabilidades:**
- CRUD de productos
- Validación de campos (código, descripción, precio, categoría)
- Listado en DataGridView

**Referencia:** [frmProducto](CapaPresentacion/Formularios/frmProducto.cs)

##### frmCompra
**Responsabilidades:**
- Registro de compras
- Selección de proveedor
- Agregación de productos con cantidades y precios
- Validación de fechas de pedido y entrega
- Cálculo de total

**Referencia:** [frmCompra](CapaPresentacion/Formularios/frmCompra.cs)

##### frmCompraDetalle
**Responsabilidades:**
- Consulta de compras registradas
- Visualización de detalle de compra
- Generación de PDF con plantilla HTML
- Reemplazo de tokens en plantilla

**Referencia:** [frmCompraDetalle](CapaPresentacion/Formularios/frmCompraDetalle.cs)

##### frmVenta
**Responsabilidades:**
- Registro de ventas
- Selección de cliente (opcional)
- Agregación de productos con cantidades y precios
- Cálculo de total
- Validación de monto de pago vs total

**Referencia:** [frmVenta](CapaPresentacion/Formularios/frmVenta.cs)

##### frmVentaDetalle
**Responsabilidades:**
- Consulta de ventas registradas
- Visualización de detalle de venta
- Generación de PDF con plantilla HTML
- Reemplazo de tokens en plantilla

**Referencia:** [frmVentaDetalle](CapaPresentacion/Formularios/frmVentaDetalle.cs)

##### frmCliente
**Responsabilidades:**
- CRUD de clientes
- Validación de documento (8 dígitos)
- Validación de correo electrónico y teléfono
- Selección de condición ante IVA

**Referencia:** [frmCliente](CapaPresentacion/Formularios/frmCliente.cs)

##### frmProveedor
**Responsabilidades:**
- CRUD de proveedores
- Validación de razón social
- Gestión de datos de contacto

**Referencia:** [frmProveedor](CapaPresentacion/Formularios/frmProveedor.cs)

##### frmUsuario
**Responsabilidades:**
- CRUD de usuarios
- Validación de documento (8 dígitos)
- Asignación de roles

**Referencia:** [frmUsuario](CapaPresentacion/Formularios/frmUsuario.cs)

##### frmComercio
**Responsabilidades:**
- Edición de datos comerciales
- Gestión de logo
- Datos de dirección y localidad

**Referencia:** [frmComercio](CapaPresentacion/Formularios/frmComercio.cs)

##### frmCategoria
**Responsabilidades:**
- CRUD de categorías de productos
- Búsqueda y filtrado

**Referencia:** [frmCategoria](CapaPresentacion/Formularios/frmCategoria.cs)

#### Formularios Modales

##### mdUsuarioCambiarClave
**Responsabilidades:**
- Cambio de contraseña del usuario actual
- Validación de clave actual
- Generación de nueva clave hasheada

**Referencia:** [mdUsuarioCambiarClave](CapaPresentacion/Formularios/Modal/mdUsuarioCambiarClave.cs)

##### mdProducto
**Responsabilidades:**
- Modal de búsqueda y selección de productos
- Selección desde DataGridView

##### mdProveedor
**Responsabilidades:**
- Modal de búsqueda y selección de proveedores

##### mdCompra
**Responsabilidades:**
- Modal de búsqueda de compras anteriores

#### Utilidades de Presentación

##### UtilidadesForm.cs
**Responsabilidades:**
- Reinicio de controles (TextBox, ComboBox, MaterialSkin controls)
- Alternancia de panel habilitado/deshabilitado

**Referencia:** [UtilidadesForm](CapaPresentacion/Utilidades/UtilidadesForm.cs)

##### UtilidadesDGV.cs
**Responsabilidades:**
- Configuración general de DataGridView
- Aplicación de filtros por columna y texto
- Estilos y ajuste automático de columnas

**Referencia:** [UtilidadesDGV](CapaPresentacion/Utilidades/UtilidadesDGV.cs)

##### UtilidadesCB.cs
**Responsabilidades:**
- Carga de ComboBox con opciones genéricas
- Carga de headers desde DataGridView

**Referencia:** [UtilidadesCB](CapaPresentacion/Utilidades/UtilidadesCB.cs)

##### UtilidadesTextBox.cs
**Responsabilidades:**
- Validación de entrada: solo dígitos, solo precios
- Validación de documentos

##### UtilidadesModal.cs
**Responsabilidades:**
- Búsqueda de cliente, proveedor, compra, venta
- Callbacks para actualizar formularios principales

## Plantillas de Generación de PDF

### PlantillaVenta.html
**Token reemplazables:**
- `@Logo`, `@RazonSocial`, `@Cuit`, `@IngresosBrutos`
- `@Direccion`, `@CodigoPostal`, `@Localidad`, `@Provincia`
- `@TelefonoComercio`, `@InicioActividad`, `@RespIVA`
- `@FechaVenta`, `@NroVenta`, `@TipoFactura`, `@ClienteRespIVA`
- `@Filas` (detalle de productos), `@Total`, `@Pago`, `@Vuelto`

**Referencia:** [PlantillaVenta.html](CapaPresentacion/Resources/PlantillaVenta.html)

### PlantillaCompra2.html
**Token reemplazables:**
- `@RazonSocial`, `@Cuit`, `@Direccion`, `@RespIVA`
- `@PrRazonSocial`, `@PrTelefono`, `@PrCorreo`
- `@FechaPedido`, `@FechaEntrega`, `@FechaCreacion`
- `@NroCompra`, `@Usuario`
- `@Filas` (detalle de productos), `@Total`
- `@Logo`

**Referencia:** [PlantillaCompra2.html](CapaPresentacion/Resources/PlantillaCompra2.html)

## Entidades (CapaEntidad)

### Entidades principales:
- `CE_Usuario` - Usuario del sistema
- `CE_Producto` - Producto en venta/compra
- `CE_Compra` / `CE_CompraDetalle` - Compras a proveedores
- `CE_Venta` / `CE_VentaDetalle` - Ventas a clientes
- `CE_Cliente` - Cliente del comercio
- `CE_Proveedor` - Proveedor de productos
- `CE_Comercio` - Datos del comercio
- `CE_Categoria` - Categoría de productos
- `CE_Rol` - Rol de usuario
- `CE_Estado` - Estados (activo/inactivo)
- `CE_ResponsableIVA` - Condición ante IVA (A, B, C)

**Referencia:** [CapaEntidad](CapaEntidad/)

## Flujos de Negocio

### Flujo de Compra
1. Usuario selecciona proveedor en frmCompra
2. Agrega productos con cantidad y precio unitario
3. Valida fechas de pedido y entrega
4. CN_Compra valida datos
5. CD_Compra ejecuta stored procedure `usp_crearCompra`
6. Stock de productos se actualiza

### Flujo de Venta
1. Usuario opcional: busca/selecciona cliente
2. Busca productos por código
3. Agrega productos con cantidad
4. Sistema calcula subtotal y total
5. Valida monto de pago >= total
6. CN_Venta valida datos
7. CD_Venta ejecuta stored procedure `usp_crearVenta`
8. Stock de productos se decrementa
9. Se genera PDF con tipo de factura según cliente

### Flujo de Autenticación
1. Usuario ingresa documento y contraseña
2. CD_Usuario busca usuario en BD
3. Hash.Verificar() compara claves
4. Si es válido, se retorna CE_Usuario con datos completos
5. Se abre frmInicio con datos del usuario

## Performance y Benchmarking

Se incluye proyecto `BenchmarkSuite1` para pruebas de performance:
- `BenchmarkCompra.cs` - Benchmark de creación de compras
- Utiliza BenchmarkDotNet con diagnoser de CPU
- Valida performance de stored procedure `usp_crearCompra`

**Referencia:** [BenchmarkSuite1](BenchmarkSuite1/)

## Observaciones y TODOs

- **IVA**: Estructura preparada pero no completamente implementada (comentarios en plantillas)
- **Stock negativo**: Sistema permite visualización pero no prevent validación de stock suficiente
- **Campos opcionales**: Algunos campos como teléfono y correo son opcionales según validaciones

## Tecnologías y Librerías

- **Framework**: .NET Framework 4.7+
- **BD**: SQL Server con Stored Procedures
- **UI**: Windows Forms + MaterialSkin
- **PDF**: iText 7
- **Seguridad**: PBKDF2 (Rfc2898DeriveBytes)
- **Testing**: BenchmarkDotNet

## Estructura de Solución

SGCV/
├── SGCV.sln
├── CapaEntidad/
│   ├── CE_Usuario.cs
│   ├── CE_Producto.cs
│   ├── CE_Compra.cs
│   ├── CE_CompraDetalle.cs
│   ├── CE_Venta.cs
│   ├── CE_VentaDetalle.cs
│   ├── CE_Cliente.cs
│   ├── CE_Proveedor.cs
│   ├── CE_Comercio.cs
│   ├── CE_Categoria.cs
│   ├── CE_Rol.cs
│   ├── CE_Estado.cs
│   ├── CE_ResponsableIVA.cs
│   └── CapaEntidad.csproj
│
├── CapaDatos/
│   ├── CD_Usuario.cs
│   ├── CD_Producto.cs
│   ├── CD_Compra.cs
│   ├── CD_CompraDetalle.cs
│   ├── CD_Venta.cs
│   ├── CD_VentaDetalle.cs
│   ├── CD_Cliente.cs
│   ├── CD_Proveedor.cs
│   ├── CD_Comercio.cs
│   ├── CD_Categoria.cs
│   ├── Conexion.cs
│   └── CapaDatos.csproj
│
├── CapaNegocio/
│   ├── CN_Usuario.cs
│   ├── CN_Producto.cs
│   ├── CN_Compra.cs
│   ├── CN_Venta.cs
│   ├── CN_Cliente.cs
│   ├── CN_Proveedor.cs
│   ├── CN_Comercio.cs
│   ├── CN_Categoria.cs
│   ├── CN_Conexion.cs
│   ├── Utilidades/
│   │   └── Hash.cs
│   └── CapaNegocio.csproj
│
├── CapaPresentacion/
│   ├── Program.cs
│   ├── frmLogin.cs
│   ├── frmInicio.cs
│   ├── Formularios/
│   │   ├── frmProducto.cs
│   │   ├── frmCompra.cs
│   │   ├── frmCompraDetalle.cs
│   │   ├── frmVenta.cs
│   │   ├── frmVentaDetalle.cs
│   │   ├── frmCliente.cs
│   │   ├── frmProveedor.cs
│   │   ├── frmUsuario.cs
│   │   ├── frmComercio.cs
│   │   ├── frmCategoria.cs
│   │   └── Modal/
│   │       ├── mdUsuarioCambiarClave.cs
│   │       ├── mdProducto.cs
│   │       ├── mdProveedor.cs
│   │       └── mdCompra.cs
│   ├── Utilidades/
│   │   ├── UtilidadesForm.cs
│   │   ├── UtilidadesDGV.cs
│   │   ├── UtilidadesCB.cs
│   │   ├── UtilidadesTextBox.cs
│   │   └── UtilidadesModal.cs
│   ├── Resources/
│   │   ├── PlantillaVenta.html
│   │   ├── PlantillaCompra2.html
│   │   └── imagenes/
│   │       └── logo.png
│   ├── Properties/
│   │   └── Resources.resx
│   └── CapaPresentacion.csproj
│
├── BenchmarkSuite1/
│   ├── BenchmarkCompra.cs
│   ├── Program.cs
│   └── BenchmarkSuite1.csproj
│
└── docs/
    ├── AGENTS.md
    ├── DATABASE.md
    ├── API.md
    └── INSTALLATION.md