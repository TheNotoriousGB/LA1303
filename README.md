# Projekt-Dokumentation


Gabriel Bischof, John Broder, Ensar Yildirim

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|10.01.2024| 1.1| Dokumentation angefangen zu bearbeiten.                             |
|10.01.2024| 1.2| Wir haben uns informiert, wie wir unser Projekt gut umsetzen können.|
|17.01.2024| 2.1| Wir haben langsam angefangen zu programmieren                       |
|17.01.2024| 2.2| Wir haben die Dokumentation weitergeführt.                          |
|14.02.2024| 3.1| Wir haben die Dokumentation weitergeführt.                          |
|14.02.2024| 3.2| Wir haben unser Projekt beendet                                     |



## 1 Informieren

### 1.1 Ihr Projekt

Unsere Website bietet eine API, mit der man Prüfungsdaten übermitteln können, um sofort die verbleibenden Tage bis zur nächsten Prüfung zu erfahren.

In diesem Projekt möchten wir eine Website entwickeln, die eine benutzerfreundliche API zur Verfügung stellt. Diese API ermöglicht es den Nutzern, ihre Prüfungsdaten und -termine einzugeben. Das System berechnet dann automatisch die verbleibenden Tage bis zur nächsten Prüfung und zeigt sie auf der Website an. Dies soll den Benutzern helfen, ihre Zeit effizienter zu organisieren und sicherzustellen, dass sie gut vorbereitet sind. Bei diesem Projekt hoffen wir, unsere Fähigkeiten in Webentwicklung, API-Design und Datenverarbeitung zu verbessern. Wir möchten auch mehr über die Umsetzung nützlicher Tools für den Alltag lernen und gleichzeitig unsere Programmierkenntnisse erweitern.

### 1.2 User Storys

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Funktional      | Muss | Als ein User möchte ich meine Prüfungen speichern lassen, damit ich aufrufen kann welche Prüfungen anstehen.|
| 2    | Funktional      | Muss | Als ein User möchte ich das Datum der Prüfung speichern lassen, damit ich weiss, wann meine Prüfungen anstehen. |
| 3    | Funktional      | Muss | Als ein User möchte ich das jetzige Datum eingeben, damit ich weiss wie viele Tage fehlen bis die Prüfung anstehen. |
| 4    | Funktional      | Muss | Als ein User möchte ich die eingegebenen Daten, falls nötig, verändern, damit ich das Datum, falls nötig anpassen kann. |
| 5    | Funktional      | Muss | Als ein User möchte ich die eingegebenen Daten, falls nötig, löschen, damit ich Prüfungen, falls sie zum Beispiel erledigt worden sind, löschen können. |
| 6    | Qualität        | Kann | Als ein User möchte ich die eingegebenen Daten in einer Benutzeroberfläche eingeben, damit es einfach und verständlich bearbeiten kann. |
| 7    | Rand            | Kann | Als ein User möchte ich meinen Lernfortschritt eingeben in %, damit ich weiss wie viel man lernen muss. |



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1 | Gebe deine anstehenden Prüfungen ein            | Prüfungen            | Anstehende Prüfung                  |
| 1.2 | Gebe das Datum deiner anstehenden Prüfungen ein | Datum                | Datum der anstehenden Prüfungen     |
| 1.3 | Jetziges Datum eingeben                         | Datum                | Datum der anstehenden Prüfungen     |
| 1.4 | neues Datum eingeben                            | neues Datum          | Das neue Datum                      |
| 1.5 | Möchten Sie die Prüfung löschen                 | Ja                   | Prüfung gelöscht                    |
| 1.6 | Daten eingeben                                  | Daten                | Angegebene Daten werden angezeigt   |
| 1.7 | Lernfortschritt eingeben                        | Lernfortschritt in % | Lernfortschritt wird in % angezeigt |


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |24.01.2024|Alle    | API erstellen  mit Datenbank           |90 min |
| 2.A  |24.01.2024|Alle    | Crud erstellen                         |90min  |
| 3.A  |24.01.2024|Alle    | Speicherung von Daten in der Datenbank |90 min |
| 4.A  |24.01.2024|Alle    | API mit Postman oder Swagger testen    |90 min |
| 5.A  |24.01.2024|Alle    | API mit Docker Container verbinden     |90 min |
| 6.A  |24.01.2024|Alle    | Dauer bis zur Prüfung ausgeben         |90 min |
| 7.A  |24.01.2024|Alle    | Lernfortschritt speichern              |90 min |



Total: 630 min

## 3 Entscheiden

Wir haben uns entschieden unser Projekt mit Postman und Swagger zu testen.
## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |17.01.2024| Alle                            |90 min| 90 min |
| 2.A  |17.01.2024| John Broder, Gabriel Bischof    |90 min| 90 min | 
| 3.A  |14.02.2024| Ensar Yildirim                  |90 min| 90 min | 
| 4.A  |14.02.2024| John Broder                     |90 min| 60 min |
| 5.A  |14.02.2024| Ensar Yildirim, Gabriel Bischof |90 min| 120 min|

Total: 450 min 


## 5 Testen

|  TC-№	  | Datum  |Resultat|
| ------------- | ------------- | ---------------|
| 1.1  |21.02.2024   |   OK             |
| 1.2| 21.02.2024   |    OK            |
| 1.3  |21.02.2024   |  OK              |
| 1.4|21.02.2024  |     OK           |
| 1.5|21.02.2024  |     OK           |
| 1.6|21.02.2024  |     OK           |
| 1.7|21.02.2024  |     nicht OK           |
