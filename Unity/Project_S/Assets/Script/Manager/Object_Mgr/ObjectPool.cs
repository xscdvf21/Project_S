using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour 
{

    public DAMAGE_FONT type;

    public int initSize;
    public GameObject prefabs;

    public Queue<GameObject> queue;
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Init()
    {
        queue = new Queue<GameObject>();

        for (int i = 0; i < initSize; ++i)
        {
            GameObject obj = Instantiate(prefabs);
            obj.transform.SetParent(transform, false);
            obj.SetActive(false);
            queue.Enqueue(obj);
        }


        if (Object_Mgr.Instance)
            Object_Mgr.Instance.text_Mgr.Add_Dic(type, this);
    }
}
