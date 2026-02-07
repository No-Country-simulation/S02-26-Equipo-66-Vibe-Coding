# Clean Architecture
The solution will be structured into the following projects:

## Layer JustinaSimulator.Domain (Class Library)

Purpose: The core of the system. Contains enterprise logic and types.
Dependencies: None.
Content: Entities (Robot, Coordinate), Value Objects, Domain Interfaces (IRobotController), Domain Exceptions.

## Layer JustinaSimulator.Application (Class Library)

Purpose: Application logic and use cases. Orchestrates the domain.
Dependencies: Projects: Domain.
Content: Use Cases/Services (MovePointerService), DTOs (PointerPositionDto), Interfaces (persistence, external services).

## Layer JustinaSimulator.Infrastructure (Class Library)

Purpose: Implementation of external concerns (DB, Hardware, IO).
Dependencies: Projects: Domain, Application.
Content: Repository Implementations (InMemory for now), Hardware Adapters (Simulated).

## Layer JustinaSimulator.API (ASP.NET Core Web API)

Purpose: Entry point for the No Code/Web clients.
Dependencies: Projects: Application, Infrastructure.
Content: Controllers, Dependency Injection Config.

graph TD
    %% Definición de Actores Externos
    User((Cirujano))
    NoCode[Front-End No-Code\n(Bubble/Figma)]
    DataEng[Data Engineer\nPipeline Python]

    %% La Caja Negra: Tu Backend en C#
    subgraph "Backend C# (Justina Engine)"
        direction TB
        
        %% Capa 4: API
        subgraph "Capa: API / Presentation"
            Controller[RobotController\n(Recibe X,Y,Z)]
        end

        %% Capa 2: Aplicación
        subgraph "Capa: Application (Casos de Uso)"
            UseCaseMove[MoveArmUseCase\n(Coordina el movimiento)]
            UseCaseAlert[CheckSafetyUseCase\n(Verifica riesgo)]
        end

        %% Capa 1: Dominio (El Núcleo Puro)
        subgraph "Capa: Domain (Reglas de Negocio)"
            EntityRobot[Clase: SurgicalRobot]
            EntityGripper[Clase: Gripper]
            ValueObj[Struct: Position3D]
            InterfaceRepo[Interface: ITelemetry]
        end

        %% Capa 3: Infraestructura
        subgraph "Capa: Infrastructure"
            JsonService[JsonTelemetryService\n(Guarda Logs)]
        end
    end

    %% Relaciones (Flujo de Dependencia)
    User -->|Mueve Mouse| NoCode
    NoCode -->|Envía JSON {x,y}| Controller
    
    Controller -->|Llama| UseCaseMove
    UseCaseMove -->|Usa| EntityRobot
    UseCaseMove -->|Valida con| UseCaseAlert
    
    %% La regla de oro: Infra depende de Dominio (Inversión de Dependencia)
    JsonService -.->|Implementa| InterfaceRepo
    UseCaseMove -->|Guarda datos vía| InterfaceRepo
    
    %% Salida de datos
    JsonService -->|Genera archivo .json| DataEng
    
    %% Estilos para que se vea lindo (Vibe)
    style User fill:#f9f,stroke:#333,stroke-width:2px
    style NoCode fill:#bbf,stroke:#333,stroke-width:2px
    style DataEng fill:#bfb,stroke:#333,stroke-width:2px
    style EntityRobot fill:#ff9,stroke:#f66,stroke-width:2px,stroke-dasharray: 5, 5