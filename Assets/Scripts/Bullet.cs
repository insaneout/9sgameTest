using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    AudioSource AudioS;
    //public Text scoreText;
    //public int Score;
    // Start is called before the first frame update
    void Start()
    {
        AudioS = GetComponent<AudioSource>();
        AudioS.Play();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("brick2") )
        {
            Destroy(other.gameObject);
            PlayerManager.InstancePlayer.score++;
            //Score = Score + 1;
            //scoreText.text = "Score£º" + Score;
        }
        
        Destroy(gameObject);
    }
}
