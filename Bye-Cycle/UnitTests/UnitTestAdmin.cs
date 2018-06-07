using System;
using Bye_Cycle;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTestAdmin
    {
        Administration admin;
        Date date;
        DateTime now;
        List<Date> dates;
        string defaultPath = Environment.SpecialFolder.MyDocuments.ToString();
        string exportName;
        string saveName;

        [TestInitialize]
        public void Init()
        {
            Directory.CreateDirectory(defaultPath);
            admin = new Administration();
            now = DateTime.Now;
            date = new Date();
            dates = new List<Date>();
            for (int i = 0; i < 5; i++) dates.Add(date);
            exportName = "\\testExp.Bye";
            saveName = "\\testSav.Bye";
        }

        [TestMethod]
        public void AddDatesToDate()
        {
            Assert.IsTrue(admin.Add(date));
            CollectionAssert.Contains(admin.Dates, date);
        }

        [TestMethod]
        public void AddDateToDatesCheckIfOrderedCorrectly()
        {
            Date laterDate = new Date();
            Date evenLaterDate = new Date();
            Assert.IsTrue(admin.Add(laterDate));
            Assert.IsTrue(admin.Add(evenLaterDate));
            Assert.IsTrue(admin.Add(date));
            Assert.AreEqual((int)(date.GetDate().Second), admin.Dates[0].GetDate().Second);
        }

        [TestMethod]
        public void AddDateWhileDateNull()
        {
            Assert.IsFalse(admin.Add(null));
        }

        [TestMethod]
        public void GetDateOnDateWithDateInList()
        {
            admin.Add(date);
            Assert.AreEqual(date, admin.GetDate(date.GetDate()));
        }

        [TestMethod]
        public void GetDateOnDateNotInList()
        {
            admin.Add(date);
            Assert.AreNotEqual(date, admin.GetDate(DateTime.MinValue));
        }

        [TestMethod]
        public void RemoveValideDateFromList()
        {
            admin.Add(date);
            Assert.IsTrue(admin.Remove(date));
            CollectionAssert.DoesNotContain(admin.Dates, date);
        }

        [TestMethod]
        public void RemoveInvalideDateFromList()
        {
            admin.Add(date);
            Assert.IsFalse(admin.Remove(null));
        }

        [TestMethod]
        public void RemoveDateNotInList()
        {
            Assert.IsFalse(admin.Remove(date));
        }

        [TestMethod]
        public void ExportFile()
        {
            foreach (Date date in dates) admin.Add(date);
            admin.Export(defaultPath + exportName);
            Assert.IsTrue(File.Exists(defaultPath + exportName));
        }

        [TestMethod]
        public void ImportFile()
        {
            CollectionAssert.AreNotEqual(dates, admin.Dates);
            foreach (Date date in dates) admin.Add(date);
            admin.Export(defaultPath + exportName);
            admin.Import(defaultPath + exportName);
            int i = 0;
            Assert.AreEqual(dates.Count, admin.Dates.Count);
        }
    }
}
