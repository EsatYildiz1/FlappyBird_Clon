using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yönetici : MonoBehaviour
{
     public GameObject PipeSpawner,OpeningScene;
    
    void Start()
    {
         
       PipeSpawner.GetComponent<PipeSpawn>().enabled=false;
       
    }

    
    void Update()
    {
         if(Input.GetMouseButtonDown(0))
        {
           
            PipeSpawner.GetComponent<PipeSpawn>().enabled=true;
             OpeningScene.SetActive(false);
             
        }

    }
}
