using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void OnTriggerEnter(Collider other){
        Destroy(gameObject);
        Destroy(other.gameObject);
        //not working, cause unkown
        //gameManager.GameOver();
    }
}