using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public AudioClip collectedClip; // Adicionando o AudioClip

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null && controller.health < controller.maxHealth)
        {
            controller.ChangeHealth(1);
            controller.PlaySound(collectedClip); // Chamando PlaySound para tocar o som
            Destroy(gameObject);
        }
    }
}



