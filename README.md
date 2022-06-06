## Crypton

É um algoritmo criptográfico simétrico com chave escondida, o qual foi inspirado na **Cifra de Cesar**. Cabe salientar que esse algoritmo foi concebido apenas por diversão, durante uma aula de Segurança da Informação e **não** deve ser utilizado em sistemas reais, pois é muito frágil. 

## Detalhes

Ele foi concebido para ter uma logica criptográfica superior a Cifra de Cesar e ao mesmo tempo "solucionar" o problema da criptografia simétrica: transmissão segura da chave. O Crypton "resolve" esse problema escondendo a chave entre a saída criptografada. A chave é gerada automaticamente pelo algoritmo, utilizando a própria entrada. Seu processo funciona em cinco passos, tanto para encriptar quanto para decriptar.

## Criptografar

1 Entrada: Receber a entrada dos dados a serem criptografados.


2 Gerar Chave: A chave criptográfica é um conjunto de caracteres cujos valores expressam a quantidade de casas que os caracteres da entrada devem **avançar** ou **retroceder**. A chave será gerada a partir da entrada, contendo a mesma quantidade de caracteres. Esse passo ocorre em duas etapas, as quais são:

2.1 Inverter os dados de entrada;
2.2 **Avançar** cada carácter de entrada usando o valor de seu respectivo carácter invertido.


3 Criptografar Entrada: **Avançar** cada carácter da entrada usando o valor de seu respectivo carácter da chave.


4 Criptografar Chave: **Avançar** cada caráter da chave usando o valor de seu respectivo carácter da mensagem (resultado obtido no passo 3).


5 Saída: Gerar saída intercalando cada carácter da mensagem com seu respectivo carácter da chave encriptada invertida.

## Descriptografar

1 Entrada: Receber a entrada dos dados a serem descriptografados, convertendo-os upper case.


2 Destacar Mensagem e Chave Encriptada: Extrair da entrada o conjunto de caracteres que compõem a mensagem e a chave encriptada. Esse passo ocorre em duas etapas, as quais são:

2.1 Separar a mensagem da chave encriptada sabendo-se que todo carácter **par** corresponde a mensagem e todo carácter **ímpar** corresponde a chave encriptada, porém invertida.

2.2 Inverter os caracteres da chave encriptada (extraída na etapa 1 do passo 2), colocando-a na ordem correta para uso.


3 Descriptografar Chave: **Retroceder** cada carácter da chave encriptada usando o valor de seu respectivo carácter da mensagem.


4 Descriptografar Mensagem: **Retroceder** cada carácter da mensagem usando o valor de seu respectivo carácter da chave.


5 Saída: Gerar saída dos dados descriptografados.

## Exemplo da execução dos passos para criptografar

Passo 2
```
W A G N E R  --> Entrada
R E N G A W  --> Entrada Invertida
Õ E T T E Õ  --> Chave
```

Passo 3
```
W A G N E R  --> Entrada
Õ E T T E Õ  --> Chave
S E Z É I N  --> Mensagem
```

Passo 4
```
Õ E T T E Õ  --> Chave
S E Z É I N  --> Mensagem
O I B I M J  --> Chave Encriptada
```

Passo 5
```
S E Z É I N  --> Mensagem
J M I B I O  --> Chave Encriptada Invertida

Saída: SJEMZIÉBIINO
```

## Observações

1. O algoritmo trabalha com caracteres em upper case.

2. O algoritmo remove espaços em branco.

## Apêndice

Vetor Alfabético:
- 0 A
- 1 B
- 2 C
- 3 D
- 4 E
- 5 F
- 6 G
- 7 H
- 8 I
- 9 J
- 10 K
- 11 L
- 12 M
- 13 N
- 14 O
- 15 P
- 16 Q
- 17 R
- 18 S
- 19 T
- 20 U
- 21 V
- 22 W
- 23 X
- 24 Y
- 25 Z
- 26 À
- 27 Á
- 28 Â
- 29 Ã
- 30 Ç
- 31 È
- 32 É
- 33 Ê
- 34 Ì
- 35 Í
- 36 Ò
- 37 Ó
- 38 Ô
- 39 Õ
- 40 Ù
- 41 Ú
- 42 Ü