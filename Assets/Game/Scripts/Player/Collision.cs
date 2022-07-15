using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage = false;
    Color32 hasPackageColor = new Color32(255,0,0,255);
    Color32 noPackageColor = new Color32(255, 255, 255,255);

    [SerializeField] AudioSource packageAudio, customerAudio;

    NumPackages numPackages;
    [SerializeField] TMP_Text numPackages_text;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();   
        numPackages = numPackages_text.GetComponent<NumPackages>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package") && !hasPackage)
        {
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            packageAudio.Play();
            Debug.Log("You picked up a package");
            Destroy(collision.gameObject, 0f);
        }
        else if (collision.CompareTag("Customer") && hasPackage)
        {
            numPackages.DeliveredPackage();
            customerAudio.Play();
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            Destroy(collision.gameObject, 0f);
            Debug.Log("You delivered a package!!");
        }

        
    }
}
