using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CondicaoVitoria : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene(5);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.name == "c1")
        {
            SceneManager.LoadScene(4);
        }
        if (other.gameObject.name == "c2")
        {
            SceneManager.LoadScene(5);
        }
    }
}
