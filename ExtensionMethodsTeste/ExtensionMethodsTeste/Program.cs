using System;
using ExtensionMethodsTeste.Extensions;

public class ProcessFile {
    public static void Main() {
        DateTime dt = new DateTime(2018, 11, 26, 8, 10, 45);
        Console.WriteLine(dt.ElapsedTime);
    }
}