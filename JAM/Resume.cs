using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Xml;

namespace JAM
{
	public class Resume
	{
		public string name;
		public string data;

		public string guid;

		public Resume (
			string name,
			string data)
		{
			this.name = name;
			this.data = data;

			guid = Guid.NewGuid().ToString();
		}

		public Resume(XmlDocument xmlDocument)
		{
			try
			{
				foreach (XmlElement element in xmlDocument.DocumentElement!.ChildNodes)
				{
					string decryptedElement = EncryptionManager.Decrypt(element.InnerText,
						element.Attributes[XmlNodeName.IV.ToString()]!.Value);
					switch (Enum.Parse(typeof(XmlNodeName), element.Name))
					{
						case XmlNodeName.NAME:
							name = decryptedElement;
							break;
						case XmlNodeName.DATA:
							data = decryptedElement;
							break;
						case XmlNodeName.GUID:
							guid = decryptedElement;
							break;
						default:
							throw new NotImplementedException();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error reading resume information from xml: " + ex.Message);
				return;
			}
			finally
			{
				name = name ?? "";
				data = data ?? "";
				guid = guid ?? Guid.NewGuid().ToString();
			}
		}

		public XmlDocument ConvertToXml()
		{
			XmlDocument xmlDocument = new XmlDocument();

			try
			{
				XmlElement root = xmlDocument.CreateElement(XmlNodeName.ROOT.ToString());
				xmlDocument.AppendChild(root);

				FileManager.AddDataToXml(xmlDocument, root, name, XmlNodeName.NAME);
				FileManager.AddDataToXml(xmlDocument, root, data, XmlNodeName.DATA);
				FileManager.AddDataToXml(xmlDocument, root, guid, XmlNodeName.GUID);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error converting resume to xml: " + ex.Message);
			}

			return xmlDocument;
		}
	}
}
