using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuestItem : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down*Time.deltaTime*60); //giro no eixo Y
        transform.position += Vector3.up * Mathf.Sin(Time.time) * 0.004f; //sobe e desce 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            other.gameObject.SendMessage("ItemCollected");
            Destroy(gameObject, .1f);
        }
    }
}
