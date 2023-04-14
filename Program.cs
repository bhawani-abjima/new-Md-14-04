using System;

class IndexerCreation
{
    private string[] val = new string[3];
    public string this[int index]
    {
        get
        {
             return val[index];
        }
        set
        {
            val[index] = value;
        }
    }
}
class SampleCollection<T>
{
    private T[] fgfg = new T[100];
    int nextIndex = 0;

    // using indexers
    public T this[int i] => fgfg[i];

    public void Add(T value)
    {
        if (nextIndex >= fgfg.Length)
            throw new IndexOutOfRangeException($"The collection can hold only {fgfg.Length} elements.");
        fgfg[nextIndex++] = value;
    }
}

public class Randomdata
{
    static public void Main()
    {

        Tuple<string> onedata = new Tuple<string>("Random data");        //creating tuple
        Tuple<string, string, int> twodata = new Tuple<string, string, int>("One entry", "Zero records", 35);
        Tuple<int, int, int, int, int, int, int, Tuple<int>> threedata = new Tuple<int, int, int, int, int, int, int, Tuple<int>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int>(8));
        Console.WriteLine(onedata);
        Console.WriteLine(twodata);
        Console.WriteLine(threedata);


        //creating tuple using create method

        var NM = Tuple.Create("New data");
        var NJ = Tuple.Create(101, 500, 910, 590);
        var XD = Tuple.Create(74, "box", 52, 90.56, 'b', 36399, "x", 120);
        Console.WriteLine(XD);
        Console.WriteLine(NM);
        Console.WriteLine(NJ);



        var VBNC = Tuple.Create("alternative data");


        // Using Item property
        Console.WriteLine("Element of first: " + VBNC.Item1);
        Console.WriteLine();


        // Using Create Method
        var PLMV = Tuple.Create(12, 30, 40, 50);


        Console.WriteLine("Element of 2: " + PLMV.Item1);
        Console.WriteLine("Element of 3: " + PLMV.Item2);
        Console.WriteLine("Element of 4: " + PLMV.Item3);
        Console.WriteLine("Element of 5: " + PLMV.Item4);
        Console.WriteLine();


        var UIUI = Tuple.Create(19, "new idea", 57, 85.00, 'n', 39639, "plm", 280);


        Console.WriteLine("Element of 1: " + UIUI.Item1);
        Console.WriteLine("Element of 2: " + UIUI.Item2);
        Console.WriteLine("Element of 3: " + UIUI.Item3);
        Console.WriteLine("Element of 4: " + UIUI.Item4);
        Console.WriteLine("Element of 5: " + UIUI.Item5);
        Console.WriteLine("Element of 6: " + UIUI.Item6);
        Console.WriteLine("Element of 7: " + UIUI.Item7);
        Console.WriteLine("Element of 8: " + UIUI.Rest);




        var VGnewdata = Tuple.Create("using itrative method", 96, 12.0);
        PrintTheTuple(VGnewdata);

        static void PrintTheTuple(Tuple<string, int, double> IOPnew)
        {
            Console.WriteLine("1: " + IOPnew.Item1);
            Console.WriteLine("2: " + IOPnew.Item2);
            Console.WriteLine("3: " + IOPnew.Item3);
        }

        IndexerCreation RT = new IndexerCreation();
        RT[0] = "C#";
        RT[1] = "C++";
        RT[2] = "C";

        Console.Write("Stored values\n");
        Console.WriteLine("1", RT[0]);
        Console.WriteLine("2", RT[1]);
        Console.WriteLine("3", RT[2]);

        var bhc = new SampleCollection<string>();
        bhc.Add("new index calling");
        System.Console.WriteLine(bhc[0]);

    }
}

