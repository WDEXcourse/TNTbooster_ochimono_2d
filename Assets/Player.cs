using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))//�L�[�R�[�hD�������ꂽ��
        {
            //transform.position  +=  new Vector3(0.2f, 0, 0);//Player�̍��W���A���̍��W����AX������+0.2����
            transform.position.x    +=  0.2;
        }
        if(Input.GetKey(KeyCode.A))
        {
            //transform.position += new Vector3(-0.2f, 0, 0);
            transform.position.x    +=  -0.2;
        }
    }
}
