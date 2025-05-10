# 🧱 C4 Level 1 – System Context Diagram: Aionetix

```mermaid
graph TD
    User[Benutzer (Admin, Analyst, Techniker, Endnutzer)]
    User --> Aionetix[Desktop App: Aionetix (WPF)]
    Aionetix --> MongoDB[(MongoDB Datenbank)]
    Aionetix --> ETL[ETL-Engine (Module)]
    Aionetix --> BI[BI-Modul (Dashboard, Analyse)]

    ETL --> DataSources[Datenquellen (CSV, REST, SQL, ...)]
    ETL --> DataTargets[Datenziele (Mongo, File, ...)]
