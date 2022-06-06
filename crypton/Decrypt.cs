using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypton
{
    public class Decrypt
    {
        // Variaveis Globais
        private const string AlphabeticVector = "ABCDEFGHIJKLMNOPQRSTUVWXYZÀÁÂÃÇÈÉÊÌÍÒÓÔÕÙÚÜ";
        private string Key = "";
        private string Message = "";
        private string EncryptedKey = "";

        private void Detach(string EncodedOutput)
        {
            // Variaveis Locais
            string inverted_encrypted_key = "";

            // Destacar: Mensagem e Chave Encriptada Invertida
            for (int w = 0; w < EncodedOutput.Length; w++)
            {
                if (w % 2 == 0)
                {
                    this.Message += EncodedOutput[w];
                }
                else
                {
                    inverted_encrypted_key += EncodedOutput[w];
                }
            }

            // Destacar: Chave Encriptada
            for (int a = inverted_encrypted_key.Length - 1; a >= 0; a--)
            {
                this.EncryptedKey += inverted_encrypted_key[a];
            }
        }

        private void DecodeKey()
        {
            // Variaveis Locais            
            int retreat;            

            // Execução            
            for (int w = 0; w < this.EncryptedKey.Length; w++)
            {
                retreat = AlphabeticVector.IndexOf(this.EncryptedKey[w]) - AlphabeticVector.IndexOf(this.Message[w]);

                if (retreat < 0)
                {
                    retreat = AlphabeticVector.Length + retreat;
                }

                this.Key += AlphabeticVector[retreat];
            }
        }

        public string Decode(string EncodedOutput)
        {
            // Variaveis Locais
            int retreat;
            string original_data = "";

            // Execução
            this.Detach(EncodedOutput);
            this.DecodeKey();

            for (int w = 0; w < this.Message.Length; w++)
            {
                retreat = AlphabeticVector.IndexOf(this.Message[w]) - AlphabeticVector.IndexOf(this.Key[w]);

                if (retreat < 0)
                {
                    retreat = AlphabeticVector.Length + retreat;
                }

                original_data += AlphabeticVector[retreat];
            }

            return original_data;
        }
    }
}
