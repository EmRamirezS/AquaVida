// Interacción sencilla: confirma antes de enviar el formulario de inscripción.
document.addEventListener('DOMContentLoaded', () => {
    const form = document.getElementById('inscripcionForm');
    if (!form) return;

    form.addEventListener('submit', (event) => {
        if (!form.checkValidity()) {
            event.preventDefault();
            event.stopPropagation();
        }
        form.classList.add('was-validated');
    });
});
