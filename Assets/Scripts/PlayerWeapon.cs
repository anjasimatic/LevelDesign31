using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform shootingStartPosition;

    private void Update()
    {
        Vector3 force = transform.forward * 700f + transform.up * 100f;
        if (Input.GetKeyDown(KeyCode.V))
        {
            GameObject newProjectile = Instantiate(projectilePrefab);
            newProjectile.transform.position = shootingStartPosition.position;
            newProjectile.GetComponent<Projectile>().Initialize(force);
        }


    }
}
