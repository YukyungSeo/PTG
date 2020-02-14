using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] NumberImage;
    public Sprite[] Number;

    public Sprite[] Stars;
    public Image StarUI;

    public GameObject EndPanel;

    public Image TimeBar;

    // Update is called once per frame
    void Update()
    {
        
        /*
        int temp = DataManager.Instance.score / 100;
        NumberImage[0].GetComponent<Image>().sprite = Number[temp];
        int temp2 = DataManager.Instance.score % 100;
        temp2 = temp2 / 10;
        NumberImage[1].GetComponent<Image>().sprite = Number[temp2];
        int temp3 = DataManager.Instance.score % 10;
        NumberImage[2].GetComponent<Image>().sprite = Number[temp3];
        */
       
       StarUI.sprite = Stars[DataManager.Instance.star];

        if (!DataManager.Instance.PlayerDie)
        {
            DataManager.Instance.PlayTimeCurrent -= 1 * Time.deltaTime;
            TimeBar.fillAmount = DataManager.Instance.PlayTimeCurrent / DataManager.Instance.PlayTimeMax;



            //시간 다되면 죽음
            if (DataManager.Instance.PlayTimeCurrent < 0)
            {
                DataManager.Instance.PlayerDie = true;
            }
            //별 0이면 죽음
            if(DataManager.Instance.star < 1)
            {
                DataManager.Instance.PlayerDie = true;
            }
        }

        if(DataManager.Instance.PlayerDie == true)
        {
            EndPanel.SetActive(true);
        }

    }

    public void Restart_Btu()

    {
        DataManager.Instance.score = 0;
        DataManager.Instance.PlayerDie = false;
        DataManager.Instance.PlayTimeCurrent = DataManager.Instance.PlayTimeMax;
        DataManager.Instance.star = 3;
     //   DataManager.Instance.margnetTimeCurrent = 0;
        SceneManager.LoadScene("Run");
    }
}
