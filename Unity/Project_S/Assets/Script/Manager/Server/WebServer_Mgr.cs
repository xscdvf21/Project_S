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

    public enum METHOD
    {
        GET,
        POST,
        PUT,
        DELETE,

    }

    public enum KIND
    {
        USER,
        ABILITY_RESOURCES,
        ITEM,
        SKILL,

    }

    WebServer_Data datas;

    string baseUrl = "https://localhost:44302/api";
    string userUrl = "users";
    string itemUrl = "items";
    string skillUrl = "skills";
    string ablityResourcesUrl = "abilitys";


    private void Awake()
    {
        instance = this;

        if (datas == null)
            datas = GetComponent<WebServer_Data>();

    }

    private void Start()
    {
       
    }

    public void SendRequest(string _id, METHOD _method, KIND _kind, object _obj, Action<UnityWebRequest> _callBack )
    {
        string URL = null;

  
        switch (_kind)
        {
            case KIND.USER:
                URL = userUrl;
                break;
            case KIND.ABILITY_RESOURCES:
                URL = ablityResourcesUrl;
                break;
            case KIND.ITEM:
                URL = itemUrl;
                break;
            case KIND.SKILL:
                URL = skillUrl;
                break;
        }


        switch (_method)
        {
            case METHOD.GET:
                StartCoroutine(CoSendGetWebRequest(URL, _id, _callBack));
                break;
            case METHOD.POST:
                break;
            case METHOD.PUT:
                break;
            case METHOD.DELETE:
                break;
        }

    }

    public void UserLogin(string _id, string _password)
    {
        SendRequest(_id, METHOD.GET, KIND.USER, null, (uwr) => 
        {
            if(uwr.error == null)
            {
                byte[] downDatas = uwr.downloadHandler.data;
                string downStr = Encoding.UTF8.GetString(downDatas);
                WebServer_User user = JsonUtility.FromJson<WebServer_User>(downStr);

                if(_password != user.password)
                {
                    LobbyPopup_Mgr.Instance.closeMsg.ShowMsg("Password Not Match");
                    return;
                }

                datas.userData.userID = user.userID;
                datas.userData.password = user.password;
                datas.userData.userName = user.userName;
                datas.userData.date = user.date;

                Game_Mgr.Instance.SuccessLogin();
                Debug.Log(uwr.downloadHandler.text);
            }
            else
            {
                //웹 서버 문제인지, 아이디가 없어서 인지 구분 필요
                LobbyPopup_Mgr.Instance.closeMsg.ShowMsg("Not Exists ID or Web Server Problem");                
            }
        });
    }


    IEnumerator CoSendGetWebRequest(string _url, string _id, Action<UnityWebRequest> _callBack)
    {

        string sendURL = $"{baseUrl}/{_url}/{_id}/";

        var uwr = new UnityWebRequest(sendURL, "GET");
        uwr.downloadHandler = new DownloadHandlerBuffer();

        uwr.SetRequestHeader("Content-Type", "application/json");

        yield return uwr.SendWebRequest();

        if (_callBack != null)
            _callBack.Invoke(uwr);

        //if (uwr.error == null)
        //{
        //     if(_callBack != null)
        //        _callBack.Invoke(uwr);
        //}
        //else
        //{
        //    Debug.Log("웹 서버 에러");
        //}


       // yield return null;
    }


    //public void SendRequest(METHOD _method, KIND _kind, object _obj, Action<UnityWebRequest> _callBack)
    //{
    //    string URL = null;

    //    switch (_kind)
    //    {
    //        case KIND.USER:
    //            URL = userUrl;
    //            break;
    //        case KIND.ABILITY:
    //            URL = abilityUrl;
    //            break;
    //        case KIND.ITEM:
    //            URL = itemUrl;
    //            break;
    //        case KIND.SKILL:
    //            URL = skillUrl;
    //            break;
    //    }

    //    if (URL == null)
    //        return;


    //    switch (_method)
    //    {
    //        case METHOD.GET:
    //            StartCoroutine(CoSendGetWebRequest(URL, _obj, _callBack));
    //            break;
    //        case METHOD.POST:
    //            StartCoroutine(CoSendPostWebRequest(URL, _obj, _callBack));
    //            break;
    //        case METHOD.PUT:
    //            StartCoroutine(CoSendPutWebRequest(URL, _obj, _callBack));
    //            break;
    //        case METHOD.DELETE:
    //            StartCoroutine(CoSendDeleteWebRequest(URL,_obj, _callBack));
    //            break;
    //    }

    //}

    ////CREATE
    //IEnumerator CoSendPostWebRequest(string _url, object _obj, Action<UnityWebRequest> _callBack)
    //{
    //    yield return null;

    //    string sendURL = $"{baseUrl}/{_url}/";

    //    using (UnityWebRequest webReqeust = UnityWebRequest.PostWwwForm(_url, ""))
    //    {

    //    }
    //}

    ////READ

    //IEnumerator CoSendGetWebRequest(string _url, object _obj, Action<UnityWebRequest> _callback)
    //{
    //    if (_obj == null)
    //        yield break;

    //    string sendURL = $"{baseUrl}/{_url}/";
    //    byte[] jsonBytes = null;

    //    string jsonStr = JsonUtility.ToJson(_obj);
    //    jsonBytes = Encoding.UTF8.GetBytes(jsonStr);


    //    var uwr = new UnityWebRequest(sendURL, "GET");
    //    uwr.uploadHandler = new UploadHandlerRaw(jsonBytes);
    //    uwr.downloadHandler = new DownloadHandlerBuffer();

    //    uwr.SetRequestHeader("Content-Type", "application/json");

    //    yield return uwr.SendWebRequest();



    //    if (uwr.error == null)
    //    {
    //        Debug.Log(uwr.downloadHandler.text);
    //        _callback.Invoke(uwr);
    //    }
    //    else
    //    {
    //        Debug.Log("웹 서버 에러");
    //    }
    //}

    ////UPDATE

    //IEnumerator CoSendPutWebRequest(string _url, object _obj, Action<UnityWebRequest> _callback)
    //{
    //    yield return null;


    //    using (UnityWebRequest webReqeust = UnityWebRequest.PostWwwForm(_url, ""))
    //    {

    //    }
    //}

    ////DELETE
    //IEnumerator CoSendDeleteWebRequest(string _url,object _obj, Action<UnityWebRequest> _callback)
    //{
    //    yield return null;


    //    using (UnityWebRequest webReqeust = UnityWebRequest.PostWwwForm(_url, ""))
    //    {

    //    }
    //}

    //IEnumerator CoSendWebRequest(string _url, string _method, object _obj, Action<UnityWebRequest> _callBack)
    //{

    //    yield return null;

    //    string sendURL = $"{baseUrl}/{_url}/";

    //    byte[] jsonBytes = null;

    //    if(_obj != null)
    //    {
    //        string jsonStr = JsonUtility.ToJson(_obj);
    //        jsonBytes = Encoding.UTF8.GetBytes(jsonStr);
    //    }

    //    var uwr = new UnityWebRequest(sendURL, _method);
    //    uwr.uploadHandler = new UploadHandlerRaw(jsonBytes);
    //    uwr.downloadHandler = new DownloadHandlerBuffer();

    //    uwr.SetRequestHeader("Content-Type", "application/json");

    //    yield return uwr.SendWebRequest();



    //    if(uwr.error == null)
    //    {
    //        Debug.Log(uwr.downloadHandler.text);
    //        _callBack(uwr);
    //    }
    //    else
    //    {
    //        Debug.Log("웹 서버 에러");
    //    }
    //}


    public WebServer_Data GetData()
    {
        if (datas == null)
            return null;

        return datas;
    }
}
