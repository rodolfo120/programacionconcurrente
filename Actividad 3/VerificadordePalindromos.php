$palabra = "reconocer";
$reverso = strrev($palabra);

if ($palabra == $reverso) {
    echo "La palabra es un palíndromo.";
} else {
    echo "La palabra no es un palíndromo.";
}
