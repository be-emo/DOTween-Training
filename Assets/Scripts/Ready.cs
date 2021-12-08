using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Ready : MonoBehaviour
{
    [SerializeField] private Image readyBG_color;
    [SerializeField] private RectTransform readyBG_rect;
    [SerializeField] private Text _text;
    
    // Start is called before the first frame update
    void Start()
    {
        // status1 出現
        readyBG_color.DOFade(1f, 0.2f)
            .SetEase(Ease.InOutQuad);

        readyBG_rect.DOScale(new Vector3(1920f, 1f, 1f), 0.8f)
            .SetEase(Ease.InOutQuad);

        _text.DOText("READY", 1f,
                scrambleMode: ScrambleMode.Uppercase)
            .SetDelay(0.8f);

        _text.DOFade(0f, 0.5f)
            .SetEase(Ease.InOutQuad)
            .SetDelay(1.8f);
        
        _text.DOText("", 0.1f)
            .SetDelay(2.2f);

        _text.DOFade(1f, 0.1f)
            .SetEase(Ease.InOutQuad)
            .SetDelay(2.8f);
        
        _text.DOText("GO", 0f)
            .SetDelay(2.8f);

        readyBG_rect.DOScale(new Vector3(1920f, 0f, 1f), 0.5f)
            .SetEase(Ease.InOutQuad)
            .SetDelay(3.3f);

        _text.DOFade(0f, 0.2f)
            .SetDelay(3.6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
