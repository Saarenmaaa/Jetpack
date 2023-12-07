using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
   public GameObject bulletPrefab;
   public Transform firePoint;
   private float fireForce = 15f;

   void Update()
   {
      if(Input.GetMouseButtonDown(0))
      {
         Fire();
      }
   }
   public void Fire()
   {
      GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
      bullet.transform.rotation = Quaternion.Euler(0f, 0f, firePoint.eulerAngles.z - 90f);
      bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.right * fireForce, ForceMode2D.Impulse);
   }
}

