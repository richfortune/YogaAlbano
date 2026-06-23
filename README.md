# YogaAlbano

YogaAlbano è una piattaforma web per la gestione di una scuola di yoga, con area pubblica informativa e area riservata per utenti e amministratori.

## Stack Tecnologico Previsto
- Backend: .NET 8 Web API
- Architettura: Clean Architecture
- Database: PostgreSQL
- ORM: Entity Framework Core
- Frontend App: React + TypeScript
- Sito pubblico: HTML/CSS
- Containerizzazione: Docker
- Versionamento: GitHub

## Documentazione
La specifica iniziale del progetto è disponibile in [Specifica MVP](docs/SPEC.md).

## Roadmap Iniziale
1. Definizione della struttura iniziale del repository.
2. Configurazione Docker, PostgreSQL e ambiente locale.
3. Creazione della solution backend .NET 8 secondo Clean Architecture.
4. Modellazione delle entità e configurazione della persistenza PostgreSQL con Entity Framework Core.
5. Avvio del frontend applicativo in React + TypeScript.
6. Realizzazione della landing page pubblica.

## Avvio Ambiente Locale
Creare il file `.env` partendo dall'esempio:

```powershell
Copy-Item .env.example .env
```

Avviare PostgreSQL:

```powershell
docker compose up -d postgres
```

Avviare pgAdmin:

```powershell
docker compose up -d pgadmin
```

Arrestare i container:

```powershell
docker compose down
```

## Backend .NET
La solution backend si trova nella cartella `backend` ed e organizzata secondo Clean Architecture:

```text
backend/
|-- YogaAlbano.sln
|-- YogaAlbano.Api/
|-- YogaAlbano.Application/
|-- YogaAlbano.Domain/
`-- YogaAlbano.Infrastructure/
```

Ripristinare i pacchetti:

```powershell
cd backend
dotnet restore
```

Compilare la solution:

```powershell
dotnet build
```

Avviare l'API:

```powershell
dotnet run --project YogaAlbano.Api
```

Endpoint di test:

```text
GET /health
```
