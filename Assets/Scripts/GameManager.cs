using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject playArea;
    [SerializeField] private GameObject fishkaMainPrb;
    [SerializeField] private Sprite[] fishkaFigureSpts;
    [SerializeField] private Color[] fishkaColors;

    private GameObject tmpFishkaObj;
    private Vector2 tmpPoint;

    private string[] fishkaNumbersTxt = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    private int tmpNum;
    private int tmpNum2;
    void Start()
    {
        tmpNum2 = Random.Range(0, 5);

        for (int i=1;i<=7;i++)
        {
            for(int j=1;j<=7;j++)
            {
                tmpFishkaObj = Instantiate(fishkaMainPrb, playArea.transform);
                tmpPoint = new Vector2((i - 4) * 0.15f, (j - 4) * 0.15f);
                tmpFishkaObj.transform.localPosition = tmpPoint;
                tmpNum = Random.Range(0, 5);
                Debug.Log(tmpNum);
                tmpFishkaObj.GetComponent<SpriteRenderer>().color = fishkaColors[tmpNum];

                tmpNum = Random.Range(0, 5);
                //tmpFishkaObj.GetComponentInChildren<SpriteRenderer>().sprite = fishkaFigureSpts[tmpNum];
                tmpFishkaObj.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = fishkaFigureSpts[tmpNum];

                tmpNum = Random.Range(0, 5);
                tmpFishkaObj.transform.GetChild(1).GetComponent<TextMeshPro>().SetText(fishkaNumbersTxt[tmpNum + tmpNum2]);
            }
        }
        
    }

    
}
