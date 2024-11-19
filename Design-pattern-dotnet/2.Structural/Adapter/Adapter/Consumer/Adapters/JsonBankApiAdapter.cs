using System.Text.Json;
namespace Adapter;

public class JsonBankApiAdapter : IBankApi<Trans>
{
    private readonly INTBNKApi iNTBNKApi;
    public JsonBankApiAdapter()
    {
        iNTBNKApi = new();
    }
    /// <summary>
    /// Hire we could used AutoMapper, but the proposite just we can understand concept pattern Adapter
    /// </summary>
    /// <param name="trans"></param>
    public void ExecTrans(Trans trans)
    {
        //INTBNKTrans iNTBNKTrans = new() { From = trans.From, To = trans.To, Amount = trans.Amount };
        var json = JsonSerializer.Serialize(trans, new JsonSerializerOptions { });
        var tran = JsonSerializer.Deserialize<INTBNKTrans>(json);
        iNTBNKApi.ExecTrans(tran);
    }

    public Trans GetTrans()
    {
        var trans = JsonSerializer.Deserialize<Trans>(iNTBNKApi.GetTrans());
        return trans;
    }
}
