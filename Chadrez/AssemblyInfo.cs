using System.Reflection;
using System.Runtime.CompilerServices;

//
// Informa��es gerais sobre um assembly s�o controladas atrav�s do seguinte
// conjunto de atributos. Altere esses valores de atributo para modificar as informa��es
// associado a um assembly.
//
[assembly: AssemblyTitle("")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]		

//
// As informa��es de vers�o de um assembly consistem nos quatro valores a seguir:
//
// Vers�o principal
// Vers�o menor
// N�mero da compila��o
//      Revis�o
//
// Voc� pode especificar todos os valores ou pode padronizar os n�meros de revis�o e compila��o
// usando o '*' como mostrado abaixo:
[assembly: AssemblyVersion("1.0.*")]

//
// Para assinar seu assembly, voc� deve especificar uma chave a ser usada. Consulte o
// Documenta��o do Microsoft .NET Framework para obter mais informa��es sobre assinatura de assembly.
//
// Use os atributos abaixo para controlar qual chave � usada para assinatura.
//
// Notas:
// (*) Se nenhuma chave for especificada, o assembly n�o ser� assinado.
// (*) KeyName refere-se a uma chave que foi instalada no Servi�o de Criptografia
// Provedor (CSP) em sua m�quina. KeyFile refere-se a um arquivo que cont�m
//       uma chave.
// (*) Se os valores KeyFile e KeyName forem especificados, o
// ocorre o seguinte processamento:
// (1) Se o KeyName puder ser encontrado no CSP, essa chave ser� usada.
// (2) Se o KeyName n�o existir e o KeyFile existir, a chave
// no KeyFile � instalado no CSP e usado.
// (*) Para criar um KeyFile, voc� pode usar o utilit�rio sn.exe (Strong Name).
// Ao especificar o KeyFile, a localiza��o do KeyFile deve ser
// relativo ao diret�rio de sa�da do projeto que �
// %Diret�rio do projeto%\obj\<configura��o>. Por exemplo, se o seu KeyFile for
// localizado no diret�rio do projeto, voc� especificaria o AssemblyKeyFile
// atributo as [assembly: AssemblyKeyFile("..\\..\\mykey.snk")]
// (*) A assinatura de atraso � uma op��o avan�ada - consulte o Microsoft .NET Framework
// documenta��o para mais informa��es sobre isso.
//
[assembly: AssemblyDelaySign(false)]
[assembly: AssemblyKeyFile("")]
[assembly: AssemblyKeyName("")]
