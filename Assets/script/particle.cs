using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
       GameObject PA = GameObject.Find("player"); 
       this.transform.position = PA.transform.position;
    }
}
