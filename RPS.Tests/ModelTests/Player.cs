using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS;

namespace RPS.Tests 
{
  [TestClass]
  public class Player
  {
    [TestMethod]
    public void PlayerConstructor_CreatesInstanceOfPlayer_Player()
    {
      Player player1 = new Player();
      Assert.AreEqual(typeof(Player), player1.GetType());
    }
  }
}