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
- [x] Für das Modul 187 den AUftrag LA_187_0707 & 0710 nacharbeiten
- [x] Modul 106 Aufträge nacharbeiten ( 2408 & 2410 )

# Testfälle

| Testfallnummer | Ausgangslage | Eingabe | Ausgabe | Erfüllt |
| -------------- | ------------ | ------- | ------- | ------- |
| 1 | Programm wurde geöffnet | "X" zum schliessen | Programm wird geschlossen |  |
| 2 | URL wurde eingegeben | Eingabe des URL | Vekürzter URL + Copy Button |   |



Heute habe ich versucht an meinem Winforms codo weiterzuarbeiten. Jedoch hatte ich die ganze Zeit Probleme und Fehlermeldungen welche ich selbst nicht wusste wie das zu beheben war. Mir fiel es deshalb sehr schwer, in meinem Winforms meine gewünschten Dinge umzusetzen weshalb ich beschlossen habe, mit dem ganzen bei einer Konsolen-Applikation zu bleiben. Ich habe dafür die Konsolen-Applikation etwas ausgebaut und habe exceptions eingefügt welche dem Benutzer beispielsweise sagt dass die eingegebene URL ungültig ist und den Benutzer anschliessend auffordert eine gültige URL einzugeben. Ebenfalls konnte ich die vorgenommenen Aufträge aus dem Modul 187 und dem Modul 106 nacharbeiten.


## 02.04.2024


# Arbeitspakete

-  [ ] Meine Exceptions überarbeiten und Benutzer solange abfragen bis Eingabe gültig war.
-  [x] Meinen Code verschönern und fertigstellen.
-  [x] Für das Modul 106 arbeiten (Joins verinnerlichen)

# Testfälle

| Testfallnummer | Ausgangslage | Eingabe | Ausgabe | Erfüllt |
| -------------- | ------------ | ------- | ------- | ------- |
| 1 | Programm wurde geöffnet | Ungültige URL wurde eingegeben. | Benutzer wird nach gültiger URL gefragt. | nicht erfüllt |
| 2 | URL wurde eingegeben | Eingabe des URL | Vekürzter URL | erfüllt  |


Heute habe ich versucht meine Exceptions zu überarbeiten in dem es den Benutzer solange nach einer gültigen URL fragt bis dies passiert. Jedoch hat das ganze nicht ganz so geklappt wie ich es mir vorgestellt habe und es wurde relativ kompliziert. Deshalb konnte ich dieses Arbeitspaket nicht erfüllen.
Ich habe jedoch meinen Code überarbeiten und schöner darstellen können wie auch weitere Aufträge im Modul 106 bearbeiten können.






## Reflexion

Ich finde ich konnte relativ gut in dieser LP arbeiten. Ich hatte ein eher kleineres Projekt weil ich mir nebenbei auch noch viel Zeit genommen habe, um andere Aufträge ais andetren Modulen zu bearbeiten. Ich bin währen der Implementierung meines Projekts auf viele Hindernisse gestossen und ihc konnte manche überweinden manche waren jedoch zu anspruchsvoll für mein Niveau. Ich habe während dieser Lp viel dazu gelernt. Zum einen habe ich meine C# Kenntnisse gut erweiter können jedoch habe ich mich auch in Sachen wie Zeitmanagement oder Planung verbessert meiner Meinung nach.
Grundsätzlich bin ich relativ zufrieden mit meiner Arbeit in dieser LP.

Mir persönlich hat die letzte LP besser gefallen. Da ich dort mehr Zeit hatte um an meinem Projekt zu arbeiten. Jedoch war meiner Meinung nach die Länge dieser LP ebenso völlig optimal um nebenbei auch noch für andere Module zu arbeiten. Deshalb würde ich sagen könnte man zukünftig durchaus weiterhin LP's in dieser Länge machen.
Ich versuche jedoch nächstes Mal mehr an einem Programmierprojekt zu arbeiten und evt im Modul-Unterricht etwas Produktiver dass ich nicht so viel nachholen muss.






