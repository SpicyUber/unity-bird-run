using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject Player;
    private int _score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Player.transform.Translate(new Vector3(-Player.transform.position.x,0,0));
        Debug.Log("Player Score: "+_score);
    }
}
