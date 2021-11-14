# NasaAPI
## Mobilní aplikace - Android

# Specifikace požadavků

Martin Goffa <br/>
goffa.martin@skola.ssps.cz <br/>
13. 11. 2021

Verze 1.0

* Úvod
  * Účel dokumentu
    * Účelem tohoto dokumentu je vytvoření Mobilní Android aplikace, která bude zobrazovat online data o asteroidech
  * Kontakty
    * Martin Goffa goffa.martin@skola.ssps.cz
  * Odkazy na ostatní dokumenty
    * https://api.nasa.gov/
* Celkový popis
  * Funkce
    * Aplikace bude volat API, ze kterého bude zobrazovat data o asteroidech
    * Data by měla uživateli dát stručný přehled o tělesech, která se aktuálně vyskytují v okolí Země
    * Data se budou skládat z názvu tělesa, rychlosti, odhadovaného průměru, datumu a času příblížení a vzdálenosti
    * Uživatel bude mít možnost rozkliknout těleso pro obsáhlejší informace
  * Uživatelské skupiny
    * běžný uživatel (aplikace má pouze jeden způsob užívání)
  * Omezení návrhu a implementace   
    * Volání API pouze v případě, že má uživatel připojení k internetu
* Požadavky na rozhraní
  * Uživatelská rozhraní 
    * Xamarin Forms
  * Softwarová rozhraní 
    * Android
* Vlastnosti systému
  1. Vypsání nových dat
    * Vstup: uživatel může refreshnout data pomocí swipnutí dolů, jestliže má připojení k internetu
    * Akce: volání API na základě aktuálního datumu
    * Výstup: zobrazení požadovaných informací o asteroidech v přehledném rozložení
  2. Refresh
    * Vstup: Swipnutí dolů
    * Akce: zavolání API a spracování dat + vypsání datumu poslední aktualizace do Labelu
    * Výstup: Aktualizovaná data se zobrazí v uživatelském rozhraní  
  3. Podrobný popis
    * Vstup: uživatel klikne na asteroid
    * Akce: otevření nového okna, které obsahuje podrobný popis
    * Výstup: zobrazení informací o asteroidu 
* Nefunkční požadavky
    * Odezva
      * Systém úspěšně vyhledá a vypíše požadovaná data do 6 sekund
    * Spolehlivost
      * 99% šance že systém úspěšně vyhledá a vypíše požadovaná data 
    * Bezpečnost
      * Systém nepracuje s žádnými osobními daty

# Funkční specifikace

Verze 1.0

* Úvod
  * Účel dokumentu
    * Účelem tohoto dokumentu je vytvoření mobilní Android aplikace, která bude zobrazovat online data o asteroidech
  * Kontakty
    * Martin Goffa goffa.martin@skola.ssps.cz
  * Odkazy na ostatní dokumenty
    * https://api.nasa.gov/
* Scénáře
  * Způsoby použití
    * Uživatel má možnost zobrazit si informace o tělesech, která se aktuálně přiblížila k zemi
    * Těmito informacemi je myšleno: název tělesa, rychlost, odhadovaný průměr, datum a čas příblížení a vzdálenost od Země
  * Personas
    * Každý uživatel má stejná práva v aplikaci, nijak se nepřihlašují, nijak se neliší 
  * Vymezení rozsahu
    * Aplikace bude pouze v českém jazyce
* Celková hrubá architektura
  * Pracovní tok
    * Uživatel spustí aplikaci
    * Pokud má připojení k internetu, zavolá se API a zpracují se data
    * zobrazí se výpis všech asteroidů, která se aktuálně přiblížila k zemi
  * Detaily
    * Aplikace bude mít MainPage
      * Titel: Asteroidy 
      * Datum poslední aktualizace pomocí labelu
      * Data o asteroidech
    * pozadí pomocí světlého gradientu
    * Tmavě šedý text
    * Asteroidy rozděleny do určitých bloků pomocí ListView
      * Label nahoře vlevo: Název asteroidu
      * Labely pod názvem: Datum přiblížení, Odh. průměr, rychlost
      * Button: Podrobný popis
        * otevře okno s podrobným popisem
          * Label nahoře vlevo: Název asteroidu
          * Labely pod názvem: ID, Datum přiblížení, Odh. průměr v km a m, rychlost v km/s a km/h, vzdálenost od Země v km, au a LD, Potenciálně nebezpečný? (Ano/Ne)
          * Možnost se vrátit zpět na původní stránku
    * Refresh pomocí swipnutí dolů
  * Všechny dohodnuté principy 
    * Data vypisována na základě API 
    
