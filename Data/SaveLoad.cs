using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using System.Linq;

namespace VNCreator
{
    public static class SaveLoad
    {
        public static List<Flag> flags = new List<Flag>();

        public static void Save(string flagName, bool flagValue)
        {
            Flag flag = new Flag(flagName, flagValue);
            flags.Add(flag);

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath + "/file21.rnd");
            bf.Serialize(file, flags);
            file.Close();
        }

        public static bool Load(string flagName)
        {
            if (File.Exists(Application.persistentDataPath + "/file21.rnd"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
                SaveLoad.flags = (List<Flag>)bf.Deserialize(file);
                file.Close();

                return flags.Any(flag => flag.flagName == flagName);
            }
            System.Console.WriteLine("There is no save file.");
            return false;

        }
    }
}
