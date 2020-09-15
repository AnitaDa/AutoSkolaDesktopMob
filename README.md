# AutoSkolaDesktopMob


TESTIRANJE
1) docker-compose build
2) docker-compose up

DESKTOP APP(WinUI)
Desktop app pristupaju uposlenici tj. referenti i instruktori.
Pristupni podaci:
REFERENT
korisnicko ime: uposlenik
pass: test

INSTRUKTOR
korisnicko ime: instruktor
pass: test
_
MOBILNA APP
KANDIDATI
korisnicko ime: kandidat
pass: test

Prilikom slanja zahtjeva
Br.ljekarskog za kandidat: 5
_
korisnicko ime: kandidat2
pass: test
Prilikom slanja zahtjeva
Br.ljekarskog za kandidat2: 4
_
korisnicko ime: kandidat3
pass: test
Prilikom slanja zahtjeva
Br.ljekarskog za kandidat3: 3

NEKE OD FUNKCIONALNOSTI:
-klikom na email korisnika, otvara se forma za izmjenu korisnickih podataka
-prilikom kupovine usluga, iste se placaju preko payment servisa(podaci su vec uneseni), kandidat ne moze kupiti uslugu, za koju prethodno nije dobio odobrenje
-sistem preporuke se nalazi u kartici "Instruktori"->odabrati instruktora->ispod detalja instruktora nalaze se preporuceni
