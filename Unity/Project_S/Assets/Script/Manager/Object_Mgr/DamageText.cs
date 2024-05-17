using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Text = TMPro.TMP_Text;
public class DamageText : MonoBehaviour
{
    [SerializeField] DAMAGE_FONT type;
    [SerializeField] Text text;
    [SerializeField] float duration;
    [SerializeField] float timer;


    [SerializeField] float angle = 80f;
    [SerializeField] private float initialVelocity = 5f;

    private Vector2 initPos;

    private float gravity = 9.8f;

    private float drawTime = 0f;

    private void OnEnable()
    {
        drawTime = 0f;
        timer = duration;

        initPos = transform.position;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        DrawText();

        if (timer <= 0)
        {
    
            ReturnObj();
        }
    }

    public void ShowText(Vector2 _vPos, string _text)
    {
        transform.position = _vPos;
        gameObject.SetActive(true);
        text.text = _text;
    }

    private void ReturnObj()
    {
        gameObject.SetActive(false);
        Object_Mgr.Instance.text_Mgr.ReturnObj(type, this.gameObject);
    }

    void DrawText()
    {
        drawTime += Time.deltaTime;

        // ��꿡 �ʿ��� ������ �������� ��ȯ
        float radians = angle * Mathf.Deg2Rad;

        // �ؽ�Ʈ�� ���ο� ��ġ ���
        float x = initialVelocity * drawTime * Mathf.Cos(radians);
        float y = initialVelocity * drawTime * Mathf.Sin(radians) - 0.5f * gravity * drawTime * drawTime;

        // �ؽ�Ʈ�� ��ġ ����
        transform.position = initPos + new Vector2(x, y);
    }
}
