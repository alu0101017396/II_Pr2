
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
