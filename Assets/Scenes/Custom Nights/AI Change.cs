using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AIChange : MonoBehaviour
{
    public int[] AI;
    public TextMeshProUGUI[] HariSmellz;
    public GameObject[] BlackScreen;
    void Start()
    {
        AI = new int[12];
        setAllTo(0);
    }
    
    public void Increase(int aiNum)
    {

        if(AI[aiNum] < 20)
        {
            AI[aiNum]++;
            HariSmellz[aiNum].text = AI[aiNum].ToString();
            BlackScreen[aiNum].SetActive(false);
        }
    }
    public void Decrease(int aiNum)
    {
        if (AI[aiNum] > 0)
        {
            AI[aiNum]--;
            HariSmellz[aiNum].text = AI[aiNum].ToString();
        }
        if (AI[aiNum] <= 0)
        {
            BlackScreen[aiNum].SetActive(true);
        }

    }

    public void setAllTo(int value)
    {
        for (int i = 0; i <= 11; i++)
        {
            AI[i] = value;
            HariSmellz[i].text = AI[i].ToString();
            if (value == 0) 
            {
                BlackScreen[i].SetActive(true);
            } else {
                BlackScreen[i].SetActive(false);
            }
            
        }
    }
}
