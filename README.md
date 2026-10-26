# Escuela de Natación AquaVida

Proyecto académico desarrollado con **ASP.NET Core MVC, C#, Razor, HTML, CSS, Bootstrap y JavaScript**.

## Funcionalidades

- Página de inicio adaptable con programas y horarios de referencia.
- Formulario de inscripción con validación del lado del servidor mediante Data Annotations.
- Acciones GET y POST en `InscripcionesController`.
- Vista de confirmación que muestra los datos procesados.
- Diseño adaptable con Bootstrap 5 y estilos propios.
- Imagen ilustrativa SVG local.

## Requisito

Instala el SDK de .NET 8 o una versión posterior compatible con el proyecto. Descarga oficial: https://dotnet.microsoft.com/download

## Ejecutar localmente

Abre la carpeta del proyecto en Visual Studio Code y ejecuta en la terminal:

```bash
dotnet restore
dotnet run
```

Abre la URL que la terminal indique, normalmente una dirección `http://localhost:...` o `https://localhost:...`.

## Estructura MVC

- `Models/Inscripcion.cs`: propiedades y reglas de validación de la inscripción.
- `Controllers/InscripcionesController.cs`: GET muestra el formulario; POST recibe los datos, comprueba `ModelState.IsValid` y devuelve la confirmación.
- `Views/Inscripciones/Crear.cshtml`: formulario Razor.
- `Views/Inscripciones/Confirmacion.cshtml`: resumen de la información enviada.
- `Views/Home/Index.cshtml`: página de inicio.
- `wwwroot/`: CSS, JavaScript e imágenes estáticas.
- `Program.cs`: registra MVC y configura las rutas HTTP.

## Importante sobre los datos

Esta versión no usa base de datos. La información se valida y se muestra en una vista de confirmación, pero no queda almacenada de forma permanente. No utilizar para recopilar datos personales reales en producción.

## Git y GitHub

Desde la raíz de la carpeta:

```bash
git init
git add .
git commit -m "Crear estructura MVC de AquaVida"
git add .
git commit -m "Agregar formulario y validación de inscripciones"
```

Crea un repositorio vacío en GitHub y sigue las instrucciones que GitHub muestre para conectar el repositorio local. Normalmente serán parecidas a estas (reemplaza la URL por la de tu repositorio):

```bash
git branch -M main
git remote add origin https://github.com/TU-USUARIO/TU-REPOSITORIO.git
git push -u origin main
```

- **Commit:** registra una versión de los cambios en tu repositorio local.
- **Push:** envía commits al repositorio remoto.
- **Pull:** descarga e integra cambios del repositorio remoto.

## Publicación

Puedes desplegar el proyecto en un servicio que admita ASP.NET Core, por ejemplo Azure App Service. La publicación necesita una cuenta del proveedor y configuración del servicio; no se ha realizado automáticamente desde este paquete.

## Guion corto para la sustentación

> AquaVida es una aplicación de una escuela de natación construida con ASP.NET Core MVC y C#. El modelo Inscripcion define los datos y sus validaciones. El controlador tiene una acción GET que muestra el formulario y una acción POST que recibe y procesa sus datos. Si ModelState.IsValid es falso, se vuelve a mostrar el formulario con errores; si es válido, se muestra la vista de confirmación. Las vistas Razor generan la interfaz y Bootstrap ayuda a que sea adaptable. En esta versión no hay base de datos, así que la confirmación no representa un almacenamiento permanente. Git registra los cambios en commits, push los publica en GitHub y pull trae los cambios remotos. Para completar la entrega se debe publicar el proyecto en un servicio de alojamiento y mostrar la URL pública.
