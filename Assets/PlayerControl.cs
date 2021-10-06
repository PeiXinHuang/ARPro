using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Animator anim;    //定义一个Animator对象
    void Start()
    {
        anim = GetComponent<Animator>(); //取得Animator对象
    }
    void Update()
    {  //每帧执行的函数
    }
    void FixedUpdate()
    { //固定的时间间隔执行的函数，与Update()不同
      //隔多少时间，可在Edit->ProjectSetting->time中查看   
        if (Input.GetButtonDown("Fire1"))
        {//开火是什么键，可在edit->
         // project settings->input中查看
            anim.SetBool("bDance", false); //把bDance变量设为false
            anim.SetBool("bAttack", true); //把bAttack变量设为true
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            anim.SetBool("bAttack", false);
            anim.SetBool("bDance", true);
        }
    }

}
