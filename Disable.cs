using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disable : MonoBehaviour
{
    GameObject player;
    //public GameObject TheronText;
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        //impy_move move = player.GetComponent<impy_move>();
    }
    void OnEnable()
    {
        GameObject player = GameObject.FindWithTag("Player"); 
 
        player.GetComponent<impy_move>().enabled = false;
        player.GetComponent<Impy_attacks>().enabled = false;
        //GameObject.Find("Imp").GetComponent(impy_move).enabled = false;

        //impy_move.enabled = false;
    }
    void OnDisable()
    {
        GameObject player = GameObject.FindWithTag("Player"); 
 
        player.GetComponent<impy_move>().enabled = true;
        player.GetComponent<Impy_attacks>().enabled = true;
        //GameObject.Find("imp").GetComponent(impy_move).enabled = true;

        //impy_move.enabled = true;
    }
}
