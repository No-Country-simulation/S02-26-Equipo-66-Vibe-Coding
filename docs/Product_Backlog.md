# 🗺️ Product Backlog - Proyecto Justina

**Versión:** 1.2
**Última actualización:** 07/02/2026
**Visión:** Plataforma de simulación quirúrgica renal minimamente invasiva para validar UX y recopilar métricas de precisión antes de la construcción de hardware robótico con dicho sistema.

---

## 🚀 Épica 1: MVP - Core de Simulación (Prioridad Máxima)
*Objetivo: Lograr que el "robot" (abstracto en estas instancias, probablemente un puntero en una pantalla) se mueva, respete límites y genere datos básicos.*

| ID | Prioridad | Historia de Usuario / Tarea Técnica | Estado |
|:---|:---:|:---|:---|
| **US-01** | 🔥 Alta | **[Simulación]** Como cirujano, quiero mover un puntero (pinza) con el mouse y ver su respuesta en pantalla sin latencia. | 🚧 En Progreso |
| **US-02** | 🔥 Alta | **[Seguridad]** Como cirujano, quiero ver una alerta visual si la pinza toca una "Zona Prohibida" (Colisión/Bounding Box). | 📅 Pendiente |
| **US-03** | 🔥 Alta | **[Data]** Como Data Engineer, quiero obtener un JSON estandarizado con coordenadas (X,Y) y estado del robot para el pipeline de IA. | 📅 Pendiente |
| **TEC-01** | 🔥 Alta | **[Backend]** Implementar Clean Architecture en C# (Domain, Application, Infra) y exponer Web API. | ✅ Completado |
| **TEC-02** | 🔥 Alta | **[Integración]** Configurar CORS y Swagger en la API para permitir conexión externa. | 📅 Pendiente |
| **UX-01** | 🔥 Alta | **[Diseño]** Definir en Figma el "Canvas Quirúrgico" y assets visuales (Pinza, Riñón) con medidas (px/mm). | 🚧 En Progreso |

---

## 🏗️ Épica 2: Infraestructura Visual & Escalabilidad
*Objetivo: Definir la herramienta de Frontend definitiva y pulir la experiencia.*

| ID | Prioridad | Historia de Usuario / Tarea Técnica | Estado |
|:---|:---:|:---|:---|
| **SPIKE-01**| ⚡ Media | **[Investigación]** Realizar prueba de concepto (PoC) en **FlutterFlow**: validar exportación de código y consumo de API. | 📅 Sprint 02 |
| **US-04** | Media | **[UX]** Como cirujano, quiero ver un indicador numérico de "Estabilidad" (temblor) en tiempo real. | 🧊 Backlog |
| **TEC-03** | Media | **[Backend]** Implementar algoritmo de suavizado de movimiento en C# para filtrar movimientos bruscos del mouse. | 🧊 Backlog |
| **US-05** | Media | **[Data]** Como Data Engineer, quiero que el JSON incluya un `session_id` único para diferenciar intentos. | 🧊 Backlog |

---

## 🔮 Épica 3: Futuro (Simulación Avanzada)
*Objetivo: Enriquecer la simulación con variables complejas (Deseos del Data Engineer).*

| ID | Prioridad | Historia de Usuario / Tarea Técnica | Estado |
|:---|:---:|:---|:---|
| **US-06** | Baja | **[Sensores]** Simular lecturas de temperatura y presión en el instrumental (Metadata en el JSON). | 🧊 Congelado |
| **US-07** | Baja | **[Visualización]** Reemplazar vista 2D por un modelo 3D interactivo (posiblemente Blazor WebAssembly o Unity). | 🧊 Congelado |
| **US-08** | Baja | **[Seguridad]** Sistema de Login para perfiles médicos (Estudiante vs. Experto). | 🧊 Congelado |
| **US-09** | Baja | **[Hardware]** Integración con mandos físicos (Joysticks) en lugar de mouse. | 🧊 Congelado |