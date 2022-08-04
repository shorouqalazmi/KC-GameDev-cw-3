using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shrouq : MonoBehaviour
{
    string heroname ="shorouq"; 
   int heropower =30;
    string villainname ="shahad";
    int villianpower =20;
    float playerspeed =2.5f;
    float newspeed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        comparespeed();
        if(heropower > villianpower)
        {
            print("heropower is bigger");
        }
        else if (heropower == villianpower)
        {
            print("they are equal");
        }
        else if (heropower < villianpower)
        {
            print("villianpower is bigger");
        }
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetSpeed(float newspeed)
    {
        print("old playerspeed is" + playerspeed);
        playerspeed = newspeed;
        print("new playerspeed is" + playerspeed);

    }
    void comparespeed()
    {
    if(playerspeed < newspeed)
    {
        print("newspeed is bigger");
    }
    else if (playerspeed > newspeed)
    {
        print("playerspeed is bigger");
    }
    else if (playerspeed == newspeed)
    {
        print("they are equal");
    }
    }
    
}
