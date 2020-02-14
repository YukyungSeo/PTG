using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    //game play time
    public float PlayTimeCurrent = 20f;
    public float PlayTimeMax = 20f;

    //star
    public int star = 3;

    public bool PlayerDie = false;
    static DataManager instance;
    // Start is called before the first frame update
    public static DataManager Instance {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if(instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }
    public int score = 0;
}
