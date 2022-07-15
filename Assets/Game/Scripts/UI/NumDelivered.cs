using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumDelivered : MonoBehaviour
{
    [SerializeField] TMP_Text delivered_text;
    [SerializeField] GameOverScreen gameOverScreen;

    int totalDeliveredPackages = 0;

    
    void Update()
    {
        delivered_text.text = totalDeliveredPackages.ToString();
    }

    public void IncrementDelivered()
    {
        totalDeliveredPackages++;
    }

    public void GameOver()
    {
        gameOverScreen.End();
    }
    
}
