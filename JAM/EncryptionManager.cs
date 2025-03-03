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
using System.Security.Cryptography;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace JAM
{
	public static class EncryptionManager
	{
		private static byte[]? key = null;

		public static EncryptionType encryptionType = EncryptionType.KEY;
		public static byte[]? tempKey = null;

		private static byte[] GetPrivateKey()
		{
			switch (encryptionType)
			{
				case EncryptionType.KEY:
					if (key != null)
					{
						return key;
					}
					if (FileManager.TryGetFile(FileType.SETTINGS, FileManager.keyFileName, out string filepath))
					{
						try
						{
							key = ProtectedData.Unprotect(File.ReadAllBytes(filepath), null, DataProtectionScope.CurrentUser);
							return key;
						}
						catch
						{
							MessageBox.Show("Key file has been tampered with. Please revert key file, or all data may be permenantly encrypted.");
							return GetPrivateKey();
						}
					}
					else
					{
						key = Aes.Create().Key;
						byte[] protectedKey = ProtectedData.Protect(key, null, DataProtectionScope.CurrentUser);
						if (!FileManager.TryCreateFile(FileType.SETTINGS, FileManager.keyFileName, protectedKey))
						{
							key = null;
							return GetPrivateKey();
						}
						return key;
					}
				case EncryptionType.TEMP:
					if (tempKey != null)
						return tempKey;
					throw new NullReferenceException("Temp key was not set.");
				case EncryptionType.NONE:
					return new byte[32];
				default:
					throw new NotImplementedException("Encryption type not implemented.");
			}
		}

		public static string Encrypt(string text, out string IV)
		{
			try
			{
				using (Aes aes = Aes.Create())
				{
					aes.Key = GetPrivateKey();
					IV = GetString(aes.IV);
					ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
					using (MemoryStream msEncrypt = new MemoryStream())
					{
						using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
						{
							using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
							{
								swEncrypt.Write(text);
							}
						}
						return GetString(msEncrypt.ToArray());
					}
				}
			}
			catch
			{
				MessageBox.Show("Something went wrong when encrypting " + text + ". This text will not be saved.");
				IV = "";
				return "";
			}
			
		}

		public static string Decrypt(string text, string IV)
		{
			try
			{
				using (Aes aes = Aes.Create())
				{
					aes.Key = GetPrivateKey();
					aes.IV = GetBytes(IV);

					ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
					using (MemoryStream msDecrypt = new MemoryStream(GetBytes(text)))
					{
						using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
						{
							using (StreamReader srDecrypt = new StreamReader(csDecrypt))
							{
								return srDecrypt.ReadToEnd();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not decrypt some data. " + ex.Message);
				return "";
			}
		}

		public static byte[] GetBytes(string text)
		{
			byte[] bytes = new byte[text.Length];
			for (int i = 0; i < bytes.Length; ++i)
			{
				bytes[i] = (byte)text[i];
			}
			return bytes;
		}

		public static string GetString(byte[] bytes)
		{
			StringBuilder sb = new StringBuilder();
			foreach (byte b in bytes)
			{
				sb.Append((char)b);
			}
			return sb.ToString();
		}

		public static void SetTempKey(string password)
		{
			using (SHA256 sha256 = SHA256.Create())
			{
				tempKey = sha256.ComputeHash(GetBytes(password));
			}
		}
	}

	public enum EncryptionType
	{
		KEY = 0,
		TEMP = 1,
		NONE = 2
	} 
}
