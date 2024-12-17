using System.Runtime.InteropServices;
using Mono.Cecil.Cil;
using UnityEngine;
namespace Assignment27
{


    public class Bayt : MonoBehaviour
    {

        void Start()
        {
            int a = 2;
            int b = 5;
            batata(a);
            Debug.Log(a);
            
            baed(ref b);

            Debug.Log(b);

            int c;
            homos(out c);
            Debug.Log(c);

        }

        public void batata(int number)
        {
            number += 10;
            
        }
       
        public void baed(ref int number)
        {
            number = number + 10;
   
        }
        public void homos(out int number)
        {
            number = 10;

        }


    }
}