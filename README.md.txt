# Aplicație desktop pentru gestionarea comenzilor într-un restaurant (Licență)

Aceasta este o aplicație desktop realizată în C# folosind WinForms și SQL Server, destinată gestionării comenzilor într-un restaurant. Lucrarea a fost dezvoltată ca parte a proiectului de licență la Facultatea de Automatică și Calculatoare, Universitatea Politehnica Timișoara.

## 📌 Link GitHub

👉 [Repo GitHub – Aplicatie Restaurant](https://github.com/florian11x/Aplicatie-desktop-pentru-gestionarea-comenzilor-intr-un-restaurant)

## ⚙️ Pași pentru compilare

1. Deschide soluția `TegaGeorgeFlorian_GestiuneRestaurant_Licenta.sln` în Visual Studio 2017 sau 2022
2. Verifică să ai instalat:
   - .NET Framework 4.7.2
   - SQL Server Management Studio (SSMS)
3. Configurează string-ul de conexiune în fișierul `App.config` pentru a corespunde instanței tale de SQL Server

## 🛠️ Pași pentru rulare

1. Clonează repository-ul:
```bash
git clone https://github.com/florian11x/Aplicatie-desktop-pentru-gestionarea-comenzilor-intr-un-restaurant.git
```
2. Creează baza de date în SQL Server
3. Rulează aplicația din Visual Studio cu F5

## 🧩 Structura proiectului

- `View/` – ferestrele aplicației (POS, Login, Bucătărie, etc.)
- `Model/` – clasele care definesc entitățile (Comanda, Produs, etc.)
- `DAL/` – accesul la baza de date
- `Rapoarte/` – formulare pentru printare și rapoarte
- `App.config` – configurarea conexiunii la baza de date

## 🚫 Ce nu este inclus

În acest repository **nu** sunt incluse fișierele compilate:  
- `bin/`  
- `obj/`  
- `.exe`, `.dll`  

Acestea sunt regenerate automat de Visual Studio la rulare.

## 👨‍💻 Autor

**George Florian Tega**  
Facultatea de Automatică și Calculatoare, Universitatea Politehnica Timișoara  
Lucrare de licență – 2025