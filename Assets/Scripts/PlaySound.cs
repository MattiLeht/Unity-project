using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audiosource;
    void Start()
    {
        Debug.Log("Pääsee tänne asti!");
        audiosource = GetComponent<AudioSource>();
    }
    
    void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("FPS_Player"))
        {
            Debug.Log("Pääseekö tänne?");
            audiosource.Play();
        }
        
    }
    private void OnControllerColliderHit(ControllerColliderHit hit) 
    {
        switch(hit.gameObject.tag)
        {
            case "JumpPad":
                Debug.Log("BOUNCE!");
                audiosource.Play();
                break;
            case "Ground":
                Debug.Log("GROUND!");
                break;
        }
    }
    
}
