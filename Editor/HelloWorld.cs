using UnityEngine;
using UnityEditor;
namespace Cutopia.HelloWorld
{
    [InitializeOnLoad]
    public class HelloWorld
    {
        static HelloWorld()
        {
            Debug.Log("Hello World!");
        }
    }
}