class Program
{
    static void Main()
    {
        //ex1();
        //ex2();
        //ex3();
        // ex4();
        // ex5();
        // ex6();
        // ex7();
        // ex8();
        // ex9();
        //ex10();
        //ex11();
        //ex12();
        //ex13();
        //ex14();
        //ex15();
        //ex16();
        //ex17();
        //ex18();
        //ex19();
        //ex20();
        //ex21();
        //ex22();
        //ex23();
        //ex24();
        //ex25();
        //ex26();
        //ex27();
        //ex28();
        //ex29();
        //ex30();
    }
    static void ex1()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        // Declarați și inițializați vectorul
        int[] vector = new int[n];

        // Citirea elementelor vectorului de la tastatură
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Calculul sumei elementelor
        int suma = 0;
        for (int i = 0; i < n; i++)
        {
            suma += vector[i];
        }

        // Afișarea rezultatului
        Console.WriteLine($"Suma elementelor vectorului este: {suma}");
    }
    static void ex2()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        // Declarați și inițializați vectorul
        int[] vector = new int[n];

        // Citirea elementelor vectorului de la tastatură
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Introduceti valoarea k: ");
        int k = int.Parse(Console.ReadLine());

        // Determinarea primei poziții în care apare k
        int pozitie = GasestePozitie(vector, k);

        // Afișarea rezultatului
        if (pozitie != -1)
        {
            Console.WriteLine($"Prima pozitie in care apare {k} este: {pozitie + 1}");
        }
        else
        {
            Console.WriteLine($"{k} nu apare in vector. Rezultat: -1");
        }
    }

    static int GasestePozitie(int[] vector, int k)
    {
        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] == k)
            {
                return i;
            }
        }
        return -1; // Returnează -1 dacă k nu apare în vector
    }
    static void ex3()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        // Declarați și inițializați vectorul
        int[] vector = new int[n];

        // Citirea elementelor vectorului de la tastatură
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Determinarea pozițiilor celor mai mici și celor mai mari elemente
        int minPos = -1;
        int maxPos = -1;

        for (int i = 0; i < n - 1; i += 2)
        {
            int localMinPos, localMaxPos;

            // Comparăm între elementele curente și găsim minimul și maximul local
            if (vector[i] < vector[i + 1])
            {
                localMinPos = i;
                localMaxPos = i + 1;
            }
            else
            {
                localMinPos = i + 1;
                localMaxPos = i;
            }

            // Actualizăm pozițiile globale ale minimului și maximului
            if (minPos == -1 || vector[localMinPos] < vector[minPos])
                minPos = localMinPos;

            if (maxPos == -1 || vector[localMaxPos] > vector[maxPos])
                maxPos = localMaxPos;
        }

        // Afișarea rezultatului
        Console.WriteLine($"Pozitia celui mai mic element: {minPos + 1}");
        Console.WriteLine($"Pozitia celui mai mare element: {maxPos + 1}");
    }
    static void ex4()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        // Declarați și inițializați vectorul
        int[] vector = new int[n];

        // Citirea elementelor vectorului de la tastatură
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Determinarea celei mai mici și celei mai mari valori, împreună cu numărul de apariții
        int minValue = vector[0];
        int maxValue = vector[0];
        int minCount = 1;
        int maxCount = 1;

        for (int i = 1; i < n; i++)
        {
            if (vector[i] < minValue)
            {
                minValue = vector[i];
                minCount = 1;
            }
            else if (vector[i] == minValue)
            {
                minCount++;
            }

            if (vector[i] > maxValue)
            {
                maxValue = vector[i];
                maxCount = 1;
            }
            else if (vector[i] == maxValue)
            {
                maxCount++;
            }
        }

        // Afișarea rezultatului
        Console.WriteLine($"Cea mai mica valoare: {minValue}, apare de {minCount} ori");
        Console.WriteLine($"Cea mai mare valoare: {maxValue}, apare de {maxCount} ori");
    }
    static void ex5()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        // Declarați și inițializați vectorul
        int[] vector = new int[n];

        // Citirea elementelor vectorului de la tastatură
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Citirea valorii e și poziției k
        Console.Write("Introduceti valoarea e: ");
        int e = int.Parse(Console.ReadLine());

        Console.Write("Introduceti pozitia k: ");
        int k = int.Parse(Console.ReadLine());

        // Verificarea dacă poziția k este validă
        if (k < 0 || k > n)
        {
            Console.WriteLine("Pozitie invalida. Programul se va incheia.");
            return;
        }

        // Inserarea valorii e în vector pe poziția k
        InserareInVector(ref vector, e, k);

        // Afișarea vectorului actualizat
        Console.WriteLine("Vectorul actualizat:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"{vector[i]} ");
        }
    }

    static void InserareInVector(ref int[] vector, int e, int k)
    {
        // Crearea unui vector temporar cu o dimensiune mai mare
        int[] vectorActualizat = new int[vector.Length + 1];

        // Copierea elementelor până la poziția k în vectorul temporar
        for (int i = 0; i < k; i++)
        {
            vectorActualizat[i] = vector[i];
        }

        // Inserarea valorii e pe poziția k
        vectorActualizat[k] = e;

        // Copierea restului elementelor în vectorul temporar
        for (int i = k + 1; i < vectorActualizat.Length; i++)
        {
            vectorActualizat[i] = vector[i - 1];
        }

        // Actualizarea vectorului original
        vector = vectorActualizat;
    }
    static void ex6()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        // Declarați și inițializați vectorul
        int[] vector = new int[n];

        // Citirea elementelor vectorului de la tastatură
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Citirea poziției k
        Console.Write("Introduceti pozitia k: ");
        int k = int.Parse(Console.ReadLine());

        // Verificarea dacă poziția k este validă
        if (k < 0 || k >= n)
        {
            Console.WriteLine("Pozitie invalida. Programul se va incheia.");
            return;
        }

        // Stergerea elementului de pe pozitia k
        StergereDinVector(ref vector, k);

        // Afișarea vectorului actualizat
        Console.WriteLine("Vectorul actualizat:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"{vector[i]} ");
        }
    }

    static void StergereDinVector(ref int[] vector, int k)
    {
        // Crearea unui vector temporar cu o dimensiune mai mică
        int[] vectorActualizat = new int[vector.Length - 1];

        // Copierea elementelor până la poziția k în vectorul temporar
        for (int i = 0; i < k; i++)
        {
            vectorActualizat[i] = vector[i];
        }

        // Copierea restului elementelor în vectorul temporar (fără elementul de pe poziția k)
        for (int i = k; i < vectorActualizat.Length; i++)
        {
            vectorActualizat[i] = vector[i + 1];
        }

        // Actualizarea vectorului original
        vector = vectorActualizat;
    }
    static void ex7()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        // Declarați și inițializați vectorul
        int[] vector = new int[n];

        // Citirea elementelor vectorului de la tastatură
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Inversarea ordinii elementelor în vector
        InversareVector(ref vector);

        // Afișarea vectorului inversat
        Console.WriteLine("Vectorul inversat:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"{vector[i]} ");
        }
    }

    static void InversareVector(ref int[] vector)
    {
        int i = 0;
        int j = vector.Length - 1;

        while (i < j)
        {
            // Schimba elementele de la inceput si sfarsit
            int temp = vector[i];
            vector[i] = vector[j];
            vector[j] = temp;

            // Muta indecsii spre mijloc
            i++;
            j--;
        }
    }
    static void ex8()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        // Declarați și inițializați vectorul
        int[] vector = new int[n];

        // Citirea elementelor vectorului de la tastatură
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Realizarea rotirii spre stânga a elementelor în vector
        RotireSpreStanga(ref vector);

        // Afișarea vectorului rotit
        Console.WriteLine("Vectorul rotit spre stanga:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"{vector[i]} ");
        }
    }

    static void RotireSpreStanga(ref int[] vector)
    {
        // Salvăm primul element pentru a-l adăuga la final
        int primulElement = vector[0];

        // Realizăm rotația propriu-zisă
        for (int i = 0; i < vector.Length - 1; i++)
        {
            vector[i] = vector[i + 1];
        }

        // Adăugăm primul element la final
        vector[vector.Length - 1] = primulElement;
    }
    static void ex9()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        // Declarați și inițializați vectorul
        int[] vector = new int[n];

        // Citirea elementelor vectorului de la tastatură
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Citirea valorii k
        Console.Write("Introduceti numarul de pozitii k pentru rotatie spre stanga: ");
        int k = int.Parse(Console.ReadLine());

        // Realizarea rotației spre stânga a elementelor în vector cu k poziții
        RotireSpreStanga(ref vector, k);

        // Afișarea vectorului rotit
        Console.WriteLine("Vectorul rotit spre stanga cu k pozitii:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"{vector[i]} ");
        }
    }

    static void RotireSpreStanga(ref int[] vector, int k)
    {
        k = k % vector.Length; // Asigurăm că k este în intervalul [0, n)

        // Creăm un vector temporar pentru a stoca elementele rotite
        int[] vectorRotit = new int[vector.Length];

        for (int i = 0; i < vector.Length; i++)
        {
            int nouaPozitie = (i - k + vector.Length) % vector.Length;
            vectorRotit[nouaPozitie] = vector[i];
        }

        // Copiem elementele vectorului rotit înapoi în vectorul original
        Array.Copy(vectorRotit, vector, vector.Length);
    }
    static void ex10()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        // Declarați și inițializați vectorul sortat
        int[] vector = new int[n];

        // Citirea elementelor vectorului de la tastatură
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1} (sortat in ordine crescatoare): ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Citirea valorii k pe care o căutăm
        Console.Write("Introduceti valoarea k pe care doriti sa o cautati: ");
        int k = int.Parse(Console.ReadLine());

        // Apelarea funcției de căutare binară
        int pozitie = CautareBinară(vector, k);

        // Afișarea rezultatului
        if (pozitie != -1)
        {
            Console.WriteLine($"Valoarea {k} se afla pe pozitia {pozitie + 1} in vector.");
        }
        else
        {
            Console.WriteLine($"Valoarea {k} nu se gaseste in vector. Rezultat: -1");
        }
    }

    static int CautareBinară(int[] vector, int k)
    {
        int stanga = 0;
        int dreapta = vector.Length - 1;

        while (stanga <= dreapta)
        {
            int mijloc = stanga + (dreapta - stanga) / 2;

            // Verificăm dacă valoarea k se află în mijloc
            if (vector[mijloc] == k)
            {
                return mijloc;
            }
            // Dacă k este mai mic, căutăm în jumătatea stângă a vectorului
            else if (vector[mijloc] > k)
            {
                dreapta = mijloc - 1;
            }
            // Dacă k este mai mare, căutăm în jumătatea dreaptă a vectorului
            else
            {
                stanga = mijloc + 1;
            }
        }

        // Dacă elementul nu a fost găsit, returnăm -1
        return -1;
    }
    static void ex11()
    {
        Console.Write("Introduceti numarul n: ");
        int n = int.Parse(Console.ReadLine());

        AfiseazaNumerePrime(n);
    }

    static void AfiseazaNumerePrime(int n)
    {
        bool[] estePrim = new bool[n + 1];

        // Inițializăm toate numerele la true
        for (int i = 2; i <= n; i++)
        {
            estePrim[i] = true;
        }

        // Ciurul lui Eratostene
        for (int i = 2; i * i <= n; i++)
        {
            if (estePrim[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    estePrim[j] = false;
                }
            }
        }

        // Afișăm numerele prime
        Console.WriteLine($"Numere prime mai mici sau egale cu {n}:");
        for (int i = 2; i <= n; i++)
        {
            if (estePrim[i])
            {
                Console.Write($"{i} ");
            }
        }
    }
    static void ex12()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        // Declarați și inițializați vectorul
        int[] vector = new int[n];

        // Citirea elementelor vectorului de la tastatură
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Apelarea funcției de sortare prin selecție
        SelectionSort(vector);

        // Afișarea vectorului sortat
        Console.WriteLine("Vectorul sortat prin selectie:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"{vector[i]} ");
        }
    }

    static void SelectionSort(int[] vector)
    {
        int n = vector.Length;

        for (int i = 0; i < n - 1; i++)
        {
            // Găsim indexul minimului în vectorul ne-sortat
            int indexMinim = i;
            for (int j = i + 1; j < n; j++)
            {
                if (vector[j] < vector[indexMinim])
                {
                    indexMinim = j;
                }
            }

            // Schimbăm elementele
            int temp = vector[i];
            vector[i] = vector[indexMinim];
            vector[indexMinim] = temp;
        }
    }
    static void ex13()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        // Declarați și inițializați vectorul
        int[] vector = new int[n];

        // Citirea elementelor vectorului de la tastatură
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Apelarea funcției de sortare prin inserție
        InsertionSort(vector);

        // Afișarea vectorului sortat
        Console.WriteLine("Vectorul sortat prin insertie:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"{vector[i]} ");
        }
    }

    static void InsertionSort(int[] vector)
    {
        int n = vector.Length;

        for (int i = 1; i < n; i++)
        {
            int elementCurent = vector[i];
            int j = i - 1;

            // Mutăm elementele mai mari decât elementul curent cu o poziție spre dreapta
            while (j >= 0 && vector[j] > elementCurent)
            {
                vector[j + 1] = vector[j];
                j--;
            }

            // Plasăm elementul curent la poziția corectă
            vector[j + 1] = elementCurent;
        }
    }
    static void ex14()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        // Declarați și inițializați vectorul
        int[] vector = new int[n];

        // Citirea elementelor vectorului de la tastatură
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Apelarea funcției pentru interschimbarea elementelor
        InterschimbareElemente(vector);

        // Afișarea vectorului modificat
        Console.WriteLine("Vectorul cu valorile egale cu zero la sfarsit:");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"{vector[i]} ");
        }
    }

    static void InterschimbareElemente(int[] vector)
    {
        int pozitieZero = 0;

        // Găsim prima poziție cu valoare zero
        while (pozitieZero < vector.Length && vector[pozitieZero] != 0)
        {
            pozitieZero++;
        }

        // Parcurgem vectorul și mutăm elementele non-zero la începutul vectorului
        for (int i = pozitieZero + 1; i < vector.Length; i++)
        {
            if (vector[i] != 0)
            {
                // Mutare la început
                vector[pozitieZero] = vector[i];
                vector[i] = 0;

                // Mergem mai departe cu poziția zero
                pozitieZero++;
            }
        }
    }
    static void ex15()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        // Declarați și inițializați vectorul
        int[] vector = new int[n];

        // Citirea elementelor vectorului de la tastatură
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Apelarea funcției pentru eliminarea duplicatelor
        EliminareDuplicat(vector, out int nouaDimensiune);

        // Afișarea vectorului modificat
        Console.WriteLine("Vectorul dupa eliminarea duplicatelor:");
        for (int i = 0; i < nouaDimensiune; i++)
        {
            Console.Write($"{vector[i]} ");
        }
    }

    static void EliminareDuplicat(int[] vector, out int nouaDimensiune)
    {
        int n = vector.Length;
        int index = 1;

        for (int i = 1; i < n; i++)
        {
            bool esteDuplicat = false;

            for (int j = 0; j < index; j++)
            {
                if (vector[i] == vector[j])
                {
                    esteDuplicat = true;
                    break;
                }
            }

            if (!esteDuplicat)
            {
                vector[index] = vector[i];
                index++;
            }
        }

        nouaDimensiune = index;
    }
    static void ex16()
    {
        Console.Write("Introduceti numarul de elemente ale vectorului: ");
        int n = int.Parse(Console.ReadLine());

        // Declarați și inițializați vectorul
        int[] vector = new int[n];

        // Citirea elementelor vectorului de la tastatură
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Introduceti elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        // Apelarea funcției pentru calcularea CMMD
        int cmmd = CalculareCMMD(vector);

        // Afișarea rezultatului
        Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este: {cmmd}");
    }

    static int CalculareCMMD(int[] vector)
    {
        int n = vector.Length;

        // Apelăm funcția Euclid pentru primele două numere
        int cmmd = Euclid(vector[0], vector[1]);

        // Continuăm să calculăm CMMD pentru celelalte numere folosind rezultatul anterior
        for (int i = 2; i < n; i++)
        {
            cmmd = Euclid(cmmd, vector[i]);
        }

        return cmmd;
    }

    static int Euclid(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }
    static void ex17()
    {
        Console.Write("Introduceti numarul in baza 10 (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Introduceti baza destinatie (1 < b < 17): ");
        int b = int.Parse(Console.ReadLine());

        // Verificare dacă baza este în intervalul corect
        if (b <= 1 || b >= 17)
        {
            Console.WriteLine("Baza trebuie să fie în intervalul (1, 17).");
            return;
        }

        // Apelarea funcției de conversie și afișarea rezultatului
        string rezultat = ConversieBaza(n, b);
        Console.WriteLine($"Numarul {n} in baza {b}: {rezultat}");
    }

    static string ConversieBaza(int n, int b)
    {
        // Caracterele pentru reprezentarea valorilor peste 9 (pentru bazele > 10)
        char[] caracterePeste9 = "ABCDEF".ToCharArray();

        // Inițializare un șir de caractere pentru a salva rezultatul conversiei
        char[] rezultatCharArray = new char[32];
        int index = 0;

        // Conversia în baza b
        while (n > 0)
        {
            int rest = n % b;

            // Adăugăm cifra în șirul de caractere rezultat
            if (rest < 10)
            {
                rezultatCharArray[index++] = (char)(rest + '0');
            }
            else
            {
                rezultatCharArray[index++] = caracterePeste9[rest - 10];
            }

            n /= b;
        }

        // Inversăm șirul de caractere rezultat
        Array.Reverse(rezultatCharArray, 0, index);

        // Convertim șirul de caractere în string
        string rezultat = new string(rezultatCharArray, 0, index);

        return rezultat;
    }
    static void ex18()
    {
        // Exemplu de utilizare
        double[] coeficienti = { 1, 2, 3 }; // Coeficientii polinomului: 3x^2 + 2x + 1
        int grad = coeficienti.Length - 1;

        Console.Write("Introduceti valoarea pentru x: ");
        double x = double.Parse(Console.ReadLine());

        // Calculul valorii polinomului la punctul x
        double rezultat = CalculValoarePolinom(coeficienti, grad, x);

        // Afișarea rezultatului
        Console.WriteLine($"Valoarea polinomului la x = {x}: {rezultat}");
    }

    static double CalculValoarePolinom(double[] coeficienti, int grad, double x)
    {
        double rezultat = 0.0;

        // Calculul valorii polinomului folosind metoda Horner
        for (int i = grad; i >= 0; i--)
        {
            rezultat = rezultat * x + coeficienti[i];
        }

        return rezultat;
    }
    static void ex19()
    {
        // Exemplu de utilizare
        int[] s = { 1, 2, 1, 2, 1, 3, 1, 2, 1 };
        int[] p = { 1, 2, 1 };

        int aparitii = NumarAparitiiSecventa(s, p);

        Console.WriteLine($"Vectorul p apare in vectorul s de {aparitii} ori.");
    }

    static int NumarAparitiiSecventa(int[] s, int[] p)
    {
        int aparitii = 0;
        int n = s.Length;
        int m = p.Length;

        if (m > n)
        {
            return 0; // Daca lungimea vectorului cautat este mai mare decat lungimea vectorului in care se cauta, nu poate aparea deloc.
        }

        for (int i = 0; i <= n - m; i++)
        {
            bool coincidenta = true;

            for (int j = 0; j < m; j++)
            {
                if (s[i + j] != p[j])
                {
                    coincidenta = false;
                    break;
                }
            }

            if (coincidenta)
            {
                aparitii++;
            }
        }

        return aparitii;
    }
    static void ex20()
    {
        // Exemplu de utilizare
        string s1 = "ABABA";
        string s2 = "BA";

        int numarSuprapuneri = NumarSuprapuneri(s1, s2);

        Console.WriteLine($"Numarul de suprapuneri este: {numarSuprapuneri}");
    }

    static int NumarSuprapuneri(string s1, string s2)
    {
        int numarSuprapuneri = 0;
        int n = s1.Length;
        int m = s2.Length;

        for (int i = 0; i < n; i++)
        {
            // Verificam pentru fiecare pozitie de inceput a primului sirag
            bool suprapunere = true;

            for (int j = 0; j < m; j++)
            {
                // Verificam suprapunerea la fiecare pas
                if (s1[(i + j) % n] != s2[j])
                {
                    suprapunere = false;
                    break;
                }
            }

            if (suprapunere)
            {
                numarSuprapuneri++;
            }
        }

        return numarSuprapuneri;
    }
    static void ex21()
    {
        // Exemplu de utilizare
        int[] vector1 = { 1, 2, 3 };
        int[] vector2 = { 1, 2, 4 };

        string ordineLexicografica = DeterminaOrdineLexicografica(vector1, vector2);

        Console.WriteLine($"Ordinea lexicografica a vectorilor: {ordineLexicografica}");
    }

    static string DeterminaOrdineLexicografica(int[] vector1, int[] vector2)
    {
        string strVector1 = String.Join("", vector1);
        string strVector2 = String.Join("", vector2);

        return String.Compare(strVector1, strVector2) < 0 ? "Vectorul 1 apare primul" : "Vectorul 2 apare primul";
    }
    static void ex22()
    {
        // Exemplu de utilizare
        int[] v1 = { 1, 2, 3, 4, 5 };
        int[] v2 = { 3, 4, 5, 6, 7 };

        List<int> intersectie = Intersectie(v1, v2);
        List<int> reuniune = Reuniune(v1, v2);
        List<int> diferentaV1MinusV2 = Diferenta(v1, v2);
        List<int> diferentaV2MinusV1 = Diferenta(v2, v1);

        // Afisare rezultate
        Console.WriteLine("Intersectia: " + string.Join(", ", intersectie));
        Console.WriteLine("Reuniunea: " + string.Join(", ", reuniune));
        Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", diferentaV1MinusV2));
        Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", diferentaV2MinusV1));
    }

    static List<int> Intersectie(int[] v1, int[] v2)
    {
        return v1.Intersect(v2).ToList();
    }

    static List<int> Reuniune(int[] v1, int[] v2)
    {
        return v1.Union(v2).ToList();
    }

    static List<int> Diferenta(int[] v1, int[] v2)
    {
        return v1.Except(v2).ToList();
    }
}
