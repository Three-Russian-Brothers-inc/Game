//глобальный скрипт. накинуть на объект с глобальными скриптами
//получает данные о всех строительных площадках и ставит на нах здание

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBldng : MonoBehaviour
{
    
    public GameObject bilding;
    public GameObject[] places;

    void Start()
    {
        places = GameObject.FindGameObjectsWithTag("place");
    }

    public void newBilding()
    {

        foreach (GameObject place in places)
        {

            if(place.gameObject.GetComponent<place>().isClicked == true && place.gameObject.GetComponent<place>().isEmpty == true)
            {

                Instantiate(bilding, new Vector3(place.transform.position.x, place.transform.position.y, place.transform.position.z), Quaternion.identity);
                place.gameObject.GetComponent<onObjClick>().createBld.gameObject.SetActive(false);
                place.gameObject.GetComponent<place>().isClicked = false;
                place.gameObject.GetComponent<place>().isEmpty = false;

            }

        }


        

    }

}
