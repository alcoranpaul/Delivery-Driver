using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage = false;
    Color32 hasPackageColor = new Color32(255,0,0,255);
    Color32 noPackageColor = new Color32(255, 255, 255,255);

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();   
    }



    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package") && !hasPackage)
        {
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Debug.Log("You picked up a package");
            Destroy(collision.gameObject, 0f);
        }
        else if (collision.CompareTag("Customer") && hasPackage)
        {
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            Debug.Log("You delivered a package!!");
        }

        
    }
}
