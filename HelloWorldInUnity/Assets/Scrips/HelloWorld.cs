using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI() {
        GUI.Label(new Rect(0, 100, 200, 200), "Welcome to the world of Unity,yuyu say Hello World!");
    }

}
