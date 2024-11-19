namespace Adapter;

public class GenericApiAdapter
{
    public void ExecTrans(Trans trans, IBankApi<Trans> bankApi)
    {
        bankApi.ExecTrans(trans);
    }

    public Trans GetTrans(IBankApi<Trans> bankApi)
    {
        return bankApi.GetTrans();
    }
}
