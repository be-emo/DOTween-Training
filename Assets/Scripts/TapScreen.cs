using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TapScreen : MonoBehaviour
{
    public GameObject load;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            StartCoroutine(load.GetComponent<LoadScene>().Load_Scene());
    }
}
