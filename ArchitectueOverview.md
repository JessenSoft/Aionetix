
---

### 📁 `team/Architecture/ArchitectureOverview.md`

```markdown
# 🔍 Architekturüberblick – Aionetix

## 🧱 Clean Architecture (angepasst für Desktop WPF)

- **UI Layer:** ReactiveUI + WPF-Views
- **Application Layer (Core):** Businesslogik, UseCases, Schnittstellen
- **Infrastructure Layer:** MongoDB, Logging, Konfig, Datenzugriff
- **Plugin Layer (ETL / BI):** Erweiterbare Module

## 🧩 Modularität

- ETL-Module als ladbare Bausteine (Extract, Transform, Load)
- BI-Komponenten erweiterbar: z. B. Diagrammtypen, Datenquellen
- Jeder Teil isoliert testbar, über Schnittstellen getrennt

## 📦 Technologien

- **WPF** + **ReactiveUI** für moderne MVVM-Architektur
- **MongoDB** als zentrale persistente Datenschicht
- **xUnit** + **FluentAssertions** für Testabdeckung

## 🧪 Teststrategie

- Unit-Tests pro Layer (Core, ETL, BI)
- Mocks für Infrastruktur
- spätere Erweiterung: Integrationstests, UI-Tests

## 🔧 Deployment

- Primärziel: Windows (Single EXE / Installer)
- Langfristig offen für: Web-Frontend, MAUI, API-Bridge
