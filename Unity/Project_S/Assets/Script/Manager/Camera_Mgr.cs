using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Mgr : MonoBehaviour
{
    private static Camera_Mgr instance;

    public static Camera_Mgr Instance
    {
        get
        {
            return instance;
        }
    }

    public Camera cam;
    private void Awake()
    {
        instance = this;

        DontDestroyOnLoad(this);
        InitCamera();
    }

    public void InitCamera()
    {
        if(cam == null)
        {
            cam = Camera.main;

            if (cam == null)
            {
                GameObject camera = new GameObject("MainCamera");
                cam = camera.AddComponent<Camera>();
                cam.tag = "MainCamera";
                cam.transform.SetParent(transform, false);
                cam.transform.position = new Vector3(0f, 0f, -10f);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
