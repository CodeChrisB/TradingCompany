# Framework
Von Prof. Gehrer @leoggehrer
https://github.com/leoggehrer/SmartNQuick

# TradingCompany

Das Projekt 'TradingCompany' ist ein kleiner Framework f�r die Erstellung von datenzentrierten Anwendungen. Ausgehend von diesem System k�nnen neue Anwendungen erstellt und erweitert werden. Der Framework unterst�tzt die Entwicklung einfacher Service-Anwendungen als auch die Erstellung von gro�en skalierbaren System-Anwendungen. Bei der Herstellung dieser Systeme wird der Entwickler von einem Code-Generator unterst�tzt. Details zur Arbeitsweise des Generators folgen in den n�chste Kapiteln.  
Die Struktur des Frameworks besteht aus folgende Teilprojekten:

|Projekt|Beschreibung|Typ|Abh�ngigkeit
|---|---|---|---|
|**CommonBase**|In diesem Projekt werden alle Hilfsfunktionen und allgemeine Erweiterungen zusammengefasst. Diese sind unabh�ngig vom Problembereich und k�nnen auch in andere Dom�n-Projekte wiederverwendet werden.|Library|keine
|**TradingCompany.Contracts**|In diesem Projekt werden alle f�r das System notwendigen Schnittstellen und Enumerationen implementiert.|Library|keine
|**TradingCompany.Logic**|Dieses Projekt beinhaltet den vollst�ndigen Datenzugriff, die gesamte Gesch�ftslogik und stellt somit den zentralen Baustein des Systems dar.|Library|CommonBase, TradingCompany.Contracts
|**TradingCompany.Transfer**|In diesem Projekt werden alle Transferobjekte f�r den Datenaustausch, zwischen den einzelnen Schichten, verwaltet.|Library|CommonBase, TradingCompany.Contracts
|**TradingCompany.WebApi**|In diesem Projekt ist die REST-Schnittstelle implementiert. Diese Modul stellt eine API (Aplication Programming Interface) f�r den Zugriff auf das System �ber das Netzwerk zur Verf�gung.|Host|CommonBase, TradingCompany.Transfer, TradingCompany.Logic
|**TradingCompany.Adapters**|In diesem Projekt ist der Zugriff auf die Logik abstrahiert. Das bedeutet, dass der Zugriff auf die Gesch�ftslogik direkt oder �ber die REST-Schnittstelle erfolgen kann. F�r dieses Modul ist die Schnittstelle 'IAdapterAccess\<T\>' im Schnittstellen-Projekt implementiert. N�here Details dazu finden sich im Kapitel 'Kommunikation der Layer'.|Host|CommonBase, TradingCompany.Contracts, TradingCompany.Logic, TradingCompany.Transfer
|**TradingCompany.ConApp**|Dieses Projekt dient als Initial-Anwendung zum Erstellen eines System-Administrators und eventuell weiterer Benutzer. Zudem kann diese auch zum Kopieren und Ausgeben der Daten verwendet werden. |Console|TradingCompany.Contracts, TradingCompany.Logic
|**CSharpCodeGenerator.ConApp**|In diesem Projekt ist die Code-Generierung implementiert. F�r alle System-Ebenen werden Standard-Komponenten generieriert. Diese Standard-Komponenten werden als 'partial'-Klasse generiert und k�nnen somit durch �berschreiben von Eigenschaften und/oder Methoden bzw. durch das Erg�nzen mit 'partial'-Methoden angepasst werden. Als Eingabe f�r den Generator dient das Schnittstellen-Projekt (TradingCompany.Contracts). Aus den Schnittstellen werden alle Informationen f�r die Generierung ermittelt. Der Generator wird automatisch bei einer �nderung der Schnittstellen ausgef�hrt.|Console|CommonBase
|**TradingCompany.AspMvc**|Diese Projekt beinhaltet die Basisfunktionen f�r eine AspWeb-Anwendung und kann als Vorlage f�r die Entwicklung einer einer AspWeb-Anwendung mit dem TradingCompany Framework verwendet werden.|Host|CommonBase, TradingCompany.Contracts, TradingCompany.Adapter
|**TradingCompany.XxxYyy**|Es folgen noch weitere Vorlagen von Client-Anwendungen wie Angular, Blazor und mobile Apps. Zum jetzigen Zeitpunkt existiert nur die AspMvc-Anwendung. Die Erstellung und Beschreibung der anderen Client-Anwendungen erfolgt zu einem sp�teren Zeitpunk.|Host|CommonBase, TradingCompany.Contracts, TradingCompany.Adapter.
