using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �κ� �� �ΰ��ӿ��� ��� �� �˾�â
/// </summary>
public class LobbyPopup_Mgr : MonoBehaviour
{
    private static LobbyPopup_Mgr instance;

    public static LobbyPopup_Mgr Instance
    {
        get
        {
            return instance;
        }
    }

    public LobbyPopup_CloseMsg closeMsg;

    private void Awake()
    {
        instance = this;
    }
}
