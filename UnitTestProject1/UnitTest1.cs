using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Login;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            String usr = "userAdmn";
            cambioContraseña cambio = new cambioContraseña();
            
            bool result = cambio.verificaUsuario(usr);

            Assert.AreEqual(true, result);
                
        }
    }
}
