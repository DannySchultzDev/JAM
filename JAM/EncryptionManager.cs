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

using System.Security.Cryptography;
using System.Text;

namespace JAM
{
	public static class EncryptionManager
	{
		#region Variables
		/// <summary>
		/// The key to use for encryption and decryption.
		/// </summary>
		private static byte[]? key = null;

		/// <summary>
		/// The type of Encryption to use.<br/>
		/// This should be KEY most of the time.<br/>
		/// The only time this should be a different value is when importing/exporting data.
		/// </summary>
		public static EncryptionType encryptionType = EncryptionType.KEY;
		/// <summary>
		/// A temporary key to use for encrypting/decrypting data being imported/exported.
		/// </summary>
		public static byte[]? tempKey = null;
		#endregion Variables

		#region Encryption
		/// <summary>
		/// Encrypts some text using AES.<br/>
		/// </summary>
		/// <param name="text">The text to encrypt.</param>
		/// <param name="IV">The public key used to encrypt the text. Store this with the text.</param>
		/// <returns>The encrypted text.<br/>
		/// Returns an empty string if the text could not be encrypted.</returns>
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

		/// <summary>
		/// Decrypts some text using AES.
		/// </summary>
		/// <param name="text">The text to decrypt.</param>
		/// <param name="IV">The public key used to decrypt the text.</param>
		/// <returns>The decrypted text.<br/>
		/// Returns an empty string if the text could not be decrypted.</returns>
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
		#endregion Encryption

		#region Data Converters
		/// <summary>
		/// Converts a string to a byte[].<br/>
		/// Is inversable with the GetString(byte[] bytes) method.
		/// </summary>
		/// <param name="text">The text to convert.</param>
		/// <returns>A byte[] representation of the input text.</returns>
		public static byte[] GetBytes(string text)
		{
			byte[] bytes = new byte[text.Length];
			for (int i = 0; i < bytes.Length; ++i)
			{
				bytes[i] = (byte)text[i];
			}
			return bytes;
		}

		/// <summary>
		/// Converts a byte[] to a string.<br/>
		/// Is inversable with the GetBytes(string text) method.
		/// </summary>
		/// <param name="bytes">The byte[] to convert.</param>
		/// <returns>A string representation of the input bytes.</returns>
		public static string GetString(byte[] bytes)
		{
			StringBuilder sb = new StringBuilder();
			foreach (byte b in bytes)
			{
				sb.Append((char)b);
			}
			return sb.ToString();
		}
		#endregion Data Converters

		#region Misc
		/// <summary>
		/// Gets the private key to use for encryption/decryption.<br/>
		/// The private key used depends on the current Encryption Type.
		/// </summary>
		/// <returns>The private key to use for encryption/decryption.</returns>
		/// <exception cref="NullReferenceException">If the current Encryption Type is TEMP and there is no temp key.</exception>
		/// <exception cref="NotImplementedException">If the Encryption Type is an invalid type.</exception>
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

		/// <summary>
		/// Sets the temp key to use with the TEMP Encryption Type.
		/// </summary>
		/// <param name="password">The password used as a base for the temp key.</param>
		public static void SetTempKey(string password)
		{
			using (SHA256 sha256 = SHA256.Create())
			{
				tempKey = sha256.ComputeHash(GetBytes(password));
			}
		}

		/// <summary>
		/// Sets the temp key to use with the TEMP Encryption Type.
		/// </summary>
		/// <param name="password">The password used as a base for the temp key.</param>
		/// <param name="salt">Salt used to strengthen encryption.</param>
		public static void SetTempKey(string password, string salt)
		{
			tempKey = Rfc2898DeriveBytes.Pbkdf2(
				GetBytes(password),
				GetBytes(salt),
				310000,
				HashAlgorithmName.SHA256,
				32
			);
		}
		#endregion Misc
	}

	public enum EncryptionType
	{
		KEY = 0,
		TEMP = 1,
		NONE = 2
	} 
}
