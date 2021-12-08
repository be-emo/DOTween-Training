using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    [SerializeField] private Image statusBG;
    [SerializeField] private RectTransform status1;
    [SerializeField] private Image status1_color;
    [SerializeField] private RectTransform status2;
    [SerializeField] private Image status2_color;
    
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(3.8f);
        
        // 背景のフェードイン
        statusBG.DOFade(1f, 1f)
            .SetEase(Ease.InOutQuad);
        
        // status1 出現
        status1_color.DOFade(1f, 0.2f)
            .SetEase(Ease.InOutQuad)
            .SetDelay(0.5f);

        status1.DOScale(new Vector3(250f, 1f, 1f), 0.8f)
            .SetEase(Ease.InOutQuad)
            .SetDelay(0.5f);
        
        // status2 出現
        status2_color.DOFade(1f, 0.2f)
            .SetEase(Ease.InOutQuad)
            .SetDelay(0.9f);

        status2.DOScale(new Vector3(250f, 1f, 1f), 0.8f)
            .SetEase(Ease.InOutQuad)
            .SetDelay(0.9f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
