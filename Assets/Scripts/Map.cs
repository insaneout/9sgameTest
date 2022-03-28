using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject[] item;


    private void Awake()
    {
        int[,] usedCoor=new int[19,14];//已占用的坐标
        for(int i = 0; i < 13; i++)//随机生成砖块1
        {
            int rX = Random.Range(-9, 9);
            int rZ = Random.Range(-12, 1);
            if (usedCoor[rX + 9, rZ + 12] != 1)
            {
                CreatMap(item[0], new Vector3(rX, (float)0.4, rZ), Quaternion.identity);
                usedCoor[rX + 9, rZ + 12] = 1;
            }
            
        }
        for(int i = -9; i < 10; i++)
        {
            for(int j = -12; j < 2; j++)
            {
                if (usedCoor[i + 9, j + 12] != 1)
                {
                    CreatMap(item[1], new Vector3(i, (float)0.4, j), Quaternion.identity);
                    usedCoor[i + 9, j + 12] = 1;
                }
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void CreatMap(GameObject creatGameobject,Vector3 creatVector3,Quaternion q)
    {
        GameObject itemG = Instantiate(creatGameobject, creatVector3, q);
        itemG.transform.SetParent(gameObject.transform);
    }
}
