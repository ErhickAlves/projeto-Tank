using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    Transform TankPlayer;

    NavMeshAgent nav;

    private void Awake()
    {
        TankPlayer = GameObject.FindGameObjectWithTag("Player").transform; //buscar o objeto com a tag "player" e o transform dele

        nav = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        nav = SetDestination(TankPlayer.position); //o inimigo vai pegar a posição do player e vai ate ele
    }

    private NavMeshAgent SetDestination(Vector3 position)
    {
        throw new NotImplementedException();
    }
}
