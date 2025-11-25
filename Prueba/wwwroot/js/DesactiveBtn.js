function desactivarBoton(boton) {
    boton.disabled = true;
    boton.innerText = "Procesando...";
}

$(document).ready(function () {
    $('form').on('submit', function () {
        if (this.checkValidity()) {
            var boton = $(this).find('button[type="submit"]');
            if (boton.length) {
                desactivarBoton(boton[0]);
            }
        }
    });
});