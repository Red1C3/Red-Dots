using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour {
    public Button onehandedmodebutton,twohandedmodebutton,creditsbutton;
    void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
	void Start () {
        onehandedmodebutton.onClick.AddListener(onehandedstart);
        twohandedmodebutton.onClick.AddListener(twohandedstart);
        creditsbutton.onClick.AddListener(credits);
	}
    public void onehandedstart()
    {
        SceneManager.LoadScene("Gameplay1");
    }
	public void twohandedstart()
    {
        SceneManager.LoadScene("Gameplay2");
    }
	public void credits()
    {
        SceneManager.LoadScene("credits");
    }
}
