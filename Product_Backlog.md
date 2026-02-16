# 🗺️ Product Backlog - Proyecto Justina

**Versión:** 2.0 (Refactorización Vibe Coding / Blazor)  
**Última actualización:** 16/02/2026  
**Visión:** Plataforma de simulación quirúrgica renal mínimamente invasiva para validar UX y recopilar métricas de precisión antes de la construcción de hardware robótico con dicho sistema.

---

## 🎯 Sprint 03 Actual: "Integración del MVP y Comunicación Cliente-Servidor"
**Fecha:** Lunes 16/02/2026 al Viernes 20/02/2026  
**Objetivo Principal:** Lograr la comunicación bidireccional entre la API (Motor de Simulación en C#) y Radzen Blazor (Frontend) para tener el MVP 100% funcional.

### Tareas del Sprint (Sprint Backlog)
* 🚧 **[Backend - API]** Configurar políticas CORS (Cross-Origin Resource Sharing) para permitir peticiones seguras desde el cliente Blazor. *(En Progreso)*
* 📅 **[Frontend - Blazor]** Configurar `HttpClient` e inyectar el servicio en la aplicación cliente. *(Pendiente)*
* 📅 **[Integración]** Conectar el evento de movimiento del mouse en `Simulador.razor` con el endpoint `POST /api/pointer/move`. *(Pendiente)*
* 📅 **[Integración]** Procesar el JSON de respuesta de la API para cambiar el estado visual de la UI en tiempo real (Ej: Alerta roja de colisión). *(Pendiente)*

---

## 🚀 Épica 1: MVP - Core de Simulación y UI (Prioridad Máxima)
*Objetivo: Lograr que el "robot" virtual se mueva, respete límites, genere datos y el cirujano interactúe con una interfaz médica realista.*

| ID | Prioridad | Historia de Usuario / Tarea Técnica | Estado |
|:---|:---:|:---|:---|
| **TEC-01** | 🔥 Alta | **[Backend]** Implementar Clean Architecture en C# (Domain, Application, Infra) y exponer Web API. | ✅ Completado |
| **UX-01** | 🔥 Alta | **[Diseño]** Definir en Figma el "Canvas Quirúrgico" y assets visuales con medidas. | ✅ Completado |
| **TEC-04** | 🔥 Alta | **[Frontend]** Construir UI del Dashboard y Canvas interactivo utilizando Radzen Blazor WebAssembly. | ✅ Completado |
| **US-01** | 🔥 Alta | **[Simulación]** Como cirujano, quiero mover la pinza con el mouse y ver su respuesta en pantalla sin latencia. | 🚧 En Progreso (Sprint 3) |
| **US-02** | 🔥 Alta | **[Seguridad]** Como cirujano, quiero ver una alerta visual si la pinza toca una "Zona Prohibida" (Colisión). | 🚧 En Progreso (Sprint 3) |
| **TEC-02** | 🔥 Alta | **[Integración]** Configurar CORS en la API para permitir conexión externa desde Blazor. | 🚧 En Progreso (Sprint 3) |
| **US-03** | Media | **[Data]** Generar un JSON estandarizado con coordenadas (X,Y) y estado del robot para consumo del Frontend. | ✅ Completado |

---

## 🏗️ Épica 2: Infraestructura Visual & Escalabilidad
*Objetivo: Refinar la herramienta de Frontend definitiva y preparar el terreno para futuras métricas.*

| ID | Prioridad | Historia de Usuario / Tarea Técnica | Estado |
|:---|:---:|:---|:---|
| **SPIKE-01**| ⚡ Media | **[Investigación]** Realizar PoC en FlutterFlow: validar exportación de código. | ❌ Pivotado a Blazor |
| **US-04** | Media | **[UX]** Como cirujano, quiero ver un indicador numérico de "Estabilidad" (temblor) en tiempo real. | 🧊 Backlog |
| **TEC-03** | Media | **[Backend]** Implementar algoritmo de suavizado de movimiento en C# para filtrar movimientos bruscos del mouse. | 🧊 Backlog |
| **US-05** | Media | **[Data]** Incluir un `session_id` único en la telemetría para diferenciar intentos y guardar en futura BD. | 🧊 Backlog |

---

## 🔮 Épica 3: Futuro (Simulación Avanzada)
*Objetivo: Enriquecer la simulación con variables complejas para futuras fases del proyecto.*

| ID | Prioridad | Historia de Usuario / Tarea Técnica | Estado |
|:---|:---:|:---|:---|
| **US-06** | Baja | **[Sensores]** Simular lecturas de temperatura y presión en el instrumental. | 🧊 Congelado |
| **US-07** | Baja | **[Visualización]** Reemplazar vista 2D por un modelo 3D interactivo (Unity/WebGL). | 🧊 Congelado |
| **US-08** | Baja | **[Seguridad]** Sistema de Login para perfiles médicos (Estudiante vs. Experto). | 🧊 Congelado |
| **US-09** | Baja | **[Hardware]** Integración con mandos físicos (Joysticks hápticos) en lugar de mouse. | 🧊 Congelado |