# ILA3_0110

Schulverwaltungsapplikation

Teammitglieder: **Gabriel** **Bischof**, Giuliano Martullo

---

## Versionsverlauf

| Datum    | Version | Zusammenfassung                                                          |
| -------- | ------- | ------------------------------------------------------------------------ |
|   23.08.2024       | 0.1       |  Wir haben unsere Planung erstellt und haben mit den ersten Arbeitespaketen angefangen.|
|30.08.2024|0.2| Wir haben uns anfangs Tag besprochen und haben danach mit dem Abarbeiten der Arbeitspakete weitergemacht|

## 1 Informieren

### 1.1 Ihr Projekt

Wir erstellen eine Applikation zur Schulverwaltung. Schüler und Lehrpersonen können erfasst und bearbeitet werden und werden nach Schuljahren zu Klassen eingeteilt.


## 1.2 User Stories

| US-№ | Verbindlichkeit | Typ (Funktional oder Qualität) | Beschreibung                                                                                                                             |
| ---- | --------------- | ----------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- |
| 1    | Muss            | Funktional                    | Als Administrator möchte ich eine Datenbank haben, die alle relevanten Informationen über Schüler, Lehrpersonen, Klassen und Schuljahre speichert. |
| 2    | Muss            | Funktional                    | Als Administrator möchte ich eine API nutzen, um Schüler, Lehrpersonen und Klassen zu verwalten, damit ich CRUD-Operationen durchführen kann.  |
| 3    | Muss            | Funktional                    | Als Benutzer möchte ich mich registrieren und anmelden können, um Zugang zur Applikation zu erhalten und meine Rolle entsprechend nutzen zu können. |
| 4    | Muss            | Funktional                    | Als Lehrer oder Administrator möchte ich Schüler- und Lehrpersonendaten über eine benutzerfreundliche Oberfläche eingeben und bearbeiten können. |
| 5    | Muss            | Qualität                      | Als Administrator möchte ich, dass alle Eingabedaten validiert werden, um sicherzustellen, dass die Informationen korrekt und vollständig sind. |
| 6    | Muss            | Funktional                    | Als Administrator möchte ich Klassen erstellen, bearbeiten und verwalten können, um die Struktur der Schule digital abzubilden.             |
| 7    | Muss            | Funktional                    | Als Lehrer oder Administrator möchte ich Schülern und Lehrpersonen Klassen zuordnen können, um den Überblick über die Klassenstruktur zu behalten. |
| 8    | Soll            | Funktional                    | Als Benutzer möchte ich schnell nach Schülern, Lehrpersonen oder Klassen suchen können, um die gewünschten Informationen schnell zu finden. |
| 9    | Soll            | Qualität                      | Als Projektverantwortlicher möchte ich sicherstellen, dass die Applikation stabil und fehlerfrei läuft, um eine reibungslose Nutzung zu gewährleisten. |
| 10   | Soll            | Qualität                      | Als Projektverantwortlicher möchte ich eine vollständige Dokumentation und Übergabe des Projekts sicherstellen, um eine einfache Wartung zu ermöglichen. |

## 1.3 Testfälle

| TC-№ | Ausgangslage                          | Eingabe                                                 | Erwartete Ausgabe                                                                 |
| ---- | ------------------------------------- | ------------------------------------------------------- | --------------------------------------------------------------------------------- |
| 1    | Datenbank ist leer.                   | Administrator erstellt eine neue Tabelle für Schüler.   | Tabelle wird erfolgreich erstellt und ist in der Datenbank sichtbar.              |
| 2    | Datenbank und API sind implementiert. | Administrator sendet eine POST-Anfrage über die API.    | Der Datensatz wird korrekt in die Datenbank eingefügt.                            |
| 3    | Benutzer ist nicht eingeloggt.        | Benutzer versucht sich mit gültigen Anmeldeinformationen einzuloggen. | Benutzer wird erfolgreich eingeloggt und erhält die entsprechenden Rechte.        |
| 4    | Benutzer ist eingeloggt.              | Lehrer füllt das Formular zur Erfassung von Schülerdaten aus und sendet es ab. | Die Daten werden erfolgreich gespeichert und sind in der Datenbank sichtbar.      |
| 5    | Benutzer gibt Daten in das Formular ein. | Benutzer übermittelt unvollständige Daten.               | System zeigt eine Fehlermeldung und verweigert das Speichern der unvollständigen Daten. |
| 6    | Benutzer ist eingeloggt.              | Administrator erstellt eine neue Klasse.                 | Die Klasse wird erfolgreich erstellt und erscheint in der Klassenliste.           |
| 7    | Schüler und Lehrpersonen sind erfasst. | Lehrer zieht Schüler und Lehrpersonen in eine Klasse.   | Die Zuordnung wird erfolgreich gespeichert, und die Klasse zeigt die korrekten Schüler und Lehrpersonen an. |
| 8    | Datenbank enthält mehrere Einträge.   | Benutzer sucht nach einem bestimmten Schülernamen.      | Der gesuchte Schüler wird korrekt angezeigt, und die Details sind zugänglich.     |
| 9    | Applikation ist vollständig entwickelt. | Benutzer navigiert durch verschiedene Funktionen.       | Die Applikation läuft stabil und es treten keine Fehler auf.                      |


## 2 Planen

| AP-№ | Frist    | Zuständig | Beschreibung                                                                                                          | geplante Zeit (Minuten) |
| ---- | -------- | --------- | --------------------------------------------------------------------------------------------------------------------- | ----------------------- |
| 1    | 15.09.23 | Giuliano  | **Datenbankdesign und -implementierung:** Entwurf und Implementierung einer relationalen Datenbank zur Speicherung von Informationen über Schüler, Lehrpersonen, Klassen und Schuljahre. | 240                     |
| 2    | 22.09.23 | Giuliano  | **API-Entwicklung zur Datenverwaltung:** Entwicklung einer RESTful API, um CRUD-Operationen (Create, Read, Update, Delete) für Schüler, Lehrpersonen und Klassen zu ermöglichen. | 300                     |
| 3    | 29.09.23 | Gabriel   | **Benutzerverwaltung und Authentifizierung:** Implementierung eines Anmelde- und Registrierungssystems mit verschiedenen Rollen (Lehrer, Administrator) und entsprechenden Zugriffsrechten. | 180                     |
| 4    | 06.10.23 | Gabriel   | **Erfassungsmaske für Schüler und Lehrpersonen:** Erstellung von Frontend-Formularen zur Eingabe und Bearbeitung von Schüler- und Lehrpersonen-Daten, die an die API angebunden sind. | 240                     |
| 5    | 13.10.23 | Gabriel   | **Validierung und Datenprüfung:** Implementierung von Validierungslogik für die Eingabeformulare, um sicherzustellen, dass alle erfassten Daten korrekt und vollständig sind. | 120                     |
| 6    | 20.10.23 | Gabriel   | **Entwicklung der Klassenverwaltung:** Implementierung einer Funktionalität zur Erstellung, Bearbeitung und Verwaltung von Klassen und deren Zuordnung zu Schuljahren. | 180                     |
| 7    | 27.10.23 | Gabriel   | **Schüler- und Lehrer-Zuordnung zu Klassen:** Entwicklung einer Oberfläche zur Zuordnung von Schülern und Lehrpersonen zu Klassen, inklusive Drag-and-Drop oder anderer intuitiver Interaktionsmethoden. | 240                     |
| 8    | 03.11.23 | Gabriel   | **Anzeige- und Suchfunktion:** Implementierung einer Funktion zur Anzeige von Schülern, Lehrpersonen und Klassen, sowie einer Suchfunktion zur schnellen Auffindbarkeit von Datensätzen. | 150                     |
| 9    | 10.11.23 | Giuliano   | **Test und Debugging der gesamten Applikation:** Durchführung umfassender Tests zur Sicherstellung, dass alle Funktionen korrekt und zuverlässig arbeiten. Behebung von Fehlern und Optimierung der Benutzeroberfläche. | 360                     |
| 10   | 17.11.23 | Giuliano   | **Dokumentation und abschließende Übergabe:** Erstellung einer Benutzerdokumentation sowie einer technischen Dokumentation für die zukünftige Wartung. Abschlussbesprechung und Übergabe des Projekts. | 180                     |


## 3 Realisieren

siehe Projektberichte

## 4 Kontrollieren

### Testprotokoll

| TC-№ | Datum | Resultat | Tester   |
| ---- | ----- | -------- | -------- |
| 1    |    26.10   |  OK        |   Giuliano Martullo       |
| 2    |   26.10    | NOK         |  Giuliano Martullo        |
| 3    |   26.10    | NOK         |  Giuliano Martullo        |
| 4    |   26.10    | NOK         |  Giuliano Martullo        |
| 5    |   26.10    | NOK         |  Giuliano Martullo        |
| 6    |   26.10    | NOK         |  Giuliano Martullo        |
| 7    |   26.10    | NOK         |  Giuliano Martullo        |
| 8    |   26.10    | NOK         |  Giuliano Martullo        |
| 9    |   26.10    | NOK         |  Giuliano Martullo        |

