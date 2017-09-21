using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPitch : MonoBehaviour {

    AudioSource audio;
    public float MinPitch, MaxPitch;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
        audio.pitch = Random.Range(MinPitch, MaxPitch);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
