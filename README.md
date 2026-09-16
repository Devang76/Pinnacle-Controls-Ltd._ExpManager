<div align="center">

# Pinnacle Industrial Controls Ltd. Expenditure Manager

**A C# and Microsoft SQL expense-tracking application for accurate, auditable financial records.**

![C#](https://img.shields.io/badge/C%23-Windows%20Forms-512BD4?logo=dotnet&logoColor=white)
![Database](https://img.shields.io/badge/Database-Microsoft%20SQL%20Server-CC2927?logo=microsoftsqlserver&logoColor=white)
![IDE](https://img.shields.io/badge/IDE-Visual%20Studio%202022-5C2D91?logo=visualstudio&logoColor=white)
![Impact](https://img.shields.io/badge/Audit%20discrepancies-30%25%20reduction-1F8A70)

</div>

> **Project focus:** replace error-prone manual expense entry with a validated, database-backed desktop workflow.

| Navigate | Navigate | Navigate |
| :--- | :--- | :--- |
| [Impact](#impact) | [Architecture](#application-workflow) | [Setup](#getting-started) |

---

A desktop expense-tracking application built to improve the accuracy, organization, and auditability of financial records at Pinnacle Industrial Controls Ltd.

- Eliminated manual-entry errors through structured data capture and validation.
- Reduced audit discrepancies by **30%**.
- Improved the organization and accuracy of expense-related financial records.
| Outcome | Result |
| --- | --- |
| Data quality | Eliminated manual-entry errors through structured capture and validation |
| Audit readiness | **30% reduction** in audit discrepancies |
| Record management | Centralized, organized financial records in Microsoft SQL Server |

## Application Workflow

```mermaid
flowchart LR
    A[Expense information] --> B[Windows Forms application]
    B --> C{Validate input}
    C -->|Valid| D[(Microsoft SQL Server)]
    C -->|Needs correction| B
    D --> E[Centralized expense records]
    E --> F[Accurate reporting and audit support]

    classDef app fill:#512BD4,color:#ffffff,stroke:#3d1f9d;
    classDef data fill:#CC2927,color:#ffffff,stroke:#8c1518;
    classDef outcome fill:#1F8A70,color:#ffffff,stroke:#146149;
    class B app;
    class D data;
    class E,F outcome;
```

<details>
<summary><strong>How the workflow improves record quality</strong></summary>

1. An employee enters expense information through the desktop application.
2. The application checks input before a record is saved.
3. Validated information is stored centrally in Microsoft SQL Server.
4. Consistent records improve traceability and reduce discrepancies during audit review.

</details>

## Key Features

- Expense data-entry interface built with C# Windows Forms.
- Microsoft SQL-backed storage for centralized expense records.
- Validation workflows to support accurate and consistent data capture.
- Database-driven record management for improved traceability and audit readiness.
- Application workflows designed around expense-management requirements.
| Feature | Value |
| --- | --- |
| C# Windows Forms interface | Provides a structured workflow for entering expense information |
| Microsoft SQL-backed storage | Centralizes expense records for reliable retrieval and management |
| Input validation | Supports accurate and consistent data capture |
| Database-driven records | Improves traceability and audit readiness |
| Requirements-based workflow | Aligns the application with expense-management needs |

| Development environment | Visual Studio 2022 |

## Project Workflow

1. Capture expense information through the desktop application.
2. Validate submitted data before it is recorded.
3. Store validated records in the Microsoft SQL database.
4. Retrieve and manage expense information through the application workflow.
5. Use consistent, database-backed records to support accurate reporting and audits.
## Getting Started

## Getting Started
<details>
<summary><strong>Prerequisites and local setup</strong></summary>


</details>

## Visual Preview

> Add screenshots here after uploading them to `docs/images/`. Good options are the expense-entry form, the database schema, and a successful record-management screen.

```text
docs/
└── images/
    ├── expense-entry-form.png
    ├── database-schema.png
    └── application-dashboard.png
```

Then embed an image in this section with:

```markdown
![Expense entry form](docs/images/expense-entry-form.png)
```

## Resume Summary
