using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class claer : MonoBehaviour{
    
    GameObject[] goals = new GameObject[4];

    string[] TITLE = {"英雄豪傑","平平凡凡","満身創痍"};
    public static string title;

    public static bool clae;

    float time;
    bool timer;
    
    public GameObject obj;

    GameObject i;
    int R;

    public GameObject paricle;

    public Text TimeText;
    // Start is called before the first frame update
    void Start(){        

        R = Random.Range(0,3);

        obj.gameObject.SetActive(false);
        GetComponent<BoxCollider2D>().enabled = false;

        goals[0] = GameObject.Find("G1");
        goals[1] = GameObject.Find("G2");
        goals[2] = GameObject.Find("G3");
        goals[3] = GameObject.Find("G4");
        
        time = 60f;
        timer = true;
        clae = false;
    }

    // Update is called once per frame
    void Update(){
        if(idou.tsu == true){
            SceneManager.LoadScene("result");
            idou.tsu = false;
        }

        GameObject r = goals[R];

        if(timer == true){
            float s2 = time;
            s2 = Mathf.Floor(s2);
            TimeText.text = "時間 "+s2+"秒";
        }
        
        if(timer == true){
            time -= Time.deltaTime;  
        }
        if(time <= 0){
            if(timer == true){
                transform.position = r.transform.position;            
                transform.rotation = r.transform.rotation;
                obj.gameObject.SetActive(true);
                GetComponent<BoxCollider2D>().enabled = true;
            }
            timer = false;
        }
    }
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "player"){
            if(timer == false){     
                paricle.gameObject.SetActive(false);     
                    if(idou.HP == 1){
                        title = TITLE[2];
                        }else{
                            if(idou.HP == 2){
                                title = TITLE[1];
                            }else{
                                if(idou.HP == 3){
                                    title = TITLE[0];
                            }
                        }
                    }
                SceneManager.LoadScene("result");
                Debug.Log(idou.HP+"だから"+title);
                clae = true;
            }
        }
    }
}
