# Diccionario Técnico - Proyecto Justina Simulator

Este documento está diseñado para el equipo de **UX/UI, No-Code y Data Analysts**. Aquí explicamos los términos técnicos de la estructura que hemos creado y cómo deben utilizarla para conectar sus interfaces y herramientas.

## ¿Qué hemos construido? (El Backend)
Hemos creado una **API (Interfaz de Programación de Aplicaciones)**. Piensen en esto como un gran "tablero de enchufes". Ustedes no necesitan saber cómo funciona la electricidad por dentro (el código C#), solo necesitan saber qué enchufe usar para cada cosa.

## Términos Clave

### 1. API (Web API)
Es el sistema central que recibe órdenes y devuelve información.
*   **Para el UX/UI**: Es el lugar de donde la interfaz sacará los datos para mostrar.
*   **Para el No-Code**: Es el servicio al que deben llamar desde Bubble, PowerApps o Zapier.

### 2. Endpoint (Punto de Acceso)
Es una dirección URL específica que hace una sola tarea. Es como un "botón" digital.
*   *Ejemplo*: `POST /api/pointer/move` es el botón para "Mover el robot".

### 3. JSON (JavaScript Object Notation)
Es el "idioma" que usamos para hablar con la API. Es texto plano, fácil de leer.
*   **Para el Data Analyst**: Así es como se ven los datos que van a analizar.
*   *Ejemplo de una orden de movimiento*:
    ```json
    {
      "x": 10.5,
      "y": 20.0,
      "z": 5.0
    }
    ```

### 4. Swagger (Documentación Interactiva)
Es una página web automática que lista todos los "enchufes" (Endpoints) disponibles.
*   **Uso vital**: Entren aquí para ver qué botones existen y probarlos sin escribir código.
*   Cuando corremos el proyecto, Swagger se abre automáticamente en el navegador.

## Guía para el Equipo

### Para el Diseñador UX/UI
*   Tú diseñas la interfaz visual (botones, sliders, gráficos 3D).
*   Cuando el usuario haga clic en "Mover", tu diseño debe decirle al desarrollador Frontend que llame al endpoint **Move Pointer**.

### Para el Desarrollador No-Code (FlutterFlow)
*   **Conexión API**: En FlutterFlow, ve a la sección "API Calls".
*   **Crear Grupo API**: Llámalo "Justina Backend".
*   **Base URL**: Será la dirección donde publiquemos la API (por ahora es local `https://localhost:7001`, luego será una URL en la nube).
*   **Call Name**: "Mover Puntero".
*   **Method**: `POST`.
*   **Endpoint**: `/api/pointer/move`.
*   **Body**: JSON (como se muestra arriba). Variables: `x`, `y`, `z` (Double).

### Para el Analista de Datos
*   Si necesitas registrar posiciones históricas:
    *   La API te entregará los datos limpios en formato JSON, listos para transformar en tablas.

## Variables del Sistema (Diccionario de Datos)

Estas son las variables que ya existen en el código y que deben usar para comunicarse con el simulador:

1.  **`x`** (Decimal): Posición en el eje horizontal.
2.  **`y`** (Decimal): Posición en el eje vertical.
3.  **`z`** (Decimal): Posición de profundidad/altura.
4.  **`CurrentTarget`** (Objeto): Representa el "Puntero" o destino actual del robot. Contiene los valores x, y, z.
    *   *Nota*: En el código estricto se llama `CurrentTarget`, pero en el JSON de respuesta lo verán dentro de la propiedad `target`.

