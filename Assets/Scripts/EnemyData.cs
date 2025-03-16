using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private int _health;
    [SerializeField] private float _speed;
    [SerializeField] private int _worth;
    [SerializeField] private GameObject _model;

    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }

    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public int Worth
    {
        get { return _worth; }
        set { _worth = value; }
    }

    public GameObject Model
    {
        get { return _model; }
        set { _model = value; }
    }
}

