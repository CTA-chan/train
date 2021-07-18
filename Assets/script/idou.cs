using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class idou : MonoBehaviour{
    
    public float maxY;//移動制限
    public float minY;
    public float maxX;
    public float minX;
    
    public float moveForceMultiplier;  //追従度
    public float moveSpeed;     //移動速度

    private Rigidbody2D rb;
    public static float sayu;
    public static float zyou;
    
    public static int HP;//HP
    public static bool tsu;
    
    public Text HPtext;

    public static bool speed;
    float speedtime = 10f;

    public static int scor;
    public Text ScoreText;
    
    public GameObject paricle;

    // Start is called before the first frame update
    void Start(){
        paricle.gameObject.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
        HP = 3;
        tsu = false;
    }

    // Update is called once per frame
    void Update(){
        if(speed == true){
            speedtime -= Time.deltaTime;
            paricle.gameObject.SetActive(true);
        }
        if(speedtime <= 0){
            moveSpeed = 5;
            speed = false;
            paricle.gameObject.SetActive(false);
            speedtime = 10f;
        }
        ScoreText.text = "コイン "+scor;
        
        HPtext.text = "体力 "+HP;
        if(HP <= 0){
            tsu = true;
        }
        Vector2 playerPos = transform.position;
        //Y軸の移動制限
        if(maxY < playerPos.y){
            playerPos.y = maxY;
        }else{
            if (minY > playerPos.y){
                playerPos.y = minY;
            }
        }
        //X軸の移動制限
        if(maxX < playerPos.x){
            playerPos.x = maxX;
        }else{
            if (minX > playerPos.x){
                playerPos.x = minX;
            }
        }
        transform.position = playerPos;
       
        Vector2 moveVector = Vector2.zero;
        
        sayu =  Input.GetAxis("Horizontal") ;
        zyou =  Input.GetAxis("Vertical") ;
        
        moveVector.x = moveSpeed * sayu;
        moveVector.y = moveSpeed * zyou;
        
        Vector2 force = new Vector2 (sayu, zyou);
        if (rb.velocity.magnitude < 2.0f) {//2以下ならば加速してヨシ
        rb.AddForce (force); // 力を加える
        }
        rb.AddForce(moveForceMultiplier * (moveVector - rb.velocity));
        }
    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.tag == "dolly"){
            HP -= 1;
            if(HP == 0){
                    claer.title = "一敗塗地";
                    paricle.gameObject.SetActive(false);
                    Debug.Log("BBBB");
                }
        }
        if(other.gameObject.tag == "speed"){
            speed = true;
            moveSpeed += 3; 
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "kaihuku"){
            if(HP < 3){
                HP += 1; 
            }
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "coin"){
            scor += 10;
            Destroy(other.gameObject);
            }
        }
    }