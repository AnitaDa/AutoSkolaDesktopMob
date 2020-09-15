# AutoSkolaDesktopMob


# TESTIRANJE


**u AutoSkola.WebApi**



1) docker-compose build
2) docker-compose up


**U startup-u pokrenuti samo AutoSkola.WinUI i AutoSkola.Mobile.UWP**


DESKTOP APP(WinUI)



Desktop app pristupaju uposlenici tj. referenti i instruktori.
Pristupni podaci:


**REFERENT**

korisnicko ime: uposlenik

pass: test



**INSTRUKTOR**


korisnicko ime: instruktor

pass: test



MOBILNA APP



**KANDIDATI**

-korisnicko ime: kandidat

pass: test


Prilikom slanja zahtjeva
Br.ljekarskog za kandidat: 5





-korisnicko ime: kandidat2

pass: test


Prilikom slanja zahtjeva
Br.ljekarskog za kandidat2: 4





-korisnicko ime: kandidat3

pass: test


Prilikom slanja zahtjeva
Br.ljekarskog za kandidat3: 3




**NEKE OD FUNKCIONALNOSTI:**



-klikom na email korisnika, otvara se forma za izmjenu korisnickih podataka


-prilikom kupovine usluga, iste se placaju preko payment servisa(podaci su vec uneseni), kandidat ne moze kupiti uslugu, za koju prethodno nije dobio odobrenje


-sistem preporuke se nalazi u kartici "Instruktori"->odabrati instruktora->ispod detalja instruktora nalaze se preporuceni
