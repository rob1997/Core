using System;
using System.Text.RegularExpressions;
using UnityEngine;

namespace Core.Utils
{
    public static class Utils
    {
        public static T[] GetEnumValues<T>() where T : struct 
        {
            if (!typeof(T).IsEnum) 
            {
                Debug.LogError($"Argument Error, Type Mismatch ; {typeof(T)} must be of Type Enum");
            
                throw new ArgumentException();
            }
        
            return (T[])Enum.GetValues(typeof(T));
        }
        
        public static string GetDisplayName(string name)
        {
            string displayName = Regex.Replace($"{name}", "(\\B[A-Z])", " $1");

            //make first char upper case
            return string.Concat(displayName[0].ToString().ToUpper(), displayName.Substring(1));
        }
    }
}
