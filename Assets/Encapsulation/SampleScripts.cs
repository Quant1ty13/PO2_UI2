using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleNameSpace
{
    public class SampleScripts : MonoBehaviour
    {
        private string username;
        public string Username
        {
            get { return username; }
            set 
            { 
                var s = "";
                foreach (var c in value)
                {
                    if (char.IsUpper(c))
                        s += char.ToLower(c);
                    else if (char.IsLetter(c) || char.IsNumber(c))
                        s += c;
                    else
                        Debug.LogError("Username Do Not Accept Special Characters.");
                }
                username = s;
            }
        }

        private void OnGUI()
        {
            GUI.Label(new Rect(50, 100, 100, 30), username);
        }
    }
}
