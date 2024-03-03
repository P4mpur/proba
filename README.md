### E Pazi Sad bajco sta ce radis
<picture>
 <img alt="YOUR-ALT-TEXT" src="https://imgs.search.brave.com/GMRjYRAAGOH9HuY4PNo2ijS_Myntd0S2_NHbY7YugNk/rs:fit:500:0:0/g:ce/aHR0cHM6Ly93d3cu/ZGVzaWNvbW1lbnRz/LmNvbS9kYzIvMDMv/MTg5ODU2LzE4OTg1/Ni5KUEc">
</picture>

###### Napravis projekat sa dotnet new webapi , sve normalno , iskopiras onaj njegov template i gle sad
# skidas ovi dotnet package-ovi :

```sh
dotnet add package Microsoft.AspNetCore.OpenApi
```
```sh
dotnet add package Microsoft.Data.SqlClient
```
```sh
dotnet add package Microsoft.EntityFrameworkCore
```
```sh
dotnet add package Microsoft.EntityFrameworkCore.Design
```
```sh
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```
## What IS NEXT
Sledece sto radis je Connection String samo iskopiraj ovo, trebalo bi da radi:
```json
"ConnectionStrings": { "projekatCS": "Server=tcp:nemacka.database.windows.net,1433;Initial Catalog=aplikacijadb;Persist Security Info=False;User ID=localhost;Password=Lenovo-T480s;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"}
```

# VAZNA STVAR:
# ------------------------- 
### napravi file ./Models  i neces nista u njih da stavljas  nego udaris ovo u konzolu 

#### ovo je celo jedna komanda
```sh 
dotnet ef dbcontext scaffold "Server=tcp:nemacka.database.windows.net,1433;Initial Catalog=aplikacijadb;Persist Security Info=False;User ID=localhost;Password=LenovoT480s;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;"Microsoft.EntityFrameworkCore.SqlServer -o Models --table Feedback --table Objects --table Reservation --table User --force
```
#### kraj

<p style="background-color:tomato;">Ovo je moja test baza.</p>

##### Ovo je moja test baza koju sam napravio,obrati paznju kako pise 
``
"-o Models --table Feedback "
``
##### ovo Objects je table 
##### i na dalje Reservation, User, Object etc..
### sve tabele koje imas na serveru moras da privuces preko 
``
--table **naziv tabele**
``
### ako ne napises nece da se scaffold-uju ili ti preuzmu

`` 
"--force"
``
### je samo oznaka da se overwrite-uje sve sto je pod istim nazivom na tvoj {Current_directory}

#####kad oces da update-ujes tabelu uvek moras prvo da drop-ujes pa onda mozes dotnet ef database update
