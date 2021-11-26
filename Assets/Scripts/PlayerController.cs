using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;
    public bool GameOver = true;
    public ParticleSystem boomPar;
    public AudioClip mooseSound;
    public AudioClip deathSound;
    private AudioSource playerAudio;
    
    // Start is called before the first frame update
    void Start()
    {
      playerAudio = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
       //player stays inside boundries 
       if(transform.position.x < -20){
       transform.position = new Vector3(-20, transform.position.y, transform.position.z);
       }
        
       if(transform.position.x > 20){
       transform.position = new Vector3(20, transform.position.y, transform.position.z);
       }
       horizontalInput = Input.GetAxis("Horizontal");
       transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
       
       playerAudio.PlayOneShot(mooseSound, 1.0f);
    }
    
    //particle added but not working, cause unkown
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Threat")){
            GameOver = true;
            Debug.Log("Game Over");
            boomPar.Play();
            playerAudio.PlayOneShot(deathSound, 1.0f);
        }
    }
}
