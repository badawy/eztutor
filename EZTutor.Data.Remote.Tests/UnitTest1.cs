﻿using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using EZTutor.Data.Remote.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using EZTutor.Data.Remote.Entities;

namespace EZTutor.Data.Remote.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ISession session = new Provider().GetSession();

            IList<Topics> topics = session.CreateQuery("from topics").List<Topics>();
        }
    }
}