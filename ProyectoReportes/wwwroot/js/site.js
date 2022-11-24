// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function onlyNumberKey(evt) {
    // Only ASCII character in that range allowed
    var ASCIICode = (evt.which) ? evt.which : evt.keyCode
    if (ASCIICode > 31 && (ASCIICode < 48 || ASCIICode > 57))
        return false;
    return true;
}

/*
document.getElementById("descarga").onclick = function ()
{
    var nombrearchivo = document.getElementById("nombre").value;
    nombre = nombrearchivo + ".pdf";

    var contenidoarchivo = document.getElementById("contenido").value;
    cont = contenidoarchivo;

    exportar(cont, nombre);

    alert("Sus datos fueron enviados");

    console.log("El nombre del archivo es: ", nombrearchivo);
}

function exportar(data, filename)
{
    var a = document.createElement("a");
    var contenido = data,
        blob = new Blob([contenido], { type: "octet/stream" }),
        url = window.URL.createObjectURL(blob);
    a.href = url;
    a.download = filename;
    a.click();
    window.URL.revokeObjectURL(url);
}
*/

/*function decarga(value)
{
    var backup = document.body.innerHTML;
    var content = document.getElementById(value).innerHTML;
    var tituloxd = document.getElementById("nombre").value;
    var tituloback = document.title;

    document.getElementById("resultado").style.display = "block";
    document.title = tituloxd;

    document.body.innerHTML = content;
    window.print();
    document.body.innerHTML = backup;

    document.getElementById("resultado").style.display = "none";
    document.getElementById("resultado").innerHTML = null;
    document.title = tituloback;
}

function mostrar(valor)
{
    document.getElementById("resultado").innerHTML = valor;
}*/