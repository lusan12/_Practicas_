## Universidad Nacional Autónoma de México
### Facultad de Ingeniería
#### Técnicas de Programación
#### Sánchez Ruiz Luis Armando
##### Práctica 3 - Polimorfismo


##### 1. Objetivos de aprendizaje
 
I. Objetivos generales:  Entender qué es y para qué sirve el polimorfismo. 
 
 
II. Objetivos específicos:
 
* Aprender qué es el polimorfismo. 
* Identificar cuándo puede utilizarse el polimorfismo. 
* Aprender a redefinir los métodos de una clase base en sus clases derivadas.
 
##### 2. Introducción

El polimorfismo suele considerarse el tercer pilar de la programación orientada a objetos, además del encapsulamiento y la herencia.
Polimorfismo es una palabra que proviene del griego, significa "con muchas formas" y tiene dos aspectos diferentes:

 1. En tiempo de ejecución, los objetos de una clase derivada pueden ser
tratados como objetos de una clase base al utilizarse en lugares tales como
parámetros de métodos, colecciones o arreglos (matrices). Cuando esto
ocurre, el tipo declarado del objeto ya no es idéntico a su tipo en tiempo de
ejecución. Por ejemplo: A partir de una clase base denominada
“Transporte” podrían crearse las clases derivadas: “Automóvil”, “Barco” y
“Avión”. Por lo tanto, un método definido para trabajar con objetos de tipo
“Transporte” será también capaz de manejar objetos de cualquiera de sus
clases derivadas.

  2. Las clases base pueden definir e implementar métodos virtuales, y las clases derivadas pueden invalidarlos, lo que significa que pueden proporcionar su propia definición e implementación. En tiempo de ejecución, cuando el código del cliente llama al método, busca el tipo en tiempo de ejecución del objeto e invoca esa invalidación del método virtual. Por lo tanto, en el código fuente puede llamarse a un método en una clase base y hacer que se ejecute una versión del método de la clase derivada. Retomando el ejemplo
anterior, la clase “Transporte” podría incorporar un método virtual llamado “Mover”, de esta manera cada una de sus clases derivadas (“Automóvil”, “Barco” y “Avión”) sería capaz de implementar a su propia manera dicho método, dependiendo del medio en el cual se desplace (tierra, agua o aire, respectivamente).

Los métodos virtuales permiten trabajar de manera uniforme con distintos grupos de
objetos relacionados.

##### 3. Actividades



##### 4. Desarrollo

