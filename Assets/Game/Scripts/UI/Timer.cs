using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timer;
    bool gameEnd = false;
    float currentTime = 0;

    // Update is called once per frame
    void Update()
    {
        if (!gameEnd)
        {
            currentTime += 1 * Time.deltaTime;
            timer.text = currentTime.ToString("0");
        }
       
    }

    public void GameEnded()
    {
       gameEnd = true;
    }
}
