using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatiN.Core;
using NUnit.Framework;

namespace DingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var browser = new IE("http://qaworks.com/contact.aspx"))
            {
                browser.TextField(Find.ByName("ctl00$MainContent$NameBox")).TypeText("j.Bloggs");
                browser.TextField(Find.ByName("ctl00$MainContent$EmailBox")).TypeText("j.Bloggs@qaworks.com");
                browser.TextField(Find.ByName("ctl00$MainContent$MessageBox")).TypeText("please contact me I want to find out more");

                browser.WaitForComplete(4000);

                browser.Button(Find.ByName("ctl00$MainContent$SendButton")).Click();
            }


            using (var browser = new IE("http://careers.qaworks.com/"))
            {
                browser.TextField(Find.ByClass("formInput")).TypeText("SDET");

                browser.WaitForComplete(4000);

                browser.Button(Find.ByName("Working...")).Click();

                browser.WaitForComplete(4000);

                NUnit.Framework.Assert.IsTrue(browser.ContainsText("SDET"));
            }

        }
    }
}
