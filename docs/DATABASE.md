# DATABASE.md

## Estructura de Base de Datos - SGCV

Este documento describe la estructura de la base de datos SQL Server para el sistema SGCV (Sistema de Gestión Comercial y Ventas).

## Tablas Principales

### Usuarios y Seguridad

#### Tabla: Usuario
**Descripción:** Almacena usuarios del sistema

**Columnas:**
- `idUsuario` (INT, PK) - Identificador único
- `documento` (VARCHAR(8), UNIQUE) - DNI del usuario (8 dígitos)
- `nombre` (VARCHAR(100), NOT NULL) - Nombre del usuario
- `apellido` (VARCHAR(100), NOT NULL) - Apellido del usuario
- `clave` (VARCHAR(MAX), NOT NULL) - Contraseña hasheada (PBKDF2)
- `idRol` (INT, FK) - Referencia a tabla Rol
- `estado` (BIT) - 1 = Activo, 0 = Inactivo
- `fechaCreacion` (DATETIME) - Fecha de creación
- `fechaModificacion` (DATETIME) - Fecha de última modificación

#### Tabla: Rol
**Descripción:** Roles de acceso en el sistema

**Columnas:**
- `idRol` (INT, PK) - Identificador único
- `descripcion` (VARCHAR(100), NOT NULL) - Nombre del rol
- `estado` (BIT) - 1 = Activo, 0 = Inactivo

**Roles predefinidos:**
- Administrador
- Vendedor
- Encargado de Compras
- Gerente

---

### Maestros de Comercio

#### Tabla: Comercio
**Descripción:** Datos del comercio/negocio

**Columnas:**
- `idComercio` (INT, PK) - Identificador único (generalmente 1)
- `razonSocial` (VARCHAR(150), NOT NULL) - Razón social del comercio
- `cuit` (VARCHAR(13)) - CUIT (formato: XX-XXXXXXXX-X)
- `ingresosBrutos` (VARCHAR(20)) - Número de ingresos brutos
- `inicioActividad` (DATE) - Fecha de inicio de actividades
- `idResponsableIVA` (INT, FK) - Referencia a tabla ResponsableIVA
- `puntoVenta` (INT) - Punto de venta para facturas
- `logo` (VARBINARY(MAX)) - Logo en binario
- `idDireccion` (INT, FK) - Referencia a tabla Direccion
- `fechaModificacion` (DATETIME) - Última actualización

#### Tabla: Direccion
**Descripción:** Direcciones

**Columnas:**
- `idDireccion` (INT, PK) - Identificador único
- `calle` (VARCHAR(150), NOT NULL)
- `numero` (VARCHAR(10))
- `departamento` (VARCHAR(10))
- `codigoPostal` (VARCHAR(10))
- `idLocalidad` (INT, FK) - Referencia a tabla Localidad

#### Tabla: Localidad
**Descripción:** Localidades

**Columnas:**
- `idLocalidad` (INT, PK) - Identificador único
- `descripcion` (VARCHAR(150), NOT NULL)
- `idProvincia` (INT, FK) - Referencia a tabla Provincia

#### Tabla: Provincia
**Descripción:** Provincias de Argentina

**Columnas:**
- `idProvincia` (INT, PK) - Identificador único
- `descripcion` (VARCHAR(100), NOT NULL)

#### Tabla: ResponsableIVA
**Descripción:** Condiciones ante IVA

**Columnas:**
- `idResponsableIVA` (INT, PK)
- `descripcion` (VARCHAR(50), NOT NULL)

**Valores predefinidos:**
- Responsable Inscripto (A)
- Responsable no Inscripto (B)
- Monotributista (C)
- Exento (E)

---

### Productos y Categorías

#### Tabla: Categoria
**Descripción:** Categorías de productos

**Columnas:**
- `idCategoria` (INT, PK)
- `descripcion` (VARCHAR(100), NOT NULL)
- `estado` (BIT) - 1 = Activo, 0 = Inactivo

#### Tabla: Producto
**Descripción:** Catálogo de productos

**Columnas:**
- `idProducto` (INT, PK)
- `codigo` (VARCHAR(50), UNIQUE, NOT NULL) - Código del producto
- `descripcion` (VARCHAR(200), NOT NULL)
- `precio` (DECIMAL(10,2), NOT NULL) - Precio de venta
- `precioCompra` (DECIMAL(10,2)) - Precio de compra (informativo)
- `stock` (INT, DEFAULT 0) - Cantidad en stock
- `stockMinimo` (INT, DEFAULT 0) - Stock mínimo de alerta
- `idCategoria` (INT, FK) - Referencia a tabla Categoria
- `estado` (BIT) - 1 = Activo, 0 = Inactivo
- `quiebreStock` (INT, DEFAULT 0) - Cantidad de quiebre de stock

---

### Clientes

#### Tabla: Cliente
**Descripción:** Clientes del comercio

**Columnas:**
- `idCliente` (INT, PK)
- `documento` (VARCHAR(8), UNIQUE, NOT NULL) - DNI (8 dígitos)
- `nombre` (VARCHAR(100), NOT NULL)
- `apellido` (VARCHAR(100), NOT NULL)
- `idResponsableIVA` (INT, FK) - Condición ante IVA
- `idContacto` (INT, FK) - Referencia a tabla Contacto
- `estado` (BIT) - 1 = Activo, 0 = Inactivo

#### Tabla: Contacto
**Descripción:** Información de contacto

**Columnas:**
- `idContacto` (INT, PK)
- `telefono` (VARCHAR(20)) - Opcional
- `correo` (VARCHAR(100)) - Opcional
- `observaciones` (VARCHAR(500))

---

### Proveedores

#### Tabla: Proveedor
**Descripción:** Proveedores de productos

**Columnas:**
- `idProveedor` (INT, PK)
- `razonSocial` (VARCHAR(150), NOT NULL)
- `idContacto` (INT, FK) - Referencia a tabla Contacto
- `estado` (BIT) - 1 = Activo, 0 = Inactivo

---

### Compras

#### Tabla: Compra
**Descripción:** Registro de compras a proveedores

**Columnas:**
- `idCompra` (INT, PK)
- `numero` (INT) - Número secuencial de compra
- `idProveedor` (INT, FK) - Referencia a tabla Proveedor
- `fechaPedido` (DATE, NOT NULL) - Fecha del pedido
- `fechaEntrega` (DATE, NOT NULL) - Fecha prevista de entrega
- `fechaCreacion` (DATETIME) - Fecha de registro en sistema
- `idUsuario` (INT, FK) - Usuario que realizó la compra
- `total` (DECIMAL(10,2), NOT NULL) - Total de la compra

#### Tabla: CompraDetalle
**Descripción:** Detalle de productos en cada compra

**Columnas:**
- `idCompraDetalle` (INT, PK)
- `idCompra` (INT, FK) - Referencia a tabla Compra
- `idProducto` (INT, FK) - Referencia a tabla Producto
- `cantidad` (INT, NOT NULL)
- `precioUnitario` (DECIMAL(10,2), NOT NULL)
- `subtotal` (DECIMAL(10,2), NOT NULL) - cantidad * precioUnitario

**Nota:** Al insertar una compra, el stock del producto se incrementa.

---

### Ventas

#### Tabla: Venta
**Descripción:** Registro de ventas a clientes

**Columnas:**
- `idVenta` (INT, PK)
- `numero` (INT) - Número secuencial de venta
- `idCliente` (INT, FK) - Referencia a tabla Cliente (Opcional)
- `fechaVenta` (DATE, NOT NULL) - Fecha de la venta
- `tipoFactura` (CHAR(1)) - A, B, C según responsable IVA
- `subtotal` (DECIMAL(10,2), NOT NULL)
- `iva` (DECIMAL(10,2), DEFAULT 0) - Impuesto (cuando aplique)
- `total` (DECIMAL(10,2), NOT NULL)
- `montoPago` (DECIMAL(10,2), NOT NULL) - Dinero recibido
- `vuelto` (DECIMAL(10,2), NOT NULL) - Dinero de cambio
- `idUsuario` (INT, FK) - Usuario que realizó la venta
- `fechaCreacion` (DATETIME) - Fecha de registro

#### Tabla: VentaDetalle
**Descripción:** Detalle de productos en cada venta

**Columnas:**
- `idVentaDetalle` (INT, PK)
- `idVenta` (INT, FK) - Referencia a tabla Venta
- `idProducto` (INT, FK) - Referencia a tabla Producto
- `cantidad` (INT, NOT NULL)
- `precioUnitario` (DECIMAL(10,2), NOT NULL)
- `subtotal` (DECIMAL(10,2), NOT NULL) - cantidad * precioUnitario

**Nota:** Al insertar una venta, el stock del producto se decrementa.

---

### Estados

#### Tabla: Estado
**Descripción:** Estados genéricos del sistema

**Columnas:**
- `idEstado` (INT, PK)
- `descripcion` (VARCHAR(50), NOT NULL)

---

## Stored Procedures

### Autenticación

#### `usp_login`
**Descripción:** Valida credenciales de usuario

```sql
EXECUTE usp_login
    @documento VARCHAR(8),
    @clave VARCHAR(MAX)
```

**Retorna:** Registro con datos de usuario si es válido, NULL si no

---

### Creación de Compras

#### `usp_crearCompra`
**Descripción:** Crea una compra con su detalle y actualiza stock

```sql
EXECUTE usp_crearCompra
    @idProveedor INT,
    @fechaPedido DATE,
    @fechaEntrega DATE,
    @idUsuario INT,
    @detalles CompraDetalleType READONLY,
    @total DECIMAL(10,2),
    @mensaje VARCHAR(500) OUTPUT
```

**Parámetro `@detalles`:**
- `idProducto` INT
- `cantidad` INT
- `precioUnitario` DECIMAL(10,2)
- `subtotal` DECIMAL(10,2)

**Acciones:**
1. Crea registro en tabla Compra
2. Inserta detalles en CompraDetalle
3. Actualiza stock de productos (suma cantidades)

**Retorna:** Mensaje de éxito o error

---

### Creación de Ventas

#### `usp_crearVenta`
**Descripción:** Crea una venta con su detalle y actualiza stock

```sql
EXECUTE usp_crearVenta
    @idCliente INT = NULL,
    @tipoFactura CHAR(1),
    @subtotal DECIMAL(10,2),
    @iva DECIMAL(10,2),
    @total DECIMAL(10,2),
    @montoPago DECIMAL(10,2),
    @vuelto DECIMAL(10,2),
    @idUsuario INT,
    @detalles VentaDetalleType READONLY,
    @mensaje VARCHAR(500) OUTPUT
```

**Parámetro `@detalles`:**
- `idProducto` INT
- `cantidad` INT
- `precioUnitario` DECIMAL(10,2)
- `subtotal` DECIMAL(10,2)

**Acciones:**
1. Crea registro en tabla Venta
2. Inserta detalles en VentaDetalle
3. Actualiza stock de productos (resta cantidades)
4. Valida que no haya stock negativo

**Retorna:** Mensaje de éxito o error

---

### Gestión de Usuarios

#### `usp_crearUsuario`
**Descripción:** Crea un nuevo usuario

```sql
EXECUTE usp_crearUsuario
    @documento VARCHAR(8),
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @claveHasheada VARCHAR(MAX),
    @idRol INT,
    @mensaje VARCHAR(500) OUTPUT
```

#### `usp_actualizarUsuario`
**Descripción:** Actualiza datos de usuario

```sql
EXECUTE usp_actualizarUsuario
    @idUsuario INT,
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @idRol INT,
    @estado BIT,
    @mensaje VARCHAR(500) OUTPUT
```

---

### Gestión de Productos

#### `usp_crearProducto`
**Descripción:** Crea un nuevo producto

```sql
EXECUTE usp_crearProducto
    @codigo VARCHAR(50),
    @descripcion VARCHAR(200),
    @precio DECIMAL(10,2),
    @precioCompra DECIMAL(10,2),
    @idCategoria INT,
    @stockMinimo INT = 0,
    @quiebreStock INT = 0,
    @mensaje VARCHAR(500) OUTPUT
```

---

### Gestión de Clientes

#### `usp_crearCliente`
**Descripción:** Crea un nuevo cliente

```sql
EXECUTE usp_crearCliente
    @documento VARCHAR(8),
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @idResponsableIVA INT,
    @telefono VARCHAR(20) = NULL,
    @correo VARCHAR(100) = NULL,
    @observaciones VARCHAR(500) = NULL,
    @mensaje VARCHAR(500) OUTPUT
```

---

## Relaciones entre Tablas

```
Usuario
  ├─ Rol (1:N)
  ├─ Compra (1:N)
  └─ Venta (1:N)

Comercio
  ├─ ResponsableIVA (N:1)
  └─ Direccion (N:1)

Direccion
  └─ Localidad (N:1)

Localidad
  └─ Provincia (N:1)

Categoria
  └─ Producto (1:N)

Producto
  ├─ CompraDetalle (1:N)
  └─ VentaDetalle (1:N)

Cliente
  ├─ ResponsableIVA (N:1)
  ├─ Contacto (N:1)
  └─ Venta (1:N)

Proveedor
  ├─ Contacto (N:1)
  └─ Compra (1:N)

Compra
  ├─ Proveedor (N:1)
  ├─ Usuario (N:1)
  └─ CompraDetalle (1:N)

CompraDetalle
  ├─ Compra (N:1)
  └─ Producto (N:1)

Venta
  ├─ Cliente (N:1, opcional)
  ├─ Usuario (N:1)
  └─ VentaDetalle (1:N)

VentaDetalle
  ├─ Venta (N:1)
  └─ Producto (N:1)
```

---

## Consideraciones de Integridad

### Validaciones:
- **Documentos:** Deben ser únicos y de 8 dígitos
- **Precios:** Decimales a 2 posiciones
- **Stock:** No permite valores negativos
- **Fechas:** Verificar formato DATE
- **Monto de pago:** Debe ser >= Total de venta
- **Hash de contraseña:** Utilizar PBKDF2 desde aplicación

### Índices recomendados:
- `Usuario.documento` - UNIQUE
- `Producto.codigo` - UNIQUE
- `Cliente.documento` - UNIQUE
- `Compra.numero`
- `Venta.numero`

---

## Consideraciones de Performance

- Mantener índices actualizados
- Usar paginación en consultas de listado
- Considerar archivado de datos históricos antiguos
- Monitorear tamaño de tabla CompraDetalle y VentaDetalle

---

**Última actualización:** Diciembre 2024
**Base de Datos:** SQL Server 2019+
