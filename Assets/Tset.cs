using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �v�f��5�̔z�������������
        int[] array = new int[5];

        // �z��̊e�v�f�ɒl��������
        array[0] = 30;
        array[1] = 20;
        array[2] = 50;
        array[3] = 10;
        array[4] = 80;

        // �z��̊e�v�f�̒l�����Ԃɕ\��
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //�z��̊e�v�f�̒l���t���ɕ\��
        for (int r = 4; r > 0; r--)
        {
            Debug.Log(array[r]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
