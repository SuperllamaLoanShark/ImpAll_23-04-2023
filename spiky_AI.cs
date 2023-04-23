using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiky_AI : MonoBehaviour
{
    public int health = 100;
    //public GameObject _deathEffect;
    [SerializeField] float Speed = 1.7f;
    Rigidbody2D SpikyBod; 
    public Collider2D headSpike;
    public Collider2D facesensor;
    public GameObject _slimeItself;
    public Transform _respawn;
    public GameObject Player;
    public Transform TPlayer;
    public Animator SlimyAnim;
    public float chaseRadius = 5f;
    private bool chasing = false;
    private float RunSpeed = 5f;
    
    void Start()
    {
        
        SpikyBod = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(IsfacingRight())
        {
            SpikyBod.velocity = new Vector2(Speed, 0f);
            SlimyAnim.SetBool("_isRight", true);
        }
        else
        {
            SpikyBod.velocity = new Vector2(-Speed, 0f);
            SlimyAnim.SetBool("_isRight", false);
        }
        //if(GameObject.Find("Imp").GetComponent<impy_move>().health <= 0)
        //{
        //    Destroy(gameObject);
        //    Instantiate(_slimeItself, _respawn.position + new Vector3(0,0, -3), _respawn.rotation);
            //transform.position = _respawn.transform.position + new Vector3(0,0, -3);
        //}

        float distance = Vector2.Distance(TPlayer.position, transform.position);

        if (distance <= chaseRadius)
        {
            chasing = true;
        }
        else
        {
            chasing = false;
        }

        if (chasing)
        {
            Speed = RunSpeed;
        }
        else
        {
            Speed = 1.7f;
        }

    }
    private bool IsfacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(SpikyBod.velocity.x)), transform.localScale.y);
    }
    private void OnTriggerEnter2D(Collider2D headSpike)
    {
        impy_move enemy = headSpike.GetComponent<impy_move>();
        if(enemy != null)
        {
            Debug.Log("Hit!");
            enemy.takeDamage(100);
        }
    }
    public void takeDamage( int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}