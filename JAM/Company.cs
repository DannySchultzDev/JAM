using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JAM
{
	public class Company
	{
		public string name;
		public string website;
		public string careerWebsite;
		public string careerHome;
		public string email;
		public string password;
		public string info;

		public string guid;

		public Company(
			string name,
			string website,
			string careerWebsite,
			string careerHome,
			string email,
			string password,
			string info)
		{
			this.name = name;
			this.website = website;
			this.careerWebsite = careerWebsite;
			this.careerHome = careerHome;
			this.email = email;
			this.password = password;
			this.info = info;

			guid = Guid.NewGuid().ToString();
		}

		public Company(XmlDocument xmlDocument)
		{
			try
			{
				foreach(XmlElement element in xmlDocument.DocumentElement!.ChildNodes)
				{
					string decryptedElement = EncryptionManager.Decrypt(element.InnerText,
						element.Attributes[XmlNodeName.IV.ToString()]!.Value);
					switch (Enum.Parse(typeof(XmlNodeName), element.Name))
					{
						case XmlNodeName.NAME:
							name = decryptedElement;
							break;
						case XmlNodeName.WEBSITE:
							website = decryptedElement;
							break;
						case XmlNodeName.CAREER_WEBSITE:
							careerWebsite = decryptedElement;
							break;
						case XmlNodeName.CAREER_HOME:
							careerHome = decryptedElement;
							break;
						case XmlNodeName.EMAIL:
							email = decryptedElement;
							break;
						case XmlNodeName.PASSWORD:
							password = decryptedElement;
							break;
						case XmlNodeName.INFO:
							info = decryptedElement;
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
				MessageBox.Show("Error reading company information from xml: " + ex.Message);
				return;
			}
			finally
			{
				name = name ?? "";
				website = website ?? "";
				careerWebsite = careerWebsite ?? "";
				careerHome = careerHome ?? "";
				email = email ?? "";
				password = password ?? "";
				info = info ?? "";
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
				FileManager.AddDataToXml(xmlDocument, root, website, XmlNodeName.WEBSITE);
				FileManager.AddDataToXml(xmlDocument, root, careerWebsite, XmlNodeName.CAREER_WEBSITE);
				FileManager.AddDataToXml(xmlDocument, root, careerHome, XmlNodeName.CAREER_HOME);
				FileManager.AddDataToXml(xmlDocument, root, email, XmlNodeName.EMAIL);
				FileManager.AddDataToXml(xmlDocument, root, password, XmlNodeName.PASSWORD);
				FileManager.AddDataToXml(xmlDocument, root, info, XmlNodeName.INFO);
				FileManager.AddDataToXml(xmlDocument, root, guid, XmlNodeName.GUID);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error converting company to xml: " + ex.Message);
			}

			return xmlDocument;
		}
	}
}
