
using System;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform startShoot;
    [SerializeField] private float spawnStep;
    private float nextspawntime;
    private Transform player;
    [SerializeField] private float rotationSpeed = 5f;
    
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
        Shoot();
       
        

    }

    private void LookAtPlayer()
    {
        var direction = player.transform.position - transform.position;
        var rotation = Vector3.RotateTowards(transform.forward, direction, rotationSpeed * Time.deltaTime, 0f);
        transform.rotation = Quaternion.LookRotation(rotation);
    }

    private void Shoot()
    {
        if (Time.time > nextspawntime)
        {
            nextspawntime = Time.time + spawnStep;
            Instantiate(bulletPrefab, startShoot.position, startShoot.rotation);

        }
    }
}
