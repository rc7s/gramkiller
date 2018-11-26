using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collision col)
    {
        if (col.gameObject.tag == "portal01")
        {
            SceneManager.LoadScene("room01");
        }
        if (col.gameObject.tag == "portal02")
        {
            SceneManager.LoadScene("room02");
        }
        if (col.gameObject.tag == "portal03")
        {
            SceneManager.LoadScene("room03");
        }
        if (col.gameObject.tag == "portal04")
        {
            SceneManager.LoadScene("room04");
        }
        if (col.gameObject.tag == "portal05")
        {
            SceneManager.LoadScene("room05");
        }
        if (col.gameObject.tag == "portal06")
        {
            SceneManager.LoadScene("room06");
        }
        if (col.gameObject.tag == "portal07")
        {
            SceneManager.LoadScene("room07");
        }
        if (col.gameObject.tag == "portal08")
        {
            SceneManager.LoadScene("room08");
        }
        if (col.gameObject.tag == "portal09")
        {
            SceneManager.LoadScene("room09");
        }
        if (col.gameObject.tag == "portalhub")
        {
            SceneManager.LoadScene("hub");
        }
    }
}
