﻿using System.Collections;
using NUnit.Framework;

namespace MainProject
{
    public class TestDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData("777", "testdesc1");
                //yield return new TestCaseData("8055", "testdesc2");

            }
        }
    }
}
