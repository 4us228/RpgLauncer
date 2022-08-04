using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject rocketPrefab;
    [SerializeField] private Transform startShoot;
    
    
    void Start()
    {
            
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           Instantiate(rocketPrefab,startShoot.position,startShoot.rotation);
            
        }
        


    }
   
   
}
