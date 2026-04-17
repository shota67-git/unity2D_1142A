using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject hp;
    public TextMeshProUGUI time;
    public TextMeshProUGUI show;
    public TextMeshProUGUI hpp;
    float count = 0;
    public void DecreaseHp()
    {
        hp.GetComponent<Image>().fillAmount -= 0.1f;       
    }
    public void IncreaseHp()
    {
        hp.GetComponent<Image>().fillAmount += 0.1f;
    }
    private void Update()
    {
        hpp.text = Mathf.RoundToInt(hp.GetComponent<Image>().fillAmount * 100) + "%";
        count += Time.deltaTime;
        float counttime = 10 - count;
        time.text = counttime.ToString("f1");
        if (counttime <= 0) {
            Time.timeScale = 0f;
            if (hp.GetComponent<Image>().fillAmount >= 0.55)
            {
                show.text = "恭喜過關！要往下一關請點滑鼠左鍵，回選單按ESC";
                if (Input.GetMouseButtonDown(0)) {
                    SceneManager.LoadScene("ch6");
                }
            }
            else 
            {
                show.text = "失敗！要重新挑戰請點滑鼠左鍵，回選單按ESC";
                if (Input.GetMouseButtonDown(0))
                {
                    Time.timeScale = 1f;
                    SceneManager.LoadScene("ch5");
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Time.timeScale = 1f;
            SceneManager.LoadScene("NinjaCat");
        }
    }
}
