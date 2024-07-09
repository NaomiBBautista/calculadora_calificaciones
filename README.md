# calculadora_calificaciones
Desarrollo de una aplicación móvil utilizando .NET Multi-platform App UI (.NET MAUI)
## VISTA
La aplicación tendrá tres páginas
#### INICIO 
Página de portada con libre diseño donde se usen imágenes, fuentes externas y fondo degradado.

#### MATERIA 
Página para calcular la calificación de una materia, siguiendo las siguientes especificaciones:
* Solicitar nombre de la materia
* Solicitar tres rubros a calificar, como por ejemplo: *asistencia, tareas, examen*.
* Solicitar el valor para cada rubro, validando que los números ingresados sean del 1-100, además de que la suma de estos sea == 100.
* Solicitar calificación para cada rubro, validando que los números ingresados sean del 1-10.
* Mostrar al usuario la calificación final de la materia, validando que esta se encuentre en un rango etre 1-10.
  
#### SEMESTRE
Página para calcular la calificación del semestre de una materia, con los siguientes requerimientos:
* Solicitar nombre de la materia.
* Solicitar el valor para cada parcial, considerando tres parciales y verificando que los números ingresados sean del 1-100, además de que la suma de estos sea == 100.
* Solicitar calificación para los dos primeros parciales, verificando ue los números ingresados sean del 1-10.
* Mostrar al usuario la calificación que necesita para sacar 6 y la que necesita para sacar 10.
* Si todavía puede sacar 10 se muestra mensaje de aliento, de lo contrario, se muestra otro mensaje de consolación.

## FUNCIONALIDAD
La aplicación debe contar con las siguientes especificaciones:
* Usar el patrón de diseño `MVVM`.
* Navegación entre paginas `TabbedPage`.

## Capturas de Pantalla
A continuación se mostrarán capturas de pantalla del resultado final, y un ejemplo al utilizarse:

**INICIO**

![Página de inicio](imagenes/inicio.png)

![Página de inicio](imagenes/inicio_ejemplo.png)


**MATERIA**

![Página de materia](imagenes/materia.png)

![Página de materia](imagenes/materia_ejemplo.png)


**SEMESTRE**

![Página de semestre](imagenes/semestre.png)

![Página de semestre](imagenes/semestre.png)
