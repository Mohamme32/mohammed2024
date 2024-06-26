using Microsoft.VisualBasic;

string name = "Mohammed";
/* 
 * DateTime ist einer von Vielen komplexen Datentypen in C#.
 * DateTime ist ein Strukturtyp,
 * Objekte können nur in der Konsole ausgegeben werden wenn sie eine Methode Tostring () haben.
 */
DateTime date = DateTime.Now;
Console.WriteLine(date.Year);

Console.WriteLine(name);

// Funktionen 
// x = 5y
/* Collections - Basics
 * string [] namen = new string [5]; das ist die alteste Methode 
 * Array ist eine Liste an Werten 
 * Eine Kontinuirliche Speicherregion , für mehrere Daten eiens gewissen Types 
 * // Collections-Basics
// Array
string[] namen = new string[5];
string[] alternative_namen = ["Tobi", "Popstar", "Lehrer"]; // max 3 items
string[] alternative_namen1 = { "Ab", "Bc", "Cd" };
namen[0] = "Tobi";
namen[1] = "Melanie";
namen[2] = "Torben";
namen[99999999999999998] = "Buxtehude!";
Console.WriteLine(namen[0][0]);


// Array ist eine Liste an Werten
// Eine kontinuirliche Speicherregion, für mehrere Daten eines gewissen Types
int[] nums = new int[5];
*/
//int x = 0;
//x = x + 1;
//x += 1;
//x++;

//Console.WriteLine("hi" + x)