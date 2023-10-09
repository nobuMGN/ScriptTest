using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] array = new int[5];

        // 配列の各要素に値を代入する
        array[0] = 30;
        array[1] = 20;
        array[2] = 50;
        array[3] = 10;
        array[4] = 80;

        // 配列の各要素の値を順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //配列の各要素の値を逆順に表示
        for (int r = 4; r >= 0; r--)
        {
            Debug.Log(array[r]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();


        for (int mp = 0; mp < 11; mp++)
        {
            // 防御用の関数を呼び出す
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

        // Magic関数
        public void Magic(int damage)
        {
                if (mp >= damage)
                {
                        
                        // 残りmpを減らす
                        this.mp -= damage;
                        Debug.Log ("魔法攻撃をした。残りMPは"+ mp +"。");
                }
                 else
                {
                        Debug.Log("MPが足りないため、魔法攻撃が使えない。");
                }
        }

}

