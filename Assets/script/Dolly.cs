using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dolly : MonoBehaviour{

    public float maxY;//移動制限
    public float minY;
    public float maxX;
    public float minX;
    
    private GameObject player;
    private GameObject dolly;
    
    Vector2 vec;
    
    bool Track;
    public static bool des;

    float time;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        player = GameObject.Find("player");
        dolly = this.gameObject;
        Track = true;
        time = Random.Range(1f,5f)+5f;
        des = false;
    }

    // Update is called once per frame
    void Update(){
       Vector2 dollyPos = transform.position;
       
         //Y軸の移動制限
        if(maxY < dollyPos.y){
            Destroy(gameObject);
            des = true;
        }else{
            if (minY > dollyPos.y){
                Destroy(gameObject);
                des = true;
            }
        }
        //X軸の移動制限
        if(maxX < dollyPos.x){
            Destroy(gameObject);
            des = true;
        }else{
            if (minX > dollyPos.x){
                Destroy(gameObject);
                des = true;
            }
        }
       if(Track == true){ 
        vec = (player.transform.position - dolly.transform.position).normalized;
        dolly.transform.rotation = Quaternion.FromToRotation(Vector3.up, vec);
        time -= Time.deltaTime;  
        if(time <= 0){
         Track = false;   
        }
       }
       if(Track == false){ 
       dolly.GetComponent<Rigidbody2D>().velocity= vec*13;
       } 
    }
    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.tag == "player"){
            Destroy(gameObject);
        }
    }
}
