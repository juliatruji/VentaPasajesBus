function removeasientos(){
    var x = document.getElementsByClassName("seleccionado");
    for (let i = 0; i < x.length; i++) {
        x[i].classList.remove("seleccionado");
    }
}

function seleccionasiento(btn, num){
    var texto = document.getElementById("textoasiento");
    removeasientos();
    texto.innerHTML = `Seleccionaste el Asiento: ${num}`;
    btn.classList.add("seleccionado");
    console.log("seleccionaste "+ num);
}

function mostrarAsientos(arraynum){
    console.log("cantidad de asientos "+ arraynum.length);
    var asientos = "";
    var contenedor = document.getElementById("idcontainerfilas");
    
    for (let i = 0; i < arraynum.length; i++) {
        if(i%4 == 0) {
            asientos += `<div class="busfila">`;
        }
        // ocupado
        var disabled = "";
        if (arraynum[i] == 1) {
            disabled = `class="disabled" disabled`;
        }
    
        asientos += `<button type="button" ${disabled} onclick="seleccionasiento(this, ${i+1})" >${i+1}</button>`;
        
        if(i>0) {
            if (i%4 == 3) {
                asientos += `</div>`;
            }
        }
        console.log(arraynum[i]);
    }
    contenedor.innerHTML=asientos;
}

// array asientos
var arrAsientos = [1, 0, 1, 1, 0, 0, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0];

mostrarAsientos(arrAsientos);
