using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Matslerp : MonoBehaviour
{
    public Material mat1;
    public Material mat2;
    public int active,tenner;
    public float lerp, lerprate,lerprator;
    public int score, highscore;
    public Camera cam;
    public Text txt,highscoretxt,gameovertxt;
    public string scoretxt;
    public UnityEngine.UI.Button Pausebutton,Menubutton;
    public float goalpha;
    public AudioClip soundsclip,falseclip;
    public AudioSource hitright,hitfalse;
    void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
    void Start()
    {
        active = Random.Range(1, 10);
        lerprate = 0.004f;
        score = 0;
        active = Random.Range(1, 10);
        Pausebutton.onClick.AddListener(TogglePause);
        Menubutton.onClick.AddListener(returntomenu);
        goalpha = 0f;
        hitright.clip = soundsclip;
        hitfalse.clip = falseclip;
        lerprator = 0.001f;
        tenner = 10;
        }
    public void returntomenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void TogglePause()
    {
        SceneManager.LoadScene("Gameplay1");
    }

    void Update()
    {
        //if (lerprate >=(lerprator*tenner))
        //{
        //  lerprator = lerprator / 10;
        // tenner = tenner * 100;
        //}
        if (lerprate >= 0.02)
        {
            lerprator = 0.0001f;
        }
        highscore = PlayerPrefs.GetInt("Highscore");
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("Highscore", highscore);
        }
        Debug.Log(highscore);
        txt.text = "Score : "+ score.ToString();
        highscoretxt.text = "Highscore : " + highscore.ToString();
        gameovertxt.color = new Color32(255, 0, 11, (byte) goalpha);
        if (lerp >= 1f)
        {
            if (goalpha < 255)
            {
                goalpha += 15;
            }
            if (goalpha == 15)
            {
                hitfalse.Play();
            }
        }
        if (active == 1)
        {

            if (lerp < 1f)
            {
                lerp += lerprate;
                GameObject.Find("Inner Circle #1").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp);
                if (Input.GetMouseButtonDown(0))
                {
                    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Circle #1")
                        {
                            lerp = 0f;
                            GameObject.Find("Inner Circle #1").GetComponent<Renderer>().material = mat1;
                            lerprate +=lerprator;
                            active = Random.Range(1, 10);
                            score += 1;
                            hitright.Play();

                        }

                    }
                }
            }
            else
            {
                GameObject.Find("Inner Circle #1").GetComponent<Renderer>().material = mat2;
            }

        }
        else
        {
            GameObject.Find("Inner Circle #1").GetComponent<Renderer>().material = mat1;
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == "Inner Circle #1")
                    {
                        lerp = 1f;
                    }

                }
            }
            
        }
        if (active == 2)
        {

            if (lerp < 1f)
            {
                lerp += lerprate;
                GameObject.Find("Inner Circle #2").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp);
                if (Input.GetMouseButtonDown(0))
                {
                    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Circle #2")
                        {
                            lerp = 0f;
                            GameObject.Find("Inner Circle #2").GetComponent<Renderer>().material = mat1;
                            lerprate += lerprator;
                            active = Random.Range(1, 10);
                            score += 1;
                            hitright.Play();

                        }

                    }
                }
            }
            else
            {
                GameObject.Find("Inner Circle #2").GetComponent<Renderer>().material = mat2;

            }

        }
        else
        {
            GameObject.Find("Inner Circle #2").GetComponent<Renderer>().material = mat1;
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == "Inner Circle #2")
                    {
                        lerp = 1f;
                    }

                }
            }
        }
        if (active == 3)
        {

            if (lerp < 1f)
            {
                lerp += lerprate;
                GameObject.Find("Inner Circle #3").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp);
                if (Input.GetMouseButtonDown(0))
                {
                    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Circle #3")
                        {
                            lerp = 0f;
                            GameObject.Find("Inner Circle #3").GetComponent<Renderer>().material = mat1;
                            lerprate +=lerprator;
                            active = Random.Range(1, 10);
                            score += 1;
                            hitright.Play();

                        }

                    }
                }
            }
            else
            {
                GameObject.Find("Inner Circle #3").GetComponent<Renderer>().material = mat2;

            }

        }
        else
        {
            GameObject.Find("Inner Circle #3").GetComponent<Renderer>().material = mat1;
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == "Inner Circle #3")
                    {
                        lerp = 1f;
                    }

                }
            }
        }
        if (active == 4)
        {

            if (lerp < 1f)
            {
                lerp += lerprate;
                GameObject.Find("Inner Circle #4").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp);
                if (Input.GetMouseButtonDown(0))
                {
                    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Circle #4")
                        {
                            lerp = 0f;
                            GameObject.Find("Inner Circle #4").GetComponent<Renderer>().material = mat1;
                            lerprate +=lerprator;
                            active = Random.Range(1, 10);
                            score += 1;
                            hitright.Play();

                        }
                        else { }
                    }
                }
            }
            else
            {
                GameObject.Find("Inner Circle #4").GetComponent<Renderer>().material = mat2;

            }

        }
        else
        {
            GameObject.Find("Inner Circle #4").GetComponent<Renderer>().material = mat1;
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == "Inner Circle #4")
                    {
                        lerp = 1f;
                    }

                }
            }
        }
        if (active == 5)
        {

            if (lerp < 1f)
            {
                lerp += lerprate;
                GameObject.Find("Inner Circle #5").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp);
                if (Input.GetMouseButtonDown(0))
                {
                    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Circle #5")
                        {
                            lerp = 0f;
                            GameObject.Find("Inner Circle #5").GetComponent<Renderer>().material = mat1;
                            lerprate +=lerprator;
                            active = Random.Range(1, 10);
                            score += 1;
                            hitright.Play();

                        }
                        else { }
                    }
                }
            }
            else
            {
                GameObject.Find("Inner Circle #5").GetComponent<Renderer>().material = mat2;

            }

        }
        else
        {
            GameObject.Find("Inner Circle #5").GetComponent<Renderer>().material = mat1;
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == "Inner Circle #5")
                    {
                        lerp = 1f;
                    }

                }
            }
        }
        if (active == 6)
        {

            if (lerp < 1f)
            {
                lerp += lerprate;
                GameObject.Find("Inner Circle #6").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp);
                if (Input.GetMouseButtonDown(0))
                {
                    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Circle #6")
                        {
                            lerp = 0f;
                            GameObject.Find("Inner Circle #6").GetComponent<Renderer>().material = mat1;
                            lerprate +=lerprator;
                            active = Random.Range(1, 10);
                            score += 1;
                            hitright.Play();

                        }
                        else { }
                    }
                }
            }
            else
            {
                GameObject.Find("Inner Circle #6").GetComponent<Renderer>().material = mat2;

            }

        }
        else
        {
            GameObject.Find("Inner Circle #6").GetComponent<Renderer>().material = mat1;
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == "Inner Circle #6")
                    {
                        lerp = 1f;
                    }

                }
            }
        }
        if (active == 7)
        {

            if (lerp < 1f)
            {
                lerp += lerprate;
                GameObject.Find("Inner Circle #7").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp);
                if (Input.GetMouseButtonDown(0))
                {
                    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Circle #7")
                        {
                            lerp = 0f;
                            GameObject.Find("Inner Circle #7").GetComponent<Renderer>().material = mat1;
                            lerprate +=lerprator;
                            active = Random.Range(1, 10);
                            score += 1;
                            hitright.Play();

                        }
                        else { }
                    }
                }
            }
            else
            {
                GameObject.Find("Inner Circle #7").GetComponent<Renderer>().material = mat2;

            }

        }
        else
        {
            GameObject.Find("Inner Circle #7").GetComponent<Renderer>().material = mat1;
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == "Inner Circle #7")
                    {
                        lerp = 1f;
                    }

                }
            }
        }
        if (active == 8)
        {

            if (lerp < 1f)
            {
                lerp += lerprate;
                GameObject.Find("Inner Circle #8").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp);
                if (Input.GetMouseButtonDown(0))
                {
                    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Circle #8")
                        {
                            lerp = 0f;
                            GameObject.Find("Inner Circle #8").GetComponent<Renderer>().material = mat1;
                            lerprate +=lerprator;
                            active = Random.Range(1, 10);
                            score += 1;
                            hitright.Play();

                        }
                        else { }
                    }
                }
            }
            else
            {
                GameObject.Find("Inner Circle #8").GetComponent<Renderer>().material = mat2;

            }

        }
        else
        {
            GameObject.Find("Inner Circle #8").GetComponent<Renderer>().material = mat1;
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == "Inner Circle #8")
                    {
                        lerp = 1f;
                    }

                }
            }
        }
        if (active == 9)
        {

            if (lerp < 1f)
            {
                lerp += lerprate;
                GameObject.Find("Inner Circle #9").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp);
                if (Input.GetMouseButtonDown(0))
                {
                    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Circle #9")
                        {
                            lerp = 0f;
                            GameObject.Find("Inner Circle #9").GetComponent<Renderer>().material = mat1;
                            lerprate +=lerprator;
                            active = Random.Range(1, 10);
                            score += 1;
                            hitright.Play();

                        }
                        else { }
                    }
                }
            }
            else
            {
                GameObject.Find("Inner Circle #9").GetComponent<Renderer>().material = mat2;

            }

        }
        else
        {
            GameObject.Find("Inner Circle #9").GetComponent<Renderer>().material = mat1;
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == "Inner Circle #9")
                    {
                        lerp = 1f;
                    }

                }
            }
        }
    }
    void OnDestroy()
    {
        PlayerPrefs.Save();
    }
}

