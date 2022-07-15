using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] TMP_Text score_text;
    [SerializeField] TMP_Text timer_text;
    [SerializeField] Player player;
    [SerializeField] Timer timer;
 
    public void End()
    {
        gameObject.SetActive(true);
        timer.GameEnded();
        score_text.text = "Fastest Time: " + timer_text.text.ToString();
        player.moveSpeed = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
