using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator doorAnimation;
    public AudioSource audioSource;
    public float SoundDelay;

    private void OnTriggerEnter(Collider other)
    {

        doorAnimation.SetBool("isOpening", true);
        audioSource.PlayDelayed(SoundDelay);
    }

    private void OnTriggerExit(Collider other)
    {
        audioSource.PlayDelayed(SoundDelay);
        doorAnimation.SetBool("isOpening", false);
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
