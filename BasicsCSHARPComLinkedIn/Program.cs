// See https://aka.ms/new-console-template for more information

 Console.WriteLine("Hello, World!");

//int 
int i = 10;

//float

float f = 10.2f; //Não foca na precisão das casas decimais.

//double

double d = 21.12d; //Não foca na precisão das casas decimais.

//decimal

decimal c =  20.9m;  //Tem precisão nas casas decimais.

//bool
bool b = true; //Sempre recebe True or False

//char

char c2 = 'a';  //Trata de caracteres.

//string
string s = "Welerson";

var cidade = "Vila Velha";  //Com VAR, o compilador aguarda o dado ser inserido para enteder qual tipo de dado está sendo trabalhado.

var idade = 55;
//var pode ser alterado mais tarde, como no exemplo abaixo, que ocorreu uma reatribuição de valores na variavel.
idade = 43;

//const 

const string estadoNascimento = "Espirito Santo"; //Não pode mais reatribuir/mudar o valor atribuido.

//Conversão de tipos

f = idade;  //Converão implicita.
f = (float)c;  //Conversão Explicita.*/


//Operadores Aritiméticos

//Operadores Relacionados   VERIFICAR SE UM DADO É IGUAL OU DIFERENTE DO OUTRO.

string cidade1 = "Cariacica";
string cidade2 = "Vila Velha";

bool ret1 = cidade1 == cidade2;
bool ret2 = cidade2 != cidade1;


//Operadores Lógicos


Console.WriteLine(ret1);
Console.WriteLine(ret2);