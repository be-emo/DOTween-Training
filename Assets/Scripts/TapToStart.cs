using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TapToStart : MonoBehaviour
{
    [SerializeField] private Image tap_to_screen;
    
    // Start is called before the first frame update
    void Start()
    {
        tap_to_screen.DOFade(0f, 1.5f)
			.SetEase(Ease.InOutQuart)
			.SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
