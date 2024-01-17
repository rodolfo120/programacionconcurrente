package main

import (
    "fmt"
    "math"
)

func main() {
    base := 2.0
    exponente := 3.0
    resultado := math.Pow(base, exponente)
    fmt.Printf("%v elevado a la %v es igual a %v\n", base, exponente, resultado)
}
