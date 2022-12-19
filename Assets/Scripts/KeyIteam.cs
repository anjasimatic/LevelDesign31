using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyIteam : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            GameVariables.keyCount += 1;
            Destroy(gameObject);
        }
    }
}
