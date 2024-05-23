using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGamePopup_Mgr : MonoBehaviour
{

    private InGamePopup_Mgr instance = null;

    public InGamePopup_Mgr Instance
    {
        get
        {
            return instance;
        }
    }

    public InGamePopup_AbilityShop abilityShop_Popup;
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
