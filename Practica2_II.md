
# Práctica 2: Script y física Unity
## Ejercicio 1. Crear una escena simple sobre la que probar diferentes configuraciones de objetosfísicos en Unity. La escena debe tener un plano a modo de suelo, una esfera y un cubo.
### - a. Ninguno de los objetos será físico.
	Esto lo hice dejandolos como me venían por defecto, ya que al crear la esfera y el cubo te vienen sin físicas.
![Gif](https://github.com/alu0101017396/practica2_II/blob/main/gif/apartado_a.gif)
### - b. La esfera tiene físicas, el cubo no.
	Esto lo hice a través de la pestaña de añadir un componentes, dandole a la opción de física.
![Gif](https://github.com/alu0101017396/gifs_practica2/blob/main/gif/apartado_b.gif)

### - c. La esfera y el cubo tienen físicas.
	La realice de la misma forma que el apartado b.
![Gif](https://github.com/alu0101017396/gifs_practica2/blob/main/gif/apartado_c.gif)
### - d. La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo.
	La masa de la esfera la cambie en la pestaña que te sale sobre físicas. Aumentar la masa de la esfera lo que hace es que en caso de colisión, la esfera va a moverse menos.
![Gif](https://github.com/alu0101017396/gifs_practica2/blob/main/gif/apartado_d.gif)
### - e. La esfera tiene físicas y el cubo es de tipo IsTrigger.
	En este caso esto ahce que el cubo no colisione con nada del escenario, haciendo que en este caso, la esfera le atraviese.
![Gif](https://github.com/alu0101017396/gifs_practica2/blob/main/gif/apartado_e.gif)
### - f. La esfera tiene físicas, el cubo es de tipo IsTrigger y tiene físicas.
	En este caso ambos caen por el peso de la gravedad, pero el cubo al ser IsTrigger no colisiona y se sale del terreno.
![Gif](https://github.com/alu0101017396/gifs_practica2/blob/main/gif/apartado_f.gif)
### - g. La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo, se impide la rotación del cubo sobre el plano XZ.
	En este caso el cubo, pese a caer encima de una esfera, no se cae de encima suya.
![Gif](https://github.com/alu0101017396/gifs_practica2/blob/main/gif/apartado_g.gif)

## Ejercicio 2. Sobre la escena que has trabajado ubica un cubo que represente un personaje quevas a mover. Se debe implementar un script que haga de CharacterController.Cuando el jugador pulse las teclas de flecha (o aswd) el jugador se moverá en ladirección que estos ejes indican.
### - a. Crear un script para el personaje que lo desplace por la pantalla, sin aplicarsimulación física.
	Esto lo realice sumando o restandole a transform.position el producto de la posición del Vector3.forward, Time.deltaTime y la velocidad de movimiento que tendrá.
![Gif](https://github.com/alu0101017396/gifs_practica2/blob/main/gif/2a.gif)
### - b. Agregar un campo público que permita graduar la velocidad del movimientodesde el inspector de objetos.
Esto lo hice añadiendole un public int al principio de la clase del script.  
![Foto con atributo](https://github.com/alu0101017396/practica2_II/blob/main/foto/Captura.PNG)
### - c. Estar a la escucha de si el usuario ha utilizado los ejes virtuales. Elegircuáles se va a permitir utilizar: flechas, awsd.
Esto lo hice añadiendo a las axis actuales del proyecto una horizontal y vertical mas correspondientes a i, j, k , l.

## Ejercicio 3. Sobre la escena que has trabajado programa los scripts necesarios para lassiguientes acciones:

### - a. Se deben incluir varias esferas sobre la escena. Cada vez que el objeto jugador colisione con una esfera se debe cambiar su color, y si se trata de una esfera de tipo A, y se pulsa la barra espaciadora el jugador impulsa la esfera hacia fuera de él.
Esto lo realice creando un tag llamado "A" y asignandoselo a ciertas esferas, les añadi fisicas y un script a cada una en la cual con cualquier colisión usando OnCollisionEnter() cambiarian a un color aleatorio, mientras que si es de tipo "A" y esta colisionando con un "player" al presionar espacio estas se empujarian. Esta funcionalidad la tengo implementada en OnCollisionStay(), calculando la dirección con la posición del eje del cubo.
![Gif](https://github.com/alu0101017396/gifs_practica2/blob/main/gif/3a.gif)

### - b. Las esferas deben responder a la física. Se deben incluir cilindros que se alejen del jugador cuando esté próximo.
Esto lo hice aumentando el tamaño del Collider y asignandoles un script a cada cilindro en el cual añadi una funcion OnTriggerEnter(), haciendo que cuando entrara un objeto con el tag "Player", se mueva en una dirección de la misma forma que en las esferas. Despúes, cuando el Player salga del Collider del cilindro, en un OnTriggerEnter(), le resto la misma fuerza que le añadi en la funcion de entrada.

![Gif](https://github.com/alu0101017396/gifs_practica2/blob/main/gif/3a.gif)
### - c. Ubicar un tercer objeto que sea capaz de detectar colisiones y que se mueva con las teclas: I, L, J, M.
Esto lo hice editando las axis del proyecto y añadiendoles las teclas pedidas.
![Gif](https://github.com/alu0101017396/gifs_practica2/blob/main/gif/3c.gif)
### - d. Debes ubicar cubos que que aumentan de tamaño cuando se le acerca una esfera y que disminuye cuando se le acerca el jugador.
Esto lo hice aumentando el tamaño del Collider y asignandoles un script a cada cubo en el cual añadi una funcion OnTriggerEnter(), distinguiendo en ella los tag "Sphere", "A" y "Player", y teniendo en cuenta si tiene que aumentar o reducirse.
![Gif](https://github.com/alu0101017396/gifs_practica2/blob/main/gif/3d.gif)
