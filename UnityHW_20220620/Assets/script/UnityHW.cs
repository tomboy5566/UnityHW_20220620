using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KuanLun
{
    public class UnityHW : MonoBehaviour
    {
        [SerializeField]
        private GameObject cube;
        [SerializeField]
        private SphereCollider sphere;
        [SerializeField]
        private GameObject caspsule;
        [SerializeField]
        Camera cam;
        [SerializeField]
        private Rigidbody rig;

        Color Randomcolor()
        {
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);
            Color color = new Color(r, g, b);
            return color;
        }

        public float thrust = 100f;

        private void Start()
        {
            //攝影機深度
            print($"攝影機深度為: {cam.depth}");
            //球體碰撞半徑
            print($"球體碰撞半徑為: {sphere.radius}");
            //攝影機的背景顏色指定為隨機顏色
            cam.backgroundColor = Randomcolor();
            print($"顏色: {cam.backgroundColor}");
            //膠囊體尺寸改為 3, 2, 1
            caspsule.transform.localScale = new Vector3(3, 2, 1);
        }
        private void Update()
        {
            //讓立方體看著球體旋轉
            transform.RotateAround(sphere.transform.position, Vector3.up, 20 * Time.deltaTime);
            //讓膠囊體往上產生推力
            rig.AddForce(transform.up * thrust);
        }
    }
}



