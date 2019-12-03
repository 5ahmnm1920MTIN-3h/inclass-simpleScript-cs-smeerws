using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public InputField ipVarA;
    public InputField ipVarB;
    public Text result;

    public void SetResult()
    {
        float a = float.Parse(ipVarA.text);
        float b = float.Parse(ipVarB.text);
        result.text = SubstractNumbers(a,b).ToString();
    }

    private float MultNumbers(float variableA, float variableB)
    {
        float result = variableA * variableB;
        return result;
    }

    private float SubstractNumbers(float variableA, float variableB)
    {
        float result = variableA - variableB;
        return result;
    }
}
