using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonNoScript : MonoBehaviour
{
    public GameObject uiPanel; // ����� UI �г�

    public void UIOff()
    {
        uiPanel.SetActive(false);
    }
    void Update()
    {

    }
    // Start is called before the first frame update
    /*
    private void Start()
    {
        // Button ������Ʈ�� ���� ������ �߰�
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnClick);
        }
        else
        {
            Debug.LogError("Button ������Ʈ�� ã�� �� �����ϴ�!");
        }
    }

    // Update is called once per frame
    
    private void OnClick()
    {
        // ����� UI �г��� ��Ȱ��ȭ
        if (uiPanel != null)
        {
            uiPanel.SetActive(false);
        }
        else
        {
            Debug.LogError("UI �г��� �Ҵ���� �ʾҽ��ϴ�!");
        }
    }
    */
}
