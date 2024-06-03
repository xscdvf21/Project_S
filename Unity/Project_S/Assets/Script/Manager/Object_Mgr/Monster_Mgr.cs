using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Mgr : MonoBehaviour
{
    [Header("몬스터 목록 (프리팹)")]
    public Monster[] monsterPrefabs;

    [Header("생존 몬스터")]
    [SerializeField] List<Monster> monster_Alive;

    [Header("죽은 몬스터")]
    [SerializeField] List<Monster> monster_death;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
            ResetMonster();

        if (monster_Alive.Count < 1)
            ResetMonster();
    }
    public void Monster_Add(Monster _monster)
    {
        monster_Alive.Add(_monster);
    }

    public void Monster_Dead(Monster _monster)
    {
        if (monster_Alive.Remove(_monster))
            monster_death.Add(_monster);
    }

    //처음 생성
    public void CreateMonster(Transform _parent, MONSTER_TYPE _type, Vector2 _vPos)
    {
        GameObject monster = Instantiate(monsterPrefabs[(int)_type].gameObject);

        monster.transform.position = new Vector2(UnityEngine.Random.Range(-10f, 10f), UnityEngine.Random.Range(-10f, 10f));
        monster.transform.SetParent(_parent, false);

        monster_Alive.Add(monster.GetComponent<Monster>());

    }

    public List<Monster> Get_AliveMonster()
    {
        return monster_Alive;
    }

    public Monster Get_MinDistanceMonster()
    {
        if (monster_Alive.Count < 1)
            return null;

        Monster result = monster_Alive[0];
        for (int i = 0; i < monster_Alive.Count; ++i)
        {
            int iIndex = i;
            BaseMonsterController resultCom = result.GetComponent<BaseMonsterController>();
            BaseMonsterController monsterCom = monster_Alive[iIndex].GetComponent<BaseMonsterController>();

            if (resultCom.playerDis > monsterCom.playerDis)
                result = monster_Alive[iIndex];
        }

        return result;
    }


    public void ResetMonster()
    {
        foreach(var monster in monster_death)
        {
            monster_Alive.Add(monster);
            monster.GetComponent<MonsterControler>().Set_Alive(true);
            monster.GetComponent<MonsterControler>().Set_Pos(new Vector2(UnityEngine.Random.Range(-10f, 10f), UnityEngine.Random.Range(-10f, 10f)));
            monster.ability.hp = monster.ability.maxHp;
        }

        monster_death.Clear();
    }

}
