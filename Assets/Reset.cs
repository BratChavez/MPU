using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Out")
        {
            SceneManager.LoadScene(0);
        }
    }
}
