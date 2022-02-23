using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS;

namespace RPS.Tests 
{
  [TestClass]
  public class ThrowHands
  {
    [TestMethod]
    public void PlayerConstructor_CreatesInstanceOfPlayer_Player()
    {
      Player player1 = new Player("test");
      Assert.AreEqual(typeof(Player), player1.GetType());
    }

    [TestMethod]
    public void PlayerConstructor_CreatesInstanceOfPlayer_String()
    {
      Player player1 = new Player("test");
      Assert.AreEqual("test", player1.Hand);
    }
  }
}