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


    public InGameUI_Player playerUI;
    public InGameUI_Menu menuUi;
    private void Awake()
    {
        if (instance == null)
            instance = this;

    }
}

