using UnityEngine;


public class InGameUI_Mgr : MonoBehaviour
{
    private static InGameUI_Mgr instance;

    public static InGameUI_Mgr Instance
    {
        get
        {
            return instance;
        }
    }


    public InGame_PlayerUI playerUI;
    private void Awake()
    {
        instance = this;
    }
}

