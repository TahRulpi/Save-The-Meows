using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{

    public float speed = 20f;

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); // Moves the bullet forward

        
       
        //  Debug.Log("Bullet is working");
    }



    /* [SerializeField]
     private GameObject bulletDecal;

     private float speed = 50f;
     private float timeDestroy = 3f;

     public Vector3 target { get; set; }
     public bool hit { get; set; }
     // Start is called before the first frame update
     public void onEnable()
     {
         Destroy(gameObject, timeDestroy);
     }

     // Update is called once per frame
    // void Update()
     {
         transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
         if (!hit && Vector3.Distance(transform.position, target) < 0.01f)
         {
             Destroy(gameObject);
         }
     }

     private void OnCollisionEnter(Collision other)
     {
         ContactPoint contact = other.GetContact(0);
         GameObject.Instantiate(bulletDecal, contact.point, Quaternion.LookRotation(contact.normal));
         Destroy(gameObject);

     }*/



}
