using System;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {


    }

    // Update is called once per frame
    void Update () {
        DateTime date = DateTime.Now;
        //Debug.Log(date.ToString());
        GetComponent<TextMesh>().text = date.ToString();
    }
}
