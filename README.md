# Escuela de Natación AquaVida

Proyecto académico desarrollado con **ASP.NET Core MVC, C#, Razor, HTML, CSS, Bootstrap y JavaScript**.

## Funcionalidades

- Página de inicio adaptable con programas y horarios de referencia.
- Formulario de inscripción con validación del lado del servidor mediante Data Annotations.
- Acciones GET y POST en `InscripcionesController`.
- Vista de confirmación que muestra los datos procesados.
- Diseño adaptable con Bootstrap 5 y estilos propios.
- Imagen ilustrativa SVG local.

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
