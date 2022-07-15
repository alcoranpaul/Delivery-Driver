using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumPackages : MonoBehaviour
{
    [SerializeField] TMP_Text package_text;

    NumDelivered deliveredFunc;
    [SerializeField] TMP_Text delivered_text;
    int totalPackages = 9;

    // Start is called before the first frame update
    void Start()
    {
        package_text.text = totalPackages.ToString();
        deliveredFunc = delivered_text.GetComponent<NumDelivered>();
    }

    public void DeliveredPackage()
    {
        totalPackages -= 1;
        package_text.text = totalPackages.ToString();
        deliveredFunc.IncrementDelivered();
        if (totalPackages == 0)
        {
            deliveredFunc.GameOver();
        }
    }
    
}
