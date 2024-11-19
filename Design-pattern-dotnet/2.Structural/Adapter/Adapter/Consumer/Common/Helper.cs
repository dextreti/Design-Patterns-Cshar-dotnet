using System.Xml;
using System.Xml.Serialization;

namespace Adapter;

public static class Helper
{
    public static XmlDocument ObjectToXmlDocument<T>(T source)
    {
        var document = new XmlDocument();
        var navigator = document.CreateNavigator();

        using (var writer = navigator.AppendChild())
        {
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(writer, source);
        }
        return document;
    }

    public static T XmlDocumentToObject<T>(XmlNode node) where T : class
    {
        MemoryStream stm = new MemoryStream();

        StreamWriter stw = new StreamWriter(stm);
        stw.Write(node.OuterXml);
        stw.Flush();

        stm.Position = 0;

        XmlSerializer ser = new XmlSerializer(typeof(T));
        T result = ser.Deserialize(stm) as T;

        return result;
    }

    public static string XmlToString(XmlDocument xmlDoc)
    {
        using (StringWriter sw = new StringWriter())
        {
            using (XmlTextWriter tx = new XmlTextWriter(sw))
            {
                xmlDoc.WriteTo(tx);
                string strXmlText = sw.ToString();
                return strXmlText;
            }
        }
    }
}
