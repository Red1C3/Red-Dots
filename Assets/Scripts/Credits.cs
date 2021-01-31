using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Credits : MonoBehaviour {
    public Button menubitton;

	void Start () {
        menubitton.onClick.AddListener(menu);
	}
	public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

}
