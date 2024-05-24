using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InGamePopup_Menu : MonoBehaviour
{
    public List<InGamePopup_MenuComponent> components;

    [Space(20)]
    [SerializeField] INGAME_MENU menuType;
    public Button closeBtn;


    public InGamePopup_Stage stage_Popup;
    public InGamePopup_AbilityShop abilityShop_Popup;
    public InGamePopup_ItemShop itemShop_Popup;
    public InGamePopup_SkillShop skillShop_Popup;
    public InGamePopup_CashShop cashShop_Popup;


    public void Awake()
    {
        closeBtn.onClick.AddListener(OnClickCloseBtn);
    }
    public void Show(INGAME_MENU _type)
    {
        menuType = _type;
        int iIndex = (int)menuType;

        if (iIndex > components.Count - 1)
            return;

        AllHide();

        components[iIndex].Show();

        gameObject.SetActive(true);
        closeBtn.gameObject.SetActive(true);
    }

    private void AllHide()
    {
        foreach (var item in components)
            item.Hide();

        menuType = INGAME_MENU.NONE;
        gameObject.SetActive(false);
        closeBtn.gameObject.SetActive(false);
    }

    public void Hide(INGAME_MENU _type)
    {

    }


    private void OnClickCloseBtn()
    {
        AllHide();

        if (InGameUI_Mgr.Instance)
            InGameUI_Mgr.Instance.menuUi.Close(menuType);
    }
}
