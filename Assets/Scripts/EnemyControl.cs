using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyControl : MonoBehaviour
{
    public GameObject bullet1;
    public GameObject bullet2;

    private int lifeVal = 20;
    public float Speed = 10;
    private float timeVal = 2;
    private float timeVal1 = 2;

    float h, v;

   

    // Update is called once per frame
    void Update()
    {
        if (lifeVal == 0)//enemy死亡游戏胜利
        {
            SceneManager.LoadScene(3);
            //Debug.Log("game over");
            //Destroy(gameObject);
        }
        if (timeVal >= 2)//定时发射子弹，E1可被摧毁
        {
            for(int i=0; i < 4; i++)
            {
                Quaternion rot = Quaternion.Euler(0, i * 90, 0);
                Instantiate(bullet1, transform.position, rot);
            }
            for (int i = 0; i < 4; i++)
            {
                Quaternion rot = Quaternion.Euler(0, i * 90-45, 0);
                Instantiate(bullet2, transform.position, rot);
            }
            timeVal = 0;
        }
        timeVal += Time.deltaTime;
    }

    private void FixedUpdate()
    {
        if (timeVal1 >= 2)//定时随机移动
        {
            int r = Random.Range(0, 4);
            switch (r)
            {
                case 0:
                    h = 1;
                    v = 1;
                    break;
                case 1:
                    h = 1;
                    v = -1;
                    break;
                case 2:
                    h = -1;
                    v = 1;
                    break;
                case 3:
                    h = -1;
                    v = -1;
                    break;
            }
            timeVal1 = 0;
        }
        timeVal1 += Time.deltaTime;
        transform.Translate(h * Speed / 200 * Vector3.right);
        transform.Translate(v * Speed / 200 * Vector3.forward);

    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            lifeVal--;
            //Debug.Log("game over" + lifeVal);
        }
    }
}
