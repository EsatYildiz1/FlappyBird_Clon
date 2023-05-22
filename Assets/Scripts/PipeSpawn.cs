using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
   public float maxTime = 1 ;
   public float timer = 0;
   public GameObject pipe;
   public float yükseklik;
   public float hız_artışı;

   

    void Start()
    {   
        if(Input.GetMouseButtonDown(0)){
         GameObject newpipe= Instantiate(pipe);
        newpipe.transform.position= transform.position+ new Vector3(0, Random.Range(-yükseklik,yükseklik), 0 );   
        }
    }

    
    void Update()
    {
        if(timer>maxTime)
        {
            GameObject newpipe= Instantiate(pipe);
            newpipe.transform.position= transform.position+ new Vector3(0, Random.Range(-yükseklik,yükseklik), 0 );
            Destroy(newpipe,10);
            timer=0;
        }
        
        timer += Time.deltaTime;  
    

    }
   
  













   
 }

    
