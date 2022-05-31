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
        Debug.Log("the player name is:" + playerName);
        string testing = "pp";
        Debug.Log("pp lenght :" + testing.Length);
        Debug.Log("the field name is" + fieldName.text +"checked");
        Debug.Log("the length is:" + fieldName.text.ToString().Length) ;
        Debug.Log(string.IsNullOrEmpty(fieldName.text.ToString())); ;
        //if (string.IsNullOrEmpty(fieldName.text));
        if (fieldName.text.Length > 1) 
        {
            playerName = fieldName.text;
        }
        Persistancy.Instance.playerNameF = playerName;
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
