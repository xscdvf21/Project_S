using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// �˾�â�� ���� ���� ��� �ΰ��� ����� ���� �� ����
/// </summary>
public class InGameUI_Menu : MonoBehaviour
{
    //���⼭�� �������� ���⿡ ����

    [SerializeField] INGAME_MENU menuType;

    public ToggleGroup group;
    public Toggle[] toggles;

    private void Awake()
    {
        Init();
    }
    void Init()
    {
        menuType = INGAME_MENU.NONE;

        group.allowSwitchOff = true;
        for (int i = 0; i < toggles.Length; ++i)
        {
            int iIndex = i;
            toggles[iIndex].isOn = false;
            toggles[iIndex].onValueChanged.AddListener( x => IsOn(toggles[iIndex].isOn, (INGAME_MENU)iIndex));
        }
    }



    void IsOn(bool _isOn, INGAME_MENU _type)
    {
        if (!_isOn || !InGamePopup_Mgr.Instance)
            return;

        if (group.allowSwitchOff)
            group.allowSwitchOff = false;

        menuType = _type;
        InGamePopup_Mgr.Instance.menu_Popup.Show(_type);
    }

    public void Close(INGAME_MENU _type)
    {
        menuType = _type;
        group.allowSwitchOff = true;

        for (int i = 0; i < toggles.Length; ++i)
        {
            int iIndex = i;
            toggles[iIndex].isOn = false;
        }
    }
}
