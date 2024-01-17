var listaDeCompras = ["Manzanas", "Leche", "Pan"]

func mostrarLista() {
    print("Lista de compras:")
    for (index, item) in listaDeCompras.enumerated() {
        print("\(index + 1). \(item)")
    }
}

mostrarLista()
