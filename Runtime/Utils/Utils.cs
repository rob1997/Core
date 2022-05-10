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
        
        public static Array GetEnumValues(Type type)
        {
            if (!type.IsEnum) 
            {
                throw new ArgumentException("GetValues<T> can only be called for types derived from System.Enum", nameof(type));
            }
        
            return Enum.GetValues(type);
        }
        
        public static string GetDisplayName(string name)
        {
            string displayName = Regex.Replace($"{name}", "(\\B[A-Z])", " $1");

            //make first char upper case
            return string.Concat(displayName[0].ToString().ToUpper(), displayName.Substring(1));
        }
        
        public static T Cast<T>(object obj)
        {
            try
            {
                return (T) obj;
            }
        
            catch (Exception e)
            {
                Debug.LogError($"Error Trying to Cast From {obj.GetType()} To {typeof(T)} {e}");
            
                throw;
            }
        }
    }
}
