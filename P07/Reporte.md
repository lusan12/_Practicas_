## Universidad Nacional Autónoma de México
### Facultad de Ingeniería
#### Técnicas de Programación
#### Sánchez Ruiz Luis Armando
##### Práctica 7 -Arreglos Multidimensionales


##### 1. Objetivos de aprendizaje
 
I. Objetivos generales:  Entender el funcionamiento y el manejo de los arreglos
multidimensionales en un lenguaje orientado a objetos. 
 
 
II. Objetivos específicos:
 
* Implementar una matriz de algún tipo de datos básico. 
* Implementar una matriz de algún de tipo de objeto.

##### 2. Introducción

Un arreglo multidimensional se define como una colección homogénea, finita y ordenada
de datos con N dimensiones. Para hacer referencia a cada componente de un arreglo
multidimensional se requieren N índices, uno para cada dimensión. Por ejemplo, un arreglo
de dos dimensiones se trata de un arreglo multidimensional que requiere de dos índices para
hacer referencia a cada uno de sus componentes, uno para especificar la columna y otro
para el renglón.
Los arreglos multidimensionales son ampliamente utilizados en la programación debido a
que comúnmente se tiene una gran cantidad de datos, que debido a su relación entre sí sería
mucho más complicado representarlos en una sola dimensión. Por ejemplo, las imágenes
pueden ser representadas en un arreglo de tres dimensiones debido a que una parte de los
datos puede expresar el color Rojo, otra para el color Azul y por último el Verde, que al ser
combinados todos entre sí nos dan el efecto del color real en una imagen.

##### 3. Actividades

* El alumno definirá al menos dos arreglos de dos o más dimensiones para
almacenar diversos valores de datos básicos (enteros, flotantes, cadenas,
booleanos, etc.) con los cuales deberá realizar alguna operación (suma, resta,
multiplicación, concatenación, etc.).
Para el almacenamiento, consulta y modificación de los valores almacenados en
cada arreglo, así como para la visualización de los resultados generados, se
deberá implementar una interfaz gráfica de usuario que sea adecuada y fácil de
utilizar.

* El alumno definirá al menos dos arreglos de dos o más dimensiones para el
almacenamiento de objetos que deberán tener cada uno al menos dos atributos,
y deberá realizarse al menos una operación entre objetos contenidos en
diferentes arreglos.
Para el almacenamiento, consulta y modificación de los valores de los atributos
de los objetos almacenados en cada arreglo, así como para la visualización de
los resultados generados, se deberá implementar una interfaz gráfica de usuario
que sea adecuada y fácil de utilizar.

##### 4. Desarrollo





        private int[,] MatrizA;
        private int[,] MatrizB;
        private int[,] MatrizC;
        public void Cargar()
        {
            MatrizA = new int[4, 4];
            MatrizB = new int[4, 4];
            MatrizC = new int[4, 4];
            Console.WriteLine("Ingresando datos al matriz A");
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    MatrizA[i, j] = int.Parse(linea);
                }
            }
            Console.WriteLine("Ingresando datos al matriz B");
            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    MatrizB[i, j] = int.Parse(linea);
                }
            }

            for (int i = 1; i <= 2; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    MatrizC[i, j] = MatrizA[i, j] + MatrizB[i, j];
                }
            }
        }

        public void suma()
        {
            Console.WriteLine("La suma de la Matriz A y Matriz B es :");
            for (int i = 1; i <= 2; i++)
            {
                Console.Write("\n");
                for (int j = 1; j <= 2; j++)
                {
                    Console.Write(MatrizC[i, j] + "  ");
                }
            }

            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Matriz pv = new Matriz();
            pv.Cargar();
            pv.suma();
        }
    }
}

