using System;

class DebugTriangleFormations
{
    static void Main()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        var triangleValidityCondition1 = a + b > c;
        var triangleValidityCondition2 = b + c > a;
        var triangleValidityCondition3 = a + c > b;

        var isValidTriangle = triangleValidityCondition1 && triangleValidityCondition2 && triangleValidityCondition3;
        //Operators was changed to "&&" instead of "||".
        if (!isValidTriangle)
        {   //Wrond printing message "Triangle is valid" instead of "Invalid Triangle.".           
            Console.WriteLine("Invalid Triangle.");
            return;
            //After this messege program needs to stop!
        }
        else
        {
            Console.WriteLine("Triangle is valid.");
        }

        var rightTriangleCondition1 = a * a + b * b == c * c;
        var rightTriangleCondition2 = b * b + c * c == a * a;//Wrong variable was multiplied "b * c". Needs to be"b *b".
        var rightTriangleCondition3 = a * a + c * c == b * b;

        if (rightTriangleCondition1)
        {
            Console.WriteLine("Triangle has a right angle between sides a and b");
            //White space in the begining of the message and dot after the message.
        }

        else if (rightTriangleCondition2)
        {
            Console.WriteLine("Triangle has a right angle between sides b and c");
            
        }

        else if (rightTriangleCondition3)//Wrong condition statment. "rightTriangleCondition2" intead of "rightTriangleCondition3"
        {
            Console.WriteLine("Triangle has a right angle between sides a and c");
        }

        else
        {
            Console.WriteLine("Triangle has no right angles");
            //Dot in the end of string was removed.
        }
    }
}
