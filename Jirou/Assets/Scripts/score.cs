using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    //�\������X�R�A
    [SerializeField]
    Text scoreText;

    private int money;//���v
    private int addScore;//���Z����X�R�A

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "���v:" + money;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "���v:" + money;
    }

    //���Z
    void CulcScore()
    {
        addScore = 0;//�H�ނ̗��v
        money += addScore;//���v�ɉ��Z
        addScore = 0;//addScore�̃��Z�b�g
    }
    //����
    void DecreaseScore()
    {
        addScore = 0;//�H�ނ̗��v
        money -= addScore;//���v���猸�Z
        addScore = 0;//addScore�̃��Z�b�g
    }
}
