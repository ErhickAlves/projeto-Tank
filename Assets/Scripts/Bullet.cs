using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float velocidade;

    public float timelimit = 3f;
    private float timer = 0;

    private Rigidbody m_Rigidbody;


    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timelimit)
        {
            timer = 0;

            Destroy(gameObject);
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Nome do objeto: " + other.gameObject.name);
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.SetActive(false);



        }



    }
}