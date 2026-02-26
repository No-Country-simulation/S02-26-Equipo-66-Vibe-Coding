# 🖥️ Simulador Justina - Frontend (Radzen Blazor)

Esta carpeta contiene el código fuente de la **Interfaz de Usuario (UX/UI)** del "Proyecto Justina", diseñada originalmente en Figma y desarrollada utilizando el framework tecnológico **Blazor** de Microsoft con la librería de componentes **Radzen Blazor**.

## 📖 Origen y Evolución del Proyecto

Durante las primeras fases del proyecto (Sprint 1 y 2), el plan original consistía en construir el Frontend utilizando herramientas No-Code (específicamente FlutterFlow o Bubble). 

Sin embargo, ante la reducción del equipo y la baja de los perfiles responsables de las integraciones No-Code, el equipo (liderado en la parte de desarrollo por la Desarrolladora .NET Beatriz Ebert) tomó la **decisión estratégica de pivotar la arquitectura**. 

Para asegurar el éxito del MVP y no depender de integraciones inciertas, se decidió migrar todo el ecosistema al **Stack .NET**:
* **Backend:** API REST en C# (Proyecto `JustinaSimulator.API`).
* **Frontend:** Esta aplicación Web construida en Blazor.

## 🎨 Del Diseño a la Realidad (Figma a Blazor)

El desarrollo visual de esta aplicación es el resultado directo del trabajo del equipo de **Diseño UX/UI** (Lara Almirón y Cristian Dal Piva).
1. **Figma:** Todo el layout, los colores, la disposición de los menús y el diseño de la "Pantalla de Simulación" (el riñón y la representación del puntero) fueron bocetados inicialmente en Figma.
2. **Radzen Studio:** La desarrolladora ha utilizado **Radzen Blazor Studio** (y código C# puro) para trasladar esos bocetos píxel a píxel a componentes web interactivos.

El uso de Radzen Blazor ha permitido acelerar el desarrollo, ofreciendo componentes pre-estilizados (como botones, tarjetas y alertas) que se adaptan a las necesidades del entorno médico (colores oscuros, contraste y tipografías claras).

## ⚙️ ¿Qué hace este Frontend?

Esta aplicación no contiene "Lógica de Negocio Pura" en su interior. Funciona como un "Espejo" o un "Control Remoto":
* **Escucha:** Captura los movimientos del mouse del usuario sobre la "Zona Quirúrgica".
* **Transmite:** Se comunica permanentemente vía peticiones HTTP (JSON) con nuestra API C# (`/api/pointer/move`, `/api/pointer/click`).
* **Reacciona:** Recibe las respuestas del servidor (ej. Estado "Safe", "Warning" o "Danger") y actualiza la pantalla al instante, cambiando los colores y mostrando las alertas diseñadas por UX.

## 🚀 Cómo ejecutarlo localmente

1. Asegúrate de tener corriendo primero el Backend (`JustinaSimulator.API`).
2. Abre una terminal en esta carpeta (`FrontEnd`).
3. Ejecuta el comando:
   ```bash
   dotnet run
   ```
4. El simulador abrirá en tu navegador (típicamente en `https://localhost:5001` o puerto similar indicado por consola).
