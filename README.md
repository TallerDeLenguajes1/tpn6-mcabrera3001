1. String es un tipo de dato por referencia, la cual representa una secuencia de caracteres.
na cadena es un objeto de tipo Cadena cuyo valor es texto. Internamente, el texto se almacena como una colección secuencial de solo 
lectura de objetos Char . No hay caracteres de terminación nula al final de una cadena de C #; por lo tanto, una cadena de C # puede 
contener cualquier número de caracteres nulos incrustados ('\ 0').

2. Secuencias de Escape: Las combinaciones de caracteres que consisten en una barra diagonal inversa ( \ ) seguida de una letra o una 
combinación de dígitos se denominan "secuencias de escape". Para representar un carácter de nueva línea, una comilla simple u otros 
caracteres de una constante de caracteres, debe utilizar secuencias de escape. Una secuencia de escape se considera un carácter individual 
y por tanto es válida como constante de caracteres.

\a	Campana (alerta)
\b	Retroceso
\f	Avance de página
\n	Nueva línea
\r	Retorno de carro
\t	Tabulación horizontal
\v	Tabulación vertical
\'	Comilla simple
\"	Comillas dobles
\\	Barra diagonal inversa
\?	Signo de interrogación literal
\ ooo	Carácter ASCII en notación octal
\x hh	Carácter ASCII en notación hexadecimal
\x hhhh	Carácter Unicode en notación hexadecimal si esta secuencia de escape se utiliza en una constante de caracteres anchos o un literal de cadena Unicode.

3. Los caracteres especiales son caracteres contextuales predefinidos que modifican el elemento de programa (una cadena literal, 
un identificador o un nombre de atributo) para que se antepongan. C# admite los siguientes caracteres especiales:

@, el carácter de identificador textual.
$, el carácter de cadena interpolada.

El carácter especial @ actúa como un identificador textual. Se puede usar de estas formas:
    Para habilitar el uso de palabras clave de C# como identificadores.
    Para indicar que un literal de cadena se debe interpretar literalmente.
