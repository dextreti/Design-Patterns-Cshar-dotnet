using System.Xml.Serialization;

namespace Adapter;

[XmlRoot("Transaction")]
public class SCTBNKTrans
{
    [XmlElement("From")]
    public string From { get; set; } = string.Empty;
    [XmlElement("To")]
    public string To { get; set; } = string.Empty;
    [XmlElement("Amount")]
    public decimal Amount { get; set; }

}
