using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Operation : MonoBehaviour
{
    public InputField num1;
    public InputField num2;
    public float n1,n2;
    public static float ans=0.0f;
    public void getNum1()
    {
        n1=float.Parse(num1.text);
    }
    public void getNum2()
    {
        n2=float.Parse(num2.text);
    }
    public void onAdd()
    {
        ans=n1+n2;
    }
    public void onMin()
    {
      ans=n1-n2;
    }
    public void onMul()
    {
      ans=n1*n2;
    }
    public void onDiv()
    {
      ans=n1/n2;
    }

}
