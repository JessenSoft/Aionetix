
---

### 📁 `team/Architecture/C4_Level2.md`

```markdown
# 🧱 C4 Level 2 – Container View

```mermaid
graph TD
    AionetixApp[WPF App (Aionetix.App)]
    Core[Aionetix.Core – Domäne]
    UI[Aionetix.UI – Views + ViewModels]
    Infra[Aionetix.Infrastructure – Mongo, Logging]
    ETL[Aionetix.ETL – Prozessmodule]
    BI[Aionetix.BI – BI-Komponenten]

    AionetixApp --> UI
    AionetixApp --> Core
    AionetixApp --> Infra
    AionetixApp --> ETL
    AionetixApp --> BI
    UI --> Core
    ETL --> Core
    BI --> Core
    Infra --> Core
