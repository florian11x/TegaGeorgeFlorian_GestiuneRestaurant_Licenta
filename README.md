# README - Aplicație desktop pentru gestionarea comenzilor într-un restaurant

**Link GitHub**:https://github.com/florian11x/TegaGeorgeFlorian_GestiuneRestaurant_Licenta

Aceasta este o aplicație desktop realizată în C# folosind WinForms și SQL Server, destinată gestionării comenzilor într-un restaurant. Lucrarea a fost dezvoltată ca parte a proiectului de licență la Facultatea de Automatică și Calculatoare, Universitatea Politehnica Timișoara.

## 🔧 Compilare și rulare

1. Deschide soluția `TegaGeorgeFlorian_GestiuneRestaurant_Licenta.sln` în Visual Studio 2017 sau 2022.
2. Asigură-te că ai instalat: .NET Framework 4.7.2 și SQL Server Management Studio.
3. În fișierul `App.config`, configurează conexiunea către instanța ta de SQL Server.
4. Rulează aplicația cu `F5` din Visual Studio.

## 🗂 Structura aplicației
├── View/ → Formulare WinForms (POS, Login, Bucătărie, etc.)
├── Model/ → Clase pentru entități (Comandă, Produs, etc.)
├── DAL/ → Accesul la baza de date (Data Access Layer)
├── Rapoarte/ → Generare bonuri și rapoarte
└── App.config → Setări conexiune la baza de date

Configurare bază de date
Scriptul bazei de date este disponibil în fișierul: `BazaDate_Restaurant.sql`.
Acesta trebuie importat în SQL Server pentru a crea toate tabelele și a popula baza cu datele inițiale.
Poți face acest lucru astfel:
1. Deschide SQL Server Management Studio.
2. Creează o bază de date nouă (ex: `GestiuneRestaurant`).
3. Click dreapta pe baza de date → New Query.
4. Încarcă și rulează fișierul `BazaDate_Restaurant.sql`.
