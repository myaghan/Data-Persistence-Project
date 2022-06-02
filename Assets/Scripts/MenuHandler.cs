using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public string playerName = "Player";
    public TMPro.TextMeshProUGUI fieldName;
    void Start()
    {
        
    }
    public void StartGeme()
    {
     
        //if (string.IsNullOrEmpty(fieldName.text));
        if (fieldName.text.Length > 1) 
        {
            playerName = fieldName.text;
        }
        Persistancy.Instance.playerNameF = playerName;
        Persistancy.Instance.LoadScore();
        if (Persistancy.Instance.heighScoreNameStored == null)//no file stored
        {
            Persistancy.Instance.heighScoreNameStored = playerName;//and the heighst score is 0
        }
        //Debug.Log(playerName);
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
