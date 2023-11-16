using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;
    public LineRenderer Line;
    // Update is called once per frame
    void Update()
    {
        //logic for bullet making
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        void Shoot()
        {
            Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        }
    }
}