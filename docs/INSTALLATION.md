# INSTALLATION.md

## Guía de Instalación y Configuración - SGCV

Este documento describe los pasos necesarios para instalar, configurar y ejecutar el sistema SGCV (Sistema de Gestión Comercial y Ventas) en un ambiente de desarrollo.

---

## Requisitos Previos

### Software Requerido

1. **Visual Studio 2019 o superior**
   - Descargar desde: https://visualstudio.microsoft.com/downloads/
   - Instalar workload ".NET desktop development"

2. **.NET Framework 4.7 o superior**
   - Incluido en instalación de Visual Studio
   - Verificar: Control Panel > Programs > Programs and Features

3. **SQL Server 2019 o superior**
   - Descargar desde: https://www.microsoft.com/sql-server/
   - Instancias soportadas:
     - SQL Server Express (gratuito)
     - SQL Server Developer Edition (gratuito)
     - SQL Server Standard/Enterprise

4. **SQL Server Management Studio (SSMS)**
   - Descargar desde: https://docs.microsoft.com/sql/ssms/
   - Versión recomendada: 18.x o superior

### Hardware Mínimo

- Procesador: Intel i3 2.0 GHz o equivalente
- Memoria RAM: 4 GB
- Disco Duro: 2 GB de espacio libre
- Pantalla: Resolución mínima 1280x720

---

## Instalación de Visual Studio

### Paso 1: Descargar Visual Studio
1. Ir a https://visualstudio.microsoft.com/vs/
2. Hacer clic en "Download Visual Studio Community" (o Enterprise si tiene licencia)
3. Ejecutar el instalador

### Paso 2: Seleccionar Componentes
Durante la instalación, seleccionar:

**Workloads:**
- ☑ .NET desktop development

**Individual components:**
- ☑ .NET Framework 4.7+ targeting pack
- ☑ Class Designer
- ☑ Code analysis tools

### Paso 3: Completar Instalación
- Click en "Install"
- Esperar a que se complete (aprox. 15-30 minutos)
- Reiniciar sistema si se solicita

---

## Instalación de SQL Server

### Opción A: SQL Server Express (Recomendado para desarrollo)

1. **Descargar**
   - Ir a https://www.microsoft.com/sql-server/sql-server-express
   - Click en "Download now"

2. **Ejecutar instalador**
   - Ejecutar `SQLEXPR_x64_ENU.exe`
   - Seleccionar "Basic"

3. **Configuración**
   - Instance Name: `SQLEXPRESS` (por defecto)
   - Authentication mode: "Windows Authentication"
   - Click "Install"

4. **Verificar instalación**
   - Abrir Services (services.msc)
   - Verificar que "SQL Server (SQLEXPRESS)" esté ejecutándose

### Opción B: SQL Server Developer Edition

Mismo proceso que Express, pero seleccionar "Developer" durante instalación.

---

## Instalación de SQL Server Management Studio

1. **Descargar**
   - Ir a https://docs.microsoft.com/sql/ssms/
   - Click en "Download SQL Server Management Studio"

2. **Ejecutar instalador**
   - Ejecutar `SSMS-Setup-ENU.exe`
   - Seguir pasos del asistente
   - Click "Install"

3. **Verificar**
   - Abrir SSMS
   - Conectar con:
     - Server name: `.\SQLEXPRESS` o `localhost`
     - Authentication: Windows Authentication
   - Click "Connect"

---

## Configuración de Base de Datos

### Paso 1: Crear Base de Datos

Abrir SQL Server Management Studio y ejecutar el siguiente script:

```sql
-- Crear base de datos
CREATE DATABASE SGCV
GO

USE SGCV
GO

-- Establecer opciones de compatibilidad
ALTER DATABASE SGCV SET COMPATIBILITY_LEVEL = 130
GO
```

### Paso 2: Crear Tablas

Ver archivo `database_schema.sql` en la carpeta `docs/` o ejecutar desde Management Studio los scripts de creación de tablas.

Estructura básica:

```sql
CREATE TABLE Usuario (
    idUsuario INT IDENTITY(1,1) PRIMARY KEY,
    documento VARCHAR(8) UNIQUE NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    clave VARCHAR(MAX) NOT NULL,
    idRol INT NOT NULL,
    estado BIT DEFAULT 1,
    fechaCreacion DATETIME DEFAULT GETDATE(),
    fechaModificacion DATETIME
)

-- Crear más tablas según DATABASE.md
```

### Paso 3: Crear Usuario de Base de Datos

**Método 1: Utilizar Windows Authentication (Recomendado)**

En Management Studio, crear login SQL Server:

```sql
USE master
GO
CREATE LOGIN sgcv_user WITH PASSWORD = 'SgcvPass123!'
GO
USE SGCV
GO
CREATE USER sgcv_user FOR LOGIN sgcv_user
GO
ALTER ROLE db_owner ADD MEMBER sgcv_user
GO
```

**Método 2: Usar autenticación integrada de Windows**

No requiere usuario adicional, utilizar credenciales del sistema operativo.

### Paso 4: Insertar Datos Iniciales

```sql
USE SGCV
GO

-- Insertar roles
INSERT INTO Rol (descripcion, estado) VALUES
('Administrador', 1),
('Vendedor', 1),
('Encargado de Compras', 1),
('Gerente', 1)

-- Insertar provincias
INSERT INTO Provincia (descripcion) VALUES
('Buenos Aires'),
('Córdoba'),
('Mendoza'),
('Santa Fe')

-- Insertar responsables IVA
INSERT INTO ResponsableIVA (descripcion) VALUES
('Responsable Inscripto (A)'),
('Responsable no Inscripto (B)'),
('Monotributista (C)'),
('Exento (E)')

-- Insertar categorías
INSERT INTO Categoria (descripcion, estado) VALUES
('Electrónica', 1),
('Alimentos', 1),
('Bebidas', 1),
('Accesorios', 1)
```

---

## Configuración del Proyecto

### Paso 1: Descargar el Proyecto

1. Clonar repositorio:
   ```powershell
   git clone https://github.com/maxgit123/SGCV.git
   ```

2. O descargar como ZIP desde GitHub y extraer

### Paso 2: Abrir Solución en Visual Studio

1. Abrir Visual Studio
2. File > Open > Project/Solution
3. Navegar a: `SGCV\SGCV.sln`
4. Click "Open"

### Paso 3: Configurar Conexión a Base de Datos

Archivo: `CapaDatos\Conexion.cs`

```csharp
public static class Conexion
{
    // CAMBIAR LA CADENA DE CONEXIÓN SEGÚN TU ENTORNO

    public static string ObtenerCadenaConexion()
    {
        // Opción 1: Windows Authentication
        return "Server=.\\SQLEXPRESS;Database=SGCV;Integrated Security=true;";

        // Opción 2: SQL Server Authentication
        // return "Server=.\\SQLEXPRESS;Database=SGCV;User Id=sgcv_user;Password=SgcvPass123!;";

        // Opción 3: Servidor remoto
        // return "Server=192.168.1.100\\SQLEXPRESS;Database=SGCV;Integrated Security=true;";
    }
}
```

**Cambios según tu configuración:**

| Componente | Cambiar a |
|-----------|----------|
| `SQLEXPRESS` | Tu instancia de SQL Server |
| `SGCV` | Nombre de tu BD |
| `sgcv_user` | Usuario SQL Server (si aplica) |
| `SgcvPass123!` | Contraseña de usuario |
| `localhost` | IP de servidor remoto (si aplica) |

### Paso 4: Actualizar NuGet Packages

1. Tools > NuGet Package Manager > Package Manager Console
2. Ejecutar:
   ```powershell
   Update-Package
   ```

3. O si es necesario reinstalar:
   ```powershell
   Reinstall-Package
   ```

---

## Compilación del Proyecto

### Paso 1: Compilar Solución

1. Build > Build Solution
2. O presionar `Ctrl + Shift + B`
3. Esperar a que se complete (0 errores esperados)

### Paso 2: Verificar Errores

Si hay errores:

1. Verificar que el archivo `Conexion.cs` está correctamente configurado
2. Verificar que SQL Server está ejecutándose
3. Verificar que la base de datos existe
4. Limpiar y reconstruir: Build > Clean Solution > Build Solution

### Paso 3: Compilación Release (Opcional)

Para generar ejecutable optimizado:

1. Seleccionar "Release" en Configuration Manager
2. Build > Build Solution
3. El ejecutable estará en: `CapaPresentacion\bin\Release\`

---

## Ejecución de la Aplicación

### Opción 1: Desde Visual Studio

1. Press `F5` o Click en "Start Debugging" (botón verde ▶)
2. Esperar a que se compile y ejecute
3. Aparecerá ventana de login

### Opción 2: Desde Explorador de Archivos

1. Navegar a: `CapaPresentacion\bin\Debug\`
2. Ejecutar: `CapaPresentacion.exe`

### Opción 3: Crear Acceso Directo

1. Click derecho en `CapaPresentacion.exe`
2. "Send to" > "Desktop (create shortcut)"
3. Double-click para ejecutar

---

## Primer Login

### Crear Usuario Administrador

Si la BD está vacía, crear usuario de prueba con SQL Server Management Studio:

```sql
USE SGCV
GO

-- Primero crear un rol si no existe
INSERT INTO Rol (descripcion, estado)
VALUES ('Administrador', 1)

-- Generar hash de contraseña desde C# o usar ejemplo
-- Para simplificar, usar una contraseña de ejemplo hasheada

INSERT INTO Usuario (documento, nombre, apellido, clave, idRol, estado)
VALUES (
    '12345678',
    'Admin',
    'Usuario',
    'HASH_AQUI', -- Usar Hash.Generar("admin123") desde código C#
    1,
    1
)
```

**Para obtener el hash de contraseña:**

1. Crear programa de prueba simple o
2. Usar PowerShell script proporcionado:

```powershell
# Script en PowerShell para generar hash PBKDF2
Add-Type -AssemblyName System.Security
$password = Read-Host "Ingrese contraseña"
$bytes = [System.Text.Encoding]::UTF8.GetBytes($password)
# ... (ver detalles en sección de utilidades)
```

### Credenciales de Prueba

- **Usuario:** `12345678`
- **Contraseña:** `admin123`

---

## Verificación de Instalación

### Checklist

- [ ] Visual Studio instalado y ejecutándose
- [ ] SQL Server instalado y ejecutándose
- [ ] SSMS instalado y puede conectar a BD
- [ ] Base de datos SGCV creada
- [ ] Todas las tablas creadas
- [ ] Datos iniciales insertados
- [ ] Archivo `Conexion.cs` configurado
- [ ] Solución compilada sin errores
- [ ] Aplicación se ejecuta sin crashes
- [ ] Login funciona con usuario de prueba

---

## Solución de Problemas

### Error: "Cannot connect to database"

**Solución:**
1. Verificar que SQL Server está ejecutándose (services.msc)
2. Verificar cadena de conexión en `Conexion.cs`
3. Verificar que la base de datos existe
4. Verificar permisos de usuario

### Error: "Login failed for user 'sa'"

**Solución:**
- Cambiar Authentication mode en Conexion.cs a Windows Authentication

### Error: "Database does not exist"

**Solución:**
1. Abrir SSMS
2. Crear base de datos manualmente ejecutando scripts
3. Insertar datos iniciales

### La aplicación se abre pero no funciona

**Solución:**
1. Verificar Output window para mensajes de error
2. Debuggear presionando F5
3. Revisar logs si existen
4. Verificar datos en BD

### Error: "NuGet packages not restored"

**Solución:**
1. Tools > NuGet Package Manager > Manage NuGet Packages for Solution
2. Click "Restore"
3. O ejecutar: `Update-Package`

---

## Configuración Recomendada para Desarrollo

### Visual Studio Settings

1. Tools > Options > General
   - ☑ Show status bar
   - ☑ Close button shows all documents

2. Tools > Options > Projects and Solutions
   - ☑ Show Output window when build starts

### SQL Server Settings

1. En SSMS, Settings > Backups
   - Configurar backups automáticos diarios
   - Ubicación: `C:\Backups\`

---

## Próximos Pasos

1. Leer `AGENTS.md` para entender arquitectura de agentes
2. Revisar `API.md` para métodos disponibles
3. Leer `DATABASE.md` para esquema de BD
4. Comenzar con desarrollo según `README.md`

---

## Contacto y Soporte

Para problemas o consultas:

- **Repositorio:** https://github.com/maxgit123/SGCV
- **Issues:** GitHub Issues
- **Email:** maxgit123@example.com

---

**Última actualización:** Diciembre 2024
**Versión:** 1.0
**Plataforma:** Windows 10/11, SQL Server 2019+, .NET Framework 4.7+
