# Requerimientos, Criterios, Casos - Cuestionario

### 1. **¿Qué es un Coding Dojo?** 
- Es cuando un grupo de programadores se reúnen para trabajar un desafío de programación puesto. Su objetivo, a parte de que cada parte se divierta, es mejorar las habilidades del equipo con prácticas deliberadas, las cuales son experiencias que realmente aportan al crecimiento de las habilidades de uno. El Coding Dojo se considera exitoso cuando el ejercicio se completa en el tiempo acordado.

### 2. **Diferencia entre Requerimientos, Criterios de Aceptación y Escenarios de Prueba. Dar ejemplos a partir de un problema distinto a la referencia.**
- Mientras los requerimientos son las necesidades y restricciones que el cliente desea que maneje el producto para la solución del problema que presenta, los criterios de aceptación son los campos que validan que dichos requisitos han sido añadidos al producto y cumplen correctamente el comportamiento que se le ha otorgado. Por lo tanto, los criterios dependen de los requerimientos. Sin embargo, para detallar que los criterios de aceptación cumplen lo dicho, se realizan escenarios, los cuales son ejemplos más precisos de los criterios, y solo validan a uno en concreto.

    - Ejemplo de requerimientos: 
	    - Req. 1: La aplicación TikTok debe permitir al usuario iniciar sesión.
    - Ejemplos de criterios de aceptación:
	    - Crit 1.1: La aplicación TikTok debe decirle al usuario si el inicio de sesión se realizó con éxito.
    - Ejemplos de escenarios:
	    - Sce 1.1.1: 
            - Usuario: paquita_05 
            - Contraseña: 200245
            - “Inicio de sesión exitoso”

### 3. **De dos ejemplos de requerimientos no-funcionales, y especifique cuál es su categoría (seguridad, performance, portabilidad, etc.)**
- La aplicación TikTok puede manejarse en dispositivos móviles, como tabletas y teléfonos inteligentes. (Requerimiento no funcional de portabilidad)
- La aplicación TikTok debe consumir, en el almacenamiento interno de los dispositivos, alrededor de unos 200 a 250 MB. (Requerimiento no funcional de eficiencia)

### 4. **¿Qué es TDD?**
- TDD corresponde a las siglas de Test-Driven Development, o también conocido como Desarrollo dirigido por pruebas. Esta es una práctica de programación en donde el primer paso es redactar las pruebas, las cuales en su mayoría son unitarias, para luego escribir el código fuente guiándose de estas. Cuando las pruebas pasan, se reestructura el código.

### 5. **¿Qué son pruebas unitarias automatizadas?**
- Son un tipo de pruebas automatizadas, y estas se utilizan para revisar pequeñas unidades individuales del programa para encontrar errores dentro de este, pero sin la necesidad de que los programadores las realicen. Herramientas de automatización realizan la labor de ejecutarlas varias veces y comparar los resultados sin la necesidad de hacerlo manualmente.

### 6. **¿Cuál fue el 1er framework de pruebas unitarias y para cual lenguaje fue creado?**
- El framework SUnit es conocido como el primero de pruebas unitarias, desarrollando casos de prueba en Smalltalk, el cual es un lenguaje reflexivo de programación, es decir, un lenguaje que se inspecciona a sí misma mientras se ejecuta. El padre del XP, o programación extrema, Kent Beck, describió este framework en su libro “Simple Smalltalk Testing: With Patterns”, en 1989.

### 7. **Describa los componentes de la arquitectura xUnit**
- **Corredor de la prueba.** Este es un programa que ejecuta las pruebas que se implementa utilizando una marco de xUnit, informando los resultados de estas. 
- **Caso de prueba.** Son los campos que condicionan al programa para determinar si el comportamiento de este es favorable.
- **Accesorios de prueba.** Son los requisitos o condiciones previas que necesitan establecerse antes de ejecutar una prueba. De este modo, al finalizar, se puede volver a su estado original. 
- **Suites de prueba.** Son conjuntos de casos de pruebas que serán ejecutados a una con el fin de verificar que esta comparte ciertos comportamientos específicos. 
- **Ejecución de pruebas.** Las pruebas unitarias se ejecutan como: configuración ();  * Cuerpo de la prueba * y teardown ();  Setup() y Teardown() se encargan de iniciar y limpiar el cuerpo de la prueba. De esta forma, no se perturban los resultados de las pruebas futuras.
- **Formateador de resultados de prueba.** Como los corredores de prueba producen sus resultados en más de un formato, un formateador de resultados de prueba, tal como dice su nombre, formatea esos resultados al formato XML.
- **Afirmaciones.** También llamado aserción, es una función comprobatoria donde se ve que el estado de la prueba es verdadero frente a los resultados que se esperan. Si la afirmación falla, se arroja una excepción que detiene la ejecución.

### 8. **Indique al menos tres desventajas de las pruebas unitarias automatizadas**
- **Mayor cantidad de código por escribir.** Mientras más grande sea el proyecto, mayores pruebas unitarias se deberán de escribir, y aunque se trate de un código simple, significa mayor cantidad de código por escribir. 
- **No se pueden escribir pruebas unitarias para las interfaces de usuario.**
- **Más costosa.** Las pruebas unitarias automatizadas suelen ser más costosas que las manuales, ya que se deben invertir en herramientas y/o softwares especializados en eso.
### 9. **Indique al menos tres ventajas de las pruebas unitarias automatizadas**
- **Estabilidad en el código.** Mientras más pruebas se realicen, mayor será la confianza en el código y su estabilidad, al mejorar aquellos errores que ralentizaron el desarrollo de este.
- **Eliminan el error humano.** Como se tienen que guardar los resultados para futuras comparaciones, las pruebas unitarias automatizadas registran los resultados automáticamente, por lo que el error de escribir una conclusión desaparece al hacerlo automático.
- **Adición de funciones con facilidad.** Al realizar todas las pruebas posibles a profundidad, el equipo podrá añadir funciones nuevas sin que se estropee todo aquello codificado anteriormente, ya que las pruebas automatizadas se aseguran de esto.
#### **Bibliografía**
- *GNU Smalltalk User’s Guide: SUnit. (s. f.). gnu.org.* https://www.gnu.org/software/smalltalk/manual/html_node/SUnit.html
- *Herranz, J. I. (2022, 14 febrero). TDD como metodología de diseño de software. Paradigma Digital.* https://www.paradigmadigital.com/dev/tdd-como-metodologia-de-diseno-de-software/
- *Interactive, P. (2020, 13 abril). Automated Unit Tests: the Pros and Cons. Proclaim Interactive.* https://www.proclaiminteractive.com/blog/automated-unit-tests-the-pros-and-cons/
- *Rehkof, M. (s. f.). Pruebas de software automatizadas para la entrega continua. Atlassian.* https://www.atlassian.com/es/continuous-delivery/software-testing/automated-testing
- *Solano Martinez, L. (2012, 10 septiembre). What is Coding Dojo. Lorenzo Solano Martinez.* https://lorenzosolano.com/what-is-coding-dojo/
- *Solano Martinez, L. (2017, 18 junio). Requirements, Acceptance Criteria, and Scenarios. Lorenzo Solano Martinez.* https://lorenzosolano.com/requirements-acceptance-criteria-and/
- *tok.wiki. (s. f.). xUnidad Arquitectura de xUnityMarcos xUnit. hmong.es.* https://hmong.es/wiki/XUnit
- *WhatIsCodingDojo. (s. f.).* https://codingdojo.org. https://codingdojo.org/WhatIsCodingDojo/	