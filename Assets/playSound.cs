using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class playSound : MonoBehaviour {

    AudioSource audioData;

	// Use this for initialization
	public void Start () {
        audioData = GetComponent<AudioSource>();
        
    }
	
    public void play()
    {
        audioData.Play();
    }
}
