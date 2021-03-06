﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EfConnectionStringHelperFacts.cs" company="Catel development team">
//   Copyright (c) 2008 - 2013 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Catel.Test.Extensions.EntityFramework5.Data
{
    using System;
    using Catel.Data;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Test.EntityFramework5.ObjectContextTest;

    public class EfConnectionStringHelperFacts
    {
        [TestClass]
        public class TheGetEntityFrameworkConnectionStringMethod
        {
            [TestMethod]
            public void ThrowsArgumentNullExceptionForNullContextType()
            {
                ExceptionTester.CallMethodAndExpectException<ArgumentNullException>(() => EfConnectionStringHelper.GetEntityFrameworkConnectionString(null, TestConnectionStrings.ObjectContextDefault));
            }

            [TestMethod]
            public void ThrowsArgumentExceptionForNullAndEmptyConnectionString()
            {
                ExceptionTester.CallMethodAndExpectException<ArgumentException>(() => EfConnectionStringHelper.GetEntityFrameworkConnectionString(typeof(TestObjectContextContainer), null));
                ExceptionTester.CallMethodAndExpectException<ArgumentException>(() => EfConnectionStringHelper.GetEntityFrameworkConnectionString(typeof(TestObjectContextContainer), string.Empty));
            }

            [TestMethod]
            public void ReturnsCorrectValueForTestObjectContext()
            {
                string expectedValue = string.Format("metadata=res://*/TestObjectContext.csdl|res://*/TestObjectContext.ssdl|res://*/TestObjectContext.msl;provider=System.Data.SqlClient;provider connection string=\"{0}\"", TestConnectionStrings.ObjectContextDefault);

                var connectionString = EfConnectionStringHelper.GetEntityFrameworkConnectionString(typeof(TestObjectContextContainer), TestConnectionStrings.ObjectContextDefault);

                Assert.AreEqual(expectedValue, connectionString);
            }
        }
    }
}