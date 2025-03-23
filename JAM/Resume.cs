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
	public class Resume
	{
		#region Variables
		/// <summary>
		/// The original resume file's name.
		/// </summary>
		public string name;

		/// <summary>
		/// The data of the resume pdf.
		/// </summary>
		public string data;

		/// <summary>
		/// Used for the Resume's file name.
		/// </summary>
		public string guid;
		#endregion Variables

		#region Constructors
		/// <summary>
		/// Constructs a Resume from data.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="data"></param>
		public Resume (
			string name,
			string data)
		{
			this.name = name;
			this.data = data;

			guid = Guid.NewGuid().ToString();
		}

		/// <summary>
		/// Constructs a Resume from an XML document.<br/>
		/// If data cannot be found, defaults will be used. 
		/// </summary>
		/// <param name="xmlDocument"></param>
		/// <exception cref="NotImplementedException"></exception>
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
		#endregion Constructors

		/// <summary>
		/// Converts the Resume to an XML document.<br/>
		/// If invalid data is used, a message box will be shown.
		/// </summary>
		/// <returns>An XML representation of the Resume.</returns>
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
