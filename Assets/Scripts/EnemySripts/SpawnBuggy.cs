using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBuggy : MonoBehaviour
{
  [SerializeField]  private GameObject buggy;
    
    
    void Start()
    {
      Instantiate(buggy.transform);
            
        
        
    }
    
}
