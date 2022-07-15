using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float steerSpeed = 100;
    [SerializeField] float defaultSpeed = 13;
    [SerializeField] float slowSpeed = 8;
    [SerializeField] float boostSpeed = 25;
    [SerializeField] AudioSource slowAudio, speedAudio;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = defaultSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SpeedBoost"))
        {
            moveSpeed = boostSpeed;
            speedAudio.Play();
            Debug.Log("I am SPEEEEEEEEED");
        }
        else if (collision.CompareTag("SlowBoost"))
        {
            moveSpeed = slowSpeed;
            slowAudio.Play();
            Debug.Log("SLOOOW");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = defaultSpeed;
        Debug.Log("Ouch!!");
    }
}
