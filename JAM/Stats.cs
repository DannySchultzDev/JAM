﻿/*
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
	public class Stats
	{
		#region Variables
		/// <summary>
		/// List of the user's stats.
		/// </summary>
		public List<(string name, string value)> stats = new List<(string, string)>();
		#endregion Variables

		#region Constructors
		/// <summary>
		/// Constructs Stats from data.
		/// </summary>
		/// <param name="stats"></param>
		public Stats(List<(string, string)> stats)
		{
			this.stats = stats;
		}

		/// <summary>
		/// Constructs Stats from an XML document.
		/// </summary>
		/// <param name="xmlDocument"></param>
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
		#endregion Constructors

		/// <summary>
		/// Converts the Stats to an XML document.<br/>
		/// If invalid data is used, a message box will be shown.
		/// </summary>
		/// <returns>An XML representation of the Stats.</returns>
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
