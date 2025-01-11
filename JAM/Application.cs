using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JAM
{
	public class Application
	{
		public static readonly Dictionary<ApplicationType, string> ApplicationTypes = new Dictionary<ApplicationType, string>
		{
			{ApplicationType.CAREERS_WEBSITE, "Careers Website" },
			{ApplicationType.LINKEDIN, "LinkedIn" },
			{ApplicationType.OTHER, "Other" }
		};

		public static readonly Dictionary<ApplicationStatus, string> ApplicationStatuses = new Dictionary<ApplicationStatus, string>
		{
			{ApplicationStatus.NOT_SENT, "Not Sent" },
			{ApplicationStatus.SENT, "Sent" },
			{ApplicationStatus.AUTO_REVIEWED, "Auto Reviewed" },
			{ApplicationStatus.MANUALY_REVIEWED, "Manualy Reviewed" },
			{ApplicationStatus.INTERVIEWING, "Interviewing" },
			{ApplicationStatus.HIRED, "Hired" },
			{ApplicationStatus.FLUSHED, "Flushed" },
			{ApplicationStatus.OTHER, "Other" }
		};

		public string company;
		public string creationTime;
		public string status;
		//statusTime is the last time you received an update to your status.
		public string statusTime;

		public string position;
		public string link;
		public string applicationType;
		public string location;
		public string salary;
		//images refers to the relative folderPath for all images for this application.
		public string images;
		//resume refers to the resume's file name.
		public string resume;
		public string coverLetterFileName;
		//coverLetter refers to the cover letter's data.
		public string coverLetter;
		public string info;

		public string guid;

		public Application(
			string company,
			string creationTime,
			string status,
			string statusTime,
			string position,
			string link,
			string applicationType,
			string location,
			string salary,
			string images,
			string resume,
			string coverLetterFileName,
			string coverLetter,
			string info)
		{
			this.company = company;
			this.creationTime = creationTime;
			this.status = status;
			this.statusTime = statusTime;
			this.position = position;
			this.link = link;
			this.applicationType = applicationType;
			this.location = location;
			this.salary = salary;
			this.images = images;
			this.resume = resume;
			this.coverLetterFileName = coverLetterFileName;
			this.coverLetter = coverLetter;
			this.info = info;

			guid = Guid.NewGuid().ToString();
		}

		public Application (XmlDocument xmlDocument)
		{
			try
			{
				foreach (XmlNode node in xmlDocument.DocumentElement!.ChildNodes)
				{
					string nodeData = EncryptionManager.Decrypt(node.InnerText,
						node.Attributes![XmlNodeName.IV.ToString()]!.Value);
					switch(Enum.Parse(typeof(XmlNodeName), node.Name))
					{
						case XmlNodeName.COMPANY:
							company = nodeData; 
							break;
						case XmlNodeName.CREATION_TIME:
							creationTime = nodeData; 
							break;
						case XmlNodeName.STATUS:
							status = nodeData;
							break;
						case XmlNodeName.STATUS_TIME:
							statusTime = nodeData;
							break;
						case XmlNodeName.POSITION:
							position = nodeData; 
							break;
						case XmlNodeName.LINK:
							link = nodeData;
							break;
						case XmlNodeName.APPLICATION_TYPE:
							applicationType = nodeData;
							break;
						case XmlNodeName.LOCATION:
							location = nodeData;
							break;
						case XmlNodeName.SALARY:
							salary = nodeData;
							break;
						case XmlNodeName.IMAGES:
							images = nodeData;
							break;
						case XmlNodeName.RESUME:
							resume = nodeData;
							break;
						case XmlNodeName.COVER_LETTER_FILE_NAME:
							coverLetterFileName = nodeData;
							break;
						case XmlNodeName.COVER_LETTER:
							coverLetter = nodeData;
							break;
						case XmlNodeName.INFO:
							info = nodeData;
							break;
						case XmlNodeName.GUID:
							guid = nodeData;
							break;
						default:
							throw new NotImplementedException();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error reading application information from xml: " + ex.Message);
				return;
			}
			finally
			{
				company = company ?? "";
				creationTime = creationTime ?? "";
				status = status ?? "";
				statusTime = statusTime ?? "";
				position = position ?? "";
				link = link ?? "";
				applicationType = applicationType ?? "";
				location = location ?? "";
				salary = salary ?? "";
				images = images ?? "";
				resume = resume ?? "";
				coverLetterFileName = coverLetterFileName ?? "";
				coverLetter = coverLetter ?? "";
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

				FileManager.AddDataToXml(xmlDocument, root, company, XmlNodeName.COMPANY);
				FileManager.AddDataToXml(xmlDocument, root, creationTime, XmlNodeName.CREATION_TIME);
				FileManager.AddDataToXml(xmlDocument, root, status, XmlNodeName.STATUS);
				FileManager.AddDataToXml(xmlDocument, root, statusTime, XmlNodeName.STATUS_TIME);
				FileManager.AddDataToXml(xmlDocument, root, position, XmlNodeName.POSITION);
				FileManager.AddDataToXml(xmlDocument, root, link, XmlNodeName.LINK);
				FileManager.AddDataToXml(xmlDocument, root, applicationType, XmlNodeName.APPLICATION_TYPE);
				FileManager.AddDataToXml(xmlDocument, root, location, XmlNodeName.LOCATION);
				FileManager.AddDataToXml(xmlDocument, root, salary, XmlNodeName.SALARY);
				FileManager.AddDataToXml(xmlDocument, root, images, XmlNodeName.IMAGES);
				FileManager.AddDataToXml(xmlDocument, root, resume, XmlNodeName.RESUME);
				FileManager.AddDataToXml(xmlDocument, root, coverLetterFileName, XmlNodeName.COVER_LETTER_FILE_NAME);
				FileManager.AddDataToXml(xmlDocument, root, coverLetter, XmlNodeName.COVER_LETTER);
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

	public enum ApplicationType
	{
		CAREERS_WEBSITE = 0,
		LINKEDIN = 1,
		OTHER = 2,
	}

	public enum ApplicationStatus
	{
		NOT_SENT = 0,
		SENT = 1,
		AUTO_REVIEWED = 2,
		MANUALY_REVIEWED = 3,
		INTERVIEWING = 4,
		HIRED = 5,
		FLUSHED = 6,
		OTHER = 7
	}
}
