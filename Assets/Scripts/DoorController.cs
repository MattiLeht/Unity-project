using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    
    public Animator doorAnimation;
<<<<<<< Updated upstream
    public AudioSource audioSource;
    public float SoundDelay;
=======
    
    
    
>>>>>>> Stashed changes

    private void OnTriggerEnter(Collider other)
    {

        doorAnimation.SetBool("isOpening", true);
<<<<<<< Updated upstream
        audioSource.PlayDelayed(SoundDelay);
        
        
     
=======
>>>>>>> Stashed changes
          
    }
    
    private void OnTriggerExit(Collider other)
    {
        
        doorAnimation.SetBool("isOpening", false);
        audioSource.PlayDelayed(SoundDelay);
    }
    // Start is called before the first frame update
    void Start()
    {
        doorAnimation = this.transform.parent.GetComponent<Animator>();
    }

    private void Update()
    {
        
    }
}
