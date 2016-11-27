
 $(document).ready(function () {
            $("#botonTabla").click(function () {
               // Usamos esta línea para cancelar el postback que el botón crea
                var parametros = {
                    nombre: $("#txtNombre").val(),
                    apellido: $("#txtApellidos").val(),
                    direccion: $("#txtDireccionCorreo").val(),
                    contraseña: $("txtConfirmarContraseña").val(),
                    numero: $("txtNumero").val()
                };

                // Ahora hacemos la llamada tipo AJAX utilizando jQuery
                $.ajax({
                    type: "POST",                               // tipo de llamada (POST, GET)
                    url: "../GUI/Registro.aspx/Guardar",                // el URL del método que vamos a llamar
                    cache: true,
                    async: false,
                    data: JSON.stringify(parametros),           // los parámetros en formato JSON
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",                           // tipo de datos enviados al servidor
                    success: function () {                      // función que se va a ejecutar si el pedido resulta exitoso
                        $('#lblMensaje').text('La información ha sido guardada exitosamente.');
                    },
                    error: function (result) {
                        alert("Jodados");
                    }
                });
            });
 });


   $(document).ready(function () {
             $('#botonTabla').click(function () {
                 var nombre = $('#txtNombre').val();
                 var apellido = $('#txtApellidos').val();

                 if (nombre && (nombre != ''))
                     sendDataAjax(nombre, apellido);
             });
         });

 function sendDataAjax(nombre, apellido) {
     var actionData = "{'nombre': '" + nombre + "',   'apellido': '" + apellido + "'}";

     $.ajax(
     {
         url: "../GUI/Registro.aspx/GetDataAjax",
         data: actionData,
         dataType: "json",
         type: "POST",
         contentType: "application/json; charset=utf-8",
         success: function (msg) { alert(msg.d); },
         error: function (result) {
             alert("ERROR " + result.status + ' ' + result.statusText);
         }
     });
 };



 $(document).ready(function () {
     $('#btn1').click(function () {
         alert("Entro");
         var nombre = $('#txtNombre').val();
         var apellido = $('#txtApellidos').val();

         if (nombre && (nombre != ''))
             GurdarAjax(nombre, apellido);
     });
 });

 function GurdarAjax(nombre, apellido) {
     alert("Hola");
     var parametros = {
         nombre: $('#txtNombre').val(),
         apellido: $('#txtApellido').val(),
         email: $('#txtDireccionCorreo').val(),
         contraseña: $('txtContraseña').val(),
         numero: $('txtTelefono').val()
          
     };
     
     $.ajax({
         type: "POST",
         url: "../../GUI/Registro.aspx/Guardar",
         data:parametros,
         contentType: "application/json; charset=utf-8",
         dataType: "json",
         success: OnSuccess,
         failure: function (response) {
             alert(response.d);
         }
     });
 }
 function OnSuccess(response) {
     alert("Respuesta " + response.d);
 }