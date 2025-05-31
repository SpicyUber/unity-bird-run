using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ptica : MonoBehaviour
{
    public GameObject Camera;
    public float Speed;
   private bool _gameOver = false;
    private int _score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame  

    // komanda - > nacrta se slika na ekranu -> jos neke komande -> druga slika na ekranu

    //Input Keycode.D

    void Update()
    {
        if (_gameOver) return;

            if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -30)
        {
            this.gameObject.transform.Translate(new Vector3(-30,0,0),Space.World);
        }
        if(Input.GetKeyDown(KeyCode.D) && transform.position.x < 30) {

            this.gameObject.transform.Translate(new Vector3(+30, 0, 0), Space.World);
        }

        Camera.transform.Translate(0, 0, Speed * Time.deltaTime, Space.World);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Camera.transform.position = new(0, 20.85f, -62.35f);
            this.transform.position = new(0,transform.position.y, transform.position.z);
            _score++;
            Debug.Log("SCORE: " + _score);
            Speed += 5;
        }
        else { 

            _gameOver = true;
        Debug.Log("GAME OVER!");
        }



    }

}
