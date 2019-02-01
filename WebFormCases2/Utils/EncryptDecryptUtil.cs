using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace MyWebFormCases.Utils
{
    public class EncryptDecryptUtil
    {
        public static void Encrypt(string plainText, string password,string outputFilePath)
        {
            byte[] salt1 = new byte[] { 0x49, 0x76, 0x61, 0x6E, 0x20, 0x4D, 0x65, 0x64 };


            string data = plainText;

            Rfc2898DeriveBytes k1 = new Rfc2898DeriveBytes(password, salt1);

            Aes encryptor = Aes.Create();
            encryptor.KeySize = 128;
            encryptor.BlockSize = 128;

            encryptor.Key = k1.GetBytes(128 / 8);
            encryptor.IV = k1.GetBytes(128 / 8);

            FileStream fsinput = new FileStream(outputFilePath, FileMode.Open);

            CryptoStream encrypt = new CryptoStream(fsinput, encryptor.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] utfd1 = new System.Text.UTF8Encoding(false).GetBytes(data);

            encrypt.Write(utfd1, 0, utfd1.Length);
            encrypt.FlushFinalBlock();
            encrypt.Close();
        }

        public static void Decrypt(string inputFilePath, string outputfilePath, string pwd)
        {
            byte[] salt1 = new byte[] { 0x49, 0x76, 0x61, 0x6E, 0x20, 0x4D, 0x65, 0x64 };

            Rfc2898DeriveBytes k2 = new Rfc2898DeriveBytes(pwd, salt1);
            Aes descrypt = Aes.Create();


            descrypt.KeySize = 128;
            descrypt.BlockSize = 128;
            descrypt.Key = k2.GetBytes(128 / 8);


            descrypt.IV = k2.GetBytes(128 / 8);

            FileStream fsOutput = new FileStream(outputfilePath, FileMode.Open);

            CryptoStream dec = new CryptoStream(fsOutput, descrypt.CreateDecryptor(), CryptoStreamMode.Write);
            byte[] edata = File.ReadAllBytes(inputFilePath);

            dec.Write(edata, 0, edata.Length);

            dec.Flush();
            dec.Close();
        }
    }
}