using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bullet; 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

       void Shoot()
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }
    }
}
