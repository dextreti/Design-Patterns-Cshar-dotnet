using System.Xml;

namespace Adapter;

public class SCTBNKApi
{
    public XmlDocument GetTrans()
    {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(@"D:\Project\DesignPattern\2.Structural\Adapter\Adapter\Scotiabank\File\SCTBK.xml");
        return xmlDocument;
    }

    public void ExecTrans(XmlDocument sCTBNKTrans)
    {
        XmlNodeList xnList = sCTBNKTrans.SelectNodes("/Trans");
        foreach (XmlNode xn in xnList)
        {
            string from = xn["From"].InnerText;
            string to = xn["To"].InnerText;
            string amount = xn["Amount"].InnerText;
            Console.WriteLine("Scotiabank execute transaction : From:{0}, To:{1}, Amount{2}", from, to, amount);
        }

    }
}
