using System;
using Tree;

public class Forest
{
    static void Main()
    {
        Wood wood = new Wood();
        wood.WoodInfo();

        Maple maple = new Maple();
        maple.MapleInfo();

        Birch birch = new Birch();
        birch.BirchInfo();

        Console.ReadLine();
    }
}
