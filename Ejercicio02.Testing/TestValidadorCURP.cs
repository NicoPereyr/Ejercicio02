using Ejercicio02.Entidades;

namespace Ejercicio02.Testing
{

        [TestClass]
        public class TestValidadorCURP
        {
            [TestMethod]
            public void ValidarCURP_Valida_DeberiaRetornarTrue()
            {
                // Arrange
                string curpValida = "NICO850412HDFRNN09";

                // Act
                bool resultado = ValidadorCURP.Validar(curpValida);

                // Assert
                Assert.IsTrue(resultado, "La CURP válida debería retornar true.");
            }
        }
    }
