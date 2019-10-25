using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public Text scoreText;

    private int points;

    public int Points
    {
        get
        {
            return points;
        }

        set
        {
            points += value;

            UpdatePointsText();
        }
    }

    void MostrarPoints()
    {
        Debug.Log("Points: " + points);

    }

    void UpdatePointsText()
    {
        scoreText.text = "Points: " + points.ToString();
    }
}
