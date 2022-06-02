using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Persistancy : MonoBehaviour
{
   
    public static Persistancy Instance;

    public string playerNameF;
    public string heighScoreNameStored;
    public int heighstScoreStored;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
        
    }

    [System.Serializable]
    class SaveData
    {
        public string nameHeighstScore;
        public int heighstScore;
    }
    public void SaveScore(string player, int playerSc)
    {
        SaveData scoreData = new SaveData();
        scoreData.nameHeighstScore = player; //temp status
        scoreData.heighstScore = playerSc; //temp
        string json = JsonUtility.ToJson(scoreData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        //Debug.Log(path);

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData dataStored = JsonUtility.FromJson<SaveData>(json);
            heighScoreNameStored = dataStored.nameHeighstScore;
            heighstScoreStored = dataStored.heighstScore;
        }else
        {
            heighScoreNameStored = null;
            heighstScoreStored = 0;
        }
    }
}