using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float velocidade = 4f;
    public GameObject tiro;

    private Rigidbody m_Rigidbody;
    private TankHealth m_TankHealth;
    private Renderer m_renderer;

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        m_TankHealth = GetComponent<TankHealth>();

        m_renderer = GetComponent<Renderer>();
    }


    private void Start()
    {
        
    }

    private void Update()
    {
        Movement();
    }


    void Movement()
    {
        if(Input.GetKey(KeyCode.W)) //Movimento para frente
        {
            transform.Translate(0, 0, 0.1f * velocidade);
        }

        if(Input.GetKey(KeyCode.S)) //Movimento para trás
        {
            transform.Translate(0, 0, -0.1f * velocidade);
        }

        if(Input.GetKey(KeyCode.A)) //Movimento para a esquerda
        {
            Vector3 rotation = transform.rotation.eulerAngles;
            rotation.y = -0.5f;

            transform.Rotate(rotation * velocidade);
        }

        if(Input.GetKey(KeyCode.D)) //Movimento para a direita
        {
            Vector3 rotation = transform.rotation.eulerAngles;
            rotation.y = 0.5f;

            transform.Rotate(rotation * velocidade);
        }
    }
}
