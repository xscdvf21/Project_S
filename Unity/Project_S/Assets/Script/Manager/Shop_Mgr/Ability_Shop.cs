using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// 플레이어 능력치를 구매하는 상점의 데이터를 들고있음
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


    public Shop_Component GetAbility(PLAYER_ABILITY _abilityType)
    {
        if (dic_Shop.TryGetValue(_abilityType, out Shop_Component _result))
            return _result;

        return null;
    }

    [Serializable]
    public class Shop_Component
    {
        [SerializeField] int value;
        [SerializeField] int goldPrice;

        public bool IsGetBuy(ref int _playerGold)
        {
            if (_playerGold < goldPrice)
                return false;

            return true;
        }
        public  bool BuyShop(ref Player _player)
        {
            if (!IsGetBuy(ref _player.resource.gold))
                return false;


            _player.resource.gold -= goldPrice;
            goldPrice += 1;
            value += 1;

            return true;

        }

        public int GetPrice()
        {
            return goldPrice;
        }
    }
    
}
