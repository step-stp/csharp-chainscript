﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stratumn.Chainscript.ChainscriptTest.TestCases
{
    public interface ITestCase
    {
        /// <summary>
        /// Test case id
        /// </summary>
        /// <returns></returns>
        String GetId();
        /// <summary>
        /// Generate encoded segment bytes.
        /// </summary>
        /// <returns></returns>
        String Generate();

        /// <summary>
        ///  Validate encoded segment bytes.
        /// </summary>
        /// <param name="encodedSegment"></param>
        void Validate(String encodedSegment);

    }
}
