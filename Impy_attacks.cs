using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Impy_attacks : MonoBehaviour
{
    //public bool attB = false;
    public Transform Fire1;
    public GameObject Fireball;
    public GameObject Shield;
    public GameObject Sword;
    public int weapon = 1;
    public GameObject FireImage;
    public GameObject shieldImage;
    public GameObject swordImage;
    void Start()
    {
        weapon =1;
    }
    void Update()
    {
        if (Input.GetButtonDown("weaponSelec"))
        {
            weapon = weapon + 1;
            if (weapon == 4)
            {
                weapon = 1;
            }
            if(weapon == 1)
            {
                FireImage.SetActive(true);
                swordImage.SetActive(false);
            }
            if(weapon == 2)
            {
                FireImage.SetActive(false);
                shieldImage.SetActive(true);
            }
            if(weapon == 3)
            {
                shieldImage.SetActive(false);
                swordImage.SetActive(true);
            }
        }
        if (Input.GetButtonDown("Fire1") && weapon == 2)
        {
            Attcak2();
        }
        if (Input.GetButtonDown("Fire1") && weapon == 3)
        {
            Attcak3();
        }
        if (Input.GetButtonDown("Fire1") && weapon == 1)
        {
            Attcak1();
        }
    }
    void Attcak1()
    {
        Instantiate(Fireball, Fire1.position, Fire1.rotation);
    }
    void Attcak2()
    {
        Instantiate(Shield, Fire1.position, Fire1.rotation);
    }
    void Attcak3()
    {
        Instantiate(Sword, Fire1.position, Fire1.rotation);
    }
}
