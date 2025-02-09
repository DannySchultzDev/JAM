using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JAM
{
	public class Skills
	{
		public List<string> skills = new List<string>();

		public Skills(List<string> skills)
		{
			this.skills = skills;
		}

		public Skills(XmlDocument xmlDocument)
		{
			try
			{
				XmlElement root = xmlDocument.DocumentElement!;
				PriorityQueue<string, int> skillsPriorityQueue = new PriorityQueue<string, int>();
				foreach (XmlNode node in root.ChildNodes)
				{
					try
					{
						int index = int.Parse(node.Attributes![XmlNodeName.INDEX.ToString()]!.Value);
						string skill = EncryptionManager.Decrypt(node.InnerText,
							node.Attributes![XmlNodeName.IV.ToString()]!.Value);

						skillsPriorityQueue.Enqueue(skill, index);
					}
					catch { }
				}

				while (skillsPriorityQueue.Count > 0)
					skills.Add(skillsPriorityQueue.Dequeue());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error reading skill information from xml: " + ex.Message);
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

				for (int index = 0; index < skills.Count; ++index)
				{
					XmlElement element = xmlDocument.CreateElement("Skill");
					element.SetAttribute(XmlNodeName.INDEX.ToString(), index.ToString());

					element.InnerText = EncryptionManager.Encrypt(skills[index], out string IV);
					element.SetAttribute(XmlNodeName.IV.ToString(), IV);

					root.AppendChild(element);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error converting skills to xml: " + ex.Message);
			}

			return xmlDocument;
		}
	}
}
