﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication1
{
    public static partial class StringCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<string> DeserializeJson(JToken inputObject)
        {
            IList<string> deserializedObject = new List<string>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                deserializedObject.Add(((string)iListValue));
            }
            return deserializedObject;
        }
    }
}
