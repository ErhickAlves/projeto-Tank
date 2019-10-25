using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject Enemy;
    public float TempoSpawn = 4.5f;
    public Transform[] PontosdeSpawn; //Localizar a posição de onde os inimigos vão spawnar



    private void Start()
    {
        InvokeRepeating("StartSpawn", TempoSpawn, TempoSpawn);
    }



    void StartSpawn()
    {
        int PontosSpawnIndex = Random.Range(0, PontosdeSpawn.Length); //Sortear os numeros e encontrar o objeto para colocar no "transform"

        Instantiate(Enemy, PontosdeSpawn[PontosSpawnIndex].position, PontosdeSpawn[PontosSpawnIndex].rotation); // Criar um objeto na cena de acordo com rotação e posição do lugar 
    }
}
