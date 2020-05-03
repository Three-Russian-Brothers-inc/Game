//создать объект, накинуть на него компонент NavMeshAgent и этот скрипт
//до этого почитать по ссылке ниже как обозначить место, где можно ходить
//https://docs.unity3d.com/Manual/nav-BuildingNavMesh.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class citizen : MonoBehaviour
{
    
    private NavMeshAgent agent;
    private float newPosX;
    private float newPosZ;

    public float terrainWidth;
    public float terrainLength;

    public float timeRemaining = 5; //таймер

    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }

        else
        {
            timeRemaining = 10;
            newPosX = Random.Range(1f, terrainWidth);
            newPosZ = Random.Range(1f, terrainLength);
            agent.SetDestination(new Vector3(newPosX, 0, newPosZ));
        }
    }
}
