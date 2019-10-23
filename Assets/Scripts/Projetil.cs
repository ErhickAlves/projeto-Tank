using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    private float timelimit = 3f;
    private float timer = 0;

    private Rigidbody m_Rigidbody;


    private void Update()
    {
        timer += Time.deltaTime;
        
        if(timer >= timelimit)
        {
            timer = 0;

            Destroy(gameObject);
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy");
        {
            other.gameObject.SetActive(false);

            
        }
    }
}
