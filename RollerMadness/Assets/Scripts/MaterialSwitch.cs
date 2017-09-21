using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialSwitch : MonoBehaviour {

    public Material[] materials = new Material[3];
    Health health;
    Renderer rend;
    int hp;
    public Text text;

    // Use this for initialization
    void Start () {
        health = GetComponent<Health>();
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        hp = (int)health.healthPoints - 1;
        if (hp >= 0 && hp < 3)
        {
            rend.material = materials[(int)health.healthPoints - 1];
        }
        text.text = "Lives: " + health.healthPoints;
	}
}
