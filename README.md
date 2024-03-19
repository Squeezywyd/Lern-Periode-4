## Lern-Periode 4
Nael Ackle

20.2 bis 2.4.2024

## Grob-Planung
Am Ende von der LP3 habe ich mir vorgenommen, zukünftig relativ ähnlich zu arbeiten. Letzte Lern-Periode hatte bei mir die Zeitplanung etc sehr gut funktioniert und ich denke wenn ich das so weiterführen könnte. Verbesserungsvorschläge wären wenn ich vielleicht noch etwas konzentrierter arbeiten würde da ich oft den FOkus während meiner Arbeit verliere. Dies könnte ich üben in dem ich vielleicht versuche mehr zuhause zu arbeiten da ich dort auf mich alleine gestellt und fokussiert bin.
Neu: Ich bin sehr interessiert daran, mich in dieser Lern-Periode mit API zu beschäftigen und experimentieren.
Ich habe mir überlegt eine URL-Verkürzer-API zu programmieren. Ich habe mich dafür entschieden, da ich denke dass eine solche Applikation bestimmt hilfreich sein kann und ich diese auch zukünftig verwenden werden kann.
20.2.2024
Heute habe ich mir überlegt was ich für ein Projekt in den nächsten 7 Wochen machen möchte. Ich bin gemeinsam mit Niclas und Mert auf die Idee ke^^gekommen, dass wir sehr gerne probieren würden etwas mit API zu machen aber jeweils unterschiedliche Projekte. Ich habe mich dazu entschieden, einen URL-Verkürzer in C# zu programmieren.
Nach dem Planen habe ich jedoch für das Modul 164 an unserem LB gearbeitet. Da müssen wir Tabellen in SQL programmieren.

27.2.2024

- [ ] Nach ergänzungen Recherchieren wie ich meinen Code ggf mit GUI in WInforms erweitern kann.

- [X] Planen was alles im Code vorhanden sein muss.

- [X] Anfangen mit den ersten Zeilen von Code - Ziel, Benutzeringabe(URL) entgegennehmen können

- [X] An meinem Modul 164 LB weiterarbeiten (Dokumentation)


# Testfälle

| Testfall-Nummer |	Ausgangslage (Given) |	Eingabe (When) |	Ausgabe (Then)	| Erfüllt?|

| ----------------- | -------------------------- | ----------------- | ------------------------ | --------- |

| Nr.1 | Bentuzer hat Programm geöffnet | Einfügen URL | Speichern der URL | Erfüllt | 	

| Nr.2 | Benutzer hat programm geöffnet | URL eingefügt |  Verkürzte Version des URL ausgegeben | Erfüllt |

| Nr.3 | Benutzer hat verkürzte URL | Eingabe verkürzter URL | Nach original URL suchen | Nicht erfüllt |

| Nr.4 | Benutzer hat verkürzte URL | EIngabe verkürzter URL | Ausgabe Original URL | Nicht erfüllt | 


# Reflexion
Heute habe ich angefangen eine passende API zu finden. Ich habe eine mögloche API von Herrn Colic erhalten, aber habe schlussendlich eine andere gefunden. Niclas, Mert und ich machen alle ein Projekt, welches eine API beinhaltet und dafür haben wir eine Seite gefunden welche "Rapidapi" heisst ( https://rapidapi.com/hub ). Auf dieser Website, kann man nach beliebigen API's suchen und erhält anschliessend Zugriff auf einen API-Key nachdem man ein Abonnement abgeschlossen hat. Anschliessend habe ich von dort auch eine Vorlage für einen möglichen Code erhalten welche ich gleich verwenden konnte. 
Anschliessend habe ich jedoch nur noch an unserer SQL-LB gearbeitet da morgen die Abgabe dafür ist.



## 5.03.2024 

# Arbeitspakete

- [ ] Die Vorlage so abändern das ich eine selbst bestimmte Ausgabe von meinem URL bekomme.
- [X] Code mit GUI in Winforms erweitern
- [X] Exceptions implementieren ( Ungültige Eingabe falls keine URL eingegeben wurde.
- [X] Die URL in der Konsole eingeben können statt immer im Code ändern zu müssen. 

# Testfälle
- [ ] Ausgabe des URL ist eine selber gewählte verkürzte Ausgabe
- [X] Benutzer hat Namen der Seite statt URL eingegeben -> Ungültige Eingabe
- [X] Ungültige Eingabe -> Erneut nach URL abfragen
- [X] Konsole wurde geöffnet -> Benutzer wird nach URL abgefragt.


Heute habe ich sehr erfolgreich arbeiten können. Ich habe zuerst noch den übrigen Auftrag LA_0705 aus dem Modul 187 von gestern nachgeholt. Dann habe ich meinen Code noch weitergeschrieben und zwar habe ich exceptionsch eingefügt falls etwas anderes als eine URL eingegeben wurde. Das ganze hat erfolgreich funktioniert und man wird nun erneut abgefragt falls die Eingabe ungültig war. Anschliessend habe ich mich informiert, wie ich meinen Code als GUI in Winforms implementieren kann. Was ich auch noch gemacht habe, ist dass ich den Code so abgeändert habe, dass der Benutzer nach öffnen der Konsole bzw nun der Winforms Applikation, nach dem URL gefragt wird und dies nicht im Code vorgenommen werden muss. Ich habe also nun eine Winforms Applikation welche nach öffnen den Benutzer nach einer URl fragt, und diese anschliessend verkürzt wieder ausgegeben wird.


## 12.03.2024 


# Arbeitspakete

- [ ] Meine Winforms Applikation schöner aussehen lassen. (Evt Farbe oder so)
- [ ] Code überarbeiten um immer erneutes öffnen zu verhindern (Fehlerbehebung)
- [ ] Ausgabe des verkürzten URL anpassen dass man den URL kopieren kann. (Evt einen Knopf implementieren welcher automatisch den verkürzten URL kopiert und in die Zwischenablage speichert.)
- [ ] Erneut versuchen den verkürzten Link selbst benennen zu können.


# Testfälle

- [ ] Applikation wird ausgeführt. - Winforms Applikation wird farbig angezeigt.
- [ ] Applikation öffnet sich nur einmal und schliesst sich nachdem man das x antippt.
- [ ] URL wurde eingegeben. - verkürzter URL kann per Knopf kopiert werden.
- [ ] URL wurde eingegeben. - AUsgabe kann bestimmt werden.
	

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen, und in der Spalte Erfüllt? einzutragen, ob Ihr Code die Test-Fälle erfüllt

Heute habe ich leider nicht wirklich an meinen geplanten Arbeitspaketen arbeiten können. Ich habe kurz versucht gehabt, das ganze zu korrigieren und überarbeiten 
dass man den URL kopieren kann aber das hat nicht wirklich funktioniert. Anschliessend habe ich eigentlich nurnoch für das Modul 187 und das Modul 106 gearbeitet, da ich in diesen Modulen noch Aufträge nacharbeiten musste. Im Modul 106 haben wir momentan SQL und da lernen wir gerade wie man Joins verwendet.


## 19.03.2024

# Arbeitspakete

- [ ] Meine Winforms Applikation schöner aussehen lassen. (Evt Farbe oder so)
- [ ] Code überarbeiten um immer erneutes öffnen zu verhindern (Fehlerbehebung)
- [ ] Ausgabe des verkürzten URL anpassen dass man den URL kopieren kann. (Evt einen Knopf implementieren welcher automatisch den verkürzten URL kopiert und in die Zwischenablage speichert.)
- [ ] Erneut versuchen den verkürzten Link selbst benennen zu können.


# Testfälle

- [ ] Applikation wird ausgeführt. - Winforms Applikation wird farbig angezeigt.
- [ ] Applikation öffnet sich nur einmal und schliesst sich nachdem man das x antippt.
- [ ] URL wurde eingegeben. - verkürzter URL kann per Knopf kopiert werden.
- [ ] URL wurde eingegeben. - AUsgabe kann bestimmt werden.


Heute habe ich versucht das Problem mit dem Schliessen der Applikation zu beheben. Ich habe viele verschiedene Dinge versucht und das ganze gemeinsam mit einem Schüler angeschaut, wie auch AI gefragt und verwendet und schlussendlich sogar noch mit der Lehrperson besprochen. Wie sich jedoch herausgestellt hat, hat das ganze nicht ganz so gut funktioniert. Deshalb habe ich mich mit der Lehrperson darauf geeinigt, dass ich das ganze in einer Form hinzufüge. Also versuche ich mich zu informieren wie ich die Buttons etc im Form-Fenster selbst einfügen kann.


## 26.02.2024

# Arbeitspakete

- [ ] Meine Winforms Applikation per Fenster implementieren und nicht mit Code.
- [ ] Den vekürzten Link durch einen "Copy" Button kopieren können.
- [ ] Für das Modul 187 den AUftrag LA_187_0707 & 0710 nacharbeiten
- [ ] Modul 106 Aufträge nacharbeiten

# Testfälle

| Testfallnummer | Ausgangslage | Eingabe | Ausgabe | Erfüllt |
| -------------- | ------------ | ------- | ------- | ------- |
| 1 | Programm wurde geöffnet | "X" zum schliessen | Programm wird geschlossen |  |
| 2 | URL wurde eingegeben | Eingabe des URL | Vekürzter URL + Copy Button |   |



