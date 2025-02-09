using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace JAM
{
	public class Stats
	{
		public List<(string name, string value)> stats = new List<(string, string)>();

		public Stats(List<(string, string)> stats)
		{
			this.stats = stats;
		}

		public Stats(XmlDocument xmlDocument)
		{
			try
			{
				XmlElement root = xmlDocument.DocumentElement!;
				PriorityQueue<(string name, string value), int> statsPriorityQueue = new PriorityQueue<(string name, string value), int>();
				foreach (XmlNode node in root.ChildNodes)
				{
					try
					{
						int index;
						string name;
						string value;

						index = int.Parse(node.Attributes![XmlNodeName.INDEX.ToString()]!.Value);
						XmlNode nameNode = node.SelectSingleNode(XmlNodeName.NAME.ToString())!;
						name = EncryptionManager.Decrypt(nameNode.InnerText,
							nameNode.Attributes![XmlNodeName.IV.ToString()]!.Value);
						XmlNode valueNode = node.SelectSingleNode(XmlNodeName.VALUE.ToString())!;
						value = EncryptionManager.Decrypt(valueNode.InnerText,
							valueNode.Attributes![XmlNodeName.IV.ToString()]!.Value);

						statsPriorityQueue.Enqueue((name, value), index);
					}
					catch { }
				}

				while (statsPriorityQueue.Count > 0)
					stats.Add(statsPriorityQueue.Dequeue());
			}
			catch (Exception ex) 
			{
				MessageBox.Show("Error reading stat information from xml: " + ex.Message);
				return;
			}
		}

		public XmlDocument ConvertToXml()
		{
			XmlDocument xmlDocument = new XmlDocument();

			try
			{
				XmlElement root = xmlDocument.CreateElement(XmlNodeName.ROOT.ToString());
				xmlDocument.AppendChild(root);

				for (int index = 0; index < stats.Count; ++index)
				{
					XmlElement element = xmlDocument.CreateElement("Stat");
					element.SetAttribute(XmlNodeName.INDEX.ToString(), index.ToString());

					FileManager.AddDataToXml(xmlDocument, element, stats[index].name, XmlNodeName.NAME);
					FileManager.AddDataToXml(xmlDocument, element, stats[index].value, XmlNodeName.VALUE);

					root.AppendChild(element);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error converting stats to xml: " + ex.Message);
			}

			return xmlDocument;
		}
	}
}
