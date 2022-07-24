using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecelerateTurretBehavior : SkillsTurretBehavior
{
    [SerializeField, Range(0, 1f)]
    public float _DecelerateRatio = 0.5f;//���ٱ���

    [SerializeField]
    private float _DecelerateTime = 1f;//����ʱ��

    public float DecelerateRatio
    {
        get
        {
            return _DecelerateRatio;
        }
        set
        {
            _DecelerateRatio = value;
        }
    }

    public float DecelerateTime
    {
        get
        {
            return _DecelerateTime;
        }
        set
        {
            _DecelerateTime = value;
        }
    }


}
