using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypton
{
    public class Encrypt
    {
        // Variaveis Globais
        private const string AlphabeticVector = "ABCDEFGHIJKLMNOPQRSTUVWXYZÀÁÂÃÇÈÉÊÌÍÒÓÔÕÙÚÜ";        
        private string Key = "";
        private string Message = "";
        private string EncryptedKey = "";        

        private void KeyGenerator(string Entry)
        {
            // Variaveis Locais
            string inverted_entry = "";
            int advance;            


            // Execução
            for (int w = Entry.Length - 1; w >= 0; w--)
            {
                inverted_entry += Entry[w];
            }

            for (int a = 0; a < Entry.Length; a++)
            {
                advance = AlphabeticVector.IndexOf(Entry[a]) + AlphabeticVector.IndexOf(inverted_entry[a]);

                if (advance > AlphabeticVector.Length)
                {
                    advance -= AlphabeticVector.Length;
                }

                this.Key += AlphabeticVector[advance];
            }
        }

        private void EncodeKey()
        {
            // Variaveis Locais            
            int advance;            


            // Execução            
            for (int w = 0; w < this.Key.Length; w++)
            {
                advance = AlphabeticVector.IndexOf(this.Key[w]) + AlphabeticVector.IndexOf(this.Message[w]);

                if (advance > AlphabeticVector.Length)
                {
                    advance -= AlphabeticVector.Length;
                }

                this.EncryptedKey += AlphabeticVector[advance];
            }
        }

        private string OutputCompiler()
        {
            // Variaveis Locais
            string inverted_encrypted_key = "";
            string result = "";

            // Execução
            for (int w = this.EncryptedKey.Length - 1; w >= 0; w--)
            {
                inverted_encrypted_key += this.EncryptedKey[w];
            }
            
            for (int a = 0; a < this.Message.Length; a++)
            {                
                result += this.Message[a].ToString() + inverted_encrypted_key[a].ToString();
            }

            return result;
        }

        public string Encode(string Entry)
        {
            // Variaveis Locais            
            int advance;            


            // Execução
            this.KeyGenerator(Entry);

            for (int w = 0; w < Entry.Length; w++)
            {
                advance = AlphabeticVector.IndexOf(Entry[w]) + AlphabeticVector.IndexOf(this.Key[w]);

                if (advance >= AlphabeticVector.Length)
                {
                    advance -= AlphabeticVector.Length;
                }

                this.Message += AlphabeticVector[advance];
            }

            this.EncodeKey();
            
            return this.OutputCompiler();
        }
    }
}