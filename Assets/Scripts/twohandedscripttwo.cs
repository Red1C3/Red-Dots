using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class twohandedscripttwo : MonoBehaviour {
    public Material mat1, mat2;
    public int active1, active2, score, highscore,tenner;
    public float lerp, lerprate, goalpha, lerp2,lerprator;
    public Camera cam;
    public Text txt, highscoretxt, gameovertxt;
    public Button retrybutton, menubutton;
    public AudioClip soundsclip, falseclip;
    public AudioSource hitright, hitfalse;
    void Awake()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
    void Start () {
        active1 = Random.Range(1, 5);
        active2 = Random.Range(1, 5);
        lerprate = 0.004f;
        score = 0;
        retrybutton.onClick.AddListener(retry);
        menubutton.onClick.AddListener(returntomenu);
        goalpha = 0f;
        hitright.clip = soundsclip;
        hitfalse.clip = falseclip;
        lerprator = 0.001f;
        tenner = 10;
    }
    public void retry()
    {
        SceneManager.LoadScene("Gameplay2");
    }
    public void returntomenu()
    {
        SceneManager.LoadScene("Menu");
    }
    void Update () {
        //if (lerprate >= (lerprator * tenner))
        //{
        //  lerprator = lerprator / 10;
        // tenner = tenner * 100;
        //}
        if (lerprate >= 0.02)
        {
            lerprator = 0.0001f;
        }
        highscore = PlayerPrefs.GetInt("Highscore2");
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("Highscore2", highscore);
        }
        txt.text = "Score : " + score.ToString();
        highscoretxt.text = "Highscore : " + highscore.ToString();
        gameovertxt.color = new Color32(255, 0, 11, (byte)goalpha);
        if (lerp >= 1f || lerp2 >= 1f)
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
        if (active1 == 1)
        {

            if (lerp < 1f && lerp2 < 1f)
            {
                lerp += lerprate;
                GameObject.Find("Inner Ring 1-1").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp);
                if (Input.touchCount > 0)
                {
                    if (Input.GetTouch(0).phase == TouchPhase.Ended)
                    {
                        Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.transform.name == "Inner Ring 1-1")
                            {
                                lerp = 0f;
                                GameObject.Find("Inner Ring 1-1").GetComponent<Renderer>().material = mat1;
                                lerprate +=lerprator;
                                active1 = Random.Range(1, 5);
                                score += 1;
                                hitright.Play();

                            }

                        }
                    }
                    if (Input.touchCount > 1)
                    {
                        if (Input.GetTouch(1).phase == TouchPhase.Ended)
                        {
                            Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                            RaycastHit hit;
                            if (Physics.Raycast(ray, out hit))
                            {
                                if (hit.transform.name == "Inner Ring 1-1")
                                {
                                    lerp = 0f;
                                    GameObject.Find("Inner Ring 1-1").GetComponent<Renderer>().material = mat1;
                                    lerprate +=lerprator;
                                    active1 = Random.Range(1, 5);
                                    score += 1;
                                    hitright.Play();

                                }

                            }
                        }
                    }
                }
            }
            else
            {
                GameObject.Find("Inner Ring 1-1").GetComponent<Renderer>().material = mat2;
            }

        }
        else
        {
            GameObject.Find("Inner Ring 1-1").GetComponent<Renderer>().material = mat1;
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Ring 1-1")
                        {
                            lerp = 1f;
                            lerp2 = 1f;
                        }

                    }
                }
                if (Input.touchCount > 1)
                {
                    if (Input.GetTouch(1).phase == TouchPhase.Ended)
                    {
                        Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.transform.name == "Inner Ring 1-1")
                            {
                                lerp = 1f;
                                lerp2 = 1f;
                            }

                        }
                    }
                }
            }
        }
        if (active1 == 2)
        {

            if (lerp < 1f && lerp2 < 1f)
            {
                lerp += lerprate;
                GameObject.Find("Inner Ring 1-2").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp);
                if (Input.touchCount > 0)
                {
                    if (Input.GetTouch(0).phase == TouchPhase.Ended)
                    {
                        Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.transform.name == "Inner Ring 1-2")
                            {
                                lerp = 0f;
                                GameObject.Find("Inner Ring 1-2").GetComponent<Renderer>().material = mat1;
                                lerprate += lerprator;
                                active1 = Random.Range(1, 5);
                                score += 1;
                                hitright.Play();

                            }

                        }
                    }
                    if (Input.touchCount > 1)
                    {
                        if (Input.GetTouch(1).phase == TouchPhase.Ended)
                        {
                            Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                            RaycastHit hit;
                            if (Physics.Raycast(ray, out hit))
                            {
                                if (hit.transform.name == "Inner Ring 1-2")
                                {
                                    lerp = 0f;
                                    GameObject.Find("Inner Ring 1-2").GetComponent<Renderer>().material = mat1;
                                    lerprate += lerprator;
                                    active1 = Random.Range(1, 5);
                                    score += 1;
                                    hitright.Play();

                                }

                            }
                        }
                    }
                }
            }
            else
            {
                GameObject.Find("Inner Ring 1-2").GetComponent<Renderer>().material = mat2;
            }

        }
        else
        {
            GameObject.Find("Inner Ring 1-2").GetComponent<Renderer>().material = mat1;
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Ring 1-2")
                        {
                            lerp = 1f;
                            lerp2 = 1f;
                        }

                    }
                }
                if (Input.touchCount > 1)
                {
                    if (Input.GetTouch(1).phase == TouchPhase.Ended)
                    {
                        Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.transform.name == "Inner Ring 1-2")
                            {
                                lerp = 1f;
                                lerp2 = 1f;
                            }

                        }
                    }
                }
            }
        }
        if (active1 == 3)
        {

            if (lerp < 1f && lerp2 < 1f)
            {
                lerp += lerprate;
                GameObject.Find("Inner Ring 1-3").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp);
                if (Input.touchCount > 0)
                {
                    if (Input.GetTouch(0).phase == TouchPhase.Ended)
                    {
                        Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.transform.name == "Inner Ring 1-3")
                            {
                                lerp = 0f;
                                GameObject.Find("Inner Ring 1-3").GetComponent<Renderer>().material = mat1;
                                lerprate += lerprator;
                                active1 = Random.Range(1, 5);
                                score += 1;
                                hitright.Play();

                            }

                        }
                    }
                    if (Input.touchCount > 1)
                    {
                        if (Input.GetTouch(1).phase == TouchPhase.Ended)
                        {
                            Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                            RaycastHit hit;
                            if (Physics.Raycast(ray, out hit))
                            {
                                if (hit.transform.name == "Inner Ring 1-3")
                                {
                                    lerp = 0f;
                                    GameObject.Find("Inner Ring 1-3").GetComponent<Renderer>().material = mat1;
                                    lerprate += lerprator;
                                    active1 = Random.Range(1, 5);
                                    score += 1;
                                    hitright.Play();

                                }

                            }
                        }
                    }
                }
            }
            else
            {
                GameObject.Find("Inner Ring 1-3").GetComponent<Renderer>().material = mat2;
            }

        }
        else
        {
            GameObject.Find("Inner Ring 1-3").GetComponent<Renderer>().material = mat1;
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Ring 1-3")
                        {
                            lerp = 1f;
                            lerp2 = 1f;
                        }

                    }
                }
                if (Input.touchCount > 1)
                {
                    if (Input.GetTouch(1).phase == TouchPhase.Ended)
                    {
                        Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.transform.name == "Inner Ring 1-3")
                            {
                                lerp = 1f;
                                lerp2 = 1f;
                            }

                        }
                    }
                }
            }
        }
        if (active1 == 4)
        {

            if (lerp < 1f && lerp2 < 1f)
            {
                lerp += lerprate;
                GameObject.Find("Inner Ring 1-4").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp);
                if (Input.touchCount > 0)
                {
                    if (Input.GetTouch(0).phase == TouchPhase.Ended)
                    {
                        Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.transform.name == "Inner Ring 1-4")
                            {
                                lerp = 0f;
                                GameObject.Find("Inner Ring 1-4").GetComponent<Renderer>().material = mat1;
                                lerprate += lerprator;
                                active1 = Random.Range(1, 5);
                                score += 1;
                                hitright.Play();

                            }

                        }
                    }
                    if (Input.touchCount > 1)
                    {
                        if (Input.GetTouch(1).phase == TouchPhase.Ended)
                        {
                            Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                            RaycastHit hit;
                            if (Physics.Raycast(ray, out hit))
                            {
                                if (hit.transform.name == "Inner Ring 1-4")
                                {
                                    lerp = 0f;
                                    GameObject.Find("Inner Ring 1-4").GetComponent<Renderer>().material = mat1;
                                    lerprate += lerprator;
                                    active1 = Random.Range(1, 5);
                                    score += 1;
                                    hitright.Play();

                                }

                            }
                        }
                    }
                }
            }
            else
            {
                GameObject.Find("Inner Ring 1-4").GetComponent<Renderer>().material = mat2;
            }

        }
        else
        {
            GameObject.Find("Inner Ring 1-4").GetComponent<Renderer>().material = mat1;
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Ring 1-4")
                        {
                            lerp = 1f;
                            lerp2 = 1f;
                        }

                    }
                }
                if (Input.touchCount > 1)
                {
                    if (Input.GetTouch(1).phase == TouchPhase.Ended)
                    {
                        Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.transform.name == "Inner Ring 1-4")
                            {
                                lerp = 1f;
                                lerp2 = 1f;
                            }

                        }
                    }
                }
            }
        }
        if (active2 == 1)
        {
            if (lerp < 1f && lerp2 < 1f)
            {
                lerp2 += lerprate;
                GameObject.Find("Inner Ring 2-1").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp2);
                if (Input.touchCount > 0)
                {
                    if (Input.GetTouch(0).phase == TouchPhase.Ended)
                    {
                        Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.transform.name == "Inner Ring 2-1")
                            {
                                lerp2 = 0f;
                                GameObject.Find("Inner Ring 2-1").GetComponent<Renderer>().material = mat1;
                                lerprate += lerprator;
                                active2 = Random.Range(1, 5);
                                score += 1;
                                hitright.Play();

                            }

                        }
                    }
                    if (Input.touchCount > 1)
                    {
                        if (Input.GetTouch(1).phase == TouchPhase.Ended)
                        {
                            Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                            RaycastHit hit;
                            if (Physics.Raycast(ray, out hit))
                            {
                                if (hit.transform.name == "Inner Ring 2-1")
                                {
                                    lerp2 = 0f;
                                    GameObject.Find("Inner Ring 2-1").GetComponent<Renderer>().material = mat1;
                                    lerprate += lerprator;
                                    active2 = Random.Range(1, 5);
                                    score += 1;
                                    hitright.Play();

                                }

                            }
                        }

                    }
                }
            }
            else
            {
                GameObject.Find("Inner Ring 2-1").GetComponent<Renderer>().material = mat2;
            }

        }
        else
        {
            GameObject.Find("Inner Ring 2-1").GetComponent<Renderer>().material = mat1;
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Ring 2-1")
                        {
                            lerp = 1f;
                            lerp2 = 1f;
                        }
                    }
                }
                if (Input.touchCount > 1)
                {
                    if (Input.GetTouch(1).phase == TouchPhase.Ended)
                    {
                        Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.transform.name == "Inner Ring 2-1")
                            {
                                lerp = 1f;
                                lerp2 = 1f;
                            }
                        }
                    }

                }

            }
        }
        if (active2 == 2)
        {
            if (lerp < 1f && lerp2 < 1f)
            {
                lerp2 += lerprate;
                GameObject.Find("Inner Ring 2-2").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp2);
                if (Input.touchCount > 0)
                {
                    if (Input.GetTouch(0).phase == TouchPhase.Ended)
                    {
                        Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.transform.name == "Inner Ring 2-2")
                            {
                                lerp2 = 0f;
                                GameObject.Find("Inner Ring 2-2").GetComponent<Renderer>().material = mat1;
                                lerprate += lerprator;
                                active2 = Random.Range(1, 5);
                                score += 1;
                                hitright.Play();

                            }

                        }
                    }
                    if (Input.touchCount > 1)
                    {
                        if (Input.GetTouch(1).phase == TouchPhase.Ended)
                        {
                            Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                            RaycastHit hit;
                            if (Physics.Raycast(ray, out hit))
                            {
                                if (hit.transform.name == "Inner Ring 2-2")
                                {
                                    lerp2 = 0f;
                                    GameObject.Find("Inner Ring 2-2").GetComponent<Renderer>().material = mat1;
                                    lerprate += lerprator;
                                    active2 = Random.Range(1, 5);
                                    score += 1;
                                    hitright.Play();

                                }

                            }
                        }

                    }
                }
            }
            else
            {
                GameObject.Find("Inner Ring 2-2").GetComponent<Renderer>().material = mat2;
            }

        }
        else
        {
            GameObject.Find("Inner Ring 2-2").GetComponent<Renderer>().material = mat1;
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Ring 2-2")
                        {
                            lerp = 1f;
                            lerp2 = 1f;
                        }
                    }
                }
                if (Input.touchCount > 1)
                {
                    if (Input.GetTouch(1).phase == TouchPhase.Ended)
                    {
                        Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.transform.name == "Inner Ring 2-2")
                            {
                                lerp = 1f;
                                lerp2 = 1f;
                            }
                        }
                    }

                }

            }
        }
        if (active2 == 3)
        {
            if (lerp < 1f && lerp2 < 1f)
            {
                lerp2 += lerprate;
                GameObject.Find("Inner Ring 2-3").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp2);
                if (Input.touchCount > 0)
                {
                    if (Input.GetTouch(0).phase == TouchPhase.Ended)
                    {
                        Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.transform.name == "Inner Ring 2-3")
                            {
                                lerp2 = 0f;
                                GameObject.Find("Inner Ring 2-3").GetComponent<Renderer>().material = mat1;
                                lerprate += lerprator;
                                active2 = Random.Range(1, 5);
                                score += 1;
                                hitright.Play();

                            }

                        }
                    }
                    if (Input.touchCount > 1)
                    {
                        if (Input.GetTouch(1).phase == TouchPhase.Ended)
                        {
                            Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                            RaycastHit hit;
                            if (Physics.Raycast(ray, out hit))
                            {
                                if (hit.transform.name == "Inner Ring 2-3")
                                {
                                    lerp2 = 0f;
                                    GameObject.Find("Inner Ring 2-3").GetComponent<Renderer>().material = mat1;
                                    lerprate += lerprator;
                                    active2 = Random.Range(1, 5);
                                    score += 1;
                                    hitright.Play();

                                }

                            }
                        }

                    }
                }
            }
            else
            {
                GameObject.Find("Inner Ring 2-3").GetComponent<Renderer>().material = mat2;
            }

        }
        else
        {
            GameObject.Find("Inner Ring 2-3").GetComponent<Renderer>().material = mat1;
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        if (hit.transform.name == "Inner Ring 2-3")
                        {
                            lerp = 1f;
                            lerp2 = 1f;
                        }
                    }
                }
                if (Input.touchCount > 1)
                {
                    if (Input.GetTouch(1).phase == TouchPhase.Ended)
                    {
                        Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.transform.name == "Inner Ring 2-3")
                            {
                                lerp = 1f;
                                lerp2 = 1f;
                            }
                        }
                    }

                }

            }
            if (active2 == 4)
            {
                if (lerp < 1f && lerp2 < 1f)
                {
                    lerp2 += lerprate;
                    GameObject.Find("Inner Ring 2-4").GetComponent<Renderer>().material.Lerp(mat1, mat2, lerp2);
                    if (Input.touchCount > 0)
                    {
                        if (Input.GetTouch(0).phase == TouchPhase.Ended)
                        {
                            Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                            RaycastHit hit;
                            if (Physics.Raycast(ray, out hit))
                            {
                                if (hit.transform.name == "Inner Ring 2-4")
                                {
                                    lerp2 = 0f;
                                    GameObject.Find("Inner Ring 2-4").GetComponent<Renderer>().material = mat1;
                                    lerprate += lerprator;
                                    active2 = Random.Range(1, 5);
                                    score += 1;
                                    hitright.Play();

                                }

                            }
                        }
                        if (Input.touchCount > 1)
                        {
                            if (Input.GetTouch(1).phase == TouchPhase.Ended)
                            {
                                Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                                RaycastHit hit;
                                if (Physics.Raycast(ray, out hit))
                                {
                                    if (hit.transform.name == "Inner Ring 2-4")
                                    {
                                        lerp2 = 0f;
                                        GameObject.Find("Inner Ring 2-4").GetComponent<Renderer>().material = mat1;
                                        lerprate += lerprator;
                                        active2 = Random.Range(1, 5);
                                        score += 1;
                                        hitright.Play();

                                    }

                                }
                            }

                        }
                    }
                }
                else
                {
                    GameObject.Find("Inner Ring 2-4").GetComponent<Renderer>().material = mat2;
                }

            }
            else
            {
                GameObject.Find("Inner Ring 2-4").GetComponent<Renderer>().material = mat1;
                if (Input.touchCount > 0)
                {
                    if (Input.GetTouch(0).phase == TouchPhase.Ended)
                    {
                        Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.transform.name == "Inner Ring 2-4")
                            {
                                lerp = 1f;
                                lerp2 = 1f;
                            }
                        }
                    }
                    if (Input.touchCount > 1)
                    {
                        if (Input.GetTouch(1).phase == TouchPhase.Ended)
                        {
                            Ray ray = cam.ScreenPointToRay(Input.GetTouch(1).position);
                            RaycastHit hit;
                            if (Physics.Raycast(ray, out hit))
                            {
                                if (hit.transform.name == "Inner Ring 2-4")
                                {
                                    lerp = 1f;
                                    lerp2 = 1f;
                                }
                            }
                        }

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
