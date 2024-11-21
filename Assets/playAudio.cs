using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip helloClip;     // Reference to the helloPeople audio file
    
    // Start is called before the first frame update
    private void Start(){
        audioSource.Play();
    }   
}
