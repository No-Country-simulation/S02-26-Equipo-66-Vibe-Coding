# Equipo S02-26-Equipo-66-Vibe-Coding
Simulación Laboral de No Country - Febrero 2026: Plataforma de simulación y entrenamiento para cirugía robótica

# Justina: Simulador de Operación Quirúrgica con Robot
## Proyecto de Simulación de Operación Renal Mínimamente Invasiva

### Visión del Producto
Desarrollar una plataforma digital de simulación que permita a los cirujanos ensayar trayectorias de las intervenciones renales que realizarán posteriormente con un robot quirúrgico.
Objetivos de esta plataforma:
- Que el Operador Humano pueda simular el control del brazo robotico.
- Que el Operador Humano pueda interactuar con la interfaz de usuario (UX) familiarizándose con el mismo en un entorno seguro (dado que es una simulación)
- Recopilar métricas para conocimiento y posterior evaluación de desempeño de la sesión.
- Corroborar la asimilación y viabilidad del Sistema para luego, con posterioridad, aplicarlo a un robot propiamente dicho

### Conformación del Equipo
* **Analista Programadora C# Vibe Coding: [Beatriz Ebert Desarrolladora .NET ](https://github.com/Beaebert):** Desarrollo Analisis de Requerimientos, desarrollo de documentación (markdown) y arquitectura del software en C# .NET 10
* **Diseñadores UX/UI:** Diseño de interfaz de control y feedback visual médico.
* **Data Analyst y Data Engineer: [Juan Paulatino](https://github.com/juan-paulatino):** Entrenamiento de modelos para análisis de trayectorias.
* **Desarrolladores No-Code:** Desarrollo de Dashboards de métricas y prototipado rápido de vistas secundarias.


### Stack Tecnológico
se estima utilizar 
* **Core Engine:** C# (.NET 10/MAUI o Blazor para portabilidad).
* **IA:** Python (Data Pipelines) con integración vía API/JSON.
* **UI Prototyping:** Figma & Herramientas No-Code (Bubble/FlutterFlow) para el panel de control del cirujano.

### Arquitectura de la Plataforma
Se evalua realizar el funcionamiento interno con la arquitectura en capas, para que las funcionalidades sean independientes del equipamiento o base de datos que se utilice, anticipando que en el futuro pueda ser reemplazado el mando o el servidor que van a estar conectados.

### User Story Actor Cirujano 
Se considera como principal usuario directo del simulador al médico cirujano que en el futuro se encontrará en la situación de operar el brazo robot con la interfaz del simulador.
#### **Título:** Control de precisión del efector final (pinza) en entorno 3D.
#### **Actor:** Médico Cirujano.
**Descripción:**
Como cirujano especialista en intervenciones renales,
Quiero una simulación de uso del sistema de pinza robótica, 
Para ensayar de forma segura el abordaje a riñón con el mando y evitar colisiones accidentales en otras zonas que puedan ocasionar daños.

**Criterios de Aceptación:**
1. La interfaz no debe de estar saturada de colores estridentes o agotadores para la vista, hay intervenciones que pueden tomar tiempo focalizando la visión.
2. Debe de poder generar una señal que alerte que se está saliendo del área necesaria (por laterales o profundidad)
3. La plataforma guarda el trayecto realizado por el operador, y cuántas veces ha tenido alertas