
namespace Adapter;

public class XmlBankApiAdapter : IBankApi<Trans>
{
    private readonly SCTBNKApi sCTBNKApi;
    public XmlBankApiAdapter()
    {
        sCTBNKApi = new();
    }
    public void ExecTrans(Trans trans)
    {
        var xml = Helper.ObjectToXmlDocument(trans);
        sCTBNKApi.ExecTrans(xml);
    }
    public Trans GetTrans()
    {
        var _trans = Helper.XmlDocumentToObject<Trans>(sCTBNKApi.GetTrans());
        return _trans;
    }
}