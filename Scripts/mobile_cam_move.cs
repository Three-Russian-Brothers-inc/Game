/* нужно создать любой объект, сделать камеру дочерним от этого объекта, повернуть камеру, 
что видеть этот объект и накинуть этот скрипт на объект*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobile_cam_move : MonoBehaviour
{

    private Vector3 dragStartPos;
    private Vector3 dragCurPos;
    private Vector3 newPos;
    
    void Start()
    {
        
        newPos = transform.position;

    }


    void Update()
    {
        
        HandleInput();

    }

    void HandleInput()  //скрипт вычисляет расстояние между кадрами и передвигает камеру в новую позицию
    {

        if(Input.GetMouseButtonDown(0)) //берем позицию камеры
        {

            Plane plane = new Plane(Vector3.up, Vector3.zero);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float entry;

            if(plane.Raycast(ray, out entry))
            {
                dragStartPos = ray.GetPoint(entry);
            }

        }

        if(Input.GetMouseButton(0)) //берем позицию после сдвига
        {

            Plane plane = new Plane(Vector3.up, Vector3.zero);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float entry;

            if(plane.Raycast(ray, out entry))
            {
                dragCurPos = ray.GetPoint(entry);

                newPos = transform.position + dragStartPos - dragCurPos;

                transform.position = newPos;
            }

        }

    }

}
