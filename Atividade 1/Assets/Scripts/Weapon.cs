using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Animator animator;
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        //checa se está na animação de correr
        if (!animator.GetCurrentAnimatorStateInfo(0).IsTag("correr"))
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
                animator.SetTrigger("Shoot");
            }
        }
        else
        {
            ClicarAtirar();
        }
    }

    void ClicarAtirar()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // logica do asset do tiro
           Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}
