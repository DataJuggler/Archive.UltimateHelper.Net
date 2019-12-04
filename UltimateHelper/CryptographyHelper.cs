

#region using statements

using System;
using System.Text;
using System.Security.Cryptography;

#endregion

namespace DataJuggler.Core.UltimateHelper
{

    #region class CryptographyHelper
    /// <summary>
    /// This object hands all encryption for this application.
    /// </summary>
    public class CryptographyHelper
	{

        #region Private variables and Constants
        // We can use a fixed pepper for the PBKDF2 salt.
        private static byte[] _pepper = new byte[] { 0x04, 0xC5, 0x02, 0xF8, 0xD3, 0xD4, 0x23, 0xB9 };
        #endregion

	    #region Methods

            #region EncryptString(string  stringToEncrypt, string password)
            /// <summary>
			/// Encrypts a strings passed in using CBC mode and a moderately decent KDF.  Does not provide integrity.
			/// </summary>
			/// <param customerName="stringToEncrypt">String to encrypt</param>
			/// <param customerName="productPassword">productPassword needed to unlock encrypted string</param>
			/// <returns>A new string that must have the same productPassword passed in to unlock.</returns>
            public static string EncryptString(string stringToEncrypt, string password)
			{
                // We can remove the try-catch and handle null strings properly.
                if (stringToEncrypt == null)
                {
                    throw new ArgumentException("The string to encrypt cannot be null.", nameof(stringToEncrypt));
                }

                if (String.IsNullOrEmpty(password))
                {
                    throw new ArgumentException("The password to use to generate a key cannot be null or empty", nameof(password));
                }

                // Remember to dispose of types that implement IDisposable - this old code had lots of memory leaks.
                using (var aes = AesManaged.Create())
                using (var pbkdf2 = new Rfc2898DeriveBytes(password, _pepper, 32767)) // MD5 is insecure as KDF, we use PBKDF2 instead.
                using (var rng = new RNGCryptoServiceProvider())
                {
                    var key = pbkdf2.GetBytes(32); // Let's use AES-256.
                    var iv = new byte[16];
                    rng.GetBytes(iv); // We always create a new, random IV for each operation.

                    var plaintext = Encoding.UTF8.GetBytes(stringToEncrypt); // We use UTF8 - there is literally no reason to use ASCII in 2019.

                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.PKCS7;
                    aes.Key = key;
                    aes.IV = iv;

                    using (var aesTransformer = aes.CreateEncryptor())
                    {
                        var ciphertext = aesTransformer.TransformFinalBlock(plaintext, 0, plaintext.Length);
                        var ivAndCiphertext = new byte[iv.Length + ciphertext.Length];
                        Array.Copy(iv, 0, ivAndCiphertext, 0, iv.Length);
                        Array.Copy(ciphertext, 0, ivAndCiphertext, iv.Length, ciphertext.Length);
                        return Convert.ToBase64String(ivAndCiphertext);
                    }
                }
			}
			#endregion

            #region EncryptString(string stringToEncrypt)
            /// <summary>
            /// Encrypt a string with the default password
            /// </summary>
            /// <param name="stringToEncrypt"></param>
            /// <returns></returns>
            public static string EncryptString(string stringToEncrypt)
            {
                return EncryptString(stringToEncrypt, "worldclass");
            }
            #endregion

            #region DecryptString(string  stringToDecrypt, string password)
            /// <summary>
			/// Decrypts a string passed in.
			/// </summary>
			/// <param customerName="stringToDecrypt">String that needs to be deciphered.</param>
			/// <param customerName="ProductPassword">Code to unlock this productPassword.</param>
			/// <returns></returns>
            public static string DecryptString(string stringToDecrypt, string password)
			{
                if (stringToDecrypt == null)
                {
                    throw new ArgumentException("The string to decrypt cannot be null.", nameof(stringToDecrypt));
                }

                if (String.IsNullOrEmpty(password))
                {
                    throw new ArgumentException("The password to use to generate a key cannot be null or empty", nameof(password));
                }

                var ivAndCiphertext = Convert.FromBase64String(stringToDecrypt);
                if (ivAndCiphertext.Length < 16)
                {
                    throw new ArgumentException("The provided ciphertext is invalid.", nameof(stringToDecrypt));
                }

                var iv = new byte[16];
                var ciphertext = new byte[ivAndCiphertext.Length - 16];
                Array.Copy(ivAndCiphertext, 0, iv, 0, iv.Length);
                Array.Copy(ivAndCiphertext, iv.Length, ciphertext, 0, ciphertext.Length);

                using (var aes = AesManaged.Create())
                using (var pbkdf2 = new Rfc2898DeriveBytes(password, _pepper, 32767))
                {
                    var key = pbkdf2.GetBytes(32);

                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.PKCS7;
                    aes.Key = key;
                    aes.IV = iv;

                    using (var aesTransformer = aes.CreateDecryptor())
                    {
                        var plaintext = aesTransformer.TransformFinalBlock(ciphertext, 0, ciphertext.Length);
                        return Encoding.UTF8.GetString(plaintext);
                    }
                }
            }
        #endregion

            #region DecryptString(string stringToDecrypt)
            /// <summary>
            /// Decrypt a string with the default password
            /// </summary>
            /// <param name="stringToDecrypt"></param>
            /// <returns></returns>
            public static string DecryptString(string stringToDecrypt)
            {
                // return value
                return DecryptString(stringToDecrypt, "worldclass");
            }
            #endregion

        #endregion

    }
	#endregion

}
