using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class SavingDemo : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(Application.persistentDataPath);
        //Save();
        Load();
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/save.dat", FileMode.OpenOrCreate);
        PlayerStats stats = new PlayerStats();
        bf.Serialize(file, stats);
        file.Close();
    }

    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/save.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/save.dat", FileMode.Open);
            PlayerStats stats = new PlayerStats();
            stats = bf.Deserialize(file) as PlayerStats;
            file.Close();

            Debug.Log(stats.healthVal);
        }
    }
}
