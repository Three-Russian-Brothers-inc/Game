//навесить на строительную площадку
//скрипт активирует кнопку UI для строительства

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onObjClick : MonoBehaviour
{
    
    public Button createBld;

    void Start()
    {
        createBld.gameObject.SetActive(false);
    }

    public void OnMouseDown()
    {
        
        createBld.gameObject.SetActive(true);
        this.gameObject.GetComponent<place>().isClicked = true;
        

    }
}
