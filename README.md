# Övning 4 - Minneshantering

## Svar på frågor

### 1. Hur fungerar stacken och heapen? 
Stacken (också kallad Call Stack) i C# är en del av minneshanteringen och en implemenation av Stack-datastrukturen. 
Stack-datastrukturen fungerar så som att det som läggs till sist, åker ut först (LIFO).
Stacken lagrar de metoder som kallas i koden och kör sedan dessa metoder och när metoden har kört klart tas metoden bort från stacken och nästa metod i stacken körs. 
Alla variabler av typen valuetype tar enbart plats i minnet i den stund som metoden körs. 
Stacken är självskötande.

Heapen är också en del av minneshantering och en implementation av Heap-datastrukturen. 
Man kan tänka sig att det är en del av programmets minne där referencetype värden så som Objekt, Klasser och variabler lagras. 
Även valuetype variabler kan lagras här om t.ex. en variable är definerad för att användas globalt i en klass, då Class är referencetype. 
Heapen sköts av en Garbage Collector som frigör minne från de värden som inte längre används av programmet. 

### 2. Vad är är Value Types respektiv Reference Type och vad skilljer dem åt? 
Value Types är variabler av typen primitiv types (int, double osv.) Dessa variable innehåller de faktiska värdet som variablen tilldelas i koden. 
Reference Type är variabler som innehåller Objekt  (string, instans av en klass m.m.). 
Dessa variabler innehåller en pointer, address till platsen i minnet där självaste värdet är lagrat. 
Dessa värden lagras i den del av programmets minne som är Heapen. 

### 3. Skillnaden mellan de två olika ReturnValue metoderna
Den första metoden använder sig av Value Type variabler (int) och den andra metoden av Reference Type variabler (MyInt). 
I den andra metoden när vi assignar y = x, det vi gör är att vi ändrar y till att peka till x värde i minnet. 
Så efter denna rad pekar x och y till samma värde i minne och genom att assigna y.MyValue = 4 ändar vi x värde av MyValue i minnet till 4. 


