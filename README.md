# ProsperDaily

**ProsperDaily** ist eine mobile App zur täglichen Finanzverwaltung. Entwickelt mit **.NET MAUI**, bietet sie eine einfache Möglichkeit, Einnahmen und Ausgaben im Tageskontext zu erfassen, zu verfolgen und zu analysieren. Die App ist als Cross-Plattform-Anwendung für Android (und später ggf. iOS) konzipiert.

---

## 🧠 Motivation

In einer zunehmend digitalen Welt ist es wichtig, finanzielle Entscheidungen bewusst zu treffen. ProsperDaily entstand aus dem Wunsch heraus, tägliche Ausgaben besser zu verstehen und persönliche Finanzmuster zu erkennen – in einem klaren, intuitiven Interface.

---

## ⚙️ Tech Stack

- [.NET MAUI](https://learn.microsoft.com/dotnet/maui/) (Multi-platform App UI)
- C# mit MVVM-Architektur
- SQLite (lokale Persistenz)
- Android Emulator / physisches Gerät

---

## 🚀 Features (geplant / teilweise implementiert)

- [x] Tagesbasierte Finanzübersicht
- [x] Eingabe von Einnahmen & Ausgaben
- [ ] Kategorisierung (z. B. Lebensmittel, Miete, Freizeit)
- [ ] Statistiken & Visualisierungen
- [ ] Exportfunktion (CSV / PDF)
- [ ] Plattformübergreifende Synchronisation (optional)

---

## 🛠️ Installation & Start

### Voraussetzungen

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- Visual Studio 2022+ mit MAUI-Workload
- Android Emulator oder physisches Gerät

### Schritte

```bash
git clone https://github.com/Wolvye/ProsperDaily.git
cd ProsperDaily
dotnet build
dotnet run --framework:net8.0-android
