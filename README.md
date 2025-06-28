README - Aplicație desktop pentru gestionarea comenzilor într-un restaurant

Link GitHub: https://github.com/florian11x/TegaGeorgeFlorian_GestiuneRestaurant_Licenta

Aceasta este o aplicație desktop realizată în C# folosind WinForms și SQL Server, destinată
gestionării comenzilor într-un restaurant. Lucrarea a fost dezvoltată ca parte a proiectului de licență la
Facultatea de Automatică și Calculatoare, Universitatea Politehnica Timișoara.

Descrierea livrabilelor proiectului
- _source/ – codul sursă complet al aplicației (fără fișiere binare compilate)
- database/ – fișierul BazaDate_Restaurant.sql necesar pentru generarea bazei de date în SQL Server
- README.md – prezentare directă pentru GitHub
- .gitignore – exclude fișierele generate automat (bin/, obj/, .vs/)

Structura aplicației
├── View/ → Formulare WinForms (POS, Login, Bucătărie, etc.)
├── Model/ → Clase pentru entități (Comandă, Produs, etc.)
├── DAL/ → Accesul la baza de date (Data Access Layer)
├── Rapoarte/ → Generare bonuri și rapoarte
└── App.config → Setări conexiune la baza de date

Compilare și rulare
1. Deschide soluția `TegaGeorgeFlorian_GestiuneRestaurant_Licenta.sln` în Visual Studio 2017
sau 2022.
2. Asigură-te că ai instalat: .NET Framework 4.7.2 și SQL Server Management Studio.
3. În fișierul App.config, configurează conexiunea către instanța ta de SQL Server.
4. Rulează aplicația cu F5 din Visual Studio.
   
Configurare bază de date
1. Deschide aplicația SQL Server Management Studio (SSMS).
2. Creează o bază de date nouă, cu un nume sugestiv, de exemplu GestiuneRestaurant.
3. Click dreapta pe baza de date creată și selectează opțiunea New Query.
4. Încarcă fișierul BazaDate_Restaurant.sql din folderul database/ și rulează întregul script.

Exemplu de configurare App.config pentru conexiunea la SQL Server
<connectionStrings>
 <add name="conexiuneGestiuneRestaurant"
 connectionString="Data Source=FLORIAN-PC\\SQLEXPRESS;Initial
Catalog=GestiuneRestaurant;Integrated Security=True"
 providerName="System.Data.SqlClient" />
</connectionStrings>
