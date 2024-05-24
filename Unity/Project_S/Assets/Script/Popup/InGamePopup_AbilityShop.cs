using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InGamePopup_AbilityShop : InGamePopup_MenuComponent
{

    [SerializeField] Button[] btns;

    private void Awake()
    {
        for(int i = 0; i < btns.Length; ++i)
        {
            int iIndex = i;
            btns[iIndex].onClick.AddListener(() => OnClickBtn(iIndex));
        }
    }
    private void OnEnable()
    {
        SetBtn();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetBtn()
    {
        var player = Object_Mgr.Instance.player_Mgr.Get_MainPlayer();

        if (player == null)
            return;

        for(int i = 0; i < btns.Length; ++i)
        {
            PLAYER_ABILITY iIndex = (PLAYER_ABILITY)i;

            btns[i].interactable = Shop_Mgr.Instance.ability_Shop.GetAbility(iIndex).Get_Buy(ref player.resource.gold);

        }
    }

    private void OnClickBtn(int _iIndex)
    {

    }


}
