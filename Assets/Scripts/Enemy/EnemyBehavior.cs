using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private Animator _Anim;
    private enum AnimState { Idle, Down, Up, Left, Right }

    // Start is called before the first frame update

    public void Awake()
    {
        _Anim = GetComponent<Animator>();
        _LastPoint = transform.position;
        _RadiusC.enabled = false;
    }

    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        UpdateAnim();
    }

    private Vector3 _LastPoint;
    //  ���¶���
    private void UpdateAnim()
    {
        if (_Anim == null) { return; }
        AnimState state = AnimState.Idle;

        if (transform.position == _LastPoint) { state = AnimState.Idle; }
        else
        {
            if (transform.position.x < _LastPoint.x) { state = AnimState.Left; }
            else if (transform.position.x > _LastPoint.x) { state = AnimState.Right; }
            else if (transform.position.x == _LastPoint.x)
            {
                if (transform.position.y < _LastPoint.y) { state = AnimState.Down; }
                else { state = AnimState.Up; }
            }
        }

        _Anim.SetInteger("State", (int)state);
        _LastPoint = transform.position;
    }

    //  ��ȡ��Χ�뾶
    [SerializeField]
    private CircleCollider2D _RadiusC = null;
    public float GetRadius()
    {
        return _RadiusC.radius * _RadiusC.transform.lossyScale.x;
    }
}
