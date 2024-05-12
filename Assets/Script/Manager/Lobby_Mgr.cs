using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lobby_Mgr : MonoBehaviour
{
    private static Lobby_Mgr instance = null;

    public static Lobby_Mgr Instance
    {
        get
        {
            return instance;
        }
    }

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
            return;
        }
        instance = this;


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
