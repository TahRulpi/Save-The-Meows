using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;
    public AudioSource deathAudio;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health--;

            if (health <= 0)
            {
                deathAudio.Play();
                GameManager.AddScore(5); // Add 5 points for each enemy destroyed
                Destroy(gameObject, deathAudio.clip.length);
            }
        }
    }
}



/*public class PlayerShoot : MonoBehaviour
{

    private PlayerInput playerInput;
    private InputAction shootAction;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private Transform barrelTransform;
    [SerializeField]
    private Transform bulletParent;
    [SerializeField]
    private float bulletHitMissDist = 25f;

    private void Awake()
    {
        

        playerInput = GetComponent<PlayerInput>();
        //shootAction = playerInput.actions["Shoot"];
    }


    private void OnEnable()
    {
        shootAction.performed += _ => ShootGun();
    }

    private void OnDisable()
    {
        shootAction.performed -= _ => ShootGun();
    }

    private void ShootGun()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            GameObject bullet = GameObject.Instantiate(bulletPrefab, barrelTransform.position, Quaternion.identity, bulletParent);
            BulletControl bulletControl = GetComponent<BulletControl>();
            bulletControl.target = hit.point;
            bulletControl.hit = true;
        }
        *//*else
        {
            bulletControl.target = transform.position + transform.forward * bulletHitMissDist = 25f;
            
            bulletControl.hit = true;
        }*//*
    }

    // Start is called before the first frame update
    
}
*/