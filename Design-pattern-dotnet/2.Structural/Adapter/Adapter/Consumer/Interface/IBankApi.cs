namespace Adapter;

public interface IBankApi<T> where T : class
{
    T GetTrans();
    void ExecTrans(T trans);
}
