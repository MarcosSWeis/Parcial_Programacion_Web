const baseUrlApi = "http://localhost:5000/api";
const VehiculoControllerPaht = "/Vehiculo";
document.addEventListener("DOMContentLoaded", () => {
  //creo la tabla
  crearCabeceraTabla();

  //busco por defecto todos los vehiculos
  getAll();

  //formulario para consultar un vehiculo por id
  formBuscarVahiculoById = document.getElementById("formGetIdVehiculo");
  formBuscarVahiculoById.addEventListener("submit", (e) => {
    e.preventDefault();
    let vehiculoInput = document.getElementById("vehiculo");
    let idVehiculo = vehiculoInput.value;
    getVehiculoById(idVehiculo);
  });

  formBuscarVahiculoById = document.getElementById("formDeleteByIdVehiculo");
  formBuscarVahiculoById.addEventListener("submit", (e) => {
    e.preventDefault();
    let vehiculoInput = document.getElementById("deleteVehiculo");
    let idVehiculo = vehiculoInput.value;
    if (idVehiculo != "" && idVehiculo != "0") {
      DeleteById(idVehiculo);
    }
  });

  //boton para volcer a buscar todos
  btnVerTodos = document.getElementById("verTodos");
  btnVerTodos.addEventListener("click", (e) => {
    e.preventDefault();
    LimpiarTabla();
    getAll();
  });

  var btnCrear = document.getElementById("crear");
  var btnActualizar = document.getElementById("actualizar");
  var formCrear = document.getElementById("formCrear");
  let idVehiculo = document.getElementById("idVehiculoUpdate");

  btnCrear.addEventListener("click", function () {
    if (formCrear.style.display == "none") {
      formCrear.style.display = "block";
      idVehiculo.style.display = "none";
    } else {
      formCrear.style.display = "none";
      idVehiculo.style.display = "block";
    }
  });
  btnActualizar.addEventListener("click", function () {
    if (formCrear.style.display == "none") {
      formCrear.style.display = "block";
      idVehiculo.style.display = "block";
    } else {
      formCrear.style.display = "none";
      idVehiculo.style.display = "none";
    }
  });

  formCrear.addEventListener("submit", function (event) {
    event.preventDefault();

    let metodo = "post";
    let url = baseUrlApi + VehiculoControllerPaht;
    let statusCode = 201;

    let idVehiculo = parseInt(document.getElementById("inputIdVehiculo").value);
    let marca = document.getElementById("marca").value;
    let modelo = document.getElementById("modelo").value;
    let tipoVehiculo = parseInt(document.getElementById("tipoVehiculo").value);
    let peso = parseInt(document.getElementById("peso").value);
    let fechaLanzamiento = new Date(document.getElementById("fechaLanzamiento").value);
    let cantidadRuedas = parseInt(document.getElementById("cantidadRuedas").value);
    let rodado = parseInt(document.getElementById("rodado").value);
    let presionMaximaAire = parseInt(document.getElementById("presionMaximaAire").value);
    let altoLlanta = parseInt(document.getElementById("altoLlanta").value);
    let anchoLlanta = parseInt(document.getElementById("anchoLlanta").value);
    let data = {
      marca: marca,
      modelo: modelo,
      tipoVehiculo: tipoVehiculo,
      peso: peso,
      fechaLanzamiento: fechaLanzamiento.toISOString(),
      cantidadRuedas: cantidadRuedas,
      ruedaId: 0,
      rueda: {
        rodado: rodado,
        presionMaximaAire: presionMaximaAire,
        altoLlanta: altoLlanta,
        anchoLlanta: anchoLlanta,
      },
    };
    if (idVehiculo != 0) {
      metodo = "put";
      url = url + "/" + idVehiculo;
      statusCode = 200;
      data.id = idVehiculo;
    }

    let webApi = new XMLHttpRequest();

    webApi.open(metodo, url, true);
    webApi.setRequestHeader("Content-Type", "application/json");

    webApi.addEventListener("load", () => {
      if (webApi.status == statusCode) {
        ocultarFormCrear();
        response = JSON.parse(webApi.response);
        getVehiculoById(response.id);
      }
    });

    webApi.send(JSON.stringify(data));
  });
});

function ocultarFormCrear() {
  document.getElementById("formCrear").style.display = "none";
}

function getAll() {
  let path = "/Vehiculo";

  let webApi = new XMLHttpRequest();
  let ur = baseUrlApi + path;

  webApi.open("get", baseUrlApi + path, true);

  webApi.addEventListener("load", () => {
    if (webApi.status == 200) {
      let response = JSON.parse(webApi.response);
      let table = document.getElementById("table_home");
      let tbody = table.querySelector("tbody");
      for (let i = 0; i < response.length; i++) {
        let tr = document.createElement("tr");

        let id = document.createElement("th");
        id.textContent = response[i].id;
        tr.appendChild(id);

        let marca = document.createElement("th");
        marca.textContent = response[i].marca;
        tr.appendChild(marca);

        let modelo = document.createElement("th");
        modelo.textContent = response[i].modelo;
        tr.appendChild(modelo);

        let tipoVehiculoString = document.createElement("th");
        tipoVehiculoString.textContent = response[i].tipoVehiculoString;

        tr.appendChild(tipoVehiculoString);

        let peso = document.createElement("th");
        peso.textContent = response[i].peso + " kg";
        tr.appendChild(peso);

        tbody.appendChild(tr);
      }

      table.appendChild(tbody);
    }
  });
  webApi.send();
}
function getVehiculoById(id) {
  let path = "/Vehiculo";

  let webApi = new XMLHttpRequest();
  let urlCompleta = baseUrlApi + path + "/" + id;

  webApi.open("get", urlCompleta, true);

  webApi.addEventListener("load", () => {
    if (webApi.status == 200) {
      let response = JSON.parse(webApi.response);
      LimpiarTabla();
      let table = document.getElementById("table_home");
      let tbody = table.querySelector("tbody");
      let tr = document.createElement("tr");

      let id = document.createElement("th");
      id.textContent = response.id;
      tr.appendChild(id);

      let marca = document.createElement("th");
      marca.textContent = response.marca;
      tr.appendChild(marca);

      let modelo = document.createElement("th");
      modelo.textContent = response.modelo;
      tr.appendChild(modelo);

      let tipoVehiculoString = document.createElement("th");
      tipoVehiculoString.textContent = response.tipoVehiculoString;

      tr.appendChild(tipoVehiculoString);

      let peso = document.createElement("th");
      peso.textContent = response.peso + " kg";
      tr.appendChild(peso);

      tbody.appendChild(tr);

      table.appendChild(tbody);

      tbody.appendChild(tr);
    }
  });
  webApi.send();
}

function crearVehiculo() {}
function crearCabeceraTabla() {
  const CabeceraApi = {
    ID: "Id",
    MARCA: "Marca",
    MODELO: "Modelo",
    TIPODEVEHICULO: "Tipo de vehiculo",
    PESO: "Peso",
  };
  let table = document.getElementById("table_home");
  let thead = document.createElement("thead");
  let tbody = document.createElement("tbody");
  let tr = document.createElement("tr");
  Object.keys(CabeceraApi).forEach((cabecera) => {
    let th = document.createElement("th");
    th.textContent = cabecera;
    tr.appendChild(th);
  });
  thead.appendChild(tr);
  table.appendChild(thead);
  table.appendChild(tbody);
}
function LimpiarTabla() {
  document.getElementById("table_home").querySelector("tbody").innerHTML = "";
}

function DeleteById(id) {
  let webApi = new XMLHttpRequest();
  let urlCompleta = baseUrlApi + VehiculoControllerPaht + "/" + id;

  webApi.open("delete", urlCompleta, true);

  webApi.addEventListener("load", () => {
    if (webApi.status == 200) {
      LimpiarTabla();
      getAll();
    }
  });
  webApi.send();
}
