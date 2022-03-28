using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public Text scoreText;
    public Text lifeText;
    //属性值
    public int lifeVal;
    public int score;

    //单例化
    private static PlayerManager instancePlayer;

    public static PlayerManager InstancePlayer { get => instancePlayer; set => instancePlayer = value; }

    private void Awake()
    {
        instancePlayer = this;
    }

   

    // Update is called once per frame
    void Update()
    {
        if (lifeVal <= 0)
        {
            SceneManager.LoadScene(2);
        }
        scoreText.text = "Score：" + score;
        lifeText.text = "Life：" + lifeVal;
    }
}
