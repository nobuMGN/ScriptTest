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
        for (int r = 4; r >= 0; r--)
        {
            Debug.Log(array[r]);
        }

        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();


        for (int mp = 0; mp < 11; mp++)
        {
            // �h��p�̊֐����Ăяo��
            lastboss.Magic(5);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Boss
{
        private int mp = 53;

        // Magic�֐�
        public void Magic(int damage)
        {
                if (mp >= damage)
                {
                        
                        // �c��mp�����炷
                        this.mp -= damage;
                        Debug.Log ("���@�U���������B�c��MP��"+ mp +"�B");
                }
                 else
                {
                        Debug.Log("MP������Ȃ����߁A���@�U�����g���Ȃ��B");
                }
        }

}

