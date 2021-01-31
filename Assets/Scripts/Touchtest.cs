using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touchtest : MonoBehaviour {
    public Text txt,txt2;
    public Touch touch1, touch2;
	// Use this for initialization
	void Start () {
        touch1 = Input.GetTouch(0);
        touch2 = Input.GetTouch(1);
	}

    // Update is called once per frame
    void Update() {
        if (Input.touchCount > 0)
        {
            txt.text = Input.GetTouch(0).position.ToString();
            //if (Input.touchCount > 1)
            //{
              //  txt2.text = Input.GetTouch(1).position.y.ToString();
            //}
        }
        if (Input.GetMouseButtonDown(0))
        {
            txt2.text = Input.mousePosition.ToString();
        }
    }

	
}
