using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private GameObject rocket;
    [SerializeField] private GameObject startShoot;
    [SerializeField] private float rocketSpeed = 30f;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 rocketSpawnPoint = startShoot.transform.position;
            
            Quaternion rocketSpawnQuaternion = startShoot.transform.rotation;
            
            GameObject fire_rocket = Instantiate(rocket,rocketSpawnPoint,rocketSpawnQuaternion);
            
            Rigidbody Run = fire_rocket.GetComponent<Rigidbody>();

            Run.AddForce(fire_rocket.transform.forward * rocketSpeed, ForceMode.Force);

            Destroy(Run,3);


        }

    }
}
