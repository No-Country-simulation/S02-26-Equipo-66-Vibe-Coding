# 🏁 Sprint Log 02: Desarrollo del Core e Investigación de Herramientas No-Code

**Fecha Inicio del Sprint:** Sábado 07/02/2026
**Fecha Cierre del Sprint:** Jueves 12/02/2026
**Estado:** ✅ Finalizado
**Scrum Master (Acting):** Analista Programadora C# [Beatriz Ebert Desarrolladora .NET ](https://github.com/Beaebert)

## 🎯 Objetivo del Sprint
Comprender los diferentes tipos de simuladores quirúrgicos y sus características, continuar el desarrollo del core del simulador. Investigar herramientas No-Code para el desarrollo del simulador. Aprender sobre la integración de herramientas No-Code con el core del simulador. Definir el stack tecnológico.

## 📅 Bitácora Diaria (Daily Log)

### Sábado 07/02 - Investigación de simuladores quirúrgicos y sus características
* **Actividad:** Investigación de simuladores quirúrgicos y sus características.
* **Resultados:**
    * Se investigaron diferentes tipos de simuladores quirúrgicos y sus características.
    * Se determino usar FlutterFlow como herramienta No-Code para el desarrollo del simulador.
    * La desarrolladora No-Code y el equipo de UX/UI investigan sobre la integración de herramientas No-Code con el core del simulador.
    * Se definió el stack tecnológico.
* **Bloqueos:** El equipo entero no posee conocimiento en manejo de objetos 3D, por lo tanto la recreación realista será un resultado esperable en el futuro.

### Lunes 09/02 - Determinar qué se encuentra construido y qué se desarrollará en el Sprint 02
* **Actividad:** 
    * Determinar qué se encuentra construido y qué se desarrollará.
    * Se dialogó sobre el uso de herramientas No-Code para el desarrollo del simulador.
    * Se dialogó sobre la integración de herramientas No-Code con el core del simulador.
    * Se dialogó sobre el stack tecnológico.
    * Se manifestó la situación de cada uno en individual y en equipo.
    * Nuevamente se revisó el posible diseño de la interfaz de usuario.
    * Se determino cuál es la funcionalidad más compleja y con nivel de urgencia de acuerdo a los requerimientos del proyecto.

* **Resultados:**
    * Se determinó lo que se encuentra construido y qué falta por desarrollar.
    * Se determinó que el Data Engineer utilizará Python y cómo se conectara con el simulador.
    * Se determinó cómo se realizaran las pruebas del simulador.
* **Bloqueos:**
    * Falta definir qué herramientas utilizará el Data Engineer, y cómo se conectara con el simulador.
    * Falta definir cómo se realizaran las pruebas del simulador.
    * Falta tener una visión Front End con la cuál comenzar a diseñar y trabajar.

### Martes 10/02 - Crisis y Reactivación
* **Incidentes:** 
    * Salida del Data Analyst del grupo por dificultades de comunicación con diferentes idiomas (portugués y español).
    * Salida del Data Engineer. El integrante abandona el proyecto y el grupo de comunicación por diferencias de enfoque de prioridades en el MVP con el Analista Programador C#.
    * Vibe Coders y No Coders asociados al proyecto no se comunican.
    * El equipo de proyecto queda conformado por tres diseñadores UX/UI, una desarrolladora No-Code y un Analista Programador C#.

* **Actividades:**
    * **Desarrolladora No-Code:** Confirma continuidad. Se le asigna la construcción de la "Pantalla 1" (Simulador) en FlutterFlow.
    * **UX/UI Designers:** Se activan para bocetear en Figma todo lo discutido en el Sprint previo (Layout, posición de herramientas, feedback visual).
    * **Acciones de Analista Programador C# / Tech Lead:**
        * Gestión: Asume parcialmente el rol de Scrum Master para documentar todo el proceso de los sprints y acciones de cada día.
        * Investigación de Contingencia: Evalúa Radzen Blazor Studio y Blazor WebAssembly como "Plan de Emergencia" en caso de que falle la integración con FlutterFlow.
        * Backend C#: Revisión de funcionalidades existentes (Clases Robot, Gripper) para asegurar que el Core funcione independientemente.
        * Decisión de Alcance: Se elimina la dependencia de "Datos Sintéticos de Paciente" desde la Nube (Python y Google Colab). El simulador funcionará con lógica interna de C#.

* **Resultados:**
    * Se definió el plan de contingencia.
    * Se definió el plan de alcance.
    * Se definió el plan de gestión.
* **Bloqueos:**
    * No tener bocetos visuales de Front End.
    * No tener un prototipo en Figma, Miro o FlutterFlow.

### Miércoles 11/02 - Desarrollo Visual
* **Objetivo:** Primera integración visual.
* **Actividad:** 
    * **Diseñadores UX/UI:** Desarrollan un diseño de prototipo de sistema en Figma.
    * **Desarrolladora No-Code:** Desarrolla la pantalla 1 del simulador en FlutterFlow.
    * **Desarrolladora Vibe Coder Back End:** Chequear los Endpoint GET /status con Swagger.

* **Resultados:**
    * Se creo el Mockup de alta fidelidad de la zona de trabajo.
    * Se expone el Endpoint GET /status testeado en Swagger.
* **Bloqueos:** 
    * No se posee desarrollo No Code al momento.
    * El equipo esta funcionando con un solo desarrollador No Code (Front End).
    * El equipo de tres diseñadores UX/UI esta teniendo solo dos activos.

### Jueves 12/02 - Cierre de Sprint
* **Actividad:** Cierre de Sprint.
* **Resultados:**
    * Se reunieron los diseñadores UX/UI para conversar sobre la situación del proyecto, qué está sucediendo, qué se puede hacer para mejorar.
    * Se cerró el Sprint 02.
* **Bloqueos:** 
    * Faltó a la reunión de cierre de sprint el desarrollador No Code por superposición de horarios en su agenda.
    * Faltó a la reunión de cierre de sprint el desarrollador Vibe Coder Back End (Analista Programador C#) por superposición de actividades laborales.
    * No hay desarrollo en manejable en FlutterFlow.

## 📊 Retrospectiva del Sprint 02
### 👍 Lo que hicimos bien (Start doing)
* Hay una base de funcionamiento en el Back End.
* Hay un diseño de prototipo de sistema en Figma.
* El prototipo de sistema en Figma esta hecho en base a lo que se discutio en el Sprint 01.
* El prototipo de Figma posee más de una página conectadas por botones apropiados al funcionamiento.
[Prototipo de Figma](https://www.figma.com/make/lKleIf92KXBYNbQTkHredJ/Simulaci%C3%B3n-de-operaciones?p=f&t=UkjN0QbWB4jTnaos-0&preview-route=%2Fsimulation%2Fselect)

### 👎 Lo que debemos mejorar (Stop doing)
* Comnunicación asincronica.
* Constancia de trabajo.
* Manifestar complicaciones debido a responsabilidades personales.


## ⏭️ Plan para Sprint 03 (Lunes 16/02)
1.  **Integración:** Definir cómo integrar el prototipo de Figma con el Back End.
2.  **Front End:** Solucionar cómo tener algo visible del sistema.
