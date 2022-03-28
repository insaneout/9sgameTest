using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;

    public float FireRate=2.0f;
    public float bulletS;
    private float t_nextFire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t_nextFire = t_nextFire + Time.fixedDeltaTime;
        if (Input.GetMouseButton(0) && t_nextFire > FireRate)
        {
            Vector3 mousePosition = Input.mousePosition;
            //mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            //屏幕坐标转换为世界坐标
            mousePosition.z = mousePosition.y;
            mousePosition.y = 0;
            //Debug.Log("m." + mousePosition);
            
            Vector3 firePosition = transform.position;
            firePosition = Camera.main.WorldToScreenPoint(firePosition);
            firePosition.z = firePosition.y;
            firePosition.y = 0;
            //Debug.Log("f." + firePosition);
            //mousePosition.y= firePosition.y;
            GameObject m_bullet = Instantiate(bullet, transform.position, Quaternion.identity);
            m_bullet.GetComponent<Rigidbody>().velocity = ((mousePosition - firePosition).normalized) * bulletS;
            //Debug.Log(mousePosition - firePosition);
            t_nextFire = 0;
        }
    }
    private void FixedUpdate()
    {
        
    }
}
