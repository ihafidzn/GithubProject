using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject Target =null;
    public GameObject T = null;
    public float speed = 1.5f;
    public int index;


    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
        T = GameObject.FindGameObjectWithTag("Target");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() 
    { 
        this.transform.LookAt(Target.transform);
        float car_Move = Mathf.Abs(Vector3.Distance(this.transform.position, T.transform.position) * speed);
        this.transform.position = Vector3.MoveTowards(this.transform.position, T.transform.position, car_Move * Time.deltaTime);
    }
}
