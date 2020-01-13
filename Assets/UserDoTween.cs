using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UserDoTween : MonoBehaviour
{
    public Transform Trans;

    void Start()
    {
        Move();
    }

    void Move()
    {

        //Trans.DOKill();        //停止动画
        //Trans.DOPause();        //暂停
        //Trans.DOPlay();
        //Trans.DOPlayBackwards();
        //Trans.DOPlayForward();
        //Trans.DOMove();

        Vector3 ToPos = new Vector3(800f,300f,0);
        float delayTime = 1f;
        float needTime = 5f;
        //SetDelay:延迟;  SetEase:动画的方式;  OnComplete:动画完成后的回调
        Trans.DOLocalMove(ToPos, needTime).SetDelay(delayTime).SetEase(Ease.Linear).OnComplete(delegate() 
        {
            Debug.LogError("动画完成:回调");
        });


        Vector3 RotateV3 = new Vector3(0f, 0f, 100f);
        Trans.DOLocalRotate(RotateV3, needTime);
    }
}
