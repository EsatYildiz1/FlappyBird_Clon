using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdScripts : MonoBehaviour
{
    public float zıplama_aralığı;
    Rigidbody2D rb;

    public Text skor_text;
    public float skor;

    public GameObject Finish;

    public AudioClip hasar,ölüm,coin,kanat;
   
   

    void Start()
    {
        
        rb= GetComponent<Rigidbody2D>();
        skor=0;
        Time.timeScale=1;
        rb.gravityScale= 0;
        
    }

   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2. up * zıplama_aralığı;
            rb.gravityScale=2;
            GetComponent<AudioSource>().PlayOneShot(kanat);
        }

        
    }

    void OnTriggerEnter2D(Collider2D temas) 
   {
     if(temas.gameObject.tag== "Scorer")
     {
        GetComponent<AudioSource>().PlayOneShot(coin);
        skor++;
        }
      skor_text.text=skor.ToString();

   }

   void OnCollisionEnter2D(Collision2D other) 
   {
    if(other.gameObject.tag== "Pipe")
    {
        GetComponent<AudioSource>().PlayOneShot(hasar);
        Time.timeScale=0;
        Finish.SetActive(true);
         GetComponent<AudioSource>().PlayOneShot(ölüm);
     }
    }

    public void RestarGame()
     {
       SceneManager.LoadScene(1);
      
     }

  
}
