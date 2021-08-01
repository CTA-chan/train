using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleCreate : MonoBehaviour{
    
    // Start is called before the first frame update
    void Start(){
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update(){
        Debug.Log(idou.speed);
        if(idou.speed == false){
            this.gameObject.SetActive(false);
            }
        if(idou.speed == true){
            this.gameObject.SetActive(true);
            }
            
        }
    }
