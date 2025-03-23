/*
Copyright 2025 Wah Infinite

This file is part of JAM.

JAM is free software: you can redistribute it and/or modify it under the terms of the GNU General
Public License as published by the Free Software Foundation, either version 3 of the License, or (at your 
option) any later version.

JAM is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even 
the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the 
GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with JAM. If not, see 
<https://www.gnu.org/licenses/>.
*/

using System.Xml;

namespace JAM
{
	public class Skills
	{
		#region Variables
		/// <summary>
		/// List of the user's skills.
		/// </summary>
		public List<string> skills = new List<string>();
		#endregion Variables

		#region Constructors
		/// <summary>
		/// Constructs Skills from data.
		/// </summary>
		/// <param name="skills"></param>
		public Skills(List<string> skills)
		{
			this.skills = skills;
		}

		/// <summary>
		/// Constructs Skills from an XML document.
		/// </summary>
		/// <param name="xmlDocument"></param>
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
		#endregion Constructors

		/// <summary>
		/// Converts the Skills to an XML document.<br/>
		/// If invalid data is used, a message box will be shown.
		/// </summary>
		/// <returns>An XML representation of the Skills.</returns>
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
