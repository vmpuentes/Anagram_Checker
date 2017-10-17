using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;
using System;


namespace AnagramChecker.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void CheckAnagram_ReturnTrueIfAnagrams_Bool()
    {
      //Arrange
     List<string> testList= new List<string>{""};
     AnagramChecker testDetector = new AnagramChecker("", testList);
     bool expected = true;
     //Act
     bool = testDetector.CheckUserAnagramList();
     //Assert
     Assert.AreEqual(expected,actual);
   }

   [TestMethod]
   public void CheckAnagram_ReturnTrueIfAllAnagrams_Bool()
   {
     //Arrange
     List<string> testList= new List<string>{""};
     AnagramDetector testDetector = new AnagramDetector("", testList);
     bool expected = true;
     //Act
     bool actual = testDetector.CheckAnagramList();
     //Assert
     Assert.AreEqual(expected,actual);
   }
   [TestMethod]
   public void CheckAnagram_ReturnAllAnagramsThatMatch_List()
   {
     //Arrange
     List<string> testList= new List<string>{""};
     AnagramDetector testDetector = new AnagramDetector("", testList);
     List<string> expected= new List<string>{""};
     //Act
     List<string> actual = testDetector.GetMatchingAnagrams();

     foreach(string s in actual)
     {
         Console.WriteLine("Matching word: " + s);
     }

     //Assert
     CollectionAssert.AreEqual(expected,actual);
   }
 }
