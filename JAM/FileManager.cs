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
	public static class FileManager
	{
		#region Variables
		/// <summary>
		/// Path to the user's application data folder.
		/// </summary>
		public static readonly string appDataString = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		
		/// <summary>
		/// Path to the JAM folder to use for user data.
		/// </summary>
		public static readonly string userDataFolder = Path.Combine(appDataString, "JAM");
		
		/// <summary>
		/// Path to folder containing user data.
		/// </summary>
		public static readonly string 
			companiesFolder = Path.Combine(userDataFolder, "Companies"),
			applicationsFolder = Path.Combine(userDataFolder, "Applications"),
			quickStatsFolder = Path.Combine(userDataFolder, "Quick Stats"),
			settingsFolder = Path.Combine(userDataFolder, "Settings"),
			resumesFolder = Path.Combine(userDataFolder, "Resumes");

		/// <summary>
		/// File name of a file that is not named based on its GUID.
		/// </summary>
		public static readonly string 
			settingsFileName = "Settings.xml",
			keyFileName = "Key.txt",
			quickStatsFileName = "Quick Stats.xml",
			skillsFileName = "Skills.xml";
		#endregion Variables

		#region Folder Methods
		/// <summary>
		/// Checks to make sure all folders for user data exist.<br/>
		/// If a folder does not exist, it is created.
		/// </summary>
		public static void EnsureAllFoldersExist()
		{
			string[] folders =
			[
				userDataFolder,
				companiesFolder,
				applicationsFolder,
				quickStatsFolder,
				settingsFolder,
				resumesFolder
			];

			foreach (string folder in folders)
			{
				if (!Directory.Exists(folder))
					Directory.CreateDirectory(folder);
			}
		}

		/// <summary>
		/// Helper function that converts a FileType into the folder the file is stored in.
		/// </summary>
		/// <param name="fileType">The type of file the folder path returned will contain.</param>
		/// <returns>A folder path that contains files of type FileType</returns>
		/// <exception cref="NotImplementedException">If the FileType has not been implemented.</exception>
		private static string GetFolderPath(FileType fileType)
		{
			string folderPath;
			switch (fileType)
			{
				case FileType.COMPANY:
					folderPath = companiesFolder;
					break;
				case FileType.APPLICATION:
					folderPath = applicationsFolder;
					break;
				case FileType.QUICK_STAT:
					folderPath = quickStatsFolder;
					break;
				case FileType.SETTINGS:
					folderPath = settingsFolder;
					break;
				case FileType.RESUMES:
					folderPath = resumesFolder;
					break;
				default:
					throw new NotImplementedException();
			}
			if (!Directory.Exists(folderPath))
			{
				Directory.CreateDirectory(folderPath);
			}
			return folderPath;
		}
		#endregion Folder Methods

		#region File Methods
		/// <summary>
		/// Trys to get a file.
		/// </summary>
		/// <param name="fileType">The type of file</param>
		/// <param name="fileName">The name of the file including its extension</param>
		/// <param name="filepath">The filepath of the file</param>
		/// <returns>If the file exists</returns>
		public static bool TryGetFile(FileType fileType, string fileName, out string filepath)
		{
			string folderPath = GetFolderPath(fileType);
			filepath = Path.Combine(folderPath, fileName);
			return File.Exists(filepath);
		}

		/// <summary>
		/// Trys to create a file
		/// </summary>
		/// <param name="fileType">The type of file</param>
		/// <param name="fileName">The name of the file including its extension</param>
		/// <param name="data">The data to store within the file</param>
		/// <returns>Whether the file could be created</returns>
		public static bool TryCreateFile(FileType fileType, string fileName, byte[] data)
		{
			try
			{
				string folderPath = GetFolderPath(fileType);
				string filepath = Path.Combine(folderPath, fileName);
				using (FileStream fileStream = File.Create(filepath))
				{
					fileStream.Write(data);
				}
				return true;
			}
			catch
			{
				MessageBox.Show("Could not create file: " + fileName);
				return false;
			}

		}
		#endregion File Methods

		#region XML Methods
		/// <summary>
		/// Trys to get the XMLDocument inside an XML file.
		/// </summary>
		/// <param name="fileType">The type of file to get</param>
		/// <param name="fileName">The name of the XML file</param>
		/// <returns>The XML inside of the file<br/>
		/// Returns null if the file doesn't exist, or if an XMLDocument cannot be loaded from it.</returns>
		public static XmlDocument? TryGetXml(FileType fileType, string fileName)
		{
			try
			{
				if (TryGetFile(fileType, fileName, out string filePath))
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(filePath);
					return xmlDocument;
				}
			}
			catch 
			{
				MessageBox.Show("Could not get XML");
			}

			return null;
		}

		/// <summary>
		/// Saves an XMLDocument to a file.
		/// </summary>
		/// <param name="xmlDocument">The XMLDocument to save</param>
		/// <param name="fileType">The type of file being saved</param>
		/// <param name="fileName">The file name to save the file as, including its extension</param>
		public static void SaveXml(XmlDocument xmlDocument, FileType fileType, string fileName)
		{
			try
			{
				string filePath = Path.Combine(GetFolderPath(fileType), fileName);
				xmlDocument.Save(filePath);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not save file: " + ex.Message);
			}
		}

		/// <summary>
		/// Encrypts and adds data to an XMLDocument under a specific node.
		/// </summary>
		/// <param name="xmlDocument">The XMLDocument to add the data to</param>
		/// <param name="root">The element of the XMLDocument to add the data under</param>
		/// <param name="data">The data to add to the XMLDocument</param>
		/// <param name="nodeName">The name of the node to add to the XMLDocument</param>
		public static void AddDataToXml(XmlDocument xmlDocument, XmlElement root,
			string data, XmlNodeName nodeName)
		{
			XmlElement element = xmlDocument.CreateElement(nodeName.ToString());
			element.InnerText = EncryptionManager.Encrypt(data, out string IV);
			element.SetAttribute(XmlNodeName.IV.ToString(), IV);
			root.AppendChild(element);
		}
		#endregion XML Methods
	}

	public enum FileType
	{
		COMPANY = 0,
		APPLICATION = 1,
		QUICK_STAT = 2,
		SETTINGS = 3,
		RESUMES = 4
	}

	public enum XmlNodeName
	{
		ROOT,
		IV,
		GUID,
		INDEX,
		DATA,
		VALUE,
		PASSWORD,
		NAME,
		WEBSITE,
		CAREER_WEBSITE,
		CAREER_HOME,
		EMAIL,
		INFO,
		COMPANY,
		CREATION_TIME,
		STATUS,
		STATUS_TIME,
		POSITION,
		LINK,
		APPLICATION_TYPE,
		LOCATION,
		SALARY,
		IMAGES,
		RESUME,
		COVER_LETTER_FILE_NAME,
		COVER_LETTER,
		APPLICATION,
		STATS,
		SKILLS
	}
}
