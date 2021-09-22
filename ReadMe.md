# Framework
Von Prof. Gehrer @leoggehrer
https://github.com/leoggehrer/SmartNQuick

# Systemstruktur [TradingCompany Backend]

## Lernzielkontrolle:

```
In dieser Lernzielkontrolle wird folgendes überprüft:
```
- Erstellen einer Backend-Systemstruktur
- Erstellen einer REST-Schnittstelle

**TradingCompany**
Aufgabe: **Grundsystem**

**TradingCompany** – Erstellen Sie ein System für eine Handels-Gesellschaft mit der System-Architektur
aus dem Unterricht. Das System soll folgende Komponenten bereitstellen:

### Product

**Name Type Nullable Attributes**
Number String No Unique Length 8
Name String No Length 256
Price decimal No

### Customer

**Name Type Nullable Attributes**
Number String No Length 8
Name String No Length 256

### Condition

**Name Type Nullable Attributes**
Product Reference No Reference to Product
Customer Reference No Reference to Customer
ConditionType Enum No Type of condition
Quantity double No Sales or number of items
Value decimal No Discount or flat rate

### Order

**Name Type Nullable Attributes**
Product Reference No Reference to Product
Customer Reference No Reference to Customer
CreatedOn DateTime No Creation date of order.
Count int No Numbers of Products
PriceNet decimal No Total price net
Discount decimal No Discount

**Hinweis** : Die Datenstruktur kann natürlich an die eigenen Anforderungen erweitert bzw. angepasst
werden.

### ConditionType :

- PieceDiscountRelative, // Rabatt ab einer bestimmten Stückzahl
- PieceDiscountAbsolute, // Abzug ab einer bestimmten Stückzahl
- ValueDiscountRelative, // Rabatt ab einem bestimmten Bestellwert
- ValueDiscountAbsolute, // Abzug ab einem bestimmten Bestellwert


Erstellen Sie die Schnittstellen, Entitäten, die Kontroller und die entsprechende Datenbank.
Anschließend implementieren Sie die Logik des Systems.

**Beschreibung der Logik** :
Die Handels-Gesellschaft handelt mit verschiedensten Produkten (Product) und wickelt nur
Geschäfte mit registrierten Kunden ab. Bestellen können also nur von registrierten Kunden
(Customer) durchgeführt werden. Dabei kann das Unternehmen für bestimmte Kunden und Produkte
unterschiedliche Konditionen anbieten.

**_Beispiele für Konditionen:_**

Kunde A erhält für das Notebook X einen Rabatt von 10% (ConditionType: PieceDiscountRelative,
Quantity: 10) ab einer Stückzahl von 5 (Value).

Kunde A erhält für das Notebook X einen Rabatt von 200 (ConditionType: PieceDiscountAbsolute,
Quantity: 200 ) ab einer Stückzahl von 10 (Value).

Kunde A erhält für das Notebook X einen Rabatt von 1 5 % (ConditionType: ValueDiscountRelative,
Quantity: 15 ) ab einem Umsatz 3300 (Value).

Kunde A erhält für das Notebook X einen Rabatt von 500 (ConditionType: ValueDiscountAbsolut,
Quantity: 500 ) ab einem Umsatz 4500 (Value).

Nachfolgend die Wertebelegung der Tabelle **_Condition_**

**Kunde Produkt ConditionType Quantity Value Anmerkung**
C Y ...
A X PieceDiscountRelative 10 5 10 % Rabatt ab 5 Stück
A X PieceDiscountAbsolute 200 10 200 EUR Rabatt ab 10 Stück
A X ValueDiscountRelative 15 3300 15 % Rabatt ab einen Umsatz
von 3300 EUR
A X ValueDiscountAbsolut 500 4500 500 EUR Rabatt ab einen
Umsatz von 4500 EUR
A Y ...
B Z ...

**Anmerkung** : Die Werte in Kunden (A, B und C) und Produkt (X, Y und Z) sind Stellvertreter für die
entsprechenden Referenzen.

Das System muss bei einer Bestellung jene Kondition auswählen, welche für den Kunden den größten
Rabatt bereitstellt berücksichtigen.
