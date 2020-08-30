using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardVolume : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Detect if it's the player
        PlayerShip playerShip
            = other.gameObject.GetComponent<PlayerShip>();
        // If we fodun something valid then continue
        if (playerShip != null)
        {
            // Death
            playerShip.Kill();
        }
    }
}
