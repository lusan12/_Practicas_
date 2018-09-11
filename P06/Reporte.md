## Universidad Nacional Autónoma de México
### Facultad de Ingeniería
#### Técnicas de Programación
#### Sánchez Ruiz Luis Armando
##### Práctica 6 -Arreglos Unidimensionales


###### 1. Objetivos de aprendizaje
 
I. Objetivos generales:  Entender el uso, creación y manejos de los datos conocidos como arreglos unidimensionales. 
 
 
II. Objetivos específicos:
 
* Entender el funcionamiento de un arreglo. 
* Aprender a crear un arreglo. 
* Aprender los metodos para trabajar arreglos unidimensionales.
 
###### 2. Introducción

Un arreglo es el conjunto de elementos finito y ordenado más simple soportado por un lenguaje de programación. Se trata de una secuencia de objetos del mismo tipo a los cuales se puede acceder por medio de un índice y todos están agrupados bajo un mismo nombre o identificador.
Un arreglo de tamaño N contiene una serie de valores dispuestos en memoria de forma consecutiva, el índice representa la posición relativa de los datos en la memoria. La primer posición del arreglo puede corresponder al índice 0 o 1 (dependiendo del lenguaje de programación) y la última posición correspondería, respectivamente, al índice N-1 o N.

###### 3. Actividades

* El alumno utilizará una estructura de datos del tipo arreglo para generar un registro de datos de algún tipo de objeto utilizando al menos 3 operaciones fundamentales para el manejo de arreglos, incluyendo el manejo de al menos 2 excepciones.

* El alumno realizará operaciones con los valores almacenados en al menos dos arreglos, utilizando para ello las estructuras de control más adecuadas.

###### 4. Desarrollo


' 

            int[] datos = { 10, 20, 30, 40, 50 };
            int[] datos2 = { 100, 200, 300, 400, 50 };

            int capacidad = 5;         
            int cantidad = 4;
            int res;
            int res2;

            int i;                     

    
            Console.WriteLine("Elementos del Arreglo 1");
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", datos[i]);
            Console.WriteLine();

            
            for (i = 0; i < cantidad; i++)
                if (datos[i] == 10)
                    Console.WriteLine("Numero diez (10) encontrado en la posición {0} ", i + 1);

            
            int maximo = datos[0];
            for (i = 1; i < cantidad; i++)
                if (datos[i] > maximo)
                    maximo = datos[i];
            Console.WriteLine("El numero mas grande es {0} ", maximo);

            
            Console.WriteLine("Añadiendo seis (6) al final");
            if (cantidad < capacidad)
            {
                datos[cantidad] = 6;
                cantidad++;
            }

            
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", datos[i]);
            Console.WriteLine();

           
            Console.WriteLine("Eliminando el segundo dato del primer arreglo");
            int posicionBorrar = 1;
            for (i = posicionBorrar; i < cantidad - 1; i++)
                datos[i] = datos[i + 1];
            cantidad--;

            
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", datos[i]);
            Console.WriteLine();

            
            if (cantidad < capacidad)
            {
                Console.WriteLine("Insertando otro treinta (30) en la posición 3");
                int posicionInsertar = 2;
                for (i = cantidad; i > posicionInsertar; i--)
                    datos[i] = datos[i - 1];
                datos[posicionInsertar] = 30;
                cantidad++;
            }

            
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", datos[i]);
            Console.WriteLine();


            res = datos[0] * datos[1] * datos[2];
            Console.WriteLine(("Multiplicando los elementos del arreglo 1" + datos[0] + ("*") + datos[1] + ("*") + datos[2]) + (" es =" + res));

            Console.WriteLine("Elementos del Arreglo 2");
            for (i = 0; i < cantidad; i++)
                Console.Write("{0} ", datos2[i]);
            Console.WriteLine();

            res2 = datos2[0] * datos2[1] * datos2[2];
            Console.WriteLine(("Multiplicando los elementos del arreglo 1 y 2 " + datos[0] + ("*") + datos2[1] + ("*") + datos[2]) + (" es =" + res2));


            Console.ReadKey();
        }
    }

}'
