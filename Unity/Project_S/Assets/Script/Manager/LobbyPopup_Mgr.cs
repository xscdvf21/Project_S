using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 로비 및 인게임에서 사용 될 팝업창
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
