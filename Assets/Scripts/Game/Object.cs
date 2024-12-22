using System;
using System.Transactions;
using UnityEngine;

public class Object : MonoBehaviour
{

    public ScoreManagment scoreM;
    void Start()
    {
        
    }


    void Update()
    {

    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Death"))
        {
            scoreM.ball--;
            Destroy(gameObject);

        }
    }
}
