# 🏁 Sprint Log 01: Discovery & Arquitectura

**Fecha Inicio del Sprint:** Lunes 02/02/2026
**Fecha Cierre del Sprint:** Jueves 05/02/2026
**Estado:** ✅ Finalizado
**Scrum Master (Acting):** Analista Programadora C# [Beatriz Ebert Desarrolladora .NET ](https://github.com/Beaebert)

## 🎯 Objetivo del Sprint
Comprender los requerimientos del desafío "Justina", conformar el equipo de trabajo y conocer el dominio de conocimiento de los miembros del equipo, definir el stack tecnológico. Definir la arquitectura del software y su lugar a habitar (local o nube).

## 📅 Bitácora Diaria (Daily Log)

### Lunes 02/02 - Kick-off & Análisis
* **Actividad:** Reunión inicial de los 7 integrantes, conocerse entre sí y sus dominios de conocimiento. Lectura de requerimientos del desafío.
* **Resultados:**
    * Entendimiento del problema: Se busca validar software y UX, no construir hardware.
    * Identificación de roles: 1 Dev C# (Vibe Coding), 3 UX/UI, 1 No-Code, 2 Data Engineer.
* **Bloqueos:** Desconocimiento general del dominio médico y falta de roles de gestión (Tech Leader,Project Manager, Product Owner y Scrum Master).

### Martes 03/02 - Investigación Asíncrona
* **Actividad:** Trabajo individual de investigación.
* **Resultados:**
    * Investigación sobre robots quirúrgicos (Da Vinci) y telemetría médica.
    * Revisión de herramientas disponibles.

### Miércoles 04/02 - Definición Técnica
* **Actividad:** Reunión para definir la Arquitectura y el Stack Tecnológico.
* **Decisiones Clave:**
    * **Backend/Core:** Se usará **C# con Clean Architecture** y metodología Vibe Coding (Antigravity + IA) para la lógica compleja.
    * **Documentación:** Se aprueba el uso de Markdown en GitHub gestionado por la Analista Programadora C#.
* **Conflicto Resuelto:** Se visualizaron ideas gráficas con el equipo de UX/UI y se alineó con el Data Engineer para definir las métricas básicas (posición/tiempo) que deberían obtenerse antes de implementar sensores complejos (térmicos, presión, etc).

### Jueves 05/02 - Cierre de Sprint & Demo Técnica (Herramientas)
* **Actividad:** Revisión de repositorio y Pruebas de Concepto (PoC) de herramientas No-Code.
* **Prueba en Vivo (Bubble.io):**
    * Se testeó la generación automática de interfaces mediante el Agente de IA de Bubble.
    * **Resultado:** La velocidad de construcción es excelente, pero la desarrolladora No-Code detectó una limitación crítica: **No permite descargar el código fuente (Vendor Lock-in).**
* **Análisis de Alternativa (FlutterFlow):**
    * Se propuso investigar FlutterFlow para el próximo Sprint, ya que permite exportar código (Dart), garantizando la propiedad intelectual del software (vital para Healthtech).
* **Definición de MVP:**
    * La primera función será "Mover Puntero" (Mouse follow) sobre un canvas, conectando el Frontend con el Backend C#.

## 📊 Retrospectiva del Sprint 01

### 👍 Lo que hicimos bien (Start doing)
* Logramos organizarnos y documentar el proceso sin tener un Project Manager y Scrum Master asignado.
* Realizamos pruebas reales de herramientas (Bubble) en lugar de solo debatir teóricamente.
* La propuesta de C# como "Motor Lógico" fue aceptada para dar robustez al No-Code.

### 👎 Lo que debemos mejorar (Stop doing)
* Evitar divagar en funcionalidades futuristas (sensores) cuando no tenemos el movimiento básico.
* Agregar datos en base a funcionalidades no solicitadas en los requerimientos o de hardware no mencionado ni disponible.
* Acelerar la decisión de diseño en Figma para no bloquear al desarrollo.

## ⏭️ Plan para Sprint 02 (Lunes 09/02)
1.  **C#:** Codificar clase `SurgicalRobot` y lógica de colisión (Vibe Coding).
2.  **No-Code:** Definir herramienta final (Bubble vs FlutterFlow) tras prueba de exportación.
3.  **UX:** Entregar Mockup de "Pantalla de Cirugía" con medidas (X,Y).
4.  **Integración:** Definir contrato JSON final para Data Engineer.