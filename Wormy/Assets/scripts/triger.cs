using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class triger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
     if(other.gameObject.tag == "Player")
        {
            // Destroy(gameObject);//stavrno ga izbrisati, unistoto
            //GetComponent<MeshRenderer>().enabled = false;//postane nevidljiv
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
        }   
    }
}
