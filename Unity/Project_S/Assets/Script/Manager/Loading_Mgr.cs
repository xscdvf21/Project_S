using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading_Mgr : MonoBehaviour
{
    private static Loading_Mgr instance = null;

    public static Loading_Mgr Instance
    {
        get
        {
            return instance;
        }
    }

    [SerializeField] string nextScene;

    public bool isLoading = false;

    private float delayTime = 2f;
    private void Awake()
    {
        instance = this;
    }
    public void NextScene(string _sceneName)
    {
        nextScene = _sceneName;
        SceneManager.LoadScene("Loading");

        StartCoroutine(NexSceneCo(_sceneName));
    }

    IEnumerator NexSceneCo(string _sceneName)
    {
        yield return null;

        AsyncOperation op = SceneManager.LoadSceneAsync(_sceneName);
        op.allowSceneActivation = false;

        float timer = 0f;

        while (!op.isDone)
        {
            yield return null;

            //로딩이 끝났고, 메인플레이어가 널이 아니라면,
            if (0.9f <= op.progress)
            {
                timer += Time.deltaTime;
                if (isLoading || delayTime < timer)
                {
                    op.allowSceneActivation = true;
                    isLoading = false;
                    yield break;
                }

            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            LoadingFinish();
    }

    public void LoadingFinish()
    {
        isLoading = true;
    }
    public void SetIsLoading(bool _b)
    {
        isLoading = _b;
    }
}
