# Equipo S02-26-Equipo-66-Vibe-Coding
Simulación Laboral de No Country - Febrero 2026: Plataforma de simulación y entrenamiento para cirugía robótica.

# Justina: Simulador de Operación Quirúrgica con Robot
## Proyecto de Simulación de Operación Renal Mínimamente Invasiva

### 🎯 Visión del Producto
Desarrollar una plataforma digital de simulación que permita a los cirujanos ensayar trayectorias de las intervenciones renales que realizarán posteriormente con un robot quirúrgico.

**Objetivos de esta plataforma:**
- Que el Operador Humano pueda simular el control del brazo robótico (efector final/pinza) mediante periféricos estándar (mouse/puntero).
- Que el Operador Humano pueda interactuar con una interfaz de usuario (UX) realista, familiarizándose con el entorno de una consola quirúrgica en un ambiente seguro.
- Recopilar métricas en tiempo real para conocimiento y posterior evaluación de desempeño de la sesión (precisión, tiempos, colisiones).
- Corroborar la viabilidad lógica del sistema para, en el futuro, acoplar este "cerebro" a un robot de hardware real.

### 👥 Conformación del Equipo (Actualizada)
* **Tech Lead & Full Stack .NET Vibe Coding: [Beatriz Ebert](https://github.com/Beaebert):** Desarrollo del Core Backend (API), Frontend (Blazor), Arquitectura de Software (Analista Programadora C# .NET), y gestión ágil (Scrum Master Acting).
* **Equipo de Diseño UX/UI:** Investigación de usuario, diseño de interfaz de control, prototipado de alta fidelidad en Figma y diseño del feedback visual médico.
*(Nota: El equipo se reestructuró durante el Sprint 02, pivotando hacia un stack 100% .NET para asegurar la viabilidad del MVP tras la necesidad de absorber las tareas de Data Engineer y No-Code Developer).*

### 💻 Stack Tecnológico Definitivo
Para garantizar la entrega del MVP en los tiempos establecidos y unificar el lenguaje de desarrollo, se utiliza:
* **Backend (Core Engine & API):** C# .NET (ASP.NET Core Web API). Encargado de la lógica espacial, física, detección de colisiones y validación de zonas.
* **Frontend (Interfaz Gráfica):** Radzen Blazor WebAssembly (C#). Consolidación de la UI médica consumiendo la API en tiempo real.
* **Diseño y Prototipado:** Figma.

### 🏗️ Arquitectura de la Plataforma (Decoupled Architecture)
Para el desarrollo del MVP, el equipo ha optado por una **Arquitectura Desacoplada** basada en API REST y separación en capas. Esta decisión estratégica garantiza la escalabilidad del simulador a largo plazo:

1. **El Motor Lógico (Backend API):** Contiene el "Cerebro" del simulador. Al ser una API REST independiente, el núcleo lógico queda completamente agnóstico al hardware o a la pantalla que lo consuma.
2. **La Consola de Usuario (Frontend Blazor):** Actúa como el cliente actual que consume los datos de la API para renderizar la experiencia visual.

**🚀 Preparación para el Futuro:**
Esta estructura de capas garantiza que las funcionalidades sean independientes. Si en el futuro los stakeholders solicitan cambiar la tecnología del Frontend (ej. a React, Vue, o motores 3D como Unity) o conectar el sistema a una Base de Datos en la nube para telemetría compleja, **el núcleo Backend permanecerá intacto**. Solo será necesario conectar los nuevos clientes a los endpoints de la API existente.

### 🧑‍⚕️ User Story: Actor Cirujano 
Se considera como principal usuario directo del simulador al médico cirujano que en el futuro se encontrará en la situación de operar el brazo robot a través de la interfaz.

**Título:** Control de precisión del efector final (pinza) en entorno 2D/3D.  
**Actor:** Médico Cirujano.  

**Descripción:**
> *Como cirujano especialista en intervenciones renales, quiero una simulación de uso del sistema de pinza robótica, para ensayar de forma segura el abordaje al riñón con el mando y evitar colisiones accidentales en otras zonas que puedan ocasionar daños clínicos.*

**Criterios de Aceptación:**
1. La interfaz no debe estar saturada de colores estridentes o agotadores para la vista (foco en modos oscuros/médicos), ya que las intervenciones exigen alta concentración sostenida.
2. El sistema debe generar una señal de alerta inmediata (feedback visual) cuando el puntero sale del "área segura" o entra en zonas de riesgo (laterales o profundidad).
3. La plataforma debe calcular y mantener el estado de la simulación en tiempo real (trayectos, colisiones, herramientas activas) comunicando el Backend con el Frontend.