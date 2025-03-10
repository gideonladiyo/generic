using System;

class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void printData()
    {
        Console.WriteLine($"Data yang tersimpan adalah {data}");
    }
}
class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Gideon");

        DataGeneric<string> dataNim = new DataGeneric<string>("2211104022");
        dataNim.printData();
    } 
}