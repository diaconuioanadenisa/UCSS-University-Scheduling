# UCSS - University Course Scheduling System
**Tehnologie:** C# (.NET Core) & SQL Server

## Obiectivul Proiectului
Digitalizarea procesului de planificare a cursurilor din cadrul facultății pentru a preveni suprapunerile de personal și resurse.

## Componente Implementate
1. **Modelul de Date:** Clase C# pentru Profesori, Săli și Cursuri.
2. **Motorul de Validare:** Algoritm care detectează dacă un profesor sau o sală sunt deja alocate.
3. **Baza de Date:** Schema SQL completă pentru persistența datelor.

## Cum funcționează
Sistemul primește o cerere de programare, verifică în lista de intrări existente dacă `TimeSlot`-ul este liber pentru sala și profesorul respectiv, și doar dacă nu există conflicte, salvează programarea.
