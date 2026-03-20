using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject hp;
    public void DecreaseHp()
    {
        hp.GetComponent<Image>().fillAmount -= 0.1f;
    }
    public void IncreaseHp()
    {
        hp.GetComponent<Image>().fillAmount += 0.1f;
    }
}
