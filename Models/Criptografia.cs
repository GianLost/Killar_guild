using System.Security.Cryptography;
using System.Text;

// usando MD5 Hash para "Criptografar" senha do usuário
 
namespace Killar_Guild.Models
{
    public class Criptografia
    {
        public static string TextoCriptografado(string senha)
        {
            MD5 MD5Hasher = MD5.Create();

            byte[] By = Encoding.Default.GetBytes(senha);
            byte[] bytesCriptografado = MD5Hasher.ComputeHash(By);

            StringBuilder SB = new StringBuilder();

            foreach (byte b in bytesCriptografado)
            {
                string DebugB = b.ToString("x2");
                SB.Append (DebugB);
            }

            return SB.ToString();
        }
    }
}
