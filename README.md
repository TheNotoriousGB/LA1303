# Projekt-Dokumentation


Gabriel Bischof, John Broder, Ensar Yildirim

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|10.01.2024| 0.0.1| Dokumentation angefangen zu bearbeiten. |
|10.01.2024| 0.0.2|Wir haben uns informiert, wie wir unser Projekt gut umsetzen können.|
|17.01.2024| 1.0.0|Wir haben langsam angefangen zu programmieren         |
|17.01.2024| 1.0.0|Wir haben die Dokumentation weitergeführt.         |


## 1 Informieren

### 1.1 Ihr Projekt

Unsere Website bietet eine API, mit der man Prüfungsdaten übermitteln können, um sofort die verbleibenden Tage bis zur nächsten Prüfung zu erfahren.

In diesem Projekt möchten wir eine Website entwickeln, die eine benutzerfreundliche API zur Verfügung stellt. Diese API ermöglicht es den Nutzern, ihre Prüfungsdaten und -termine einzugeben. Das System berechnet dann automatisch die verbleibenden Tage bis zur nächsten Prüfung und zeigt sie auf der Website an. Dies soll den Benutzern helfen, ihre Zeit effizienter zu organisieren und sicherzustellen, dass sie gut vorbereitet sind. Bei diesem Projekt hoffen wir, unsere Fähigkeiten in Webentwicklung, API-Design und Datenverarbeitung zu verbessern. Wir möchten auch mehr über die Umsetzung nützlicher Tools für den Alltag lernen und gleichzeitig unsere Programmierkenntnisse erweitern.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Funktional      | Muss | Als ein User möchte ich meine Prüfungen speichern lassen, damit ich aufrufen kann welche Prüfungen anstehen.|
| 2    | Funktional      | Muss | Als ein User möchte ich das Datum der Prüfung speichern lassen, damit ich weiss wann meine Prüfungen anstehen. |
| 3    | Funktional      | Muss | Als ein User möchte ich das jetzige Datum eingeben, damit ich weiss wie viele Tage fehlen bis die Prüfung anstehen. |
| 4    | Funktional      | Muss | Als ein User möchte ich die eingebenen Daten falls nötig verändern, damit ich das Datum falls nötig anpassen kann. |
| 5    | Funktional      | Muss | Als ein User möchte ich die eingebenen Daten falls nötig löschen, damit ich Prüfungen falls sie zum Beispiel erledigt worden sind löschen können. |
| 6    | Qualität        | Kann | Als ein User möchte ich die eingebenen Daten in einer Benutzeroberfläche eingeben, damit es einfach und verständlich bearbeiten kann. |
| 7    | Rand            | Kann | Als ein User möchte ich meinen Lernfortschritt eingeben in %, damit ich weiss wie viel man lernen muss. |




✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1 | Gebe deine anstehenden Prüfungen ein   |Prüfungen          | Anstehende Prüfung                  |
| 1.2 | Gebe das Datum deiner anstehenden Prüfungen ein       |Datum        |  Datum der anstehenden Prüfungen               |
| 1.3 | Jetziges Datum eingeben       |Datum       | Datum der anstehenden Prüfungen               |
| 1.4 | neues Datum eingeben       |neues Datum       | Das neue Datum               |
| 1.5 | Möchten Sie die Prüfung löschen|   Ja    | Prüfung gelöscht               |
| 1.6 |Daten eingeben|   Daten  | Angegebene Daten werden angezeigt               |
| 1.7 |Lernfortschritt eingeben|   Lernfortschritt in %  | Lernfortschritt wird in % angezeigt|


✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️Fügen Sie hier ein Use Case-Diagramm mit mindestens 3 Anwendungsfällen ein; und eine Skizze davon, wie Ihre Netzseite aussehen sollte.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |24.01.2024|Alle    | API erstellen  mit Datenbank |   90 min |
| 2.A  |24.01.2024|Alle    | API mit Postman oder Swagger testen|90 min |
| 3.A  |24.01.2024|Alle    | API mit Docker Container verbinden  |90 min |
| 3.B  |24.01.2024|Alle    | Speicherung von Daten in der Datenbank |90 min |
| 4.A  |24.01.2024|Alle    |eingegebene  Daten bearbeiten|90 min |
| 5.A  |24.01.2024|Alle    | eingegebene Daten löschen|90 min |
| 6.A  |24.01.2024|Alle    | Dauer bis zur Prüfung ausgeben  |90 min |
| 7.A  |24.01.2024|Alle    |Lernfortschritt speichern|90 min |



Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
