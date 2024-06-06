using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] Tab1 = new string[3];
        string[] Tab2 = new string[3];
        string[] Tab3 = new string[6];

        Tab1[0] = "ce";
        Tab1[1] = "wed";
        Tab1[2] = "xa";

        Tab2[0] = "the";
        Tab2[1] = "wild";
        Tab2[2] = "cat";

        Tab3[0] = Tab1[0];
        Tab3[1] = Tab1[1];
        Tab3[2] = Tab1[3];
        Tab3[3] = Tab2[0];
        Tab3[4] = Tab2[1];
        Tab3[5] = Tab2[2];

    }
}