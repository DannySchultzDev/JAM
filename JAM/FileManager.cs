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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace JAM
{
	public static class FileManager
	{
		public static readonly string appDataString = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		public static readonly string userDataFolder = Path.Combine(appDataString, "JAM");
		
		public static readonly string companiesFolder = Path.Combine(userDataFolder, "Companies");
		public static readonly string applicationsFolder = Path.Combine(userDataFolder, "Applications");
		public static readonly string quickStatsFolder = Path.Combine(userDataFolder, "Quick Stats");
		public static readonly string settingsFolder = Path.Combine(userDataFolder, "Settings");
		public static readonly string resumesFolder = Path.Combine(userDataFolder, "Resumes");

		public static readonly string settingsFileName = "Settings.xml";
		public static readonly string keyFileName = "Key.txt";
		public static readonly string quickStatsFileName = "Quick Stats.xml";
		public static readonly string skillsFileName = "Skills.xml";

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

		public static void AddDataToXml(XmlDocument xmlDocument, XmlElement root,
			string data, XmlNodeName nodeName)
		{
			XmlElement element = xmlDocument.CreateElement(nodeName.ToString());
			element.InnerText = EncryptionManager.Encrypt(data, out string IV);
			element.SetAttribute(XmlNodeName.IV.ToString(), IV);
			root.AppendChild(element);
		}
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
