# Clean Architecture
The solution will be structured into the following projects:

## Layer JustinaSimulator.Domain (Class Library)

**Purpose:** The core of the system. Contains enterprise logic and types.  
**Dependencies:** None.  
**Content:** Entities (Robot, Coordinate), Value Objects, Domain Interfaces (IRobotController), Domain Exceptions.

## Layer JustinaSimulator.Application (Class Library)

**Purpose:** Application logic and use cases. Orchestrates the domain.  
**Dependencies:** Domain.  
**Content:** Use Cases/Services (MovePointerService), DTOs (PointerPositionDto), Interfaces (persistence, external services).

## Layer JustinaSimulator.Infrastructure (Class Library)

**Purpose:** Implementation of external concerns (DB, Hardware, IO).  
**Dependencies:** Domain, Application.  
**Content:** Repository Implementations (InMemory for now), Hardware Adapters (Simulated).

## Layer JustinaSimulator.API (ASP.NET Core Web API)

**Purpose:** Entry point for the No Code/Web clients.  
**Dependencies:** Application, Infrastructure.  
**Content:** Controllers, Dependency Injection Config.

---

## Diagrama de Arquitectura
```mermaid
graph TD
    %% Definición de Actores Externos
    User((Cirujano))
    NoCode[Front-End No-Code<br/>Bubble/Figma]
    DataEng[Data Engineer<br/>Pipeline Python]

    %% Capa 4: API
    subgraph API["Capa: API / Presentation"]
        Controller[RobotController<br/>Recibe X,Y,Z]
    end

    %% Capa 2: Aplicación
    subgraph Application["Capa: Application - Casos de Uso"]
        UseCaseMove[MoveArmUseCase<br/>Coordina el movimiento]
        UseCaseAlert[CheckSafetyUseCase<br/>Verifica riesgo]
    end

    %% Capa 1: Dominio - El Núcleo Puro
    subgraph Domain["Capa: Domain - Reglas de Negocio"]
        EntityRobot[Clase: SurgicalRobot]
        EntityGripper[Clase: Gripper]
        ValueObj[Struct: Position3D]
        InterfaceRepo[Interface: ITelemetry]
    end

    %% Capa 3: Infraestructura
    subgraph Infrastructure["Capa: Infrastructure"]
        JsonService[JsonTelemetryService<br/>Guarda Logs]
    end

    %% Relaciones - Flujo de Dependencia
    User -->|Mueve Mouse| NoCode
    NoCode -->|Envía JSON x,y| Controller
    
    Controller -->|Llama| UseCaseMove
    UseCaseMove -->|Usa| EntityRobot
    UseCaseMove -->|Valida con| UseCaseAlert
    
    %% Inversión de Dependencia
    JsonService -.->|Implementa| InterfaceRepo
    UseCaseMove -->|Guarda datos vía| InterfaceRepo
    
    %% Salida de datos
    JsonService -->|Genera archivo .json| DataEng
    
    %% Estilos
    style User fill:#f9f,stroke:#333,stroke-width:2px
    style NoCode fill:#bbf,stroke:#333,stroke-width:2px
    style DataEng fill:#bfb,stroke:#333,stroke-width:2px
    style EntityRobot fill:#ff9,stroke:#f66,stroke-width:2px
    style Domain fill:#fff4e6,stroke:#ff6b6b,stroke-width:3px
    style Application fill:#e3f2fd,stroke:#2196f3,stroke-width:2px
    style Infrastructure fill:#f3e5f5,stroke:#9c27b0,stroke-width:2px
    style API fill:#e8f5e9,stroke:#4caf50,stroke-width:2px
```

---

## Flujo de Datos Detallado
```mermaid
sequenceDiagram
    participant C as Cirujano
    participant UI as Frontend No-Code
    participant API as RobotController
    participant UC as MoveArmUseCase
    participant Domain as SurgicalRobot
    participant Repo as ITelemetry
    participant Infra as JsonService
    participant Data as Data Pipeline

    C->>UI: Mueve mando robótico
    UI->>API: POST /api/robot/move {x, y, z}
    API->>UC: ExecuteMove(Position3D)
    
    UC->>Domain: robot.MoveTo(position)
    Domain->>Domain: ValidateSafetyZone()
    
    alt Posición segura
        Domain-->>UC: Movement OK
        UC->>Repo: SaveTelemetry(movement)
        Repo->>Infra: Write JSON log
        Infra-->>Data: telemetry.json
        UC-->>API: Success Response
        API-->>UI: 200 OK + new position
        UI-->>C: Actualiza visual
    else Alerta de colisión
        Domain-->>UC: CollisionAlert
        UC-->>API: Warning Response
        API-->>UI: 200 OK + alert flag
        UI-->>C: Muestra alerta visual
    end
```