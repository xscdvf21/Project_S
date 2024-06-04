using UnityEngine;
using System.Collections.Generic;
using System;

/// <summary>
/// 인게임 몬스터 생성 및 배치 (보관은 Game_Mgr));
/// </summary>
public class InGame_Monster : MonoBehaviour
{
    [SerializeField] Transform me;
    Dictionary<MONSTER_TYPE, Transform> dic_parent;

    private void Awake()
    {
       
    }
    public void Init()
    {
        dic_parent = new Dictionary<MONSTER_TYPE, Transform>();
        for (int i = 0; i < (int)MONSTER_TYPE.END; ++i)
        {
            GameObject obj = new GameObject(((MONSTER_TYPE)i).ToString());
            obj.transform.SetParent(me);

            dic_parent.Add((MONSTER_TYPE)i, obj.transform);
        }
    }


    public Transform GetParent(MONSTER_TYPE _type)
    {
        if (dic_parent.TryGetValue(_type, out Transform _result))
            return _result;

        return null;
    }
}

