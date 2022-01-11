using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button1 : MonoBehaviour
{
    [SerializeField] private GameObject OnButton1;
    [SerializeField] private GameObject OnButton2;
    [SerializeField] private GameObject OnButton3;
    [SerializeField] private GameObject OnButton4;
    [SerializeField] private GameObject OnButton5;
    
    // 残像アニメーションのために取得
    [SerializeField] private RectTransform _rectTransform;
    // Widthの減少速度
    private float fadeSpeed = 0.2f;
    // Width, heightを取得
    private float buttonWidth;
    private float buttonHeight;
    // 初期のWidthを取得
    private float firstButtonWidth;
    // OnButton1のImageコンポーネントを取得
    private Image OnButton1_Image;

    void Start()
    {
        // 空オブジェクトにアタッチしたスクリプトから，どうやってボタンのRectTransformまたはImageを取得する？
        // それができない場合はボタン各々にアタッチするが，activeSelfがfalseになった時，このスクリプトは正常に動作するのか．
        // →しなくなって良いのでは？
        buttonWidth = _rectTransform.sizeDelta.x;
        buttonHeight = _rectTransform.sizeDelta.y;
        firstButtonWidth = _rectTransform.sizeDelta.x;
        OnButton1_Image = OnButton1.GetComponentInChildren<Image>();
    }
    
    void Update()
    {
        if (OnButton2.activeSelf || OnButton3.activeSelf || OnButton4.activeSelf || OnButton5.activeSelf)
        {
            if (OnButton1.activeSelf)
            {
                buttonWidth -= Time.deltaTime / fadeSpeed;
                _rectTransform.sizeDelta = new Vector2(buttonWidth, buttonHeight);   
            }

            if (buttonWidth <= 0)
            {
                OnButton1.SetActive(false);
                _rectTransform.sizeDelta = new Vector2(firstButtonWidth, buttonHeight);
            }
        }
    }
}
