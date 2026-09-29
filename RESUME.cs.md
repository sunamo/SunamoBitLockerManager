---
schema_version: 1
type: library
file_count: 28
delete_recommendation_percent: 5
generated_date: 2026-09-29
---

## Description

Knihovna pro správu BitLocker šifrování disků z .NET kódu (WMI wrapper nad `Win32_EncryptableVolume`).

Obsahuje `BitLockerManager`/`BitLockerHelper` a sadu enumů popisujících stav a nastavení šifrování (typ šifrovacího klíče, metoda šifrování, stav konverze, hardwarová akcelerace apod.).

Vznikla 2026-09-28 vyčleněním z `sunamo.notmine`, publikovaná jako samostatný NuGet balíček. Obsahuje runner (`RunnerSunamoBitLockerManager`) a testy.
