using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

public class WebServer_Mgr : MonoBehaviour
{
    private static WebServer_Mgr instance;

    public static WebServer_Mgr Instance
    {
        get
        {
            return instance;
        }
    }


    string baseUrl = "https://localhost:44302/api";

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        //UserInfo userInfo = new UserInfo() 
        //{ userID = "TESTS", password = "1234", date = DateTime.Now, userName = "TESTNAME" };


        //StartCoroutine(CoSendWebRequest("users", "POST", userInfo));

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator CoSendWebRequest(string _url, string _method, object _obj)
    {

        yield return null;

        string sendURL = $"{baseUrl}/{_url}/";

        byte[] jsonBytes = null;

        if(_obj != null)
        {
            string jsonStr = JsonUtility.ToJson(_obj);
            jsonBytes = Encoding.UTF8.GetBytes(jsonStr);
        }

        var uwr = new UnityWebRequest(sendURL, _method);
        uwr.uploadHandler = new UploadHandlerRaw(jsonBytes);
        uwr.downloadHandler = new DownloadHandlerBuffer();

        uwr.SetRequestHeader("Content-Type", "application/json");

        yield return uwr.SendWebRequest();


        if(uwr.error == null)
        {
            Debug.Log(uwr.downloadHandler.text);
        }
        else
        {
            Debug.Log("웹 서버 에러");
        }
    }

    [Serializable]
    public class UserInfo
    {
        public string userID;
        public string password;
        public string userName;
        public DateTime date;
    }
}
