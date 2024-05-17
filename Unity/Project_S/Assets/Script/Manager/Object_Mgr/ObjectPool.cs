using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour 
{

    private DAMAGE_FONT type;

    public int initSize;
    public GameObject prefabs;

    public Queue<GameObject> queue;
    // Start is called before the first frame update
    void Start()
    {
        Init();

        if (Object_Mgr.Instance)
            Object_Mgr.Instance.text_Mgr.Add_Dic(type, this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init()
    {
        queue = new Queue<GameObject>();

        for (int i = 0; i < initSize; ++i)
        {
            CreateObject();
        }
    }
    /// <summary>
    /// 초기 생성과 부족할 떄 사용
    /// </summary>
    public void CreateObject()
    {
        GameObject obj = Instantiate(prefabs);
        obj.transform.SetParent(transform, false);
        obj.SetActive(false);
        queue.Enqueue(obj);
    }

    public GameObject GetObject()
    {
        if (queue.Count < 1)
            CreateObject();

        return queue.Dequeue();
    }

    public void ReturnObject(GameObject _obj)
    {
        queue.Enqueue(_obj);
    }
}

