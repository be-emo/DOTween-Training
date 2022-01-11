using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TitleFade : MonoBehaviour
{
    
    [SerializeField] private Image panel;
    
    // 処理を実行する間隔span
    [SerializeField] private float span;
    private float timeCount = 0f;

    // Start is called before the first frame update
    void Start()
    {
        panel.DOFade(0f, 2f);	// フェードイン
        panel.DOFade(1f, 2f)
            .SetDelay(span-2f);	// フェードアウト
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        if (timeCount > span)
        {
            panel.DOFade(0f, 2f);
            panel.DOFade(1f, 2f)
                .SetDelay(span-2f);
            timeCount = 0f;
        }
    }
}
