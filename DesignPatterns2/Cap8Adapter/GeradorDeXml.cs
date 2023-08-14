using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatterns.Cap8Adapter
{
    public class GeradorDeXml
    {
        public string GeraXML(object o)
        {
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            StringWriter stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, o);
            return stringWriter.ToString();
        }
    }
}
