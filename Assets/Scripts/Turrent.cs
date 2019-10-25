using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrent : MonoBehaviour
{

    public float velocidade;

    
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) //Girar a torreta para a direita
        {
            transform.Rotate(0, 0.1f * velocidade, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) //Girar a torreta para a direita
        {
            transform.Rotate(0, -0.1f * velocidade, 0);
        }
    }

}
