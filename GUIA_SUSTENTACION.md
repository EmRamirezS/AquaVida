# Guía para la sustentación de AquaVida

## Demostración en vivo

1. Ejecuta `dotnet run` y abre la URL que aparezca en la terminal.
2. Muestra la página principal y los enlaces de navegación.
3. Entra a **Inscríbete**.
4. Intenta enviar el formulario vacío para mostrar las validaciones.
5. Completa los campos con datos ficticios y envía el formulario.
6. Explica la pantalla de confirmación y aclara que esta versión no persiste los datos.
7. Abre en VS Code `Models/Inscripcion.cs`, `Controllers/InscripcionesController.cs`, `Views/Inscripciones/Crear.cshtml` y `Views/Inscripciones/Confirmacion.cshtml`.
8. Muestra el historial de Git con `git log --oneline`.
9. Cuando esté publicado, abre el repositorio remoto y la URL pública de la aplicación.

## Explicación del recorrido de una solicitud

- El navegador solicita `GET /Inscripciones/Crear`.
- La ruta predeterminada dirige la solicitud al método `Crear` de `InscripcionesController`.
- La acción GET devuelve la vista Razor `Views/Inscripciones/Crear.cshtml`.
- El formulario envía los campos por POST.
- El model binder crea el objeto `Inscripcion` y las Data Annotations se usan para validarlo.
- Si `ModelState.IsValid` es falso, el controlador devuelve el formulario con los errores.
- Si es válido, devuelve `Confirmacion.cshtml` con el objeto recibido.

## Conceptos de Git

- **Working tree:** archivos locales que estás editando.
- **Commit:** captura de los cambios seleccionados en el historial local.
- **Push:** publica commits locales en el repositorio remoto.
- **Pull:** descarga e integra cambios del remoto en la rama local.
- **Repositorio remoto:** copia del repositorio alojada en GitHub.

## Publicación en un proveedor de alojamiento

El código fuente está preparado para publicarse, pero el despliegue requiere que el estudiante ingrese a una cuenta del proveedor y cree/configure el recurso web. Antes de entregar, confirma:

- La URL pública abre la aplicación sin iniciar sesión en el proveedor.
- El proveedor utiliza una versión de .NET compatible con `net8.0`.
- La aplicación funciona también en el entorno publicado.
- El repositorio remoto tiene los commits y el código fuente.
- El video de Teams muestra tanto la URL pública como el repositorio.

No cargues datos personales reales durante la demostración: la app es académica y no tiene almacenamiento persistente.
