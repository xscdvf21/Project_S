using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System;

public abstract class SaveFile
{

}

public static class SaveSystem
{
    private static readonly string key = "your-encryption-key"; // 32 bytes for AES-256
    private static readonly string iv = "your-encryption-iv";   // 16 bytes for AES

    public static void Save(string _FileName, SaveFile _data)
    {

        string ToJsonData = JsonUtility.ToJson(_data, true);
        File.WriteAllText(GetPath(_FileName), Encrypt(ToJsonData));
        //File.WriteAllText(GetPath(_FileName), ToJsonData);
    }


    public static void Load<T>(string _FileName, out T _data)
    {
        bool exists = Exists(_FileName);

        if (exists == false)
        {
            Debug.Log("파일이 존재하지 않음");
            _data = default(T);
        }


        try
        {
            string FromJsonData = Decrypt(File.ReadAllText(GetPath(_FileName)));
            _data = JsonUtility.FromJson<T>(FromJsonData);


            //string FromJsonData = File.ReadAllText(GetPath(_FileName));
            //_data = JsonUtility.FromJson<T>(FromJsonData);
        }
        catch
        {
            _data = default(T);
        }


    }
    // 존재 유무
    public static bool Exists(string name_)
    {
        return File.Exists(GetPath(name_));
    }
    // 경로
    private static string GetPath(string name)
    {
        return Path.Combine(Application.dataPath, name + ".json");
    }
    public static void Delete(string _name)
    {
        bool exists = Exists(_name);

        if (exists == false)
            return;

        File.Delete(GetPath(_name));
    }

    private static string Encrypt(string _plainText)
    {
        using(Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Game_Mgr.Instance.key;
            aesAlg.IV  = Game_Mgr.Instance.iv;

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using (System.IO.MemoryStream msEncrypt = new System.IO.MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (System.IO.StreamWriter swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(_plainText);
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
    }

    private static string Decrypt(string _cipherText)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Game_Mgr.Instance.key;
            aesAlg.IV = Game_Mgr.Instance.iv;

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (System.IO.MemoryStream msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(_cipherText)))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (System.IO.StreamReader srDecrypt = new System.IO.StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }


    public static byte[] GenerateRandomKey(int size)
    {
        byte[] key = new byte[size];
        using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(key);
        }
        return key;
    }

}