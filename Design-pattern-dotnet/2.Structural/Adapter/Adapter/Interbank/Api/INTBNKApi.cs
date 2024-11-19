

namespace Adapter;

public class INTBNKApi
{
    public string GetTrans()
    {
        var jsonString = File.ReadAllText(@"D:\Project\DesignPattern\2.Structural\Adapter\Adapter\Interbank\File\INBNK.json");
        return jsonString;
    }

    public void ExecTrans(INTBNKTrans iNTBNKTrans)
    {
        Console.WriteLine("Interbank execute transaction: From:{0}, To:{1}, Amount:{2}", iNTBNKTrans.From, iNTBNKTrans.To, iNTBNKTrans.Amount);
    }

}
