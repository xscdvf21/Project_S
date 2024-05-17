using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
/// <summary>
/// 텍스트 (데미지 텍스트) 를 관리하기 위
/// </summary>
public class Text_Mgr : MonoBehaviour
{

    public Dictionary<DAMAGE_FONT, ObjectPool> dic_Text = new Dictionary<DAMAGE_FONT, ObjectPool>(); 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowDamage(DAMAGE_FONT _type, Vector2 _vPos, string _damageStr)
    {
        if (!dic_Text.ContainsKey(_type))
            return;

        GameObject obj = dic_Text[_type].GetObject();
        DamageText component = obj.GetComponent<DamageText>();

        if(component)
        {
            component.ShowText(_vPos, _damageStr);
        }
    }

    public void ReturnObj(DAMAGE_FONT _type, GameObject _obj)
    {
        if (!dic_Text.ContainsKey(_type))
            return;

        dic_Text[_type].ReturnObject(_obj);
    }

    public void Add_Dic(DAMAGE_FONT _key, ObjectPool _pool)
    {
        if (!dic_Text.ContainsKey(_key))
            dic_Text.Add(_key, _pool);
    }

   
}
