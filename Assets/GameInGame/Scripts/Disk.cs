using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disk : MonoBehaviour {

    public int hp;

    public void LoseHp()
    {
        hp--;
    }

    public bool IsBroken()
    {
        if (hp <= 0)
            return true;
        else return false;
    }
}
