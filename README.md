# Model1

1p 1. Sa se creeze baza de date avand urmatoarea structura

Recenzie -
	IDRecenzie - int - cheie primara
	Titlu - string
	Descriere - text
	Nota - int - intre 1 si 5
	NumeUtilizator - string
	IDFilm - int - cheie straina

Film -
	IDFilm - int - cheie primara
	Denumire - string

Populati tabelele cu 3-4-5 inregistrari din IDE.

4.5p 2. Creati operatiile uzuale de CRUD
	1p Index care sa se apeleze cu ruta /NumeController/AfisareRecenzii si sa fie ordonate dupa nota descrescator
	0.5p Show care afiseaza detaliile recenziei impreuan cu cele ale filmului
	1p New - creaza o recenzie, iar pentru selectia filmului dropdown populat din metoda conform cursului
	1p Delete - Sa se faciliteze operatia de delete
	1p Edit - Sa se poata edita o recenzie, campurile fiind completate cu datele vechi, iar pentru film dropdown

1p 3. Sa se valideze la fiecare pas datele transmise si sa se afiseze mesaje de eroare corespunzatoare (Nota intre 1 si 5, data sa fie de tip date...)

0.5p 4. Sa se creeze un layout pentru a facilita navigarea, sa contina link catre Index, New si Search

1.5p 5. Sa se creeze functionalitatea de search pe recenzii, fiind posibila cautarea dupa nota si denumirea filmului. Daca ambele sunt date, sa se caute cu AND.

0.5p 6. Pentru fiecare actiune sa se faca redirect la index si sa se afiseze un mesaj corespunzator (Recenzia fost editata cu succes, Recenzia a fost stearsa...)

Oficiu 1p

Observatii:
	Nu sunt permise coduri generate de IDE (Controller cu actiuni / View-uri cu modele). Totul trebuie sa fie Empty.
	Trebuie folosite toate verbele HTTP studiate (get, post, put, delete).
	Timp de lucru 2 ore.
