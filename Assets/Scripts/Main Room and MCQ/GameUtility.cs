﻿using System.IO;
using System.Xml.Serialization;
using UnityEngine;
using System.Xml;

/// GameUtility is responsible for loading the questions from their flatfiles

public class GameUtility {

    public const float      ResolutionDelayTime     = 1;
    public const string     SavePrefKey             = "Game_Highscore_Value";

    public const string     FileName                = "Q";
    public static string    FileDir                 
    {
        get
        {
            return Application.dataPath + "/";
        }
    }
}
[System.Serializable()]
public class Data
{
    public Question[] Questions = new Question[0];

    public Data () { }

    public static void Write(Data data, string path)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Data));
        using (Stream stream = new FileStream(path, FileMode.Create))
        {
            serializer.Serialize(stream, data);
        }
    }
    public static Data Fetch(string filePath)
    {
        return Fetch(out bool result, filePath);
    }
    public static Data Fetch(out bool result, string filePath)
    {
        // if (!File.Exists(filePath)) { result = false; return new Data(); }

        WWW reader = new WWW(filePath);
        XmlSerializer deserializer = new XmlSerializer(typeof(Data));
        using (MemoryStream stream = new MemoryStream(reader.bytes))
        {
            var data = (Data)deserializer.Deserialize(stream);

            result = true;
            return data;
        }
    }
}