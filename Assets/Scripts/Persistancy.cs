using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persistancy : MonoBehaviour
{
   

    public static Persistancy Instance;

    public string playerNameF;
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
}