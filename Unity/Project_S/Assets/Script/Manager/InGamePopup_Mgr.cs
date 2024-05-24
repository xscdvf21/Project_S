using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGamePopup_Mgr : MonoBehaviour
{

    private static InGamePopup_Mgr instance = null;

    public static InGamePopup_Mgr Instance
    {
        get
        {
            return instance;
        }
    }

    public InGamePopup_Menu menu_Popup;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
            instance = this;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
