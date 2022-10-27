using System;

namespace DataTypeAndVariables
{
    public class Program
    {
      public static void Main(string[] args)
      {
          Console.WriteLine("Hello World!");

          byte myByte = 134;
          sbyte mySbyte = -125;
          int myInt = 24558;
          uint myUint = 54889;
          short myShort = 4252;
          ushort myUShort = 25485;
          float myFloat = 33.45f;
          double myDouble = 54.56452;
          char myCharacter = 'k';
          bool myBool = true;
          string myText = "Hello World";
          string numText = "937";

          string stringVar = "I control text";
          string numVar = "47";

          Console.WriteLine(stringVar);
          Console.WriteLine(Text2Num(numVar));

      }

      public static int Text2Num(string numText)
      {
        int success;
        if (Int32.TryParse(numText, out success))
        {
          return success;
        }

        throw new NotImplementedException();
      }
    }
}
