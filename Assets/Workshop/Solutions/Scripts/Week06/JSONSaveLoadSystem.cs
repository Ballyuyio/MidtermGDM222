using UnityEngine;
using System.IO;

namespace Solution
{
    public class JSONSaveLoadSystem 
    {
        private static string savefilePath = Application.persistentDataPath + "/savefile.json";

        public static void SaveGame(PlayerScore data)
        {
            string json = JsonUtility.ToJson(data,true);
            File.WriteAllText(savefilePath,json);
            Debug.Log("GAMe SAVE : "+ savefilePath);
        }
        public static PlayerScore LoadGame()
        {
            if (File.Exists(savefilePath))
            {
                string json = File.ReadAllText(savefilePath);

                PlayerScore data = JsonUtility.FromJson<PlayerScore>(json);
                Debug.Log("Game Loaded!!!!");
                return data;
            }
            else
            {
                Debug.Log("Save not found 666");
                return null;
            }
        }
    }
}
