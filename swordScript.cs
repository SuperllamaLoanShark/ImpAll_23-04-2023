using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordScript : MonoBehaviour
{
    float timer = 0.5f;
    void FixedUpdate()
    {
        timer -= Time.fixedDeltaTime;
        if(timer <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        spiky_AI enemy = hitinfo.GetComponent<spiky_AI>();
        if(enemy != null)
        {
            enemy.takeDamage(30);
        }
        JumpingBeanAI enemy2 = hitinfo.GetComponent<JumpingBeanAI>();
        if(enemy2 != null)
        {
            enemy2.takeDamage(110);
        }
        _lichen_Lu enemy3 = hitinfo.GetComponent<_lichen_Lu>();
        if(enemy3 != null)
        {
            enemy3.takeDamage(34);
        }
    }
}
