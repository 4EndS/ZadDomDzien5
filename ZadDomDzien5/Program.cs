

//w21 dzień 5, zadanie domowe  plus zadania z discorda

int number = 1044555788;
Console.WriteLine("numer do sprawdzenia: " + number);
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char lettersChar in letters)
{
    if (lettersChar == '0')
    {
        counter0++;
    }
    else if (lettersChar == '1')
    {
        counter1++;
    }
    else if (lettersChar == '2')
    {
        counter2++;
    }
    else if (lettersChar == '3')
    {
        counter3++;
    }
    else if (lettersChar == '4')
    {
        counter4++;
    }
    else if (lettersChar == '5')
    {
        counter5++;
    }
    else if (lettersChar == '6')
    {
        counter6++;
    }
    else if (lettersChar == '7')
    {
        counter7++;
    }
    else if (lettersChar == '8')
    {
        counter8++;
    }
    else if (lettersChar == '9')
    {
        counter9++;
    }
}
Console.WriteLine("0 ==>" + counter0);
Console.WriteLine("1 ==>" + counter1);
Console.WriteLine("2 ==>" + counter2);
Console.WriteLine("3 ==>" + counter3);
Console.WriteLine("4 ==>" + counter4);
Console.WriteLine("5 ==>" + counter5);
Console.WriteLine("6 ==>" + counter6);
Console.WriteLine("7 ==>" + counter7);
Console.WriteLine("8 ==>" + counter8);
Console.WriteLine("9 ==>" + counter9);




////w21 dzień 5,ĆWICZENIE: zamiana st Celsjusza na  st Fahrenheita
//double c, f;
//Console.WriteLine("Podaj temperaturę w stopniach Celsjusza : ");
//c = float.Parse(Console.ReadLine());
//f = (c * 1.8) + 32;
//Console.WriteLine("Temperatura w st. Fahrenheita wynosi: ");
//Console.WriteLine(f);


////w21 dzień 5, zamiana st.Fahrenheita na Celsjusza
//double f, c;
//Console.WriteLine("Podaj temperaturę w st. Fahrenheta : ");
//f = double.Parse(Console.ReadLine());
//c = (f - 32) * (5.0 / 9);
//Console.WriteLine("temperatura w st Celsjusza wynosi: " + c);




//CWICZENIE: wypisanie dnia tygodnia po numerze

//Console.WriteLine("wprowadź numer dnia tygodnia: ");
//string nrDay = Console.ReadLine();
//if (nrDay == "1")
//    Console.WriteLine("poniedziałek");
//else if (nrDay == "2")
//    Console.WriteLine("wtorek");
//else if (nrDay == "3")
//    Console.WriteLine("środa");
//else if (nrDay == "4")
//    Console.WriteLine("czwartek");
//else if (nrDay == "5")
//    Console.WriteLine("piatek");
//else if (nrDay == "6")
//    Console.WriteLine("sobota");
//else if (nrDay == "7")
//    Console.WriteLine("niedziela");
//else Console.WriteLine("wprowadziłeś niepoprawny nr dnia tygodnia");




//CWICZENIE:  w pętli wyświetla cały alfabet

//string[] alfabet = {"a","ą","b","c","ć","d","e","ę","f","g","h","i","j","k","l","ł","m","n","o","ó","p","q",
//    "r","s","t","u","v","w","x","y","z","ź","ż"};
//foreach (string a in alfabet)
//    Console.Write(" " + a);





//w21 dzien5, CWICZENIE: największa liczba z trzech

//int a = 30, b = 31, c = 32;
//Console.WriteLine("wprowadź pierwszą liczbę");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("wprowadź drugą liczbę");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine("wprowadź trzecią liczbę");
//int c = int.Parse(Console.ReadLine());
//if (a >= b && c >= b)
//    Console.WriteLine("największa liczba to: " + c);
//else if (a <= b && c <= b)
//    Console.WriteLine("największa liczba to: " + b);
//else if (a >= b && c <= a)
//    Console.WriteLine("największa liczba to: " + a);
//else Console.WriteLine(" ");





//w21 dzień 5,  CWICZENIE: sprawdzenie czy liczba jest dodatnia, ujemna czy równa 0,

//int a;
//Console.WriteLine("wprowadź liczbę: ");
//a = int.Parse(Console.ReadLine());

//if (a > 0)
//{
//    Console.WriteLine("wprowadziłeś liczbę dodatnią");
//}
//else if (a < 0)
//{
//    Console.WriteLine("wprowadziłeś liczbę ujemną");
//}
//else if (a == 0)
//{
//    Console.WriteLine("wprowadziłeś liczbę równą zero");
//}



//// CWICZENIE:  tablice odwrotne
//int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//foreach (int x in tab)
//    Console.Write("{0,2},", x);
//    Console.WriteLine("");
//Array.Reverse(tab);
//foreach (int y in tab)
//    Console.Write("{0,2},", y);

////druga tablica odwrotna
//Console.WriteLine("");
//int[] uczestnicy = new int[] { 19, 34, 23, 54, 31, 9, 74, 11, 64 };
//for (int j = 0; j <= 8; j++)
//    Console.Write(uczestnicy[j]+ ", ");
//    Console.WriteLine("");
//int[] odwrotnie = new int[uczestnicy.Length];
//// Wpisywanie elementów do tablicy odwrotnie
//for (int i = uczestnicy.Length - 1; i >= 0; i--)
//    odwrotnie[uczestnicy.Length - i - 1] = uczestnicy[i];
//// Wyświetlenie elementów tablicy odwrotnie
//for (int i = 0; i < odwrotnie.Length; i++)
//    Console.Write(odwrotnie[i]+ ", ");





////CWICZENIE: losowy ciąg 10 liczb
//int n = 10;
//int[] ciag = new int[n];
//Console.WriteLine(n + " liczb wybranych losowo");
//Random rand = new Random();
//for (int i = 0; i < n; i++)
//{
//    ciag[i] = (rand.Next(1, 100));
//    Console.Write(ciag[i] + " ");
//}

//// w21 dzień 5, program wypisuje podane liczb w odwrotnej kolejności
//int[] ciagOdwrotnie = new int[ciag.Length];
//// Wpisywanie elementów do tablicy odwrotnie
//for (int i = ciag.Length - 1; i >= 0; i--)
//{
//    ciagOdwrotnie[ciag.Length - i - 1] = ciag[i];
//}
//// Wyświetlenie elementów tablicy odwrotnie
//Console.WriteLine();
//Console.WriteLine("ten sam ciąg liczb w odwrotnej kolejności ");
//for (int i = 0; i < ciagOdwrotnie.Length; i++)
//{
//    Console.Write(ciagOdwrotnie[i] + " ");
//}
//Console.WriteLine();


//w21 dzień 5, 

//int d;
////double y = 365, m = 31,30, 29, 28 t = 7;
//Console.WriteLine("wprowadź liczbę dni: ");
//d = int.Parse(Console.ReadLine());
//if (d == 0 && d <= 7)
//{
//    Console.WriteLine("{d} dni, {0} lat, {0} tygodni" + d);
//}
////else if (d <= 7 )





// w21 dzień 5, 
//string[] znakiS = {©, ™, , ®, §, °, ↑, ↓, →, ←, ▲, ▼, ►, ◄, ×, ∙, ÷, ±, ≈, ≅, ≤, ≥, √, ∛, ∜, ∞ , ∑, ∧, ∨, 
//‰, ♪, ♫, €, ☺, ☼, —, –, „, ”, …,   , };

//string[] znakSpec = {!, @, #, $, %, ^, &, *, (, ), -, +, {, }, [, ], |, \, :, ;, ", ", ', <, >,/, \, ?, };



//w21 wpisać z konsoli 9 liczb, program wypisuje liczbę max, minimalną i średnią

//int r = 10;
//int suma = 0;
//int[] tLiczb = new int[r];
//int max = tLiczb[0];
//int min = tLiczb[0];
//double srednia;
//Console.WriteLine("wprowadź 9 liczb ");
//Console.WriteLine();
//for (int i = 1; i < tLiczb.Length; i++)
//{
//    Console.WriteLine("wprowadz liczbę : {0}", i);
//    tLiczb[i] = int.Parse(Console.ReadLine());
//    suma += tLiczb[i];
//    if (tLiczb[i] != 0)
//    {
//        if (tLiczb[i] > max) max = tLiczb[i];
//        if (tLiczb[i] < min) min = tLiczb[i];
//    }
//}
//srednia = (double)suma / tLiczb.Length;
//Console.WriteLine("średnia = " + srednia);
//Console.WriteLine("najmniejsza liczba to : " + min + "   największa liczba to: " + max);
//Console.WriteLine();


//do tablicy są wpisywane losowe liczby

//Console.Write("Podaj rozmiar tablicy: ");
//int rozmiar = Convert.ToInt32(Console.ReadLine());
//int[] tab = new int[rozmiar];
//Random rand = new Random();
//int suma;
//double srednia;
//for (int i = 0; i < tab.Length; i++)
//{
//    tab[i] = rand.Next(1, 50);
//    Console.WriteLine(tab[i]);
//}
//int max = tab[0];
//for (int i = 0; i < tab.Length; i++)
//{
//    if (tab[i] > max)
//    {
//        max = tab[i];
//    }
//}
//int min = tab[0];
//for (int i = 0; i < tab.Length; i++)
//{
//    if (tab[i] < min)
//    {
//        min = tab[i];
//    }
//}

//suma = 0;
//srednia = 0;

//for (int i = 0; i < tab.Length; i++)
//{
//    suma += tab[i];
//    srednia = suma / rozmiar;

//}
//Console.WriteLine("Największy element = {0} ", max);
//Console.WriteLine("Największy element tablicy znajduje się na pozycji {0}, ", Array.IndexOf(tab, max));
//Console.WriteLine("Najmniejszy element = {0} ", min);
//Console.WriteLine("Najmniejszy element tablicy znajduje się na pozycji {0}, ", Array.IndexOf(tab, min));
//Console.WriteLine("Suma elementów tablicy wynosi: {0}", suma);
//Console.WriteLine("Średnia liczb tablicy wynosi: {0}", srednia);
//Console.ReadKey();







//int rozmiar = 9;     // wysłano 12.03.2023
//int[] tab = new int[rozmiar];
//int suma;
//double srednia;

//Console.WriteLine("Podaj 9 liczb");
//for (int i = 0; i < tab.Length; i++)
//{
//    Console.WriteLine("podaj {0} liczbę: ",i+1);
//    tab[i] = Convert.ToInt32(Console.ReadLine());

//}
//int max = tab[0];
//for (int i = 0; i < tab.Length; i++)
//{
//    if (tab[i] > max)
//    {
//        max = tab[i];
//    }
//}
//int min = tab[0];
//for (int i = 0; i < tab.Length; i++)
//{
//    if (tab[i] < min)
//    {
//        min = tab[i];
//    }
//}

//suma = 0;
//srednia = 0;

//for (int i = 0; i < tab.Length; i++)
//{
//    suma += tab[i];
//    srednia = (float)suma / rozmiar;

//}
//Console.WriteLine("Największy element = {0} ", max);
//Console.WriteLine("Najmniejszy element = {0} ", min);
//Console.WriteLine("Suma liczb wynosi: {0}", suma); 
//Console.WriteLine("Średnia liczb wynosi: {0,-10:F6}", srednia);
//Console.ReadKey();




//int r = 10;
//int suma = 0;
//int l;
//int max = 0;
//int min = 0;
//double srednia;
//Console.WriteLine("wprowadź 9 liczb ");
//Console.WriteLine();
//for (int i = 1; i < r; i++)
//{
//    Console.WriteLine("wprowadz liczbę : {0}", i);
//    l = int.Parse(Console.ReadLine());
//    suma += l;
//    {
//        if (l < min)  min = l;
//        if (l > max)  max = l;
//    }
//}
//srednia = (double)suma / r;
//Console.WriteLine("średnia = " + srednia);
//Console.WriteLine("najmniejsza liczba to : " + min + "   największa liczba to: " + max);
//Console.WriteLine();





//int;
//int min = int.MaxValue;
//int max = int.MinValue;

//do
//{
//    Console.WriteLine("New number: ");
//    if (!int.TryParse(Console.ReadLine(), out num))
//    {
//        Console.WriteLine("Not an integer. Try again.");
//        num = 1; // Warunek w pętli musi być true;
//        continue;
//    }

//    if (num != 0)
//    {
//        min = Math.Min(num, min);
//        max = Math.Max(num, max);

//        Console.WriteLine("min: {0}, max: {1}", min, max);
//    }
//}
//while (num != 0);





//int suma = 0;
//double srednia;
//int max;

//int rozmiar = 9;
////string[] tabLiczb = new string[rozmiar];
//Console.WriteLine("Wprowadź 9 liczb: ");
//for (int i = 1; i <= rozmiar; i++)
//{
//    Console.WriteLine("podaj liczbę: ", i);
//    int d = int.Parse(Console.ReadLine());
//    suma += d;

//    if ( d > max)
//    {
//        max = d;
//    }

//}
//srednia = (double)suma / rozmiar;
//Console.WriteLine("średnia = " + srednia);
//Console.WriteLine("max ", max);







//Console.WriteLine("Ile chcesz wpisać imion?");
//int rozmiar = Convert.ToInt32(Console.ReadLine());
//string[] imiona = new string[rozmiar];
//for (int i = 0; i < imiona.Length; i++)
//{
//    Console.WriteLine("Podaj {0} imię", i + 1);
//    imiona[i] = Console.ReadLine();
//}
//for (int i = 0; i < imiona.Length; i++)
//{
//    Console.Write(imiona[i] + ", ");
//}
//Console.ReadKey();




//zadanie: napisz program, który przyjmie ciąg znaków i zwróci analizę ile razy występują poszczególne znaki

//Console.WriteLine("wprowadź ciąg znaków, naciśnij enter: ");
////char[] text = Console.ReadLine();
//foreach (char[] x in text)
//{
//    Console.Write("$ znak {x.Key} ilość wystąpień {x.Value}");
//}
////Console.ReadKey;
///

//Console.WriteLine("wprowadź ciąg znaków, naciśnij enter: ");
//string text = Console.ReadLine();
//foreach (char litera in text)
//    Console.WriteLine(litera);
//string result = Count(tekst);
//Console.ReadKey();