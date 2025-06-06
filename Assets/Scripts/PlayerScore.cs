using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class PlayerScore : MonoBehaviour
{
    private int score;
    private List<int> Coins = new List<int>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("startBericht");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 50)
        {
            Debug.Log("Gewonnen");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            AddCoin(10);
        }
    }

    void AddCoin(int coinValue)
    {
        Coins.Add(coinValue);
        score += coinValue;
        Debug.Log("you got a coin" + score);
    }
}
