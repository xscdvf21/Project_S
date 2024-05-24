using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class InGamePopup_AbilityShop : InGamePopup_MenuComponent
{

    [SerializeField] AbilityComponent[] component;

    private void Awake()
    {
        for(int i = 0; i < component.Length; ++i)
        {
            int iIndex = i;
            component[iIndex].btn.onClick.AddListener(() => OnClickBtn(iIndex));
        }
    }
    private void OnEnable()
    {
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateActiveBtn();
    }



    private void UpdateActiveBtn()
    {
        //var player = Object_Mgr.Instance.player_Mgr.Get_MainPlayer();

        //if (player == null)
        //    return;

        //for(int i = 0; i < component.Length; ++i)
        //{
        //    PLAYER_ABILITY iIndex = (PLAYER_ABILITY)i;
        //    //var shop = Shop_Mgr.Instance.ability_Shop.GetAbility(iIndex);
        //    component[i].btn.interactable = shop.IsGetBuy(ref player.resource.gold);
        //    component[i].needGold.text = shop.GetPrice().ToString() + " C";
        //}
    }

    private void OnClickBtn(int _iIndex)
    {
        //var player = Object_Mgr.Instance.player_Mgr.Get_MainPlayer();

        //if (player == null)
        //    return;

        //PLAYER_ABILITY iIndex = (PLAYER_ABILITY)_iIndex;
        ////bool result = Shop_Mgr.Instance.ability_Shop.GetAbility(iIndex).BuyShop(ref player);

        //if (result)
        //    Game_Mgr.Instance.Get_SaveData().GetAbility().Add_Index(iIndex);

    }

    [Serializable]
    public class AbilityComponent
    {
        public Button btn;
        public Text needGold;
    }
}
