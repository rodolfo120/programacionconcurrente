let tareas = [];

function agregarTarea(tarea) {
    tareas.push(tarea);
}

function mostrarTareas() {
    console.log("Lista de tareas:");
    for (let i = 0; i < tareas.length; i++) {
        console.log(i + 1 + ". " + tareas[i]);
    }
}

agregarTarea("Hacer la compra");
agregarTarea("Estudiar para el examen");
mostrarTareas();
