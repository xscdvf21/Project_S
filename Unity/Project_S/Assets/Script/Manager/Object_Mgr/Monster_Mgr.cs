using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Mgr : MonoBehaviour
{
    [Header("���� ��� (������)")]
    public Monster[] monsterPrefabs;

    [Header("���� ����")]
    [SerializeField] List<Monster> monster_Live;

    [Header("���� ����")]
    [SerializeField] List<Monster> monster_death;

    public void Monster_Add(Monster _monster)
    {
        monster_Live.Add(_monster);
    }

    public void Monster_Dead(Monster _monster)
    {
        if (monster_Live.Remove(_monster))
            monster_death.Add(_monster);
    }

    public void CreateMonster(Transform _parent, MONSTER_KIND _kind, Vector2 _vPos)
    {
        GameObject monster = Instantiate(monsterPrefabs[(int)_kind].gameObject);

        monster.transform.position = _vPos;
        monster.transform.SetParent(_parent, false);

        monster_Live.Add(monster.GetComponent<Monster>());

    }
}
