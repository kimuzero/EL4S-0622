using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    //表示するスコア
    [SerializeField]
    Text scoreText;

    private int money;//合計
    private int addScore;//加算するスコア

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "利益:" + money;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "利益:" + money;
    }

    //加算
    void CulcScore()
    {
        addScore = 0;//食材の利益
        money += addScore;//合計に加算
        addScore = 0;//addScoreのリセット
    }
    //減少
    void DecreaseScore()
    {
        addScore = 0;//食材の利益
        money -= addScore;//合計から減算
        addScore = 0;//addScoreのリセット
    }
}
