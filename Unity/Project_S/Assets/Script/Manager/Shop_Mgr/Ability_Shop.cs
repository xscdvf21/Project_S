using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// 플레이어 능력치를 구매하는 상점
/// </summary>
public class Ability_Shop : MonoBehaviour
{
    Dictionary<PLAYER_ABILITY, Shop_Component> dic_Shop;

    private void Awake()
    {
        Init();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Init()
    {
        dic_Shop = new Dictionary<PLAYER_ABILITY, Shop_Component>();

        for (int i = 0; i < (int)PLAYER_ABILITY.END; ++i)
        {
            int iIndex = i;

            if (!dic_Shop.ContainsKey((PLAYER_ABILITY)iIndex))
                dic_Shop.Add((PLAYER_ABILITY)iIndex, new Shop_Component());
                
        }
    }

    public void BuyAbility(PLAYER_ABILITY _abilityType, ref int _playerGold)
    {
        if (dic_Shop.TryGetValue(_abilityType, out Shop_Component _result))
            _result.BuyShop(ref _playerGold);
    }

    public Shop_Component GetAbility(PLAYER_ABILITY _abilityType)
    {
        if (dic_Shop.TryGetValue(_abilityType, out Shop_Component _result))
            return _result;

        return null;
    }

    [Serializable]
    public class Shop_Component
    {
        public int value;
        public int goldPrice;

        public bool Get_Buy(ref int _playerGold)
        {
            if (_playerGold < goldPrice)
                return false;

            return true;
        }
        public  void BuyShop(ref int _playerGold)
        {
            if (!Get_Buy(ref _playerGold))
                return;


            _playerGold -= goldPrice;

            goldPrice += 1;
            value += 1;
            
        }
    }
    
}
