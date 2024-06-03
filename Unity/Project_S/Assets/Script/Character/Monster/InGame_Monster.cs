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

        CreateMonster(20, MONSTER_TYPE.MONSTER_B);
    }



    private void CreateMonster(int _count, MONSTER_TYPE _type)
    {
        if (dic_parent.TryGetValue(_type, out Transform _result))
        {

            for (int i = 0; i < _count; ++i)
            {
                int iIndex = i;
                Object_Mgr.Instance.monster_Mgr.CreateMonster(_result, _type, new Vector2(UnityEngine.Random.Range(-100f, 100f), UnityEngine.Random.Range(-100f, 100f)));
            }
        }

    }



}

